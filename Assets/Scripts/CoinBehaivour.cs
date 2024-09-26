using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaivour : MonoBehaviour
{
    
    public Vector3 speedRotation;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speedRotation * Time.deltaTime, Space.World); //Time.deltaTime sirve para hacer que la moneda de una vuelta por segundo independietemente de los fps del ordenador// 
        //* significa multiplicar //Space.World que se ajuste a los ejes del mundo y no del objeto concreto//

    }
}
