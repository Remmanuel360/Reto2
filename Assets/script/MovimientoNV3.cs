using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNV3 : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private float movimientoHorizontal = 0f;

    [SerializeField] private float VelocidaDeMovimiento ;
    [SerializeField] private float suavizadoDemovimiento;

    private Vector3 velocidad =Vector3.zero;
    private bool mirandoDerecha = true;

    [Header("Salto")]
    [SerializeField] private float fuerzaDesalto;

    [SerializeField] private LayerMask queEsSuelo;

    [SerializeField] private Transform contraladorSuelo;
    [SerializeField] private Vector3 dimensionesCaja;
    [SerializeField] private bool enSuelo;

    private bool salto = false;


    private void Start()
    {
         rb2D = GetComponent<Rigidbody2D>();    
    }

    private void Update()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal") * VelocidaDeMovimiento;

        if (Input.GetKeyDown(KeyCode.W))
        {
            salto = true;
        }

    }

    private void FixedUpdate()
    {
        enSuelo = Physics2D.OverlapBox(contraladorSuelo.position, dimensionesCaja, 0f, queEsSuelo);
        Mover(movimientoHorizontal * Time.deltaTime, salto);   

        salto = false;  
    }

    private void Mover(float mover, bool saltar)
    {
        Vector3 velovidadObjetivo = new Vector2(mover, rb2D.velocity.y);
        rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, velovidadObjetivo, ref velocidad, suavizadoDemovimiento);

        if (mover > 0 && !mirandoDerecha)
        {
            Girar();
        }

        else if (mover < 0 && mirandoDerecha)
        {
            Girar();
        }

        if (enSuelo && saltar ) {
            enSuelo = false;
            rb2D.AddForce(new Vector2(0f, fuerzaDesalto));
        }

    }

    private void Girar ()
    {
        mirandoDerecha = !mirandoDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }

   

}
