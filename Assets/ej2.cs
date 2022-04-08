using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej2 : MonoBehaviour
{
    /*Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
        Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.
        */

    public int producto1, producto2, producto3, dineroDisponible;
    int suma;
    int resto;
    
    // Start is called before the first frame update
    void Start()
    {
        suma = producto1 + producto2 + producto3;
        resto = dineroDisponible - suma;

        if(suma > dineroDisponible)
        {
            Debug.Log("La suma de los productos supera el dinero disponible, y le faltan " + -resto);
        }
        else if(suma == dineroDisponible)
        {
            Debug.Log("La suma de los productos es igual al dinero disponible");
        }
        else
        {
            Debug.Log("La suma de los productos no supera el dinero disponible!! Le sobran "+ resto);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
