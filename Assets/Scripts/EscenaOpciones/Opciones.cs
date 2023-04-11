using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Opciones : MonoBehaviour
{


    
    public GameObject[] playerObjects;
    public int selectioncharacter = 0;
    public string selectedcharacterdataname = "Selected Character";
    private void Start()
    {
        
        hideallcharacters();
        

    }

    //OCULTAR TODOS LOS CARACTERES
    public void hideallcharacters()
    {
        foreach (GameObject g in playerObjects) 
        {
           
            g.SetActive(false);
        }
        //inicialisamos indice,leemos indice guardado en memoria--inicialisamos 0 

        selectioncharacter = PlayerPrefs.GetInt(selectedcharacterdataname, 0);
        playerObjects[selectioncharacter].SetActive(true);
    }

    //SIGUIENTE PERSONAJE
    public void nextcharacter()
    {
        //apagar caracter o personaje activo
        playerObjects[selectioncharacter].SetActive(false);
        //incrementar indice 
        selectioncharacter++;
        //validar tamaño del array 
        if (selectioncharacter >= playerObjects.Length)
        {
            selectioncharacter = 0;
        }
        //activar personaje
        playerObjects[selectioncharacter].SetActive(true);
    }
    //ANTERIOR PERSONAJE
    public void previouscharacter()
    {
        //apagar caracter o personaje activo
        playerObjects[selectioncharacter].SetActive(false);
        //incrementar indice 
        selectioncharacter--;
        //validar tamaño del array 
        if (selectioncharacter < 0)
        {
            selectioncharacter = playerObjects.Length - 1;
        }

        //activar personaje
        playerObjects[selectioncharacter].SetActive(true);
    }
    //BOTON REGRESAR
    public void regresar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //INICIAR JUEGO

    public void startGame()
    {
        //guardar en memoria el valor del indice del caracter o personaje seleccionado
       if (selectioncharacter == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }


    }


}
