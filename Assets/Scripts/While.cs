using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{
    public int[] array = new int[5];
    public List<int> list = new List<int>();

    public Array arrayClass;
    public List listClass;

    public int i;

    void Start()
    {
        //Paso 1
        while(i < array.Length)
        {
            array[i] = Random.Range(0, 1000);
            list.Add(array[i]);
            print("index " + i + " = " + array[i]);

            i++;
        }
        //Paso 2
        while (i < arrayClass.variables2.Length)
        {
            arrayClass.variables2[i] = Random.Range(0, 1000);
            listClass.list.Add(arrayClass.variables2[i]);

            if (i % 2 == 0)
            {
                print("Index " + i + " = " + arrayClass.variables2[i]);
            }


            i++;
        }
    }
}
