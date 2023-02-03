namespace Treinador_de_Classes_e_Métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //entrada de 2 numeros inteiros
            Console.WriteLine("Digite 2 números inteiros: ");

            // Readline recebe string, então faz parse para int
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
                               
        //a Classe Soma não tem métodos estáticos, então é necessário criar nova instância da classe Soma.
        //Soma (Classe) soma (nome da nova instancia da classe Soma) = new Soma() (chama o construtor de Soma)
            Soma soma = new Soma();
                        
        //cria variavel tipo int de nome resultado, e atribui o valor de classe soma, método Somar, parametros (x, y)
            int resultado = soma.Somar(x, y);

        //mostra o resultado no console
            Console.WriteLine("O resultado da Soma é: " + resultado);

        //aqui repete o mesmo para subtração
            Subtracao subtracao = new Subtracao();
            int resultado2 = subtracao.Subtrair(x, y);
            Console.WriteLine("O resultado da Subtração é: " + resultado2);

        //aqui repete o mesmo para divisao
            Divisao divisao = new Divisao();
            int resultado3 = divisao.Dividir(x, y);
            Console.WriteLine("O resultado da Divisão é: " + resultado3);

        //aqui uma novidade, a classe Multiplicação tem um método static, então pode ser acessada diretamente daqui sem criar objeto multiplicação
            int resultado4 = Multiplicacao.Multiplicar(x, y);
            Console.WriteLine("O resultado da Multiplicação é: " + resultado4);

            Console.ReadKey();

        }
    }
}