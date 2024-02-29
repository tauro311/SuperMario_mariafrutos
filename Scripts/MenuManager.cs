using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Text scoreText;
    private int score;

    // Etiqueta del objeto que al ser destruido incrementará la puntuación
    public string tagObjetivo;

    void Start()
    {
        LoadScore();
    }

    void Update()
    {
        // Actualiza el texto de la puntuación en cada frame
        UpdateScoreText();
    }

    void LoadScore()
    {
        // Carga la puntuación desde algún lugar, si es necesario.
        // Por ejemplo, desde un archivo guardado o una base de datos.
        // Aquí simplemente inicializamos la puntuación a cero.
        score = 0;
    }

    void UpdateScoreText()
    {
        // Actualiza el texto con la puntuación actual
        scoreText.text = "Puntuación: " + score.ToString();
    }

    public void LoadFirstLevel()
    {
        // Carga el primer nivel
        SceneManager.LoadScene("Nivel 1");
    }

    void OnTriggerEnter(Collider other)
    {
        // Verifica si el jugador colisiona con un objeto que tenga la etiqueta "Coin" o "Goombas_1"
        if (other.CompareTag("Coin") || other.CompareTag("Goombas_1"))
        {
            // Incrementa la puntuación
            score++;
        }
    }

    void OnDestroy()
    {
        // Verifica si el objeto destruido tiene la etiqueta correcta
        if (gameObject.CompareTag(tagObjetivo))
        {
            // Incrementa la puntuación
            score++;
        }
    }
}