using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigos : MonoBehaviour
{
    //ENEMIGO-1
    public Transform ObjectToFollow;
    public NavMeshAgent nav;
    public float velocidad;
    public Animator anim;
    public AudioClip caminar;
    public AudioClip zombie;
    private AudioSource source;
    private void Awake()
    {
        nav.speed = velocidad;
        anim =GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        
    }
 

    // Update is called once per frame
    void Update()
    {
        EnemyBehavior();
    }
    private void camina()
    {
        source.clip = caminar;
        source.loop = false;
        source.Play();
    }
    public void zombise()
    {
        source.clip = zombie;
        source.loop = false;
        source.Play();
    }
    public void EnemyBehavior()
    {

        var distancia=Vector3.Distance(ObjectToFollow.transform.position, transform.position);
       
        if(distancia<=10 && distancia > 5)
        {
            var y=ObjectToFollow.position.y - 4;
            var x = ObjectToFollow.position.x;

            var z = ObjectToFollow.position.z;

            Vector3 seguir =new Vector3(x,y,z);
            anim.SetBool("idle", false);
            
            anim.SetBool("ataque", false);
            anim.SetBool("run", true);
            camina();
            nav.SetDestination(seguir);

        }
        else
        {
            if(distancia <3 & distancia >1)
            {
                anim.SetBool("idle", false);
               
                anim.SetBool("ataque", true);
                anim.SetBool("run", false);
               
            }
            else
            {
                anim.SetBool("idle", true);
                
                anim.SetBool("ataque", false);
                anim.SetBool("run", false);
                
            }
        }
       
      
    }
    }
