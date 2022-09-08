using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDController : MonoBehaviour
{
    static HUDController instance;
    public static HUDController Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<HUDController>();
            return instance;
        }
    }

    public int gameScore;
    public int noteValue;

    [SerializeField]
    private TMP_Text scoreText;

    [SerializeField]
    private Sprite[] status = new Sprite[3];
    [SerializeField]
    private Image imageStatus;

    private void Start()
    {
        imageStatus.sprite = status[1];
    }

    void Update()
    {
        Status();
    }

    public void ScoreUp()
    {
        gameScore += noteValue;
        scoreText.text = "Score: \n" + gameScore.ToString();
    }

    private void Status()
    {
        if (GameManager.Instance.sequenceHits > 10)
        {
            imageStatus.sprite = status[2];
        }
        else if (GameManager.Instance.sequenceHits > 5)
        {
            imageStatus.sprite = status[1];
        }

        else if (GameManager.Instance.sequenceHits > 0)
        {
            imageStatus.sprite = status[0];
        }
    }

    private void CongratulationScore()
    {

    }
}