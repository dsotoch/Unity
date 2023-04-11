using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class findeljuego : MonoBehaviour
{
    // Start is called before the first frame update
     public void salir()
    {
        Application.Quit();
    }
    public void jugardenuevo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
    }
}
