using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    //Usando Arreglos
    //public int[] valor4 = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    public int[] variables2 = new int[10];
    public int index;

    void Awake()
    {
        //Asignar un valor entre 0 y 999
        //print("Cantidad de elementos de mi arreglo: " + variables2.Length);

        ////Primer elemento de un arreglo es el que tiene index variables2.Length-1
        //print("Primer elemento de un arreglo: " + variables2[0]);

        ////Último elemento de un arreglo es el que tiene index variables2.Length-1
        //print("Último elemento de un arreglo: " + variables2[variables2.Length - 1]);
    }

    
    void Update()
    {
        
    }
}
