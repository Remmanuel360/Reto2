using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class vida : MonoBehaviour
{
    [SerializeField] int Vidas;
    [SerializeField] Slider sliderVidas;

    public float vidapersonaje;


    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject.CompareTag("enemigo"))
        {
            
            Vidas--;
            sliderVidas.value = Vidas;
            vidapersonaje = sliderVidas.value;
        }

        if ( vidapersonaje <=0)
        {
            Destroy(this.gameObject);

            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;



            // Carga nuevamente la escena actual
            SceneManager.LoadScene(currentSceneIndex);

        }
    }


}
