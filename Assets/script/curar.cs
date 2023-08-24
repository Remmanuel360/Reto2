using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;

public class curar : MonoBehaviour
{

    [SerializeField] int Vidas;
    [SerializeField] Slider sliderVidas;

    public float vidapersonaje;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemigo"))
        {

            Vidas++;
            sliderVidas.value = Vidas;
            vidapersonaje = sliderVidas.value;
        }
    }
}
