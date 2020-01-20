using Builder.Entidad;
using Builder.Service.Interface;
using System.Collections.Generic;

namespace Builder.Service.Instancia.Constructor
{
    class ConstructorManual : IConstructor
    {
        Manual Manual { get; set; }

        public void AsignarAsientos(int _iNumero)
        {
            Manual.lstcOperaciones.Add(string.Format("se diseñaron {0} asientos", _iNumero));
        }

        public void AsignarComputadoraDeViaje()
        {
            Manual.lstcOperaciones.Add("se diseño la computadora de viaje");
        }

        public void AsignarGPS()
        {
            Manual.lstcOperaciones.Add("se diseño GPS");
        }

        public void AsignarMotor(string _cMotor)
        {
            Manual.lstcOperaciones.Add(string.Format("se diseño el motor tipo {0}", _cMotor));
        }

        public void Reset()
        {
            Manual = new Manual() { lstcOperaciones = new List<string>() };
        }

        public Manual GetResult()
        {
            return this.Manual;
        }
    }
}
