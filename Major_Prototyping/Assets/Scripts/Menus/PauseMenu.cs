using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseUI;

    private bool isPaused = false;

    void Start() {

        pauseUI.SetActive(false);
    }

    void Update() {

        if (Input.GetKeyDown(KeyCode.Escape)) {

            isPaused = !isPaused;
        }

        if (isPaused) {

            pauseUI.SetActive(true);
            Time.timeScale = 0;
        }

        if (!isPaused)
        {

            pauseUI.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void ResumeGame() {

        isPaused = false;
    }
}
