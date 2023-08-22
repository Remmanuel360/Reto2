using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puerta : MonoBehaviour
{

    public string sceneToload;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        
        

            if (collision.gameObject.CompareTag("jugador")) {

            SceneManager.LoadScene(sceneToload);
            }

        

    }
}
