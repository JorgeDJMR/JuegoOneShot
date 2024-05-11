using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Es para que se pueda modificar la escena
using UnityEngine.SceneManagement;



public class ScriptControl : MonoBehaviour
{
    public GameObject panelVictoria;
    //Para saver cuantos enemigos tenemos
    public int numEnemigos;

    
    void Start()
    {
        //Es necesario que el nombre de "Enemigo" sea igual al que pusiste en la etiqueta del Unity
        //Con esto tambien podremos saber la cantidad, para eso el .Length
        numEnemigos = GameObject.FindGameObjectsWithTag("Enemigo").Length;
        panelVictoria.SetActive(false);
    }

    
    void Update()
    {
        
    }

    //Esta funcion permitira que cada vez que matemos un circulo se reste de la cantidad
    //de circulos, y al final muestre el panel de victoria
    public void restaDeEnemigos()
    {
        //Sirve para que serte uno cada vez que destruya el circulo
        numEnemigos--;
        //Cuando el numero de enemigos llegue a a ser menor o igual a cero el panel de victoria aparecera. esto para demostrar
        //queb has derrotado a todos los enemigos
        if(numEnemigos <= 0)
        {
            panelVictoria.SetActive(true);
        }
    }

    //
    public void reiniciarElJuego()
    {
        //Algo muy importante es que el nombre de la escena debe de ser iguial a la que tu pusiste o no funcionara
        //En mi caso la mia esta por predeterminado, no le cambia nada asi que sera "SampleScene", debes de respetar 
        //Todo, eso incluye mayusculas y minusculas incluso esparcios.
        SceneManager.LoadScene("SampleScene");
    }



}
