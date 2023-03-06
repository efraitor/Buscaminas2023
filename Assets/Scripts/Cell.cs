using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    //Variable que nos permite conocer si un panel tiene una mina o no
    public bool hasMine;
    //Array en el que guardamos todas las im�genes que corresponden a que no hay una mina en esa celda al pulsar sobre ella
    public Sprite[] emptyTextures;
    //Necesitamos la imagen de que hay una mina
    public Sprite mineTexture;

    //Creamos unas variables donde guardar la posici�n de la celda concreta
    int x, y;

    // Start is called before the first frame update
    void Start()
    {
        //Le decimos que hay un 15% de posibilidades de que haya una mina en esa celda
        hasMine = (Random.value < 0.15);//Random.value nos da un valor entre 0 y 1. Si se cumple en este caso que ese valor sea menor que 0.15, hasMine ser� verdadero, si no falso
        //Variables para recoger la posici�n inicial de la celda
        x = (int)this.transform.position.x; //La posici�n en X de esa celda concreta (la columna)    (int) lo usamos para transformar un float si lo hubiera a n�mero entero
        y = (int)this.transform.position.y; //La posici�n en Y de esa celda concreta (la fila)
        //Metemos esta celda concreta(this) con esa X e Y que hemos obtenido en la posici�n X e Y correspondiente de ese array de celdas
        GridHelper.cells[x, y] = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //M�todo para cuando pulsamos en una celda y soltamos el click del rat�n
    private void OnMouseUpAsButton()
    {
        //Si esa celda tiene una mina
        if(hasMine)
        {
            //TO DO:
            //Llamamos al m�todo que descubre todas las minas del juego
            Debug.Log("Pringaaao");
        }
        //Si no hay mina en esa celda
        else
        {
            //TO DO:
            //Cambiar la textura de la celda
            //Descubrir todo el �rea sin minas alrededor de la celda destapada
            //Comprobar si el juego ha acabado o no
        }
    }

    //M�todo para cargar las texturas en las celdas
    public void LoadTexture()
    {

    }

    //M�todo de ayuda para saber si la celda ha sido destapada o no, devolvi�ndonos verdadero o falso
    public bool IsCovered()
    {
        /*Coge del SpriteRenderer de esa celda la textura que est� ah� puesta para saber si es un panel o no
        * En caso de que sea un panel, ser� verdadero, y sino falso*/
        return GetComponent<SpriteRenderer>().sprite.texture.name == "panel";
    }
}
