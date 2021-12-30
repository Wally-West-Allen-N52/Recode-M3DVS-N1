using System;

namespace Sintaxe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Crie uma aplicação console contemplando três variáveis inteiras, com nomes livres.
                Atribua valores iniciais às três.
                Imprima o resultado de cada uma delas em linhas distintas.
                Imprima o resultado utilizando operadores de comparação, a sua escolha, entre as duas primeiras variáveis.
                Imprima o resultado utilizando operadores de igualdade entre as duas últimas variáveis.
                Utilize operadores aritméticos distintos com a primeira e a última variáveis e em seguida imprima o novo resultado das duas em linhas distintas.
            */
            int idade = 37;
            int peso = 60;
            int valor = 30;
            Console.WriteLine("Idade é: " + idade);
            Console.WriteLine("Peso é: " + peso);
            Console.WriteLine("Valor é de R$" + valor);

            Console.WriteLine("A idade mennnor que peso? " + (idade < peso));
            Console.WriteLine("Peso e valor são iguais? " + (peso == valor));
            
            Console.WriteLine("Peso e valor são iguais? " + (peso == valor));
            Console.WriteLine("Peso e valor são iguais? " + (peso == valor));

            Console.WriteLine("Idade da sua cabeça de velho: " + (idade * valor));
            Console.WriteLine("quanto você está valendo no mercado, agora: " + (idade - valor));

            Console.WriteLine("Novo valor de peso: " + peso);
            Console.WriteLine("Novo valor de valor R$: " + valor);
        }
    }
}
