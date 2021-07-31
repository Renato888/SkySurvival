using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public List<int> list = new List<int>();

    // Start is called before the first frame update
    void Awake()
    {
        print("Tamaño de mi lista: " + list.Count);

        list.Add(Random.Range(0, 1000));
        list.Add(Random.Range(0, 1000));
        list.Add(Random.Range(0, 1000));
        list.Add(Random.Range(0, 1000));
        list.Add(Random.Range(0, 1000));
        list.Add(Random.Range(0, 1000));
        list.Add(Random.Range(0, 1000));
        print("Tamaño de mi lista: " + list.Count);

        //int temp = Random.Range(0, 1000);
        //list.Add(temp);
        //print("Tamaño de mi lista: " + list.Count);
        //list.Remove(temp);

        //print("Elemento borrado: " + temp);
        //print("Tamaño de mi lista: " + list.Count);

        //list.RemoveAt(2);
        //print("Tamaño de mi lista: " + list.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
