using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public int gameScore;
    public int noteValue;
    [SerializeField]
    private TMP_Text scoreText;

    [SerializeField]
    private Sprite[] status = new Sprite[3];

    [SerializeField]
    private Image imageStatus;

    [SerializeField]
    private Sprite[] life = new Sprite[3];

    [SerializeField]
    private Image imageLife;

    private void Start()
    {
        imageStatus.sprite = status[1];
        imageLife.sprite = life[2];
    }
    void Update()
    {
        Status();

        Life();
    }
    public void ScoreUp()
    {
        gameScore += noteValue;
        scoreText.text = "Score: \n" + gameScore.ToString();
    }
    private void Status()
    {
  
    }
    private void Life()
    {

    }

}