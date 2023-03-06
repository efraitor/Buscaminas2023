using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    //Variable que nos permite conocer si un panel tiene una mina o no
    public bool hasMine;
    //Array en el que guardamos todas las imágenes que corresponden a que no hay una mina en esa celda al pulsar sobre ella
    public Sprite[] emptyTextures;
    //Necesitamos la imagen de que hay una mina
    public Sprite mineTexture;

    //Creamos unas variables donde guardar la posición de la celda concreta
    int x, y;

    // Start is called before the first frame update
    void Start()
    {
        //Le decimos que hay un 15% de posibilidades de que haya una mina en esa celda
        hasMine = (Random.value < 0.15);//Random.value nos da un valor entre 0 y 1. Si se cumple en este caso que ese valor sea menor que 0.15, hasMine será verdadero, si no falso
        //Variables para recoger la posición inicial de la celda
        x = (int)this.transform.position.x; //La posición en X de esa celda concreta (la columna)    (int) lo usamos para transformar un float si lo hubiera a número entero
        y = (int)this.transform.position.y; //La posición en Y de esa celda concreta (la fila)
        //Metemos esta celda concreta(this) con esa X e Y que hemos obtenido en la posición X e Y correspondiente de ese array de celdas
        GridHelper.cells[x, y] = this;
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

    //Método para cargar las texturas en las celdas
    public void LoadTexture()
    {

    }

    //Método de ayuda para saber si la celda ha sido destapada o no, devolviéndonos verdadero o falso
    public bool IsCovered()
    {
        /*Coge del SpriteRenderer de esa celda la textura que está ahí puesta para saber si es un panel o no
        * En caso de que sea un panel, será verdadero, y sino falso*/
        return GetComponent<SpriteRenderer>().sprite.texture.name == "panel";
    }
}
