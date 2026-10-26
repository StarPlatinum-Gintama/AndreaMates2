using UnityEngine;

public class ExpectedValue : MonoBehaviour
{
    [Header("Numero de cartas")]
    //Cuantas cartas hay de cada tipo dentro del mazo.

    [SerializeField] private float n_As = 4;
    [SerializeField] private float n_Tres = 4, n_Rey = 4, n_Caballo = 4, n_Sota = 4, n_Siete = 4, n_Seis = 4, n_Cinco = 4, n_Cuatro = 4, n_Dos = 4;

    [Header("Valores de cartas")]
    //El valor de cada carta según su tipo 

    [SerializeField] private float v_As = 11;
    [SerializeField] private float v_Tres = 10, v_Rey = 4, v_Caballo = 3, v_Sota = 2, v_Siete = 0, v_Seis = 0, v_Cinco = 0, v_Cuatro = 0, v_Dos = 0;


    float numCartasTotal,PuntosTotales,espTotal;

    float prob_As, prob_Tres, prob_Rey, prob_Caballo, prob_Sota, prob_Siete, prob_Seis, prob_Cinco, prob_Cuatro,prob_Dos;

    float esperanza_As, esperanza_Tres, esperanza_Rey, esperanza_Caballo,esperanza_Sota,esperanza_Siete, esperanza_Seis, esperanza_Cinco,esperanza_Cuatro, esperanza_Dos;


    public void CalcularProbabilidades()
    {
        //Calcular la probabilidad de cada carta cada vez que ejecutamos la escena

        numCartasTotal = n_As + n_Tres + n_Rey + n_Caballo + n_Sota + n_Siete + n_Seis + n_Cinco + n_Cuatro + n_Dos;
        Debug.Log("Hay " + numCartasTotal + " cartas");

        PuntosTotales = (v_As * n_As) + (v_Tres * n_Tres) + (v_Rey * n_Rey) + (v_Caballo * n_Caballo) + (v_Sota * n_Sota)
                               + (v_Siete * n_Siete) + (v_Seis * n_Seis) + (v_Cinco * n_Cinco) + (v_Cuatro * n_Cuatro) + (v_Dos * n_Dos);
        Debug.Log("Los puntos totales que se pueden conseguir son " + PuntosTotales);


        // veces que aparece combinación buscada/todas las combinaciones posiles
        prob_As = n_As / numCartasTotal;
        Debug.Log("La probabilidad de sacar un As es de " + (float)System.Math.Round(prob_As, 2));

        prob_Tres = n_Tres / numCartasTotal;
        Debug.Log("La probabilidad de sacar un Tres es de " + (float)System.Math.Round(prob_Tres, 2));

        prob_Rey = n_Rey / numCartasTotal;
        Debug.Log("La probabilidad de sacar un Rey es de " + (float)System.Math.Round(prob_Rey, 2));

        prob_Caballo = n_Caballo / numCartasTotal;
        Debug.Log("La probabilidad de sacar un Caballo es de " + (float)System.Math.Round(prob_Caballo, 2));

        prob_Sota = n_Sota / numCartasTotal;
        Debug.Log("La probabilidad de sacar un Sota es de " + (float)System.Math.Round(prob_Sota, 2));

        prob_Siete = n_Siete / numCartasTotal;
        Debug.Log("La probabilidad de sacar un Siete es de " + (float)System.Math.Round(prob_Siete, 2));

        prob_Seis = n_Seis / numCartasTotal;
        Debug.Log("La probabilidad de sacar un Seis es de " + (float)System.Math.Round(prob_Seis, 2));

        prob_Cinco = n_Cinco / numCartasTotal;
        Debug.Log("La probabilidad de sacar un Cinco es de " + (float)System.Math.Round(prob_Cinco, 2));

        prob_Cuatro = n_Cuatro / numCartasTotal;
        Debug.Log("La probabilidad de sacar un Cuatro es de " + (float)System.Math.Round(prob_Cuatro, 2));

        prob_Dos = n_Dos / numCartasTotal;
        Debug.Log("La probabilidad de un Dos es de " + (float)System.Math.Round(prob_Dos, 2));


        // Añade que imprima en la consola la esperanza de valor de cada carta.
        // Calcular la esperanza multiplicando la probabilidad con el valor.

        esperanza_As = prob_As * v_As;
        Debug.Log("La esperanza del As es de " + (float)System.Math.Round(esperanza_As, 2));

        esperanza_Tres = prob_Tres * v_Tres;
        Debug.Log("La esperanza del Tres es de " + (float)System.Math.Round(esperanza_Tres, 2));

        esperanza_Rey = prob_Rey * v_Rey;
        Debug.Log("La esperanza del Rey es de " + (float)System.Math.Round(esperanza_Rey, 2));

        esperanza_Caballo = prob_Caballo * v_Caballo;
        Debug.Log("La esperanza del Caballo es de " + (float)System.Math.Round(esperanza_Caballo, 2));

        esperanza_Sota = prob_Sota * v_Sota;
        Debug.Log("La esperanza del Sota es de " + (float)System.Math.Round(esperanza_Sota, 2));

        esperanza_Siete = prob_Siete * v_Siete;
        Debug.Log("La esperanza del Siete es de " + (float)System.Math.Round(esperanza_Siete, 2));

        esperanza_Seis = prob_Seis * v_Seis;
        Debug.Log("La esperanza del Seis es de " + (float)System.Math.Round(esperanza_Seis, 2));

        esperanza_Cinco = prob_Cinco * v_Cinco;
        Debug.Log("La esperanza del Cinco es de " + (float)System.Math.Round(esperanza_Cinco, 2));

        esperanza_Cuatro = prob_Cuatro * v_Cuatro;
        Debug.Log("La esperanza del Cuatro es de " + (float)System.Math.Round(esperanza_Cuatro, 2));

        esperanza_Dos = prob_Dos * v_Dos;
        Debug.Log("La esperanza del Dos es de " + (float)System.Math.Round(esperanza_Dos, 2));
    }

