using Unity.VisualScripting;
using UnityEngine;
public class Entrega2 : MonoBehaviour
{

    void Start()
    {
        ActividadCinco();
        ActividadSeis();
        ActividadSiete();
    }

    void ActividadUno()
    {
        //Un método que reciba un float (de 0.0 a 1.0, si no, no hará nada) y devuelva el equivalente en % de probabilidad.

        float ProbDecimal = Random.Range(0.0f, 1.0f);
        float ProbPorcentaje = (float)System.Math.Round(ProbDecimal, 2) * 100;

        Debug.Log("La probabilidad en decimal es de " + ProbDecimal + " y en porcentaje es de " + ProbPorcentaje + "%");
    }

    void ActividadDos()
    {
        //Un método que reciba un % de probabilidad (de 0% a 100%, si no, no hará nada) y devuelva el equivalente en decimales(float)
        float ProbPorcentaje = Mathf.Round (Random.Range(0f, 100f));
        float ProbDecimal = ProbPorcentaje / 100;

        Debug.Log("La probabilidad en porcentaje es de " + ProbPorcentaje + "% y en decimal es de " + ProbDecimal);

    }

    void ActividadTres()
    {
        //Un método que calcule la probabilidad con la fórmula básica. Recibirá número de resultados buscados entre número de resultados posibles. Se devolverá en formato %.
        
        float ResBuscados = Mathf.Round (Random.Range(1,50));
        int ResPosibles = 50;

        float FormulaBasica = ResBuscados/ResPosibles;
        float ProbPorcentaje = (float)System.Math.Round(FormulaBasica, 2) * 100;

        Debug.Log ("La probaiblidad de que te salgan " + ResBuscados + " resultados de "+ ResPosibles +" posibles es del " + ProbPorcentaje + "%");

    }

    void ActividadCuatro()
    {
        //Un método que calcule la probabilidad que suceda un evento O de que suceda otro.
        //(Ej: probabilidad de sacar una figura O un As en la baraja: 12/52 + 4/52 = 16/52).

        float Evento1 = 12f; 
        float Evento2 = 4f;
        int ResPosibles = 52;

        float Probabilidad = (Evento1 + Evento2) / ResPosibles;

        Debug.Log("La probabilidad del evento 1 es de " + Evento1/ResPosibles + " y la del evento 2 es de " + Evento2/ResPosibles);
        Debug.Log("La probabilidad de que ocurra uno o el otro es de " + System.Math.Round(Probabilidad, 2));
    }

    void ActividadCinco()
    {
        //Un método que calcule la probabilidad que suceda un evento Y de que suceda otro.
        //(Ej: probabilidad de sacar un As Y de que sea diamante: 4/52 x 13/52 = 16/52).

        float Evento1 = 4f;
        float Evento2 = 13f;
        int ResPosibles = 52;

        float Probabilidad = (float)System.Math.Round ( (Evento1/ResPosibles) * (Evento2/ ResPosibles),2);

        Debug.Log("La probabilidad de que ocurran ambos eventos es de " + Probabilidad);
    }

    void ActividadSeis()
    {
        //Un método que sea como un dado de seis lados (D6). Al llamar al método devolverá un número entre el 1 y el 6 inclusive.

        int Numero = Random.Range (1, 7);
        Debug.Log(Numero);
    }

    void ActividadSiete()
    {
        //Un método que se le pase por parámetro una cantidad de lados y devuelva un número entre el 1 y la cantidad de lados inclusive.

        int NumLados = 12;
        int Numero = Random.Range(1, NumLados + 1);
        Debug.Log(Numero);
    }




}   