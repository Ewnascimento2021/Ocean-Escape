using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Sprite[] concha = new Sprite[2];
    public SpriteRenderer spriteConcha;
    [SerializeField]
    private CheckNotes checkNotes;

    public int sequenceHits = 7;
    

    static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<GameManager>();
            return instance;
        }
    }

    private void Start()
    {
        spriteConcha.sprite = concha[1];
    }

    private void Update()
    {
        Concha();

        if (!checkNotes.isSomeNoteInside && Input.GetKeyDown(KeyCode.Space)  )
        {
            if (GameManager.Instance.sequenceHits > 10)
            {
                GameManager.Instance.sequenceHits = 6;
            }
            else if (GameManager.Instance.sequenceHits > 5)
            {
                GameManager.Instance.sequenceHits = 1;
            }
            else
            {
                PauseController.Instance.GameOver();
            }

        }

    }
   
    private void Concha()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            spriteConcha.sprite = concha[0];
        }
        else
        {
            spriteConcha.sprite = concha[1];
        }
    }



}
