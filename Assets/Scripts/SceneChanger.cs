using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    void Start()
    {
        // Etsit‰‰n UI-buttonit nimien perusteella
        Button playButton = GameObject.Find("PlayButton").GetComponent<Button>();
        Button settingsButton = GameObject.Find("SettingsButton").GetComponent<Button>();
        Button quitButton = GameObject.Find("QuitButton").GetComponent<Button>();

        // Lis‰t‰‰n tapahtumat nappeihin
        playButton.onClick.AddListener(LoadPlayMenu);
        settingsButton.onClick.AddListener(LoadSettingsMenu);
        quitButton.onClick.AddListener(QuitGame);
    }

    void LoadPlayMenu()
    {
        SceneManager.LoadScene("PlayMenu");
    }

    void LoadSettingsMenu()
    {
        SceneManager.LoadScene("SettingsMenu");
    }

    void QuitGame()
    {
        Debug.Log("Quit game called"); // n‰kyy editorissa
        Application.Quit();            // toimii buildiss‰
    }

}
