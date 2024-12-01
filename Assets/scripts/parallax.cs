using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class parallax : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private Vector3 direccion;
    [SerializeField] private float anchoImagen;

   private Vector3 posicionInicial;


    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //resto da la informcion de cunato nos queda de recorrido para alcazar un nuevo ciclo
        float espacio = velocidad * Time.time;
       float resto= espacio % anchoImagen;

        // Mi posicion se va refrescando desde la inicial sumando tanto comp resto me quede en la posicion deseada
        // recalculamos la posisicion, si el resto es cero la posicion vuelva al inicio
        transform.position = posicionInicial + resto * direccion;


    }
}
