using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaEnemigo02 : MonoBehaviour
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

            anim.SetBool("parado", false);
            anim.SetBool("run", false);
           
            gameObject.SetActive(false);

        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            vidaactual -= daño;
            enemigos.zombise();

        }
    }
}
