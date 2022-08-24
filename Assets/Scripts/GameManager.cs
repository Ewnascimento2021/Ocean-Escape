using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
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
}
