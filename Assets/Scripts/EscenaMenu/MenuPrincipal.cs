using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject canvaLogica;
    public GameObject canvamenu;

    public void botonOpciones()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void botonPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void botonLogica()
    {
        canvamenu.SetActive(false);

        canvaLogica.SetActive(true);
    }
    public void botonmenu()
    {
        canvaLogica.SetActive(false);
        canvamenu.SetActive(true);
    }

    public void salir()
    {
        Application.Quit();

    }
}
