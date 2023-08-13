using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creditos : MonoBehaviour
{
    public float scrollSpeed = 10f;
    public float stopPositionY = 100f; // La posici�n Y en la que los cr�ditos se detendr�n

    private bool shouldScroll = true;

    void Update()
    {
        if (shouldScroll)
        {
            transform.Translate(Vector3.up * scrollSpeed * Time.deltaTime);

            if (transform.position.y >= stopPositionY)
            {
                shouldScroll = false;
            }
        }
    }
}


