using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class enmigo : MonoBehaviour
{
    [SerializeField] List<Transform> wayPoints;
    float Velocidad =5 ;
    float distanciaCambio = 0.2f;
    byte siguientePosicion; 
    public int vidaEnemigos = 2 ;
    public int Vidaactual;
    public int muerteEnemigo;
    public GameObject potionPrefab; // Prefab de la poción
    public Transform spawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        Vidaactual = vidaEnemigos;
        
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

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("jugador"))
        {

            vidaEnemigos --;
            Vidaactual = vidaEnemigos;
            muerteEnemigo = Vidaactual;
        }

        if (muerteEnemigo <= 0)
        {
           
            Destroy(this.gameObject);

            Instantiate(potionPrefab, spawnPoint.position, Quaternion.identity);

        }

    }
}
