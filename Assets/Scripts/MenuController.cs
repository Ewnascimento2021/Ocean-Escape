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

    [SerializeField]
    private Button returnMenu;

    [SerializeField]
    private Button buttonLevel1;

    [SerializeField]
    private Button buttonLevel2;

    [SerializeField]
    private Button buttonLevel3;

    [SerializeField]
    private Button buttonLevelBonus;

    [SerializeField]
    private GameObject telaMenu;

    [SerializeField]
    private GameObject telaSelectLevel;





    private void Awake()
    {
        Time.timeScale = 1;
        telaMenu.SetActive(true);
        telaSelectLevel.SetActive(false);


        startButton.onClick.AddListener(LevelSelect);
        exitButton.onClick.AddListener(ExitGame);
        returnMenu.onClick.AddListener(ReturnToMenu);

        buttonLevel1.onClick.AddListener(Level1);
        buttonLevel2.onClick.AddListener(Level2);
        buttonLevel3.onClick.AddListener(Level3);
        buttonLevelBonus.onClick.AddListener(LevelBonus);

    }

    private void OnDestroy()
    {
        startButton.onClick.RemoveListener(LevelSelect);
        exitButton.onClick.RemoveListener(ExitGame);
        returnMenu.onClick.RemoveListener(ReturnToMenu);


        buttonLevel1.onClick.RemoveListener(Level1);
        buttonLevel2.onClick.RemoveListener(Level2);
        buttonLevel3.onClick.RemoveListener(Level3);
        buttonLevelBonus.onClick.RemoveListener(LevelBonus);
    }

    private void LevelSelect()
    {
        telaMenu.SetActive(false);
        telaSelectLevel.SetActive(true);

    }

    private void ReturnToMenu()
    {
        telaMenu.SetActive(true);
        telaSelectLevel.SetActive(false);

    }
    private void Level1()

    {
        SceneManager.LoadScene("Level1");
    }

    private void Level2()

    {
        SceneManager.LoadScene("Level2");
    }

    private void Level3()

    {
        SceneManager.LoadScene("Level3");
    }

    private void LevelBonus()

    {
        SceneManager.LoadScene("LevelBonus");
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
