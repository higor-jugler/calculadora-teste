
public class Calculadora {
    enum Menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7 }

    public static void Main () {

        bool opcaoSair = false;
        while (!opcaoSair) {
            Console.WriteLine ( "Bem vindo ao aplicativo Calculadora, selecione a opção desejada:\n" );
            Console.WriteLine (
                "1 - Soma\n2 - Subtração\n" +
                "3 - Divisão\n4 - Multiplicação\n" +
                "5 - Potencia\n6 - Raiz\n7 - Sair" );

            Menu menu = (Menu)int.Parse ( Console.ReadLine () );
            Console.WriteLine ( menu );

            Console.Clear ();

            switch (menu) {

                case Menu.Soma:
                Soma ();
                Console.WriteLine ( "Digite enter para voltar ao menu" );
                Console.ReadLine ();
                Console.Clear ();
                break;

                case Menu.Subtracao:
                Subtrair ();
                Console.WriteLine ( "Digite enter para voltar ao menu" );
                Console.ReadLine ();
                Console.Clear ();
                break;

                case Menu.Divisao:
                Divisao ();
                Console.WriteLine ( "Digite enter para voltar ao menu" );
                Console.ReadLine ();
                Console.Clear ();
                break;

                case Menu.Multiplicacao:
                Multiplicacao ();
                Console.WriteLine ( "Digite enter para voltar ao menu" );
                Console.ReadLine ();
                Console.Clear ();
                break;

                case Menu.Potencia:
                Potencia ();
                Console.WriteLine ( "Digite enter para voltar ao menu" );
                Console.ReadLine ();
                Console.Clear ();
                break;

                case Menu.Raiz:
                RaizQuadrada ();
                Console.WriteLine ( "Digite enter para voltar ao menu" );
                Console.ReadLine ();
                Console.Clear ();
                break;

                case Menu.Sair:
                opcaoSair = true;
                break;

                }

            }

        static double Soma () {

            Console.WriteLine ( "Insira dois números: " );
            Console.WriteLine ( "Digite o primeiro número: " );
            double num01 = double.Parse ( Console.ReadLine () );
            Console.WriteLine ( "Digite o segundo número: " );
            double num02 = double.Parse ( Console.ReadLine () );
            Console.WriteLine ( $"A soma de {num01} e {num02} é de {num01 + num02}" );

            return 0;
            }

        static double Subtrair () {

            Console.WriteLine ( "Insira dois números: " );
            Console.WriteLine ( "Digite o primeiro número: " );
            double num01 = double.Parse ( Console.ReadLine () );
            Console.WriteLine ( "Digite o segundo número: " );
            double num02 = double.Parse ( Console.ReadLine () );
            Console.WriteLine ( $"A subtração de {num01} e {num02} é de {num01 - num02}" );

            return 0;
            }

        static double Divisao () {

            Console.WriteLine ( "Insira dois números: " );
            Console.WriteLine ( "Digite o primeiro número: " );
            double num01 = double.Parse ( Console.ReadLine () );
            Console.WriteLine ( "Digite o segundo número: " );
            double num02 = double.Parse ( Console.ReadLine () );

            while (num02 == 0) {
                Console.WriteLine ( "Não é possível fazer divisão por 0, entre com outro número: " );
                num02 = double.Parse ( Console.ReadLine () );
                }

            Console.WriteLine ( $"A divisão de {num01} e {num02} é de {num01 / num02}" );

            return 0;
            }

        static double Multiplicacao () {

            Console.WriteLine ( "Insira dois números: " );
            Console.WriteLine ( "Digite o primeiro número: " );
            double num01 = double.Parse ( Console.ReadLine () );
            Console.WriteLine ( "Digite o segundo número: " );
            double num02 = double.Parse ( Console.ReadLine () );
            Console.WriteLine ( $"A multiplicação de {num01} e {num02} é de {num01 * num02}" );

            return 0;
            }

        static double Potencia () {

            Console.WriteLine ( "Insira dois números: " );
            Console.WriteLine ( "Digite o número base: " );
            double numBase = double.Parse ( Console.ReadLine () );
            Console.WriteLine ( "Digite a potência desejada: " );
            double numPot = double.Parse ( Console.ReadLine () );
            double resultado = Math.Pow ( numBase, numPot );
            Console.WriteLine ( $"O número base é {numBase} elevado a {numPot}, dando a potência {resultado}" );

            return 0;
            }

        static double RaizQuadrada () {
            Console.WriteLine ( "Insira o número desejado para achar a raiz quadrada: " );
            Console.WriteLine ( "Digite o número desejado: " );
            double num01 = double.Parse ( Console.ReadLine () );
            double raiz = Math.Sqrt ( num01 );
            Console.WriteLine ( $"A raiz de {num01} é {raiz}" );

            return 0;
            }

        }

    }
