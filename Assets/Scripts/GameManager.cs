using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    bool _isPaused = false;
    [SerializeField] GameObject _pauseMenu;
    [SerializeField] GameObject _gameMenu;
    [SerializeField] GameObject _startMenu;
    
    // A reference to two different CinemachineVirtualCameras
    [SerializeField] private Cinemachine.CinemachineVirtualCamera _cinemachineVirtualCamera;
    [SerializeField] private Cinemachine.CinemachineVirtualCamera _cinemachineVirtualCamera2;
    
    
    void Start() {
        
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            PauseGame();
        }

    }

    public void StartGame() {
        // Fade out and disable _startMenu
        // Transition from _cinemachineVirtualCamera to _cinemachineVirtualCamera2
        
        // Fade out and disable _startMenu
        _startMenu.SetActive(false);
        _gameMenu.SetActive(true);
        
        // Transition from _cinemachineVirtualCamera to _cinemachineVirtualCamera2
        _cinemachineVirtualCamera.Priority = 0;
        _cinemachineVirtualCamera2.Priority = 1;
        
    }

    public void PauseGame() {
        if (!_isPaused) {
            Time.timeScale = 0;
            _isPaused = true;
            _pauseMenu.SetActive(true);
        }
        else {
            Time.timeScale = 1;
            _isPaused = false;
            _pauseMenu.SetActive(false);
        }
    }
    
    public void QuitGame() {
        Application.Quit();
    }

}
