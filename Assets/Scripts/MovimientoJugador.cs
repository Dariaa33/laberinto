using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;

    public float velocidadMovimiento = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        movimientoEjeZ = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
        movimientoEjeX = - Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;
        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);
    }
}
