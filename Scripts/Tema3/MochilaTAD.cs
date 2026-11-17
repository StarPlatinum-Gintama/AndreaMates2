using System;
using UnityEngine;

public class MochilaTAD
{
    // === ENCAPSULACIÓN ===
    // Nadie fuera de esta clase puede tocar directamente este array ni el contador

    private string[] huecos; //Array que almacena los huecos (pueden no estar todos rellenados)
    private int cantidadActual; //Almacena la cantidad de huecos rellenados del array

    // Constructor: inicializa la estructura interna con capacidad máxima N
    public MochilaTAD(int capacidadMaxima)
    {
        huecos = new string[capacidadMaxima];
        cantidadActual = 0;
    }

    // === MÉTODOS DE ACCESO ===

    public bool EstaVacia()
    {
        return cantidadActual == 0;
    }

    public bool EstaLlena()
    {
        return cantidadActual == huecos.Length;
    }

    public int VerCantidad()
    {
        return cantidadActual;
    }

    public bool Guardar(string nuevoItem)
    {
        if (EstaLlena())
        {
            return false; // No cabe más en la mochila
        }
        huecos[cantidadActual] = nuevoItem;
        cantidadActual++;
        return true;
    }

    public string SacarUltimo()
    {
        if (EstaVacia())
        {
            return null;
        }
        cantidadActual--;
        string itemExtraido = huecos[cantidadActual];
        huecos[cantidadActual] = null; // Limpiamos la casilla
        return itemExtraido;
    }

    //Hechos por mí
    public string SacarMedio()
    {
        //Si la mochila no está vacía, extrae y devuelve el objeto que esté en medio guardado.

        if (!EstaVacia())
        {
            /*
             * Acceder al objeto que esté en medio

                Las posiciones son :      0      1      2     3     4
                Si el array es huecos [ item1, item2, item3, item4 ,null ]

                cantidadActual = 4 (item1,item2,item3,item4);
                medio = cantidadActual/2 = 1 (devuelve la posición del medio)
                medio = 4/2 = 2; 

                Si hacemos cantidadActual--, sería 
                cantidadActual = 3;
                medio = 3/2 = 1,5 = 1;
            */

            int medio = cantidadActual - 1 /2;

            //Sobreescribir el array para que no quede hueco (los de después del medio se mueven 1 hueco atrás)
            for (int i = medio + 1; i >= cantidadActual; i++)
            {
                huecos[i] = huecos[i + 1]; //El siguiente al del medio pasa a ocupar el espacio anterior
            }

            //Eliminar el objeto de la cantidad actual
            cantidadActual = cantidadActual - 1;

            return huecos[medio];
        }

        return null;
    }
}
