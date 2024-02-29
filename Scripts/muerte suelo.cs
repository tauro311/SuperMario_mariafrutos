using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class muertesuelo : MonoBehaviour
{

    private BoxCollider2D boxCollider;
    
    // Start is called before the first frame update
    void Awake()
    {

        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Game over");
        }
    }

}
