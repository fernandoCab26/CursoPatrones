using Observador.Observers;
using System;

namespace Ejercicio
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("1) Subir Código");
            Console.WriteLine("2) Agregar Notificador");
            Console.WriteLine("3) Agregar Compilador");
            Console.WriteLine("4) Agregar Ejecutor de pruebas");
            Console.WriteLine("5) Agregar Instalador");

            Subject subject = new Subject();
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu(subject);
            }
            
        }

        private static bool MainMenu(Subject subject)
        {

            switch (Console.ReadLine())
            {
                case "1":
                    SubirCodigoObserver subirCodigoObserver = new SubirCodigoObserver();

                    subject.AgregarObserver(subirCodigoObserver);
                    subject.NotificarObserver();
                    return true;
                case "2":
                    NotificadorObserver notificadorObserver = new NotificadorObserver();
                    subject.AgregarObserver(notificadorObserver);
                    return true;
                case "3":
                    CompiladorObserver compiladorObserver = new CompiladorObserver();
                    subject.AgregarObserver(compiladorObserver);
                    return true;
                case "4":
                    EjecutorUTObserver ejecutorUTObserver = new EjecutorUTObserver();
                    subject.AgregarObserver(ejecutorUTObserver);
                    break;
                case "5":
                    InstaladorObserver instaladorObserver = new InstaladorObserver();
                    subject.AgregarObserver(instaladorObserver);
                    return true;
                default:
                    return true;

            }

            return true;
        }
    }
}
