using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{

    public void Niveles(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

   
}
