namespace Treinador_de_Classes_e_Métodos
{
    internal class Program
    {
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

            //coloca \n dentro do writeline para criar novas linhas p espaçamento
            Console.WriteLine("\nRepetindo:\n");

            // ou sem o $ e fazendo concatenacao
            Console.WriteLine("A nota Final do aluno " + aluno1.Nome + " é " + aluno1.NotaFinal);

            //readkey para a janela não fechar sozinha
            Console.ReadKey();

        }
    }
}