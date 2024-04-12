using FolhaPagamento;

namespace FolhaPagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagamento p = new Pagamento();
            p.Nome = "Ana";
            p.Sal = 5000;
            p.HED = 0;
            p.HEN = 12;
            p.ND = 0;
            p.Fal = 20;
            p.DE = 5;
            p.REF = 5;
            p.Val = 1;
            Console.WriteLine(p.FolhaDePagamento());
        }
    }
}
