using System;

class Program
{
    static void Main()
    {

        // Exercicio 1 ----------
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }
        // SOMA == 91
        Console.WriteLine(SOMA);




        // Exercicio 2 --------

        Console.WriteLine("Informe um número para verificar se pertence à sequência de Fibonacci:");
        int numero = int.Parse(Console.ReadLine());

        if (Fibonacci(numero))
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} NÃO pertence à sequência de Fibonacci.");
        }


        // Exercicio 3 ----------

        // a) 1, 3, 5, 7, 9

        // b) 2, 4, 8, 16, 32, 64, 128

        // c) 0, 1, 4, 9, 16, 25, 36, 49

        //  d) 4, 16, 36, 64, 100

        //  e) 1, 1, 2, 3, 5, 8, 13 

        //  f) 2,10, 12, 16, 17, 18, 19, 2000

        // Exercicio 4 ----------

        /* Resposta= Chamaremos os interruptores de Int1, int2 e int3 
                    Ligaria o Int1 e esperaria uns minutos, desligaria e ligaria o Int2
                    iria até uma das salas, se a lampada estiver apagada, significa que pode ser o int1 ou int3
                    tocaria na lampada, caso esteja quente, significa que o int1 é o interruptor daquela sala
                    se estiver frio, significa que é o int3
                    se a lampada estiver acesa significa que é o int2

                    apenas para confirmar, voltaria, ligaria o int3 e esperaria alguns minutos
                    voltaria em uma sala diferente e verificaria a temperatura novamente das lampadas.

                    c
        */

        // Exercicio 5 ---------

        Console.WriteLine("Digite uma string:");
        string stringNormal = Console.ReadLine();

        string stringReversa = InverterString(stringNormal);

        Console.WriteLine($"String invertida: {stringReversa}");
    }

    static bool Fibonacci(int numero)
    {
        int a = 0, b = 1;

        while (b < numero)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return b == numero;
    }

    static string InverterString(string input)
    {
        char[] charArray = input.ToCharArray();

        int i = 0;
        int j = charArray.Length - 1;

        while (i < j)
        {

            char temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;

            i++;
            j--;
        }

        return new string(charArray);
    }

}