using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneToLoad; //Donde meteremos la escena a la que queremos cambiar.
    public string sceneToLoad2;

    void Start()
    {
        
    }

    void Update()
    {
       
    }

    public void ChangeScene() //Función para cambiar la escena.
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void ChangeScene2()
    {
        SceneManager.LoadScene(sceneToLoad2);
    }
}
