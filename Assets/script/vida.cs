using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class vida : MonoBehaviour
{
    public float vidapersonaje;

    private void Start()
    {
        
    }

    private void Update()
    {
        if ( vidapersonaje <= 0)
        {
            Destroy(gameObject);
        }
    }
}
