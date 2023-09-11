using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    private Rigidbody2D MiCuerpo;

    void Start()
    {
        //Al atributo MiCuerpo le asigno
        //el componete rigid body 2d de
        //este personaje
        Micuerpo = GetComponent < Rigidbody2D();

    }

    // Update is called once per frame
    void Update()
    {
        float velActualVert = MiCuerpo.velocity.y;
        float movHoriz = Input.GetAxis("Horizontal");
        if (movHoriz > 0)// a la derecha
             {
                 Micuerpo.velocity = new vector3(3, velActualVert, 0);
             }
        else if (movHoriz <0)//a la izquierda
             {
                 Micuerpo.velocity = new Vector(-3, velActualVert, 0);
             }
        else//quieto
             {
               MiCuerpo.velocity =new Vector3(0,VelActualVert,0);
              
             }





             
            MiCuerpo.velocity = new Vector3(3, velActualVert, 0);

    }
}
