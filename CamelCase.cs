using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra3
{ 
    class CamelCase
    {
        //Daniel Araya Araya;
        char[] letras;//Creo un arreglo para guardar el string.
        int cont = 1;//Creo un contador que va servir para llevar el numero de mayusculas.
        /// <summary>
        /// Metodo que calcula la cantidad de palabras del string.
        /// </summary>
        /// <param Frase="str">la frase de donde se van a contar las palabras</param>
        /// <returns></returns>
        public int calculate(String str)
        {
            letras = str.ToCharArray();//Convierto el String el un arreglo de caracteres.
            for (int i = 0; i < letras.Length; i++)//Ciclo que recorre el arreglo.
            {
                if (char.IsUpper(letras[i]))//Pregunto si hay un caracter en mayuscula.
                {
                    cont++;//incremento el contador.
                }
            }
            return cont;//Retorno el contador.
        }
    }
}
