using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameController : MonoBehaviour
{
    // Start is called before the first frame update

    public static int totalScore = 1000;
    public static GameController instance;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }
}
