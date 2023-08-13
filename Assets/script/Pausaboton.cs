using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausaboton : MonoBehaviour
{
    public GameObject panelToShow; // Arrastra aquí el GameObject del panel en el Inspector
    public KeyCode keyToPress = KeyCode.P;

    private bool panelVisible = false;

    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            panelVisible = !panelVisible;
            panelToShow.SetActive(panelVisible);
        }
    }
}
