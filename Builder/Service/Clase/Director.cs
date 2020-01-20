using Builder.Service.Interface;

namespace Builder.Service.Clase
{
    class Director
    {
        public void CrearManual(IConstructor _IConstructor)
        {
            _IConstructor.Reset();
            _IConstructor.AsignarAsientos(2);
            _IConstructor.AsignarMotor("V8");
            _IConstructor.AsignarComputadoraDeViaje();
            _IConstructor.AsignarGPS();
        }

        public void CrearAuto(IConstructor _IConstructor)
        {
            _IConstructor.Reset();
            _IConstructor.AsignarAsientos(4);
            _IConstructor.AsignarMotor("V11");
            _IConstructor.AsignarComputadoraDeViaje();
            _IConstructor.AsignarGPS();
        }
    }
}
