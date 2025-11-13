using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public GameObject _MainMenu;
    public GameObject _HelpMenu;
    public GameObject _CreditMenu;
    public GameObject _GamePlayMenu;
    public GameObject _OurTeam;
    public GameObject _SceneMenu;
    public GameObject _PauseMenu;
    public GameObject _CactiMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    public void OnButtonClick(GameObject _UIObject)
    {
        if (_UIObject.name == "Start")
        {
            _MainMenu.SetActive(false);
            _GamePlayMenu.SetActive(true);
            Time.timeScale = 1;
        }
        else if (_UIObject.name == "Credits")
        {
            _MainMenu.SetActive(false);
            _CreditMenu.SetActive(true);
        }
        else if (_UIObject.name == "Cacti")
        {
            _MainMenu.SetActive(true);
            _CactiMenu.SetActive(true);
        }
        else if (_UIObject.name == "Team")
        {
            _MainMenu.SetActive(false);
            _OurTeam.SetActive(true);
        }
        else if (_UIObject.name == "Scenes")
        {
            _MainMenu.SetActive(false);
            _SceneMenu.SetActive(true);
        }
        else if (_UIObject.name == "Help")
        {
            _MainMenu.SetActive(false);
            _HelpMenu.SetActive(true);
        }
        else if (_UIObject.name == "Exit")
            Application.Quit();
        else if (_UIObject.name == "Back")
        {
            _MainMenu.SetActive(true);
            _HelpMenu.SetActive(false);
            _CreditMenu.SetActive(false);
            _OurTeam.SetActive(false);
            _SceneMenu.SetActive(false);
            _CactiMenu.SetActive(false);
        }
        else if (_UIObject.name == "Restart")
        {
            Time.timeScale = 1.0f;
            Application.LoadLevel(0);

        }
        else if (_UIObject.name == "Desert")
        {
            _MainMenu.SetActive(false);
            _SceneMenu.SetActive(false);
            _GamePlayMenu.SetActive(true);
            Time.timeScale = 1;
        }

        else if (_UIObject.name == "Pause")
        {
            _GamePlayMenu.SetActive(false);
            _PauseMenu.SetActive(true);
            Time.timeScale = 1;
        }

        else if (_UIObject.name == "Quit")
        {
            DesertScene();

        }

        else if (_UIObject.name == "Play")
        {
            _GamePlayMenu.SetActive(true);
            _PauseMenu.SetActive(false);
            
        }

        else if (_UIObject.name == "RestartDesert")
        {

            _PauseMenu.SetActive(false);
            _GamePlayMenu.SetActive(true);
            Time.timeScale = 1;

        }

        else if (_UIObject.name == "RestartDesert")
        {
            

        }

        else if (_UIObject.name == "Snow")
        {
            SnowScene();
        }

        else if (_UIObject.name == "Forest")
        {
            ForestScene();
        }

        else if (_UIObject.name == "Halloween")
        {
            HalloweenScene();
        }

    }

    public void DesertScene()
    {
        SceneManager.LoadScene("Desert");
        Time.timeScale = 1;
    }
    public void SnowScene()
    {
        SceneManager.LoadScene("Snow");
        Time.timeScale = 1;
    }
    public void ForestScene()
    {
        SceneManager.LoadScene("Forest");
        Time.timeScale = 1;
    }
    public void HalloweenScene()
    {
        SceneManager.LoadScene("Halloween");
        Time.timeScale = 1;
    }


}