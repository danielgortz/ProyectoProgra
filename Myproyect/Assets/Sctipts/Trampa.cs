using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    public int puntosDanio;
     private void OnCollisionEnter2D(Collision2D collision)
    {
        print(name + " hizo colision con"
            + collision.gameObject.name);

        GameObject otro = collision.gameObject;
        if(otro.tag == "player")

        {
            //Accedo al comoponente de tipo personaje
            //del objeto con el que choque
            Personaje elPerso = otro.GetComponent<Personaje>();
            //Aplico el daño al otro invocando al metodo hacer daño
            elPerso.hacerDanio(puntosDanio, this.gameObject);


        }
     }
    // Update is called once per frame
    void Update()
    {
        
    }
}
