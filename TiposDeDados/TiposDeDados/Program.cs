using System;

namespace TiposDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variaveis
            string nome = "Dario Ribeiro";
            int idade = 25;
            float altura = 1.68f;
            double peso = 116.5;
            bool fazOCurso = true;

            // Constantes
            const int NUMERODEINSCRICAO = 582;

            // Vetores - Arrays
            // Indices começa do 0
            string[] livros =
            {
                "Harry Potter",
                "1984",
                "A Revolução dos Bichos"
            };

            // Operadores Aritiméticos 
            // Soma + 
            // Subtração -
            // Multiplicação *
            // Divisão /
            double num1 = 45;
            double num2 = 21;

            double resultado = num1 / num2;

            // Operadores Relacionais
            // =    - Atribuição
            // ==   - Comparação - igual
            // !=   - Comparação - diferente
            // >    - Maior que
            // <    - Menor que
            // >=   - Maior ou igual
            // <=   - Menor ou igual
            Console.WriteLine(num1 >= num2);

            // Operadores Lógicos
            // ||   - OU
            // &&   - E
            Console.WriteLine(num1 > num2 && num1 == num2);

            // Estrutura Condicional
            // Simples
            if (idade > 18)
            {
                Console.WriteLine("Você pode tirar a carteira de motorista");
            }

            // Composta
            if(idade > 18)
            {
                Console.WriteLine("Você pode tirar a carteira de motorista");
            }else if(idade >= 16)
            {
                Console.WriteLine("Você deve pedir autorização ao seu responsavel para tirar a carteira de motorista");
            }
            else
            {
                Console.WriteLine("Você ainda não pode tirar a carteira de motorista");
            }
            //Encadeada - um if dentro do outro
            if(idade > 15)
            {
                if(nome == "Dario Ribeiro")
                {
                    Console.WriteLine("Bem vindo ao Rock In Rio");
                }
            }
        }
    }
}
