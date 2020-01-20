namespace Builder.Service.Interface
{
    public interface IConstructor
    {
        void Reset();

        void AsignarAsientos(int _iNumero);

        void AsignarMotor(string _cMotor);

        void AsignarComputadoraDeViaje();

        void AsignarGPS();
    }
}
