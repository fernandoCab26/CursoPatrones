using PatronEstrategia.FormatosImagenes;
using System;

namespace PatronEstrategia
{
    class Program
    {
        static void Main(string[] args)
        {
            CreadorImagenes creadorImagenes = new CreadorImagenes();
            Console.WriteLine("Ingresa el nombre de la imagen");
         string nombre=   Console.ReadLine();

            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("1) BPMN");
            Console.WriteLine("2) PNG");
            Console.WriteLine("3) JPEG");


            MainMenu(creadorImagenes);
            

            Console.WriteLine(creadorImagenes.GuardarImagen(nombre));
        }

        private static bool MainMenu(CreadorImagenes creador)
        {

            switch (Console.ReadLine())
            {
                case "1":
                    creador.SetCreadorImagenes(new GuardarImagenBmp());
                    return true;
                case "2":
                    creador.SetCreadorImagenes(new GuardarImagenPng());
                    return true;
                case "3":
                    creador.SetCreadorImagenes(new GuardarImagenJpg());
                    return true;
                default:
                    return true;

            }
        }
    }
}
