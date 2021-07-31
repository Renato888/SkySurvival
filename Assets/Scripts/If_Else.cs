using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Else : MonoBehaviour
{
    public int valor_1IF;
    public int valor_2IF;
    public int valor_3IF;

    // Start is called before the first frame update
    void Start()
    {
        if (valor_1IF == valor_2IF && valor_1IF == valor_3IF)
        {
            print("Los valores 1IF , 2IF y 3IF son iguales");
        }
        else if (valor_1IF < valor_2IF || valor_1IF < valor_3IF)
        {
            print("El valor 1IF es menor que los demas valores");
        }
        else
        {
            print("el valor 1IF es mayor que los demas valores");
        }
        
        if (valor_3IF != valor_1IF)
        {
            if (valor_2IF == valor_1IF)
            {
                print("El valor 1 es diferente a 3 pero igual a 2");
            }
        }
        else
        {
            print("El valor 1IF es igual al valor 3IF");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
