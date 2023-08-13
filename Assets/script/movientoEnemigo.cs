using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movientoEnemigo : MonoBehaviour
{

    public float Speed;
    public bool Esderecha;
    public float ContadorT;
    public float TiempoParaRegresar;

    // Start is called before the first frame update
    void Start()
    {
      // ContadorT = TiempoParaRegresar;
    }

    // Update is called once per frame
    void Update()
    {
        if (Esderecha == true)
        {
            transform.position = Vector3.right * Speed * Time.deltaTime;

        }

        if (Esderecha == false)
        {
            transform.position = Vector3.left * Speed * Time.deltaTime;
        }


    }
}
