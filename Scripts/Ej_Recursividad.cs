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
        /*
        // 1.Contar las cifras de un entero no negativo (Pista: si divides por división entera entre 10, le vas quitando cifras al número.Ej: 1234 / 10 = 123).
        ContarCifras(1234);

        //2.Contar las veces que una cifra c aparece en un entero n no negativo (Pista: piensa cuál es el resultado de 1234 % 10)
        int cifra2 = 1;
        VecesApareceC(11342, cifra);

        //3.Averiguar si todas las cifras de un entero no negativo n son pares.
        EsPar(2244);

        //4.Averiguar si un dato d aparece en un vector no ordenado v
        int dato4 = 2;
        int[] vec4 = new int[3] { 2, 0, 4 };
        int iter4 = 0;

        AparecedVector(vec4, dato4, iter4);
        
       
        // 5.Contar las veces que un dato d aparece en un vector no ordenado v
        int dato5 = 3;
        int iter5 = 0;
        int[] vec5 = new int[3] { 3, 0, 3 };

        Debug.Log ("d aparece " + VecesDVector(dato5, vec5, iter5) + " veces en v.");
       
        
        // 6.Mostrar en la consola los elementos de un vector no ordenado v en orden natural(del primero al último), uno en cada línea.
        int[] vec6 = new int[3] { 1, 2, 3 };
        int iter6 = 0;

        ComponentesVectorOrdenados(vec6, iter6);
        */

        // 7.Mostrar en la consola los elementos de un vector no ordenado v en orden inverso(del último al primero), uno en cada línea.
        int[] vec8 = new int[3] { 1, 2, 3 };
        int iter8 = vec8.Length - 1;



        ComponentesVectorInversos(vec8, iter8);

        // 8.Averiguar si un vector no vacío v está ordenado de menor a mayor.

        // 9.Encontrar el menor elemento en un vector no ordenado y no vacío v

        // 10.Averiguar si todos los elementos de un vector no ordenado y no vacío v son mayores que un dato d

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

        else
        {
            i = i + 1;
            return AparecedVector(array, d, i);
        }
    }

    int VecesDVector(int d, int[] v, int i)
    {
        /* Start() 
         {
           // Contar las veces que un dato d aparece en un vector no ordenado v
        int dato2 = 3;
        int iterador = 0;
        int[] vector2 = new int[3] { 3, 0, 3 };

        Debug.Log("d aparece " + VecesDVector(dato2, vector2, iterador) + " veces en v.");
       
          }
        */

        int veces = 0;

        if (i >= v.Length) return veces;

        if (d == v[i]) return veces + 1 + VecesDVector(d, v, i + 1);
        else return VecesDVector(d, v, i + 1);
    }

    string ComponentesVectorOrdenados(int[] v, int i)
    {
        /*
            // 6.Mostrar en la consola los elementos de un vector no ordenado v en orden natural(del primero al último), uno en cada línea.
        int[] vector = new int[3] { 1, 2, 3 };
        int iterador = 0;

        ComponentesVectorOrdenados(vector, iterador);

        */
            
        if (i >= v.Length) return null;

        else
        {
            Debug.Log("El componente " + (i + 1) + " del vector es " + v[i]);
            return ComponentesVectorOrdenados(v, i + 1);
        }
    }

    string ComponentesVectorInversos(int[] v, int i)
    {
        /*
            // 7.Mostrar en la consola los elementos de un vector no ordenado v en orden inverso(del último al primero), uno en cada línea.
        int[] vec8 = new int[3] { 1, 2, 3 };
        int iter8 = vec8.Length-1;

        ComponentesVectorInversos(vec8, iter8);
       
       */

        if (i <= 0)
        {
            return null;
        }
        else
        {
            //Ojo pq el vector tiene 3 componentes pero v[3] no existe (van de 0 a 2), por eso daba error
            Debug.Log("El componente " + (i) + " del vector es " + v[i - 1]);
            return ComponentesVectorInversos(v, i - 1);
        }
    }

    bool VecMenorMayor(int[] v, int i)
    {
        // 8.Averiguar si un vector no vacío v está ordenado de menor a mayor. {1,2,3} i = 0
        //No vacio significa que NO estan todos sus componentes a 0.

        if (i > v.Length - 1 || i > v.Length - 2) return true; //Si llega al final  

        if (v[i] <= v[i + 1]) return VecMenorMayor(v, i + 1);

        return false;

       /* if (i > v.Length - 1) return true; //Si llega al final significa q si están ordenados

        if (v[i] >= v[i - 1]) return VecMenorMayor(v, i - 1);
        
        return false;*/
    }


    int ElemMenor(int[] v, int i, int aux)
    {
        // 9.Encontrar el menor elemento en un vector no ordenado y no vacío v.
        // el aux q recibimos será un int muy grande

        if (i > v.Length - 1) return aux;
        if (v[i] < aux) aux = v[i];
    
        return ElemMenor(v, i+1, aux);
    }

    bool MayorqD(int[] v, int d, int i)
    {
        // 10.Averiguar si todos los elementos de un vector no ordenado y no vacío v son mayores que un dato d

        if (i > v.Length - 1) return true;

        if (v[i] <= d) return false;
      
        return MayorqD(v, d, i + 1);
        
    }




}

