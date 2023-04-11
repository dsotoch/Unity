using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PersonajeElegido : MonoBehaviour
{


    public float fuerzamovimiento = 10.0f;
    public float fuerzarotacion = 170.0f;
    private float x, y;
    private Animator anim;
    public Joystick joystick;
    
    public Button AtackButton;
    public Button botonsalto;
    public Color newColor;
    private LogicaJuego logica;
    private Rigidbody rb;
    public float potenciasalto=10.0f;
    bool conectadotierra;
    
    private void Start()
    {

        anim =GetComponent<Animator>();
        logica = GameObject.FindObjectOfType<LogicaJuego>();
        rb = GetComponent<Rigidbody>();
        conectadotierra = true;
    }


    void Update()
    {

        x = joystick.Horizontal;
        y = joystick.Vertical;
        anim.transform.Translate(0, 0, y * Time.deltaTime * fuerzamovimiento);
        anim.transform.Rotate(0, x * Time.deltaTime * fuerzarotacion, 0);
        anim.SetFloat("movimientoX", x);
        anim.SetFloat("movimientoY", y);

        



    }
    //ATAQUES DEL PERSONAJE
    public void notAttack()
    {
        ColorBlock cb = AtackButton.colors;
        cb.selectedColor = Color.white;
        AtackButton.colors = cb;
        anim.SetBool("swordAttack", false);
    }

    public void SwordAttack()
    {
        ColorBlock cb = AtackButton.colors;
        cb.selectedColor = newColor;
        AtackButton.colors = cb;
        anim.SetBool("swordAttack", true);
        logica.atackSound();



    }
    public void salto()
    {
        
        ColorBlock cb = botonsalto.colors;
        cb.selectedColor = newColor;
        botonsalto.colors = cb;
        anim.SetBool("salto", true);
        if (conectadotierra == true)
        {

                 logica.sonidoSalto();
                transform.Translate(new Vector3(0, potenciasalto, 0));
                conectadotierra = false;
            
           
            
        }
        
        
    }
    public void Nosalto()
    {
        conectadotierra = false;
        ColorBlock cb = botonsalto.colors;
        cb.selectedColor = Color.white;
        botonsalto.colors = cb;
        anim.SetBool("salto", false);
        if (conectadotierra == false)
        {
           
                transform.Translate(new Vector3(0, -potenciasalto, 0));
                conectadotierra = true;
               
            
            
        }
       
    }
   






}
