using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTriggerZone : MonoBehaviour
{
    //public AudioClip scoreSound;
    //private AudioSource scoreAudio;

    //private void Start()
    // {
    // scoreAudio = GetComponent<AudioSource>();
    //}
 

    bool active = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (active && collision.gameObject.tag == "Player")
        {
            active = false;
            //Add 1 to the score when the player enters the trigger zone
            ScoreManager.score++;

            PlatformerPlayerController playercontroller = collision.gameObject.GetComponent<PlatformerPlayerController>();
            playercontroller.PlayCoinSound();
            Destroy(gameObject);
        }
   
    }
}
