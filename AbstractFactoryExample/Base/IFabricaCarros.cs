using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.Base
{
    interface IFabricaCarros
    {
        Carro crearCarro();
    }
}
