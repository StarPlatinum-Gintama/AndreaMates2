using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        





    }

    void ContarC()
    {
        //Contar las veces que una cifra c aparece en un entero no negativo n. (Pista: piensa cuál es el resultado de 1234 % 10)

        int n = Random.Range(0,10000);
        int c = Random.Range(1,10);
        int apareceC = 0;
        
        if (n == c)
        {
            Debug.Log ("La cifra "+ c +"aparece 1 vez en el número " + n);
        }
        else
        {
            int auxN = n;
            int digitoFinal = 0;
            while (auxN > 0)
            {
                digitoFinal = auxN % 10;

                if (digitoFinal == c ) 
                {
                    apareceC = apareceC + 1;        
                }

                auxN = auxN / 10;
            }

            Debug.Log("La cifra" + c + " aparece " + apareceC + " veces en el número " + n);
        }

        /*
         * Talla del problema: Número de cifras que tenga n
         * 
         * Mejor caso y coste: Cuando n = c porque su coste es de 0(1).
         * Peor caso y coste: Cuando n!= c porque su coste es de 0(n).
         */
    }

    void CifrasOdrdenadasDeMenorAMayor()
    {
        //Mostrar en consola las cifras de un número entero no negativo n en orden natural (de menor a mayor), uno en cada línea.

        int n = 3124;

        int auxN = n;
        int digitoFinal = 0;

        int[] vecesCifras = new int[10];
        //El array tiene 10 posiciones (de 0 a 9) y cada una almacena las veces que aparece dicha cifra en el n
        // P.ej la posicion 0 almacena las veces que aparece el 0 en n
        
        if (n == 0)
        {
            Debug.Log(n);
        }
        else
        {
            while (auxN > 0)
            {
                digitoFinal = auxN % 10;
                vecesCifras[digitoFinal] += 1;

                auxN = auxN / 10;
            }

            for (int i = 0; i<=10 ; i++)
            {
                if (vecesCifras[i] > 0)
                {
                    Debug.Log(i);
                }
                
            }

            /*
            * Talla del problema: Número de cifras que tenga n
            * 
            * Mejor caso y coste: Cuando n = 0 porque su coste es de 0(1).
            * Peor caso y coste: Cuando n!= 0 porque su coste es de 0(n).
            */
        }

    }
}
