using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenes : MonoBehaviour
{
    public void StartButtonPressed()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void CatalogPressed()
    {
        SceneManager.LoadScene("_Catalog");
    }
    public void SmetsPressed()
    {
        SceneManager.LoadScene("_Smets");
    }
    public void CategoriesPressed()
    {
        SceneManager.LoadScene("_Categories");
    }
    public void ExitPressed()
    {
        Application.Quit();
    }
    public void menuPressed()
    {
        SceneManager.LoadScene("menu");
    }
}
