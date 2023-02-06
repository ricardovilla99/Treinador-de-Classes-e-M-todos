namespace Treinador_de_Classes_e_Métodos
{


    public class Aluno
    {
        //variavel de campo privado tem underline antes: nome fica _nome
        private string _nome;

        //4 notas privadas
        private double _nota1;
        private double _nota2;
        private double _nota3;
        private double _nota4;

        // nota final publica, média das notas anteriores
        public double _notaFinal;

        //variavel nome
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        //variaveis nota, com validacao p valores entre 0 e 10
        public double Nota1
        {
            get { return _nota1; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _nota1 = value;
                    CalcularFinal();
                }
                else
                {
                    Console.WriteLine("Nota Invalida, deve ser entre 0 e 10, favor refazer.");
                }
            }
        }

        //variaveis nota, com validacao p valores entre 0 e 10
        public double Nota2
        {
            get { return _nota2; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _nota2 = value;
                    CalcularFinal();
                }
                else
                {
                    Console.WriteLine("Nota Invalida, deve ser entre 0 e 10, favor refazer.");
                }
            }
        }

        //variaveis nota, com validacao p valores entre 0 e 10
        public double Nota3
        {
            get { return _nota3; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _nota3 = value;
                    CalcularFinal();
                }
                else
                {
                    Console.WriteLine("Nota Invalida, deve ser entre 0 e 10, favor refazer.");
                }
            }
        }

        //variaveis nota, com validacao p valores entre 0 e 10
        public double Nota4
        {
            get { return _nota4; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _nota4 = value;
                    CalcularFinal();
                }
                else
                {
                    Console.WriteLine("Nota Invalida, deve ser entre 0 e 10, favor refazer.");
                }
            }
        }

        //variavel notaFinal
        public double NotaFinal
        {
            get { return _notaFinal; }
        }

        //metodo calcular final, some e divide por 4
        private void CalcularFinal()
        {
            _notaFinal = (_nota1 + _nota2 + _nota3 + _nota4) / 4;
        }
    }


}
