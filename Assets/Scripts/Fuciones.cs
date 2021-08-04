using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuciones : MonoBehaviour
{

    public int valor1;
    public int valor2;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ImprimeValor();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            ImprimeValorDoble();
            ImprimeCualEsMayor(valor1, valor2);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            print(Mensaje());
        }

        //Paso 1 - Función void Sencilla
        void ImprimeValor()
        {
            int tempValue = RandomValue();
            print("Valor temporal es: " + tempValue);
        }


        void ImprimeValorDoble()
        {
            valor1 = RandomValue();
            valor2 = RandomValue();
        }
        //Paso 2 - Función con parámetros
        void ImprimeCualEsMayor(int val1, int val2)
        {
            if (val1 > val2)
            {
                print("El valor 1 es MAYOR que le valor 2");
            }
            else if (val1 == val2)
            {
                print("El valor 1 y 2 son IGUALES");
            }
            else
            {
                print("El valor 1 es MENOR que el valor 2");
            }
        }

        int RandomValue()
        {
            return Random.Range(0, 1000);
        }

        int RandomValue(int multiple)
        {
            int temp = Random.Range(0, 1000);
            temp = temp * multiple;

            return temp;
        }


        string Mensaje()
        {
            return "Hola";
        }
    }
}
