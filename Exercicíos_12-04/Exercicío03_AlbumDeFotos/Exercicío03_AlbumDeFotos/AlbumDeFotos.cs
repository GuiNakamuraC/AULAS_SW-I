using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicío03_AlbumDeFotos
{
    public class AlbumDeFotos
    {
        private int numeroTotalDePaginas;
        private int numeroTotalDeFotos;

        public AlbumDeFotos(int numeroTotalDePaginas) 
        {
            numeroTotalDePaginas = numeroTotalDePaginas;
        }
        public int NumeroTotalDePaginas
        {
            get { return numeroTotalDePaginas; }
        }
        public int NumeroTotalDeFotos
        {
            get { return numeroTotalDePaginas * 2;}
        }
        public int NumeroDeFotos
        {
            get { return NumeroDeFotos; }
            set 
            { 
                if (value > numeroTotalDeFotos)
                {
                    Console.WriteLine("Erro: Número de fotos excede o limite total de fotos.");
                }
                else
                {
                    NumeroDeFotos = value;
                    Console.WriteLine("As fotos podem ser adicionadas ao álbum.");
                }
            }
        }
    }
}
