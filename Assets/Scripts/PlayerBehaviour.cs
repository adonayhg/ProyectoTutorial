using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBehaviour : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce = 10f; //f es un float
    public float movementSpeed = 5f;
    public int monedasObtenidas = 0;
    public TextMeshProUGUI coinsText; //variable para mostrar texto en la pantalla del juego

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //KeyDown al soltar la tecla //KeyCode.Space indicar la tecla que se usa para ese comando
       {
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse); //transform.up ir hacia arriba
       }

       Vector3 movement = new Vector3(); //Vector3 se usan los tres ejes
       movement.x = Input.GetAxis("Horizontal");
       movement.z = Input.GetAxis("Vertical");

        rb.AddForce(movement * Time.deltaTime * movementSpeed, ForceMode.Impulse);
    }
    private void OnTriggerEnter(Collider other) //enter es para que avise la primera vez que toque una moneda
    {
        if(other.CompareTag("CoinItem")) //tag se crean dentro de unity
        {
            monedasObtenidas = monedasObtenidas +1;
        }

        else if(other.CompareTag("SpecialCoinItem"))
        {
            monedasObtenidas = monedasObtenidas + 5;
        }

        Debug.Log("He tocado " + monedasObtenidas + " monedas");

        if(other.tag.Contains("Coin")) //se eliminen solo los tag que tengan la palabra Coin
        {
        coinsText.text = monedasObtenidas.ToString(); //hacer que el texto de la consola se vea en la pantalla
        other.gameObject.SetActive(false); //hacer que desaparezca el objeto despues de tocarlo
        }
    }
    
}