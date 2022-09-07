using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
    static PauseController instance;
    public static PauseController Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<PauseController>();
            return instance;
        }
    }

    [SerializeField]
    private Button pauseButton;
    [SerializeField]
    private Button resumeButton;
    [SerializeField]
    private Button restartPauseButton;
    [SerializeField]
    private Button restartGameOverButton;
    [SerializeField]
    private Button exitPausetButton;
    [SerializeField]
    private Button exitGameOverButton;

    [SerializeField]
    private GameObject pauseMenu;
    [SerializeField]
    private GameObject menuGameOver;
    [SerializeField]
    private GameObject HUD;

    private void Awake()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        menuGameOver.SetActive(false);
        HUD.SetActive(true);

        pauseButton.onClick.AddListener(Pause);
        resumeButton.onClick.AddListener(Resume);
        restartPauseButton.onClick.AddListener(Restart);
        restartGameOverButton.onClick.AddListener(Restart);
        exitPausetButton.onClick.AddListener(ExitToMenu);
        exitGameOverButton.onClick.AddListener(ExitToMenu);
    }

    private void OnDestroy()
    {
        pauseButton.onClick.RemoveListener(Pause);
        resumeButton.onClick.RemoveListener(Resume);
        restartPauseButton.onClick.RemoveListener(Restart);
        restartGameOverButton.onClick.RemoveListener(Restart);
        exitPausetButton.onClick.RemoveListener(ExitToMenu);
        exitGameOverButton.onClick.RemoveListener(ExitToMenu);
    }

    public void GameOver()
    {
        menuGameOver.SetActive(true);
        HUD.SetActive(false);
        pauseMenu.SetActive(false);
        //Teste de pause da tela
        NoteManager.Instance.song.Pause();
        Time.timeScale = 0;
    }

    private void Pause()
    {
        Time.timeScale = 0;
        NoteManager.Instance.song.Pause();
        pauseMenu.SetActive(true);
        HUD.SetActive(false);
    }

    private void Resume()
    {
        Time.timeScale = 1;
        NoteManager.Instance.song.Play();
        pauseMenu.SetActive(false);
        HUD.SetActive(true);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void ExitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
