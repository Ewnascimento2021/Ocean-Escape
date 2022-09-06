using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private Button startButton;

    [SerializeField]
    private Button exitButton;

    private void Awake()
    {
        startButton.onClick.AddListener(LevelSelect);

        exitButton.onClick.AddListener(ExitGame);
    }

    private void OnDestroy()
    {
        startButton.onClick.RemoveListener(LevelSelect);

        exitButton.onClick.AddListener(ExitGame);
    }

    private void LevelSelect()
    {
        SceneManager.LoadScene("Select Level");
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
