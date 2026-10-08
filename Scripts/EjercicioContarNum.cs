using System.Timers;
using UnityEngine;

public class EjercicioContarNum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ContarCifrasEntero();
    }

   void ContarCifrasEntero ()
    { 
        int n = Random.Range (-1000, 1001);
        int cont = n;
        int cifras = 0;

        if (n>= 0)
        {
            while (cont>0)
             {
                cont /= 10;
                cifras++;
            }
           Debug.Log("El numero " + n + " tiene " + cifras + " cifras.");
        }
        else
        {
            Debug.Log("El número es negativo.");
        }
     
        /*
         
        Indica la talla del problema = La cantidad de cifras que tenga el numero n. 

        Coste de la solución en notación O = 0(n) porque se repetirá n veces el bucle que es la parte donde más operaciones se van a realizar (maypr coste)
        
        Mejor Caso = Que n esté entre 0 y 9 (que tenga solo una cifra). 
        Peor Caso = 0(n) Porque el tiempo es proporcional a los datos de entrada y depende directamente de ellos. 

        Tanto el mejor como el peor caso es el mismo. Pq el coste es el mismo en ambos.j


         */
       
    }
}
