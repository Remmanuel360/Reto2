using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmigo : MonoBehaviour
{
    [SerializeField] List<Transform> wayPoints;
    float Velocidad =3 ;
    float distanciaCambio = 0.2f;
    byte siguientePosicion; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position, wayPoints[siguientePosicion].transform.position, Velocidad * Time.deltaTime);

        if (Vector3.Distance(
            transform.position, wayPoints[siguientePosicion].transform.position) < distanciaCambio)

           {
            siguientePosicion++;

            if (siguientePosicion >= wayPoints.Count)

            {
                siguientePosicion = 0;
            }
        }

    }
}
