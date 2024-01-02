using System;

namespace conversorIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            string nomeUsuario;
            decimal peso;
            decimal altura;

            //Coleta de informações
            Console.Write("Informe seu nome: ");
            //Início do loop para repetição
            while (true)
            {
            nomeUsuario = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Qual seu peso? (ex: 79,9)");
            peso = decimal.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Qual sua altura? (ex: 1,63)");
            altura = decimal.Parse(Console.ReadLine());
            Console.Clear();

            //Formular matemática
            decimal resultado = peso / (altura * altura);
            //Necessário arredondar o valor desta forma
            decimal resultadoArredondado = Math.Round(resultado, 2);
            Console.WriteLine($"Seu IMC é de {resultadoArredondado}\n");

            if (resultadoArredondado <= 16.9m)
            {
                Console.WriteLine("Você está muito abaixo do peso\n");
                Console.WriteLine("Pressione qualquer tecla para fazer um novo calculo");
                }
            else if (resultadoArredondado <= 18.4m && resultadoArredondado >= 17)
            {
                Console.WriteLine("Você está abaixo do peso\n");
                Console.WriteLine("Pressione qualquer tecla para fazer um novo calculo");

            }
                else if (resultadoArredondado <= 24.9m && resultadoArredondado >= 18.5m)
            {
                Console.WriteLine("Você está com seu peso ideal\n");
                Console.WriteLine("Pressione qualquer tecla para fazer um novo calculo");
            }
            else if (resultadoArredondado <= 29.9m && resultadoArredondado >= 25)
            {
                Console.WriteLine("Você está acima do peso\n");
                Console.WriteLine("Pressione qualquer tecla para fazer um novo calculo");
            }
            else if (resultadoArredondado <= 34.9m && resultadoArredondado >= 30)
            {
                Console.WriteLine("Você está acima do peso, grau I\n");
                Console.WriteLine("Pressione qualquer tecla para fazer um novo calculo");
            }
            else if (resultadoArredondado <= 35 && resultadoArredondado > 40)
            {
                Console.WriteLine("Você está acima do peso, grau II\n");
                Console.WriteLine("Pressione qualquer tecla para fazer um novo calculo");
            }
            else if (resultadoArredondado >= 40)
            {
                Console.WriteLine("Você está acima do peso, grau III\n");
                Console.WriteLine("Pressione qualquer tecla para fazer um novo calculo");
            }

            }
        }
    }
}