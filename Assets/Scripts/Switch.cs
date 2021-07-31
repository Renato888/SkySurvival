using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direcciones
{
    Norte, Sur, Este, Oeste
}
public class Switch : MonoBehaviour
{
    public int valor1;
    public Direcciones direcciones;
    // Start is called before the first frame update
    void Start()
    {
        switch (valor1)
        {
            case 0:
                print("El valor 1 es igual a 0");
                break;
            case 1:
            case 2:
            case 3:
            case 4:
                print("El valor 1 es mayor a 0");
                break;
            default:
                print("El valor 1 es mayor a 4 o menor a 0");
                break;
        }
        switch (direcciones)
        {
            case Direcciones.Norte:
                print("El norte");
                break;
            case Direcciones.Oeste:
                print("El oeste");
                break;
            case Direcciones.Sur:
                print("El sur");
                break;
            default:
                print("El este");
                break;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
