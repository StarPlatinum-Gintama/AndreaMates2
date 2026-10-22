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
        
        if (n == 0)
        {
            Debug.Log ("La cifra "+ c +"no aparece en el número " + 0);
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
         * Mejor caso y coste: Cuando n = 0 porque su coste es de 0(1).
         * Peor caso y coste: Cuando n/= 0 porque su coste es de 0(n).
         */
    }

    void CifrasOdrdenadasDeMenorAMayor()
    {
        //Mostrar en consola las cifras de un número entero no negativo n en orden natural (de menor a mayor), uno en cada línea.

        int n = 3124;
        int auxN = n;
        
        int digitoFinal = 0;
        

        while (auxN>0)
        {
            digitoFinal = auxN % 10;

            if (digitoFinal == 0)
            {
               Debug.Log (digitoFinal);
            }


           auxN = auxN / 10;
        }


    }
}
