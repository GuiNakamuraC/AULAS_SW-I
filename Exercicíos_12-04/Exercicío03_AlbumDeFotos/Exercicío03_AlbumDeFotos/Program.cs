namespace Exercicío03_AlbumDeFotos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número total de páginas do álbum: ");
            int numertoTotalDePaginas = Convert.ToInt32(Console.ReadLine());

            AlbumDeFotos album = new AlbumDeFotos(numertoTotalDePaginas);

            Console.WriteLine("Informe o número de fotos a serem adicionadas: ");
            int numeroDeFotos = Convert.ToInt32(Console.ReadLine());

            album.NumeroDeFotos = numeroDeFotos;
        }
    }
}