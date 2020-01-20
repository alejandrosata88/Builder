using Builder.Entidad;
using Builder.Service.Interface;
using System.Collections.Generic;

namespace Builder.Service.Instancia.Constructor
{
    class ConstructorAuto : IConstructor
    {
        Auto Auto { get; set; }

        public void AsignarAsientos(int _iNumero)
        {
            Auto.lstcOperaciones.Add(string.Format("se agrego {0} asientos", _iNumero));
        }

        public void AsignarComputadoraDeViaje()
        {
            Auto.lstcOperaciones.Add("se agrego computadora de viaje");
        }

        public void AsignarGPS()
        {
            Auto.lstcOperaciones.Add("se agrego GPS");
        }

        public void AsignarMotor(string _cMotor)
        {
            Auto.lstcOperaciones.Add(string.Format("se agrego el motor tipo {0}", _cMotor));
        }

        public void Reset()
        {
            Auto = new Auto() { lstcOperaciones = new List<string>()};
        }

        public Auto GetResult()
        {
            return this.Auto;
        }
    }
}
