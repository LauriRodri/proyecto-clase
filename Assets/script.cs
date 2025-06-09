using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject settingsPanel;

    // Cambiar a la escena del juego
    public void PlayGame()
    {
        SceneManager.LoadScene("level1"); // Cambia este nombre por el real
    }

    // Mostrar el panel de configuración
    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    // Cerrar el panel de configuración (por ejemplo, con un botón "Back")
    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
    }

    // Salir del juego
    public void ExitGame()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}

