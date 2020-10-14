using System.Collections.Generic;

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

        public bool Exercicio09(int numero1, int numero2, int numero3)
        {
            //Fazer um algoritmo para ler 03 números reais do teclado e verificar se o  
		    //primeiro é maior que a soma dos outros dois.

            if(numero1 == numero2 + numero3)
            {
                return true;
            }
            return false;
        }

        public bool Exercício08(int numero1, int numero2)
        {
            //Ler dois números inteiros, X e Y, e apresentar mensagem informando se o X é múltiplo de Y.

            if(numero1 % numero2 == 0)
            {
                return true;
            }

            return false;
        }

        public double[] Exercicio01(double[] arrayA, double[] arrayB, double[] arrayC)
        {
            //Ler dois arrays A e B com 10 elementos. construir uma array , onde cada elemento de C é a 
            //subtração dos elementos de A e B

            for(int i = 0; i < arrayB.Length; i++)
            {
                arrayC[i] = arrayA[i] - arrayB[i];
            }

            return arrayC;

        }

        
        public int Exercicio02()
        {
            //Imprimir a soma dos números inteiros de 1 a 100

            int soma = 0;

            for(int i = 0; i < 101; i++)
            {
                soma += i;
            }
            return soma;
        }
        
        public int[] Exercicio17(int numero)
        {
            // Imprimir a tabuada de acordo com o numero fornecido

            int[] valorTabuada = new int[10];
            for(int i = 0; i < 10; i++)
            {
                valorTabuada[i] = numero * (i+1);
            }
            return valorTabuada;
        }

        public bool Exercicio3(int[] arrayA, int numero)
        {
            //Leia 10 elementos e armazene em um array A. Em seguida, solicite pelo 
            //teclado um número qualquer e pesquise no array se o número existe.

            for(int i = 0; i < arrayA.Length; i++)
            {

                if(numero == arrayA[i])
                {
                    return true;
                }

            }
            return false;
         
        }

        public bool Exercicio4(int[] arrayA, int[] arrayB)
        {
            //Leia dois arrays A e B com 10 elementos. Em seguida, compare os arrays e verifique se
            // os mesmos são iguais ou diferentes.

            for(int i = 0; i < arrayA.Length; i++)
            {
                if(arrayA[i] != arrayB[i])
                {
                   return false;
                }
                
            }
            return true;
            
        }

<<<<<<< HEAD:Domain/Exercicios.cs
        public (int[], int[]) Exercicio2_01(int[] arrayA, int[] arrayB)
        {
            //Popule dois vetores com 10 valores cada. 
            //Após esta operação, troque o conteúdo dos vetores.

            int[] arrayC = new int[arrayA.Length];

            for(int i = 0; i < arrayA.Length; i++)
            {
                arrayC[i] = arrayA[i];
                arrayA[i] = arrayB[i];
                arrayB[i] = arrayC[i];
            }

            return (arrayA, arrayB);
        }

        // public bool Exercicio2_02(int[] arrayA)
        // {
        //     //receber um vetor com 10 valores. Após esta operação, 
        //     //informe se há ou não números repetidos nesse vetor.

        //     for(int i = 0; i < arrayA.Length; i++)
        //     {
        //         if(arrayA[i] == arrayA[i])
        //         {
        //             return true;
        //         }
               
        //     }
        //     return false;
        // }

        // public void Exercicio2_03() 
        // {
        //     //Um certa empresa fez uma pesquisa para saber se as pessoas gostaram ou não de um novo
        //     // produto lançado no mercado. Para isso, forneceu-se o sexo do entrevistado e a sua resposta
        //     // (sim ou não). Sabendo-se que foram entrevistadas 10 pessoas, fazer um algoritmo que calcule e escreva:
        //     // • O número de pessoas que responderam sim;
        //     // • O número de pessoas que responderam não;
        //     // • A percentagem de pessoas do sexo feminino que responderam sim;
        //     // • A percentagem de pessoas do sexo masculino que responderam não;
        // }

=======
>>>>>>> f1e3a9bae159d16ca2a38d42716cd8b664e8efc5:Entra21_Teste-master/Entra21_Teste-master/Exercicios.cs
        public int Exercicio2_04(int[] matrizA)
        {
            //Desenvolver um programa que efetue a leitura de cinco elementos de uma matriz 
            // A do tipo vetor. No final, apresente o total da soma de todos os elementos 
            // que sejam impares.
            int soma = 0; 
            for(int i = 0; i < matrizA.Length; i++)
            {
                if(matrizA[i] % 2 != 0)
                {
                    soma += matrizA[i];

                }
            }

            return soma;
        }

        public int Exercicio2_05(int[] arrayA )
        {
            //Contar quantos valores de um vetor de 10 posições são positivos.
            
            int numPositivo = 0;

            for(int i = 0; i < arrayA.Length; i++)
            {
                if(arrayA[i] > 0)
                {
                    numPositivo ++;
                }
            }
            return numPositivo;
        }

<<<<<<< HEAD:Domain/Exercicios.cs
        // public void Exercicio2_06()
        // {
        //     //Ler um vetor de 10 posições 
        //     //Escrever a seguir o valor do maior elemento de Q 
        //     //e a respectiva posição que ele ocupa no vetor.
        // }

=======
>>>>>>> f1e3a9bae159d16ca2a38d42716cd8b664e8efc5:Entra21_Teste-master/Entra21_Teste-master/Exercicios.cs
        public int Exercicio2_07(int[] arrayA)
        {
            //Crie e popule um vetor A e imprima na tela o número de vezes que existe 
            //um número residindo na mesma posição do vetor que seu valor numérico.

            int numIgual = 0;
            for(int i = 0; i < arrayA.Length; i++)
            {
                if(arrayA[i] == i)
                {
                    numIgual ++;
                }
            }

            return numIgual;
        }
            
        public int Exercicio2_08(string[] arrayA)
        {
            //Crie um vetor de strings de 10 posições onde cada posição
            //recebe uma letra do alfabeto. No final, imprima quantas destas são vogais.

            var letras = 0;
            for(int i = 0; i < arrayA.Length; i++)
            {
                if(arrayA[i] == "a" || arrayA[i] == "e" || arrayA[i] == "i" || arrayA[i] == "o" || arrayA[i] == "u")
                {
                    letras++;
                }
            }
            return letras;
<<<<<<< HEAD:Domain/Exercicios.cs
        }

        public string Exercicio2_09(string[] arrayA)
        {
            //Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto. 
            //No final, imprima a string resultante da soma das strings que residem em índices pares.

            string palavra = "";
            for(int i = 0; i < arrayA.Length; i++)
            {
                if(i % 2 ==0)
                {
                    palavra += arrayA[i];
                }
            }
            return palavra;
=======
>>>>>>> f1e3a9bae159d16ca2a38d42716cd8b664e8efc5:Entra21_Teste-master/Entra21_Teste-master/Exercicios.cs
        }
    }
}