using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class vida : MonoBehaviour
{
    [SerializeField] int Vidas;
    [SerializeField] Slider sliderVidas;

    public float vidapersonaje;

    private void Start()
    {
        
    }

    private void OnCollisionEnter2D (Collision2D otro )
    {
        if (otro.gameObject.CompareTag("enemigo"))
        {
            Vidas--;
            sliderVidas.value = Vidas;
        }
    }
}
