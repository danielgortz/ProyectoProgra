using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorUi : MonoBehaviour
{
    public Personaje heroe;
    public Text etiquetaHPHeroe;
    public Image barraHPHeroe;

    // Update is called once per frame
    void Update()
    {
        etiquetaHPHeroe.text =
             heroe.hp + "/" + heroe.hpMax;

        float porcentajeHp =
            heroe.hp / (float)heroe.hpMax;
        barraHPHeroe.fillAmount = porcentajeHp;
    }
}
