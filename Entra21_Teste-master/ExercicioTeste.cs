using System;
using System.Collections.Generic;
using Xunit;

namespace Entra21_test
{
    public class ExercicioTeste
    {
        [Theory]
        [InlineData( 20, 3, 8.0, 8760)]
       
        public void Gasto_de_um_fumante(int cigarroDia, int anos, double preco, double result)
        {
            var exercicios = new Exercicios();
            double resultado = exercicios.Exercicio7(cigarroDia, anos, preco);
            cigarroDia = 20;
            anos = 3;
            Assert.Equal(result, resultado);
        }

        [Fact]
        public void Porcent_mulheres()
        {
            var exercicios = new Exercicios();
            var Lista = new List<int>(){15,25,30,28,40};
            int resultado = exercicios.Exercicio5(Lista);
            Assert.Equal(60, resultado);
        }

        [Theory]
        [InlineData(10 , 5 , true)]
        [InlineData(15 , 4 , false)]
        public void Retorna_se_x_multiplo_y(int numero1, int numero2, bool result)
        {

            //Quando a aplicação receber dois numeros inteiros, deve retornar True se o primeiro numero
            //For multiplo do segundo numero

            var exercicios = new Exercicios();
            var multiplo = exercicios.Exercicio08( numero1, numero2); 
            Assert.Equal(result, multiplo);
        }

        [Fact]
        public void Retorna_lista_1_a_10()
        //A aplicação deverá retornar todos os número de 1 a 10
        {
             var exercicios = new Exercicios();
             var retorna = exercicios.Exercicio01A();
             var valor_esperado = new int[10]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

             for(int i = 0; i < valor_esperado.Length; i++)
             {
             Assert.Equal(valor_esperado[i], retorna[i]);
             }
        }

        [Fact]
        public void Retorna_lista_10_a_1()
        //A aplicação deverá retornar todos os número de 10 a 1
        {
            var exercicios = new Exercicios();
            var retorna = exercicios.Exercicio01B();
            var valor_esperado = new int [10]{10, 9, 8, 7, 6, 5, 4, 3, 2, 1};

            for(int i = 10; i > valor_esperado.Length; i++)
            {
                Assert.Equal(valor_esperado[i], retorna[i]);
            }
        }

        [Fact]
        public void Retorna_lista_pares_1_a_10()
        {
            //a aplicação deverá retornar os números de 1 a 10, mas somente os pares
            
            var exercicios = new Exercicios();
            var retorna = exercicios.Exercicio01C();
            var valor_esperado = new int[5]{2, 4, 6, 8, 10};

            Assert.Equal(5, retorna.Length);
            for(int i = 0; i < retorna.Length; i++)
            {
                Assert.Equal(valor_esperado[i], retorna[i]);
            }
        }
    }
}