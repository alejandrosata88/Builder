using Builder.Service.Clase;
using Builder.Service.Instancia.Constructor;
using Builder.Entidad;
using System.Collections.Generic;
using System;

namespace Builder.Controller
{
    public class Cliente
    {
        public void Main()
        {
            Auto Auto = new Auto();
            Manual Manual = new Manual();
            Director Director = new Director();

            ConstructorAuto ConstructorAuto = new ConstructorAuto();
            Director.CrearAuto(ConstructorAuto);
            Auto= ConstructorAuto.GetResult();
            ImpirmirOperaciones(Auto.lstcOperaciones);
            Console.WriteLine();

            ConstructorManual ConstructorManual = new ConstructorManual();
            Director.CrearAuto(ConstructorManual);
            Manual = ConstructorManual.GetResult();
            ImpirmirOperaciones(Manual.lstcOperaciones);
            Console.ReadLine();
        }

        public void ImpirmirOperaciones(List<string> _lstString)
        {
            foreach(string cOperacion in _lstString)
            {
                Console.WriteLine(cOperacion);
            }
        }
    }
}
