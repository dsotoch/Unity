using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportarse : MonoBehaviour
{
    
    public Transform posicion;
    public Transform posicionnoche;
    public LogicaJuego logica;
    void Start()
    {
        logica = GameObject.FindObjectOfType<LogicaJuego>();
    }

    
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "teleport_dia")
        {
            gameObject.transform.position = posicionnoche.transform.position;
            logica.teleport();
            
           
        }
        else
        {

            if (collision.gameObject.name == "Teleport_Noche")
            {
                gameObject.transform.position = posicion.transform.position;
                logica.teleport();

            }
        }

    }
}
