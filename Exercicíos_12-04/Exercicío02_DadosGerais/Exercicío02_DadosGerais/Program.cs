namespace Exercicío02_DadosGerais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Guilherme";
            p.DataNascimento = new DateTime(2008, 3, 22);
            p.Altura = 1.78f;

            p.ImprimirDados();

            int idade = p.CalcularIdade();

            Console.WriteLine("Idade: " + idade);

            Console.ReadKey();
        }
    }
}