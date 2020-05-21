using System;
using System.Collections.Generic;
using System.Text;

namespace Pruebaa
{
    abstract class Vehiculo
    {
        private Motor _motor;
         
        protected Vehiculo(string id, TipoMotor tipoMotor, int cilindrada)
        {
            _motor = new Motor(id,tipoMotor,cilindrada);
        }

        internal Motor Motor { get => _motor; set => _motor = value; }
    }
}
