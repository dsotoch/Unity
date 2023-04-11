using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaEnemigo : MonoBehaviour
{

    public float vida = 60;
    public float vidaactual;
   
    public float daño = 20f;
    public Animator anim;
    private Enemigos enemigos;
    void Start()
    {
        vidaactual = vida;
        anim = GetComponent<Animator>();
        enemigos = GameObject.FindObjectOfType<Enemigos>();
    }


    void Update()
    {
        
       
        if (vidaactual <= 0)
        {

            anim.SetBool("idle", false);
            anim.SetBool("run", false);
            anim.SetBool("ataque", false);
            gameObject.SetActive(false);

        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
       if (collision.gameObject.tag == "Player")
        {
            vidaactual -= daño;
             enemigos.zombise();

        }
      
    }

 
}
