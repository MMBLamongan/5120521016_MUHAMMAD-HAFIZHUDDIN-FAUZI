using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KontenS : MonoBehaviour
{
    public void KembaliGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
    public void NextGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void KeluarGame(){
        Application.Quit();
        Debug.Log("Keluar");
    }
}
    