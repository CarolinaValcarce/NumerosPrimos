using System;

namespace NUMEROSPRIMOS
{
    class Program
    {
        static void Main(string[] args)
        {
        //La variable x es para las filas, la variable y es para las columnas y la variable valor es para el número que tendremos que comprobar
        int x, y, valor;
        //La variable teclado para saber que escribir por consola
        String teclado = "";
        //Variable para guardar si es primo o no
        Boolean esPrimo;
        //Variable para crear la matriz
        String[,] matriz = new string[10, 10];
        //Bucle para comprobar por filas
        for (x=0;x<10; x++)
        {
            //Bucle para comprobar por columnas
            for (y=0;y < 10; y++)
            {
                esPrimo = true;
                valor = x * 10 + y;
                //Bucle para comprobar si es primo
                //Va dividiendo el número entre cada número partiendo de 2 y si el resto de la división entre un número distinto a él mismo es 0; entonces es que no es primo
                for(int i=2; i <=valor; i++)
                {
                    if(valor% i==0 && valor!=i)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                //Si es primo ( y distinto de 0 y 1 que no se consideran primos) guardamos el número en la matriz y en la variable teclado para imprimirlo
                if (esPrimo && valor != 0 && valor != 1)
                {
                    teclado += valor;
                    if (x == 0 && y != 9) teclado += "";   
                    if (y != 9) teclado += "";
                    matriz[x, y] = valor.ToString();
                }
                //Si no es primo guardamos la "X" en la matriz y en la variable de log para imprimirlos
                else
                {
                    teclado += "X";
                    if (y != 9) teclado += "";
                    matriz[x, y] = "X";
                }
            }
            //Metemos un salto de línea por cada fila nueva
            if (x != 9) teclado += "\n";
        }
        //Imprimimos la variable teclado para que sea la matriz y ponemos un Console.ReadLine () para que se quede esperando y ver el resultado.
        Console.Write(teclado);
        Console.ReadLine();
        }
    }
}  

