using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuController : MonoBehaviour
{
    [Header("Menu Switching Options")]
    [SerializeField] private GameObject _mainMenuCanvasGO;
    [SerializeField] private GameObject _pauseMenuCanvasGO;
    [SerializeField] private GameObject _nextLevelMenuGo;


    [Header("Frist Selected Menu Item Options")]
    [SerializeField] private GameObject _mainMenuFirst;
    [SerializeField] private GameObject _pauseMenuFirst;
    [SerializeField] private GameObject _nextLevelMenuFirst;

    private bool isPaused;

    private void Start()
    {
        OpenMainMenu();
    }

    private void Update()
    {
        if (InputManager.instance.MenuOpenCloseInput)
        {
            if (!isPaused)
            {
                Pause();
            }
            else
            {
                Unpause();
            }
        }    
    }

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;

        OpenPauseMenu();
    }

    public void Unpause()
    {
        isPaused = false;
        Time.timeScale = 1f;

        CloseMenus();
    }

    public void StartGame()
    {
        CloseMenus();
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    private void OpenMainMenu()
    {
        _mainMenuCanvasGO.SetActive(true);
        _pauseMenuCanvasGO.SetActive(false);
        _nextLevelMenuGo.SetActive(false);

        EventSystem.current.SetSelectedGameObject(_mainMenuFirst);
    }

    private void OpenPauseMenu()
    {
        _mainMenuCanvasGO.SetActive(false);
        _pauseMenuCanvasGO.SetActive(true);
        _nextLevelMenuGo.SetActive(false);

        EventSystem.current.SetSelectedGameObject(_pauseMenuFirst);
    }

    private void OpenNextLevelMenu()
    {
        _mainMenuCanvasGO.SetActive(false);
        _pauseMenuCanvasGO.SetActive(false);
        _nextLevelMenuGo.SetActive(true);

        EventSystem.current.SetSelectedGameObject(_nextLevelMenuFirst);
    }

    public void CloseMenus()
    {
        _mainMenuCanvasGO.SetActive(false);
        _pauseMenuCanvasGO.SetActive(false);
        _nextLevelMenuGo.SetActive(false);
    }

    public void OnResumePress()
    {
        Unpause();
    }

    public void OnContinuePress()
    {

    }
}
