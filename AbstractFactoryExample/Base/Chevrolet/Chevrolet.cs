using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.Base.Chevrolet
{
    class Chevrolet:IFabricaCarros
    {
        public Carro crearCarro() {
            Nuevo_Chevrolet carro = new Nuevo_Chevrolet();
            return carro;
        }
    }
}
