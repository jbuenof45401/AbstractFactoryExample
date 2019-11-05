using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.Base.Ford
{
    class Ford:IFabricaCarros
    {
        public Carro crearCarro() {
            Nuevo_Ford carro = new Nuevo_Ford();
            return carro;
        }
    }
}
