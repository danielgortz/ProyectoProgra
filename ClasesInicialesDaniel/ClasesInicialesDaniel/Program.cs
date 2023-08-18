using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInicialesDaniel
{
    class Program
    {
        //Este es el metodo main.
        // Sirve como punto de entrada
        // para el programa (inica
        //desde aqui)
        static void Main(string[] args)
        {
            //Esto es una instancia de Mochila
            Mochila mochilaAna = new Mochila();
            mochilaAna.Disenio = "Piolin";
            mochilaAna.Material = "Vinyl";
            mochilaAna.NumDeBolsas = 3;
            mochilaAna.NumLlaveros = 0;
            mochilaAna.Precio = 500.00f;
            mochilaAna.color = new Color();
            mochilaAna.color.Rojo = 100;
            mochilaAna.color.Verde = 20;
            mochilaAna.color.Azul = 33;

            Mochila mochilaBeto = new Mochila();
            mochilaBeto.Material = "piel";
            mochilaBeto.Disenio = "Pokemon";
            mochilaBeto.NumDeBolsas = 3;
            mochilaBeto.NumLlaveros = 3;
            mochilaBeto.Precio = 179.50f;
            mochilaBeto.Tamanio = "Grande";
            mochilaBeto.color = new Color();
            mochilaBeto.color.Rojo = 0;
            mochilaBeto.color.Verde = 128;
            mochilaBeto.color.Azul = 210;

            Mochila mochilaJorge = new Mochila();
            mochilaJorge.Material = "Tela";
            mochilaJorge.Disenio = "Fornite";
            mochilaJorge.NumDeBolsas = 4;
            mochilaJorge.NumLlaveros = 2;
            mochilaJorge.Precio = 310.50f;
            mochilaJorge.Tamanio = "Grande";
            mochilaJorge.color = new Color();
            mochilaJorge.color.Rojo = 34;
            mochilaJorge.color.Verde = 47;
            mochilaJorge.color.Azul = 128;


        }
    }
}
