using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] GameObject controller;
    [SerializeField] AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        if (controller == null)
        {
            controller = GameObject.FindGameObjectWithTag("GameController");
        }

        if (audio == null)
        {
            audio = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D (Collider2D other)
    {
        Debug.Log("do stuff");
        /* when Mario collides with the coin:
         * 1. increase score
         * 2, play sound effect
         * 3. make coin disappear */


        //1. increase score
        controller.GetComponent<Scorekeeper>().AddPoints();

        //2. play sound effect
        //audio.Play();
        AudioSource.PlayClipAtPoint(audio.clip, transform.position);

        //3. coin should disappear
        Destroy(gameObject);
    }


}
