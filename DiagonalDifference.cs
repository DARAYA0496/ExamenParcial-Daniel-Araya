using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra3I
{
    class DiagonalDifference
    {
        int matriz;//Entero para saber decuanto es la  matriz.
        String[] parts2;//Arreglo donde separo el string a numeros.

        /// <summary>
        /// Metodo que saca la diferencia entre las diagonales de la matriz
        /// </summary>
        /// <param matriz="str">El String va ser la matriz</param>
        /// <returns></returns>
        public int matrix(String str)
        {
            int[] numerosmat=new int[1000];//Arreglo donde guardo todos los numeros que van a ir al matriz.
            String[] parts= str.Split('|');//Separo el string en partes y lo guardo en el arreglo.
            matriz = parts.Length;//Le asigno el largo del arreglo para asi saber de cuanto es la matriz.
            int[,] numeros = new int[matriz, matriz];//Creo la matriz y le asigno la variale matriz porque asi le digo de cuanto es la matriz.
            int contnumeros = 0;//Contador que se va utlizar para recorrer el arreglo numerosmat.
            int cont = 0;//Contador que se va utlizar para recorrer el arreglo numerosmat.
            int Diagonal=0;//Entero para guardar la suma de la primer diagonal.
            int Diagonal2=0;//Entero para guardar la suma de la segunda diagonal.
            int resultado=0;//Entero que guarda la diferencia entre las diagonales para luego retornarla.

            for (int i = 0; i < parts.Length; i++)//Ciclo para recorrer el arreglo parts.
            {
                parts2 = parts[i].Split(' ');//Separo los string que estan en el arreglo en numeros.
                for (int j = 0;  j < parts2.Length; j++)//Ciclo para recorrer el arreglo parts2.
                {
                    String num = parts2[j];//Guardo la posicion j del arreglo en la variable num.
                    numerosmat[contnumeros] = int.Parse(num);//Guardo la variable num en el arreglo;
                    contnumeros++;//incremento el contador que va llevar la posicion del arreglo numerosmat.
                }
            }
            

            for (int i = 0; i < numeros.GetLength(0); i++)//Ciclo para recorrer las filas de la matriz.
            {
                for (int j = 0; j < numeros.GetLength(1); j++)//Ciclo para recorrer las columnas de la matriz.
                {
                    numeros[i, j] = numerosmat[cont];//Guardo lo del arreglo en la matriz.
                    cont++;//Incremento el contador que va llevar la posicion del arreglo numerosmat.
                }
            }

            for (int i = 0; i < numeros.GetLength(0); i++)//Ciclo para recorrer las filas de la matriz.
            {
                Diagonal = Diagonal + numeros[i, i];//Suma la diagonal de la matriz.
            }
            for (int i = 0; i < numeros.GetLength(0); i++)//Ciclo para recorrer las filas de la matriz.
            {
                    Diagonal2 = Diagonal2 + numeros[i, (numeros.GetLength(0) - 1) - i];//Suma la diagonal de la matriz.              
            }
            resultado = Diagonal - Diagonal2;//Guardo la diferencia de las diagonales
            
            return resultado;//Retorno la diferencia
        }
    }
}
