using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garrafa : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    [SerializeField] private AudioSource audioS;


    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "PT"){

            audioS.Play();
            GameController.totalScore -= score;
            GameController.instance.UpdateScoreText();
            
            audioS.transform.parent = null;
            Destroy(audioS, 1f);
            Destroy(gameObject);
        }
    }
}
