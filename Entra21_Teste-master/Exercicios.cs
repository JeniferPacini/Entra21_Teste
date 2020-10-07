using System.Collections.Generic;
using Xunit;

namespace Entra21_test
{
    public class Exercicios
    {
        private const bool V = true;

        public double Exercicio7(int cigarrosPorDia, int anos, double preco)
        {
                //Calcular a quantidade de dinheiro gasta por um fumante. 
                //Dados: o numero de anos que ele fuma, o nº de cigarros fumados por 
                //dia e o preço de uma carteira.

               var cigarroAnual = 0.0;
               var varejo = (preco / 20);
               cigarroAnual = (varejo * cigarrosPorDia) * 365;
               double total = (cigarroAnual * anos);
               return total;   
        }

        public int Exercicio5(List<int> idades)
        {
            //Criar um algoritmo que peça o nome e a idade de 5 mulheres. Após 
            //informar estes dados, o programa deve mostrar apenas porcentagem de
            // mulheres que estão com idade entre 18 e 35
            var total = 0;
            var mulheres = 0;
            foreach (var item in idades)
            {
                
                if(item > 17 && item < 36)
                {
                    mulheres += idades.Count;
                }
            }   
            total = (mulheres *100 / 25);
            
            return total;
        
        } 

        public int Exercicio03(List<int> Lista)
        {
            //Imprimir todo os números ímpares menores de 200.
            var impares = 0;
            impares = Lista.Count;

            return impares;
        }

        public bool Exercicio08(int numero1, int numero2)
        {
            bool  multiplo  =  true ;
            multiplo = numero1 % numero2 == 0;

            return multiplo;
        }

        public int[] Exercicio01A()
        {
            var numeros = new int[10];

            for(int i = 1; i < 11; i++)
            {
                numeros[i - 1] = i;
            }
            return numeros;
        }

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1b,
        // então a aplicação deverá retornar todos os números de 1 a 10 de forma decrescente
        public int[] Exercicio01B()
        {
            var numeros = new int [10];
            
            for(int i = 10; i > 0; i--)
            {
                numeros[numeros.Length - i] = i; 
            }
            return numeros;
        }

         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
        // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares
        public int[] Exercicio01C()
        {
                  var numeros = new int[5];

            
            for (int counter = 2; counter < 11; counter += 2) {
                var index = (counter / 2) - 1;
                numeros[index] = counter;
            }

            return numeros;
        }

        public string Exercicio03(double[] array, double numero)
        {
            //Leia 10 elementos e armazene em um array A. Em seguida, solicite pelo 
            //teclado um número qualquer e pesquise no array se o número existe.

            var resultado = "O número não existe no array";

            for(int i = 0; i < array.Length; i++)
            {
                if(array.Length == numero)
                {
                    resultado = "O número existe no array";
                    return resultado;
                }
            }

            return resultado;
        }

        public int[] Exercicio04(double[] array)
        {
            //Leia um array A com 15 elementos, e calcule a média aritmética dos mesmos, 
            //em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

            var resultado = new int[3];
            double media = 0.0;
            double soma = 0.0; 
            for(int i = 0; i < array.Length; i++)
            {
                soma += array[i];
            }

            media = soma / array.Length;

            foreach( var item in array)
            {
                if(item < media)
                {
                    resultado[0] ++;
                }
                if(item == media)
                {
                    resultado[1] ++;
                }
                if(item > media)
                {
                    resultado[2] ++;
                }
            }
            return resultado;
        }

        public void Exercicio16(double salario)
        {
            //Ler o salário de uma pessoa e imprimir o Salário Líquido, de acordo com a redução de imposto descrito ao lado:
            //Menor ou igual a R$600,00 - ISENTO;
            //Maior que R$600,00 e menor ou igual a R$1.000,00 - 20% desconto;
            //Maior que R$1.200,00 e menor ou igual a R$2.000,00 - 25% desconto;
            //Maior que R$2.000,00 - 30% desconto.

            var resultado = "Isento";
            double salario = 0.0;
            double desconto1 = (salario - ((salario * 20) / 100));
            double desconto2 = (salario - ((salario * 25) / 100));
            double desconto3 = (salario - ((salario * 30) / 100));

            if(salario <= 600.00)
            {
                return resultado;
            }
            if(salario > 600.00 && salario <= 1000.00)
            {
                return desconto1;
            }
            if(salario > 1200.00 && salario <= 2000.00)
            {
                return desconto2;
            }
            if(salario > 2000.00)
            {
                return desconto3;
            }       
        } 

        public void Exercicio18()
        {
            //As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia.
            //R$1,00 se forem compradas pelo menos 12.
            //Escreva um programa que leia o número de maçãs compradas,
            //calcule e escreva o custo total da compra.

            int maca = 0;
            double resultado = 0.0;

            if(maca < 12)
            {
                var resultado = maca * 1.30;
                return resultado;
            }
            else{
                var resultado = maca * 1.00;
                return resultado
            }

        }
        
    }
}