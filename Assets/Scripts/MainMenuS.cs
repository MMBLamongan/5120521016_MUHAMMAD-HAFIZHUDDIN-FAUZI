using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuS : MonoBehaviour
{

    public void MulaiGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void KeluarGame()
    {
        Application.Quit();
        Debug.Log("Keluar");
    }

    public void Bukaig(string Url1)
    {
        Application.OpenURL(Url1);
    }
    public void Bukagmail(string Url)
    {
        Application.OpenURL(Url);
    }

}