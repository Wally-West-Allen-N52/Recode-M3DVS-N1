using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            FOR EACH, apenas para ler os elemantos
            para inicializar os elementos usamos o FOR/WHILE/DO WHILE
            */
            int[] nums = { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int n in nums)
            {
                Console.WriteLine(n);

                /*
                    Adicione uma de repetição que tenha 5 execuções, utilizando a estrutura de controle de sua preferência.
                    Adicione uma nova variável para o controle das repetições.
                    A cada impressão, informe o número da execução em curso.
                    anteriormente.
                */

                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Show works");
                }
            }
        }
    }
}
