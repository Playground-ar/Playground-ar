using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenes : MonoBehaviour
{
    public void StartButtonPressed()
    {
        SceneManager.LoadScene("_Camera");
    }
    public void CatalogPressed()
    {
        SceneManager.LoadScene("_Catalog");
    }
    public void SmetsPressed()
    {
        SceneManager.LoadScene("_Smets");
    }
    public void MenuPressed()
    {
        SceneManager.LoadScene("menu");
    }
    public void ExitPressed()
    {
        Application.Quit();
    }
}
