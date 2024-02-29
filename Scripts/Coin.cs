using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    AudioSource source;
    public AudioClip coin;

    // Start is called before the first frame update
    void Start()
    {
        
    }
     void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            source.PlayOneShot(coin);
            Destroy(gameObject, 0.5f);
        }
    }

}
