using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahSceneLanjut : MonoBehaviour
{
    // Start is called before the first frame update
    public void GantiScene(string NamaScene)
    {
        SceneManager.LoadScene(NamaScene);
    }
}
