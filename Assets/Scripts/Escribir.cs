using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escribir : MonoBehaviour
{
    public int Primer_Numero;
    public int Segundo_Numero;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Escribir_En_Consola()
    {
        /*int i = 1;
        while (i<=100)
        {
            Debug.Log("Hola mundo!");
            i++;
        }
        i = 0;

        for (int i = 1; i!=100; i++)
        {
            Debug.Log(i);
        }*/
        if(Primer_Numero!=Segundo_Numero || Primer_Numero > Segundo_Numero)
        {
            while (Primer_Numero >= Segundo_Numero)
            {
                Debug.Log(Primer_Numero);
                Primer_Numero -= 1;
            }
        }
        else
        {
            Debug.Log("Parametros invalidos");
        }
        
        
    }
}
