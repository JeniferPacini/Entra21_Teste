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
            //A aplicação deverá retornar os números de 1 a 10, mas somente os pares
            
            var exercicios = new Exercicios();
            var retorna = exercicios.Exercicio01C();
            var valor_esperado = new int[5]{2, 4, 6, 8, 10};

            Assert.Equal(5, retorna.Length);
            for(int i = 0; i < retorna.Length; i++)
            {
                Assert.Equal(valor_esperado[i], retorna[i]);
            }
        }

        [Theory]
        [InlineData(1250, 937.5)]
        [InlineData(500, 500)]
        public void Retorna_o_valor_do_desconto_de_acordo_com_o_salario(double salario, double resultado)
        {
            //A aplicação deve retornar o valor do desconto de acordo com o salario

            //setup
            var exercicios = new Exercicios();
            //ação do usuario
            var retorna = exercicios.Exercicio16(salario);
            //resultado
            Assert.Equal(resultado, retorna);

        }

        [Theory]
        [InlineData(15, 15)]
        [InlineData(10, 13)]
        public void Retorna_o_valor_total_da_compra_das_macas(int quantidadeMaca, double valorEsperado)
        {
            //A aplicação deve retornar o valor total da compra das maças

            var exercicios = new Exercicios();
            var resultado = exercicios.Exercicio18(quantidadeMaca);
            Assert.Equal(valorEsperado, resultado);

        }

        [Theory]
        [InlineData(15, 10, "15 é o maior")]
        [InlineData(8, 17, "17 é o maior")]
        [InlineData(15, 15, "15 = 15")]
        public void Retorna_o_maior_numero_ou_se_sao_iguais(int numero1, int numero2, string resultadoEsperado)
        {
            // Deve retornar o maior numero entre 2, ou se são iguais

            var exercicios = new Exercicios();
            var resultado = exercicios.Exercicio10(numero1, numero2);
            Assert.Equal(resultadoEsperado, resultado);

        }

        [Theory]
        [InlineData(20, 0, "Divisão por Zero")]
        [InlineData(20, 10, "20 / 10 = 2")]
        public void Retorna_o_quociente_da_divisao(int numero1, int numero2, string valorEsperado)
        {
            //Deve retornar o quociente da divisão

            var exercicios = new Exercicios();
            var resultado = exercicios.Exercicio11(numero1, numero2);
            Assert.Equal(valorEsperado, resultado);
        }

        [Theory]
        [InlineData(15,10,5,true)]
        [InlineData(12,7,9,false)]
        public void Retonar_se_numero1_é_a_soma_do_numero2_e_numero3(int numero1, int numero2, int numero3, bool retornoEsperado)
        {
            //Deve retornar se o numero 1 é a soma do numero 2 e 3

            var exercicios = new Exercicios();
            var resultado = exercicios.Exercicio09(numero1, numero2, numero3);
            Assert.Equal(retornoEsperado, resultado);
        }

        [Theory]
        [InlineData(10,2, true)]
        [InlineData(15,7, false)]
        public void Retorna_se_numero1_é_multiplo_de_numero2(int numero1, int numero2, bool respostaEsperada)
        {
            //Deve retornar se numero 1 é multiplo de numero 2

            var exercicios = new Exercicios();
            var resultado = exercicios.Exercicio08(numero1, numero2);
            Assert.Equal(respostaEsperada, resultado);
        }
        [Theory]
        [InlineData(new double[10]{5,10,15,20,25,30,35,40,45,50},new double[10]{1,2,3,4,5,6,7,8,9,10},
        new double[10]{4,8,12,16,20,24,28,32,36,40})]
        public void Retona_a_subtração_do_arrayA_pelo_arrayB(double[] arrayA, double[] arrayB, double[] arrayC)
        {
            //deve retornar um arrayC de acordo com a subtração do array A pelo B

            var exercicios = new Exercicios();
            var resultado = exercicios.Exercicio01(arrayA, arrayB, arrayC);
            Assert.Equal(arrayC, resultado);
        }

        [Fact]
        public void Retonar_a_soma_de_1_a_100()
        {
            //Deve retornar a soma dos numeros de 1 a 100

            var exercicios = new Exercicios();
            var resultado = exercicios.Exercicio02();
            Assert.Equal(5050, resultado);
        }
        
        [Theory]
        [InlineData(2,new int[10]{2,4,6,8,10,12,14,16,18,20})]
        [InlineData(5,new int[10]{5,10,15,20,25,30,35,40,45,50})]
        public void Retorna_a_tabuada(int numero, int[] valorEsperado)
        {
            //Deve retornar a tabuada do numero fornecido 
            var exercicios = new Exercicios();
            var resultado = exercicios.Exercicio17(numero);
            Assert.Equal(valorEsperado, resultado);

        }

        [Theory]
        [InlineData(new int[10]{2,5,4,7,5,6,8,55,2,10}, 7, true)]
        [InlineData(new int[10]{2,5,4,7,5,6,8,55,2,10}, 15, false)]
        public void Retorna_se_numero_existe_no_array(int[] arrayA, int numero, bool valorEsperado)
        {
            //Deve retornar se o numero existe no array

            var exercicios = new Exercicios();
            var resultado = exercicios.Exercicio3(arrayA, numero);
            Assert.Equal(valorEsperado, resultado);

        }

        [Theory]
        [InlineData(new int[5]{2,5,6,4,8}, new int[5]{2,5,6,4,8}, true)]
        [InlineData(new int[5]{2,5,6,4,8}, new int[5]{2,5,9,4,8}, false)]
        public void Retorna_se_arrayA_igual_arrayB(int[] arrayA, int[] arrayB, bool resultadoEsperado)
        {
            //Deve retornar se o arrayA é igual ao arrayB

            var exercicios = new Exercicios();
            var resultado = exercicios.Exercicio4(arrayA, arrayB);
            Assert.Equal(resultadoEsperado, resultado);

        }

        [Theory]
        [InlineData(new int[5]{2,2,3,5,2}, 8)]
        [InlineData(new int[5]{2,1,3,5,2}, 9)]
        public void Retorna_a_soma_dos_numeros_impares_de_uma_lista(int[] matrizA,int resultadoEsperado)
        {
            var exercicios = new Exercicios();
            var resultado = exercicios.Exercicio2_04(matrizA);
            Assert.Equal(resultadoEsperado, resultado);

        }
        
        [Theory]
        [InlineData(new int[5]{-2,5,-6,3,7}, 3)]
        [InlineData(new int[5]{-2,5,-6,3,-7}, 2)]
        public void Retorna_quantos_numeros_sao_positivos(int[] arrayA, int resultadoEsperado)
        {
            //Deve retornar quantos numeros de uma lista são positivos 

            var exercicios = new Exercicios();
            var resultado = exercicios.Exercicio2_05(arrayA);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(new int[5]{0,3,4,7,4},2)]
        [InlineData(new int[4]{1,5,2,6},1)]
        public void Retorna_quantos_numeros_estao_na_posicao_correspondete_ao_seu_valor(int[] arrayA, int resultadoEsperado)
        {
            var exercicios = new Exercicios();
            var resultado = exercicios.Exercicio2_07(arrayA);
            Assert.Equal(resultadoEsperado, resultado);

        }

        // [Theory]
        // [InlineData(new string[10]{"a","f","g","e","i","r" },)]
        // [InlineData()]
        // public void Retorna_quantas_vogais_tem_no_array(string[] arrayA, int resultadoEsperado)
        // {
        //     //Deve retornar quantas vogais existem no array

        //     var exercicios = new Exercicios();
        //     var resultado = exercicios.Exercicio2_08(arrayA);
        //     Assert.Equal(resultadoEsperado, resultado);

        // }

    }
}
