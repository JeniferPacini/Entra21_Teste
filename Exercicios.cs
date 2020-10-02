using System.Collections.Generic;
using Xunit;

namespace Entra21_test
{
    public class Exercicios
    {
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
         //Imprimir todo os números ímpares menores de 200.
         {
           var impares = 0;
           impares = Lista.Count;
           return impares;
         }

    }
}