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

        public double Exercicio16(double salario)
        {
            //Ler o salário de uma pessoa e imprimir o Salário Líquido, de acordo com a redução de imposto descrito ao lado:
            //Menor ou igual a R$600,00 - ISENTO;
            //Maior que R$600,00 e menor ou igual a R$1.200,00 - 20% desconto;
            //Maior que R$1.200,00 e menor ou igual a R$2.000,00 - 25% desconto;
            //Maior que R$2.000,00 - 30% desconto.

            if(salario > 2000.00)
            {
                return salario - ((salario * 30) / 100); 
            } 
            
            if(salario > 1200.00)
            {
                return salario - ((salario * 25) / 100); 
            } 
            
            if(salario > 600.00)
            {
                return salario - ((salario * 20) / 100);   
            }

            return salario;

        } 

        public double Exercicio18(int quantidadeMaca)
        {
            //As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia.
            //R$1,00 se forem compradas pelo menos 12.
            //Escreva um programa que leia o número de maçãs compradas,
            //calcule e escreva o custo total da compra.

            if(quantidadeMaca < 12)
            {
                return quantidadeMaca * 1.30;
            }

            return quantidadeMaca;

        }

        public string Exercicio10(int numero1, int numero2)
        {
            // ler 02 números reais do teclado (A e B), verificar e imprimir qual deles é maior,
            // ou a mensagem \"A = B\" caso sejam iguais.

            if(numero1 > numero2)
            {
                return numero1.ToString() + " é o maior";
            }

            if( numero1 < numero2)
            {
                return numero2.ToString() + " é o maior";
            }

            return numero1.ToString() + " = " + numero2.ToString();

        }

        public string Exercicio11(int numero1, int numero2)
        {
            // Ler 2 números inteiros do teclado. Se o segundo for diferente de zero, 
            // calcular e imprimir o quociente do primeiro pelo segundo. 
            // Caso contrário imprimir a mensagem \" DIVISÃO POR ZERO \ 

            if(numero2 == 0 )
            {
                return "Divisão por Zero";
            }

            else{
                return numero1.ToString() + " / " + numero2.ToString() + " = " + (numero1 / numero2);
            }

        }
    }
}