using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Sprite[] concha = new Sprite[2];
    public SpriteRenderer spriteConcha;

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

    public bool isPaused;

    [SerializeField]
    private Button pauseButton;

    private void Start()
    {
        spriteConcha.sprite = concha[1];
    }

    private void Update()
    {
        Concha();
    }
    private void Awake()
    {
        pauseButton.onClick.AddListener(Pause);
    }

    public void Pause()
    {
        Time.timeScale = 0;
        NoteManager.Instance.song.Pause();
        isPaused = true;

    }

    public void Continue()
    {
        Time.timeScale = 1;
        NoteManager.Instance.song.Play();
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
