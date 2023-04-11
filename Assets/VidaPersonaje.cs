using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPersonaje : MonoBehaviour
{

    public float vida = 100f;
    public float vidaactual;
    public Image barravida;
    public float daño=0.01f;
    public Animator anim;
    public GameObject canvaperdiste;
    private LogicaJuego logica;
    void Start()
    {
        vidaactual = vida;
        anim = GetComponent<Animator>();
        logica = GameObject.FindObjectOfType<LogicaJuego>();
        canvaperdiste.SetActive(false);
    }

 
    void Update()
    {
        
        if (vidaactual <=0)
        {
            
            if (canvaperdiste.gameObject.activeInHierarchy == false)
            {
                logica.sonidoperdiste();
                canvaperdiste.SetActive(true);
                Time.timeScale = 0;
            }
           
            
            

        }
        verificarvida();
    }

    void verificarvida()
    {
        barravida.fillAmount=vidaactual/vida;
        if (barravida.fillAmount <= 0.7f &&  barravida.fillAmount >=0.5f)
        {
            barravida.color = Color.cyan;
        }
        else
        {
            if(barravida.fillAmount < 0.5f)
            {
                barravida.color = Color.red;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("enemigo"))
        {
            vidaactual -= daño;

        }
    }
   
}
