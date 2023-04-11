using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaJuego : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip clipmoneda;
    public AudioClip clipverde;
    public AudioClip clipazul;
    public AudioClip cliprojo;
    public AudioClip clipFind;
    public AudioClip clipTeleport;
    public AudioClip caminar;
    public AudioClip atack;
    public AudioClip clipSalto;
    public Text texmoneda;
    public Text textverde;
    public Text texrojo;
    public Text textazul;
    public GameObject find;
    public int cantidadmoneda=0;
    public int cantidadbotellaazul=0;
    public int cantidadbotellaroja = 0;
    public int cantidadbotellaverde = 0;
   
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        find.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        verificarJuego();
    }
    public void sonidoperdiste()
    {
        audiosource.clip = clipFind;
        audiosource.loop = true;
        audiosource.Play();
    }
    public void atackSound()
    {
        audiosource.clip = atack;
        audiosource.loop = false;
        audiosource.Play();
    }
    public void Running()
    {
        audiosource.clip = caminar;
        audiosource.loop = false;
        audiosource.Play();
    }
    public void teleport()
    {

        audiosource.clip = clipTeleport;
        audiosource.loop = false;
        audiosource.Play();
    }
    public void sonidoSalto()
    {

        audiosource.clip = clipSalto;
        audiosource.loop = false;
        audiosource.Play();
    }
    void verificarJuego()
    {
        if(cantidadmoneda==10 && cantidadbotellaazul==6 && cantidadbotellaroja==6 && cantidadbotellaverde == 6)
        {

            //VERIFICAR Si EL OBJETO ESTA ACTIVO EN LA ESCENA
            if (find.gameObject.activeInHierarchy == false)
            {

                audiosource.clip = clipFind;
                audiosource.loop = true;
                audiosource.Play();
                find.SetActive(true);
                Time.timeScale = 0;
                
            }
           
        }
    }

   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("moneda"))
        { 
            audiosource.clip = clipmoneda;
            audiosource.Play();
            cantidadmoneda += 1;
            texmoneda.text = cantidadmoneda.ToString();

            collision.gameObject.SetActive(false);
            
         
        }
        else
        {
            if (collision.gameObject.CompareTag("botellaroja"))
            {
                audiosource.clip = cliprojo;
                audiosource.Play();
                cantidadbotellaroja += 1;
                texrojo.text = cantidadbotellaroja.ToString();
                collision.gameObject.SetActive(false);
            }
            else
            {
                if (collision.gameObject.CompareTag("botellaverde"))
                {
                    audiosource.clip = clipverde;
                    audiosource.Play();
                    cantidadbotellaverde += 1;
                    textverde.text = cantidadbotellaverde.ToString();
                    collision.gameObject.SetActive(false);
                }
                else
                {
                    if (collision.gameObject.CompareTag("botellaazul"))
                    {
                        audiosource.clip = clipazul;
                        audiosource.Play();
                        cantidadbotellaazul += 1;
                        textazul.text = cantidadbotellaazul.ToString();
                        collision.gameObject.SetActive(false);
                    }
                }
            }
        }
    }
}
