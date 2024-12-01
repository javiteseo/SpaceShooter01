using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private float Velocidad;
    [SerializeField] private GameObject disparo;
    [SerializeField] private GameObject spawn1;
    [SerializeField] private GameObject spawn2;
    [SerializeField] private float ratioDisparo;
    private float temporizador=0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();

        DelimitarMovimiento();

        Disparar();
    }
    void Movimiento()
    {
        float PosH = Input.GetAxis("Horizontal");
        float PosV = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(PosH, PosV, 0).normalized * Velocidad * Time.deltaTime);

    }
    void DelimitarMovimiento()
    {
        //delimitacion de area
        float xClamped = Mathf.Clamp(transform.position.x, -8.5f, 8f);
        float yClamped = Mathf.Clamp(transform.position.y, -5f, 5f);
        transform.position = new Vector3(xClamped, yClamped, 0);
    }
    void Disparar()
    {
        temporizador +=1*Time.deltaTime;

        if (Input.GetKey(KeyCode.Space)&&temporizador>ratioDisparo)
          {
            Instantiate(disparo,spawn1.transform.position,Quaternion.identity);
            Instantiate(disparo, spawn2.transform.position, Quaternion.identity);
            temporizador = 0;
        }

    }
}
