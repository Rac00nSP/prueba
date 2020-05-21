using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pruebaa
{
    enum TipoMotor
    {
        DOS_TIEMPOS, CUATRO_TIEMPOS
    }
    class Motor : VehiculoComponente
    {
        private readonly string _id;
        private TipoMotor _tipoMotor;
        private int _cilindrada;
        public Motor(string id,TipoMotor tipoMotor, int cilindrada) : base()
        {
            _id = id;
            _tipoMotor = tipoMotor;
            _cilindrada = cilindrada; 

        }

        public string Id  => _id;  
        public int Cilindrada { get => _cilindrada; set => _cilindrada = value; }
        internal TipoMotor TipoMotor { get => _tipoMotor; set => _tipoMotor = value; }
    }
}
