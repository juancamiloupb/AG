using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ComandosBasicos : MonoBehaviour
{
    // Start is called before the first frame update
    public void CargarEscena(string NombreDeEscena)
    {
        SceneManager.LoadSceneAsync(NombreDeEscena);
        
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Has Salido");
    }

}
