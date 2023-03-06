using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    //Variable que nos permite conocer si un panel tiene una mina o no
    public bool hasMine;

    // Start is called before the first frame update
    void Start()
    {
        //Le decimos que hay un 15% de posibilidades de que haya una mina en esa celda
        hasMine = (Random.value < 0.15);//Random.value nos da un valor entre 0 y 1. Si se cumple en este caso que ese valor sea menor que 0.15, hasMine será verdadero, si no falso
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Método para cuando pulsamos en una celda y soltamos el click del ratón
    private void OnMouseUpAsButton()
    {
        //Si esa celda tiene una mina
        if(hasMine)
        {
            //TO DO:
            //Llamamos al método que descubre todas las minas del juego
            Debug.Log("Pringaaao");
        }
        //Si no hay mina en esa celda
        else
        {
            //TO DO:
            //Cambiar la textura de la celda
            //Descubrir todo el área sin minas alrededor de la celda destapada
            //Comprobar si el juego ha acabado o no
        }
    }
}
