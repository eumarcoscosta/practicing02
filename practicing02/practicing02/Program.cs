using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {


            int numero, i;
            Console.WriteLine("Insira o numero abaixo: ");
            numero = int.Parse(Console.ReadLine());


            string[] nomes = new string[numero];
            int[] idade = new int[numero];
            double[] altura = new double[numero];

            for (i = 0; i < numero; i++)
            {

                string[] vet1 = Console.ReadLine().Split(' ');

                nomes[i] = vet1[0];
                idade[i] = int.Parse(vet1[1]);
                altura[i] = double.Parse(vet1[2], CultureInfo.InvariantCulture);


            }

            double somaAltura = 0.0;
            int pessoasValidas = 0;

            for (i = 0; i < numero; i++)
            {
                if (altura[i] > 0)
                {
                    somaAltura = somaAltura + altura[i];
                    pessoasValidas++;
                }
            }

            double alturaMedia = somaAltura / pessoasValidas;
            Console.WriteLine($"Altura média : {alturaMedia.ToString("F2", CultureInfo.InvariantCulture)}");

            double idadeMenos16 = 0.0;
            for (i = 0; i < numero; i++)
            {

                if (idade[i] < 16)
                {

                    idadeMenos16++;

                }

            }

            double porcentagemMenorcw16 = ((double)idadeMenos16 / numero) * 100;
            Console.WriteLine($"Porcentagem de pessoas com menos de 16 anos: {porcentagemMenorcw16.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}