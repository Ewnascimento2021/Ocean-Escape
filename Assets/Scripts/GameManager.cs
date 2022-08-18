using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int gameScore;
    public int noteValue;
    [SerializeField]
    private TMP_Text scoreText;
    [SerializeField]
    private Image[] hearts;
    


    void Update()
    {

    }
    public void ScoreUp()
    {
        gameScore += noteValue;
        scoreText.text = "Score: " + gameScore.ToString();
        hearts[2].gameObject.SetActive(true);
    }
}
