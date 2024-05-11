using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEnemigo : MonoBehaviour
{
    //Creamos un dato tipo publico para las particulas
    public GameObject animacionParticulas;
    public ScriptControl Scontrol;

    //para el el movimiento del mouse
    private void OnMouseDown()
    {
        //instancia del efecto que emeos creado de particulas
        Instantiate(animacionParticulas, transform.position, Quaternion.identity);
        //Esto es para que reste uno despues de que instancie
        Scontrol.restaDeEnemigos();
        //Despues de instanciar, que s emuestre el efecto particulas al destruir el enemigo
        Destroy(gameObject);

    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }


}
