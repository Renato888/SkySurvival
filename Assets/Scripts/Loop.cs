using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    public int[] array = new int[5];
    public List<int> list = new List<int>();

    public Array arrayClass;
    public List listClass;

    void Start()
    {
        //for (int i = 0; i < array.Length; i++)
        //{
        //    array[i] = Random.Range(0, 1000);
        //    list.Add(array[i]);
        //    print("index "+ i + " = " + array[i]);
        //}

        for (int i = 0; i < arrayClass.variables2.Length; i++)
        {
            arrayClass.variables2[i] = Random.Range(0, 1000);
            listClass.list.Add(arrayClass.variables2[i]);
            print("index " + i + " = " + arrayClass.variables2[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
