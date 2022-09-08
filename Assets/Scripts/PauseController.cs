using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    private Button restartCongratulationButton;
    [SerializeField]
    private Button exitPausetButton;
    [SerializeField]
    private Button exitGameOverButton;
    [SerializeField]
    private Button exitCongratulationButton;

    [SerializeField]
    private GameObject menuPause;
    [SerializeField]
    private GameObject menuGameOver;
    [SerializeField]
    private GameObject HUD;
    [SerializeField]
    private GameObject menuCongratulation;

    [SerializeField]
    private TMP_Text scoreCongratulationText;

    private void Awake()
    {
        Time.timeScale = 1;
        HUD.SetActive(true);
        menuPause.SetActive(false);
        menuGameOver.SetActive(false);
        menuCongratulation.SetActive(false);

        pauseButton.onClick.AddListener(Pause);
        resumeButton.onClick.AddListener(Resume);
        restartPauseButton.onClick.AddListener(Restart);
        restartGameOverButton.onClick.AddListener(Restart);
        restartCongratulationButton.onClick.AddListener(Restart);
        exitPausetButton.onClick.AddListener(ExitToMenu);
        exitGameOverButton.onClick.AddListener(ExitToMenu);
        exitCongratulationButton.onClick.AddListener(ExitToMenu);
    }

    private void OnDestroy()
    {
        pauseButton.onClick.RemoveListener(Pause);
        resumeButton.onClick.RemoveListener(Resume);
        restartPauseButton.onClick.RemoveListener(Restart);
        restartGameOverButton.onClick.RemoveListener(Restart);
        restartCongratulationButton.onClick.AddListener(Restart);
        exitPausetButton.onClick.RemoveListener(ExitToMenu);
        exitGameOverButton.onClick.RemoveListener(ExitToMenu);
        exitCongratulationButton.onClick.RemoveListener(ExitToMenu);
    }

    private void Pause()
    {
        Time.timeScale = 0;
        NoteManager.Instance.song.Pause();
        HUD.SetActive(false);
        menuPause.SetActive(true);
        menuGameOver.SetActive(false);
        menuCongratulation.SetActive(false);
    }

    private void Resume()
    {
        Time.timeScale = 1;
        NoteManager.Instance.song.Play();
        HUD.SetActive(true);
        menuPause.SetActive(false);
        menuGameOver.SetActive(false);
        menuCongratulation.SetActive(false);
    }

    public void GameOver()
    {
        HUD.SetActive(false);
        menuPause.SetActive(false);
        menuGameOver.SetActive(true);
        menuCongratulation.SetActive(false);
        //Teste de pause da tela
        NoteManager.Instance.song.Pause();
        Time.timeScale = 0;
    }

    public void Congratulations()
    {
        scoreCongratulationText.text = "Score: " + HUDController.Instance.gameScore.ToString();
        Time.timeScale = 0;
        HUD.SetActive(false);
        menuPause.SetActive(false);
        menuGameOver.SetActive(false);
        menuCongratulation.SetActive(true);
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
