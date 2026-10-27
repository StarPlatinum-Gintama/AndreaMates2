using System;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Ej_Recursividad : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Contar las cifras de un entero no negativo (Pista: si divides por división entera entre 10, le vas quitando cifras al número.Ej: 1234 / 10 = 123).
        ContarCifras(1234);

        //Contar las veces que una cifra c aparece en un entero n no negativo (Pista: piensa cuál es el resultado de 1234 % 10)
        int cifra = 1;
        VecesApareceC(11342, cifra);

        //Averiguar si todas las cifras de un entero no negativo n son pares.
        EsPar(2244);

        //Averiguar si un dato d aparece en un vector no ordenado v
        int dato = 2;
        int[] vector = new int[3] { 2, 0, 4 };
        int i = 0;

        AparecedVector(vector, dato, i);

        // Contar las veces que un dato d aparece en un vector no ordenado v

        // Mostrar en la consola los elementos de un vector no ordenado v en orden natural(del primero al último), uno en cada línea.

        // Mostrar en la consola los elementos de un vector no ordenado v en orden inverso(del último al primero), uno en cada línea.

        // Averiguar si un vector no vacío v está ordenado de menor a mayor.

        // Encontrar el menor elemento en un vector no ordenado y no vacío v

        // Averiguar si todos los elementos de un vector no ordenado y no vacío v son mayores que un dato d

    }

    int ContarCifras(int n)
    {
        //El caso base es que no haya cifras
        if (n == 0) return 0;

        //Devuelve un 1 y vuelve a llamarse a si misma con 1 cifra menos
        return 1 + ContarCifras(n / 10);
    }

    int VecesApareceC(int n, int c)
    {
        if (n == 0) return 0;

        if (c == n % 10) return 1 + VecesApareceC(n / 10, c);
        else return 0 + VecesApareceC(n / 10, c);
    }

    bool EsPar(int n)
    {
        //Averiguar si todas las cifras de un entero no negativo n son pares.
        // n = 56677

        if (n / 10 == 0) return n % 2 == 0;

        if (n % 2 != 0) return false;
        else return EsPar(n / 10);
    }

    bool AparecedVector(int[] array, int d, int i)
    {
        //Averiguar si un dato d aparece en un vector no ordenado v
        
        if (i > array.Length) return false;

        if (array[i] == d) return true;
        else return AparecedVector(array, d, i + 1);

    }
   
    /*
     * for (int i = 0; i < array.lenght, i++)
     * {
     *      if (array [i] == d )
     *      {
     *        ApareceD = true;
     *        Break;
     *      }
     * }
     * 
     * 
     * 
     * 
     * 
     */

}
