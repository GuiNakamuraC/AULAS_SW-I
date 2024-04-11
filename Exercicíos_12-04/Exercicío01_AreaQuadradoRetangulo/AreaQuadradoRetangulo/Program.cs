namespace AreaQuadradoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula a Área do Quadrado/Retângulo");

            Area xyz = new Area();
            Console.WriteLine(xyz.Calcular());

            Console.WriteLine(xyz.Dados());
        }
    }
}