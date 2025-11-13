using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIforOthers : MonoBehaviour
{
    public GameObject _PauseMenu;
    public GameObject _GamePlayMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ButtonClick(GameObject _UIObject)
    {
        if (_UIObject.name == "Pause")
        {
            _GamePlayMenu.SetActive(false);
            _PauseMenu.SetActive(true);
            Time.timeScale = 1;
        }

        else if (_UIObject.name == "Play")
        {
            _GamePlayMenu.SetActive(true);
            _PauseMenu.SetActive(false);
            
        }
        else if (_UIObject.name == "RestartSnow")
        {
            SnowScene();

        }

        else if (_UIObject.name == "RestartForest")
        {
            ForestScene();

        }
        else if (_UIObject.name == "RestartHalloween")
        {
            HalloweenScene();

        }

        else if (_UIObject.name == "Quit")
        {
            DesertScene();

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
