using System.Diagnostics.Metrics;

namespace Treinador_de_Classes_e_Métodos
{
    internal class Program
    {


        // Enum declarado na forma horizontal
        enum Meses { Janeiro, Fevereiro, Março, Abril, Maio, Junho, Julho, Agosto, Setembro, Outubro, Novembro, Dezembro }
        enum Qualidades { Inteligente, Burro, Capaz, Incompetente}


        static void Main(string[] args)
        {
            //entrada de 2 numeros inteiros
            Console.WriteLine("Digite 2 números inteiros: ");

            // try catch para administrar erros de digitacao (ex: letra ao inves de numero)
            try
            {
                // Readline recebe string, então faz parse para int
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());


                //a Classe Soma não tem métodos estáticos, então é necessário criar nova instância da classe Soma.
                //Soma (Classe) soma1 (nome da nova instancia da classe Soma) = new Soma() (chama o construtor de Soma)
                Soma soma1 = new Soma();

                //cria variavel tipo int de nome resultado, e atribui o valor de classe soma, método Somar, parametros (x, y)
                int resultado = soma1.Somar(x, y);

                //mostra o resultado no console
                Console.WriteLine("O resultado da Soma é: " + resultado);

                //aqui repete o mesmo para subtração
                Subtracao subtracao1 = new Subtracao();
                int resultado2 = subtracao1.Subtrair(x, y);
                Console.WriteLine("O resultado da Subtração é: " + resultado2);

                //aqui repete o mesmo para divisao
                Divisao divisao1 = new Divisao();
                int resultado3 = divisao1.Dividir(x, y);
                Console.WriteLine("O resultado da Divisão é: " + resultado3);

                //aqui uma novidade, a classe Multiplicação tem um método static, então pode ser acessada diretamente daqui sem criar objeto multiplicação
                int resultado4 = Multiplicacao.Multiplicar(x, y);
                Console.WriteLine("O resultado da Multiplicação é: " + resultado4);

            }

            //aqui é o catch, que mostra a mensagem e o erro 'ex'
            catch
            {
                Exception ex = new Exception();
                Console.WriteLine("Erro de digitação, favor reiniciar o programa.");
                Console.WriteLine(ex);
            }



            //*************** aqui é a parte onde treina métodos get e set ************
            // trabalha em conjunto com a classe Aluno
            // aqui nao botei try catch, entao um erro de digitação irá dar crash no programa.

            // cria uma instancia da classe Aluno, chamada aluno1
            Aluno aluno1 = new Aluno();

            //esse aluno tem nome
            Console.WriteLine("\n\nDigite o nome do aluno:");
            aluno1.Nome = Console.ReadLine();

            //Esse aluno tem 4 notas e uma nota final
            Console.WriteLine("Digite as 4 notas:");
            aluno1.Nota1 = double.Parse(Console.ReadLine());
            aluno1.Nota2 = double.Parse(Console.ReadLine());
            aluno1.Nota3 = double.Parse(Console.ReadLine());
            aluno1.Nota4 = double.Parse(Console.ReadLine());
            double notaFinal = aluno1.NotaFinal;

            // aqui tem 2 métodos de mostrar variaveis: uma é botando o $ antes das aspas
            // e botando o valor entre chaves
            Console.WriteLine($"A nota Final do aluno {aluno1.Nome} é {aluno1.NotaFinal}");

            //coloca \n dentro das aspas do writeline para criar novas linhas p espaçamento
            Console.WriteLine("\nRepetindo:\n");

            // ou sem o $ e fazendo concatenacao
            Console.WriteLine("A nota final do aluno " + aluno1.Nome + " é " + aluno1.NotaFinal);

            // aqui pega uma variavel de a até d e usa o enum Qualidades para atribuir cada elemento do enum
            Qualidades a = Qualidades.Inteligente;
            Qualidades b = Qualidades.Incompetente;
            Qualidades c = Qualidades.Capaz;
            Qualidades d = Qualidades.Burro;
            
            //aqui gera uma frase dependendo da nota final do aluno hehe
            if (notaFinal > 7)
            {
                // aqui mostra uma frase combinando as variaveis
                Console.WriteLine($"\nO aluno {aluno1.Nome} é {a} e não é {b}, é {c} e não é {d} ");
            }
            else
            {
                Console.WriteLine($"\nO aluno {aluno1.Nome} é {d} e não é {c}, é {b} e não é {a} ");
            }


           
            //****************************************************************

            // Aqui tem outros recursos para demonstração

            // aqui variavel hora do tipo DateTime. Puxa DateTime.Now para mostrar a hora atual.
            DateTime hora = DateTime.Now;
            Console.WriteLine($"\nData atual: {hora}");


            // demonstração do uso de constante para uma formula
            const double Pi = 3.141592;
            Console.WriteLine("\nQual o raio do Círculo?\n");
            double raio = double.Parse(Console.ReadLine());

            //demonstração de calculo de area multiplicando 2x raio
            double areaCirculo1 = Pi * raio * raio;
            Console.WriteLine($"\nA área do circulo é: {areaCirculo1}");

            //coloca \n dentro das aspas do writeline para criar novas linhas p espaçamento
            Console.WriteLine("\nRepetindo:\n");

            //calculando a mesma coisa, mas usando o método Pow da classe Math.
            double areaCirculo2 = Pi * Math.Pow(raio, 2);
            Console.WriteLine($"A área do circulo é: {areaCirculo2}");

            // aqui usa o enum Meses declarado lá no inicio
            //mostra o indice do item do enum Meses2 (começa em 0)
            Console.WriteLine("\nO índice do mês Fevereiro é: " + (int)Meses.Fevereiro);

            //mostra o elemento Fevereiro
            Console.WriteLine("\n" + Meses.Fevereiro);
          

            // emite um beep no pc speaker
            Console.Beep();



            //readkey para a janela não fechar sozinha
            Console.ReadKey();




        }
    }


}
