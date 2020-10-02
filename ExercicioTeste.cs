using System;
using System.Collections.Generic;
using Xunit;

namespace Entra21_test
{
    public class ExercicioTeste
    {
        [Theory]
        [InlineData( 20, 3, 8.0, 8760)]
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

        [Fact]
        public void  Numeros_impares()
        {
            var exercicios = new Exercicios();
            var Lista = new List<int>(){ }
        }
    }
}