    public void EsperanzaTotal()
    {
        //Podría llamar la funcion anterior, pero saldrían todos los debug.logs y en esta solo quiero mostrar la esperanza total.
        //Calcular probabilidad de cada carta
        numCartasTotal = n_As + n_Tres + n_Rey + n_Caballo + n_Sota + n_Siete + n_Seis + n_Cinco + n_Cuatro + n_Dos;

            prob_As = n_As / numCartasTotal;
            prob_Tres = n_Tres / numCartasTotal;
            prob_Rey = n_Rey / numCartasTotal;
            prob_Caballo = n_Caballo / numCartasTotal;
            prob_Sota = n_Sota / numCartasTotal;
            prob_Siete = n_Siete / numCartasTotal;
            prob_Seis = n_Seis / numCartasTotal;
            prob_Cinco = n_Cinco / numCartasTotal;
            prob_Cuatro = n_Cuatro / numCartasTotal;
            prob_Dos = n_Dos / numCartasTotal;

        //Calcular Esperanza de cada carta
            esperanza_As = prob_As * v_As;
            esperanza_Tres = prob_Tres * v_Tres;
            esperanza_Rey = prob_Rey * v_Rey;
            esperanza_Caballo = prob_Caballo * v_Caballo;
            esperanza_Sota = prob_Sota * v_Sota;
            esperanza_Siete = prob_Siete * v_Siete;
            esperanza_Seis = prob_Seis * v_Seis;
            esperanza_Cinco = prob_Cinco * v_Cinco;
            esperanza_Cuatro = prob_Cuatro * v_Cuatro;
            esperanza_Dos = prob_Dos * v_Dos;

        espTotal = esperanza_As + esperanza_Tres + esperanza_Rey + esperanza_Caballo + esperanza_Sota 
                                + esperanza_Siete + esperanza_Seis + esperanza_Cinco + esperanza_Cuatro +esperanza_Dos;

        Debug.Log("La esperanza total es de " + (float)System.Math.Round(espTotal,2));
    }
}
