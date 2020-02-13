namespace Observador.Interfaces
{
    public interface ISubject
    {
        void AgregarObserver(IObserver observer);
        void NotificarObserver();
    }
}
