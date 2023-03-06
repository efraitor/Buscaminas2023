using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Es una clase de tipo "Helper", un script que nos sirve de apoyo pero no depende de MonoBehaviour
public class GridHelper : MonoBehaviour
{
    //Variables para conocer el ancho y el alto de la rejilla
    public static int w = 15; //ancho de la malla       static significa que s�lo habr� por ejemplo en este caso un ancho y un alto de rejilla en todo el juego
    public static int h = 15; //alto de la malla
    //Un array donde guardar todas las celdas de nuestro juego
    public static Cell[,] cells = new Cell[w, h]; //al ser static tambi�n me permite acceder a este desde otro script
    
    //M�todo para destapar todas las minas
    public static void UncoverAllMines()
    {
        //Bucle para recorrer el array de celdas y que vaya destapando las minas que haya en esta rejilla
        foreach (Cell c in cells)
        {
            //Si esa celda tiene una minas
            if (c.hasMine)
            {
                //Llamar al m�todo que carga la textura de la minas

            }
        }

        /*for(int f = 0; f < height; f++)
        {
            for (int c = 0; c < width; c++)
            {

            }
        }*/
    }

    //M�todo para saber si hay una mina en una posici�n dada
    public static bool HasMineAt(int x, int y) //La posici�n de la celda
    {
        //Si estas condiciones se cumplen estaremos dentro de la rejilla
        if (x >= 0 && y >= 0 && x < w && y < h)
        {
            //Vemos que celda hemos seleccionado y guardamos su posici�n en una variable de tipo celda
            Cell cell = cells[x, y];
            //De esa celda nos devolver� su booleano, si es true habr� mina, si es falso no
            return cell.hasMine;
        }
        //Si las condiciones de arriba no se cumplen estamos fuera de la rejilla
        else
        {
            //No hay posibilidad de que haya una mina
            return false;
        }
    }
   
}
