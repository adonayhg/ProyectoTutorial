using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{

    //Variables
    // El Tipo De Dato      Nombre
    int numeroDeSaltos = 0;  //; siempre para cerrar//

    public int primerLogroSaltos = 5; //public para poder modificarlo desde el inspector//
    public int segundoLogroSaltos = 10;
    public int tercerLogroSaltos = 15;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision infoChoque)
    {
        numeroDeSaltos = numeroDeSaltos + 1;
        /*Debug.Log("Veces que ha colisionado: " + numeroDeSaltos + " " + gameObject.name);
        Debug.Log("Ha chocado con " + infoChoque.gameObject.name); */

        if(numeroDeSaltos == primerLogroSaltos || numeroDeSaltos == segundoLogroSaltos || numeroDeSaltos == tercerLogroSaltos) //forma comprimida || significa o//
        {
            Debug.Log(gameObject.name + " ha chocado " + numeroDeSaltos + " veces ");
        }
        else
        {
        
        }

        /*if(numeroDeSaltos == primerLogroSaltos) //doble== cuando quieras que pase algo cuando tu variable valga ese valor// //if: si se cumple esta cosa sucede esta otra//
        {
        Debug.Log(gameObject.name + " ha chocado " + numeroDeSaltos + " veces ");

        }

        if(numeroDeSaltos == segundoLogroSaltos)
        {
        Debug.Log(gameObject.name + " ha chocado " + numeroDeSaltos + " veces ");

        }

        if(numeroDeSaltos == tercerLogroSaltos)
        {
        Debug.Log(gameObject.name + " ha chocado " + numeroDeSaltos + " veces "); 

        }*/
    }
}