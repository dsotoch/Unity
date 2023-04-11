using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausarJuego : MonoBehaviour
{
    public GameObject canvapause;
    // Start is called before the first frame update
    void Start()
    {
        canvapause.SetActive(false);
    }

   

    public void pause()
    {        
        //VERIFICAR Si EL OBJETO ESTA ACTIVO EN LA ESCENA
        if (canvapause.gameObject.activeInHierarchy == false)
        {
            canvapause.SetActive(true);
            Time.timeScale = 0;
        }
       
    }

    public void initialMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void resume()
    {
        canvapause.SetActive(false);
        Time.timeScale = 1;
    }
}
