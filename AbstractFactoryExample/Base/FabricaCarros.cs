using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.Base
{
    class FabricaCarros
    {
        IFabricaCarros fabricante;
        public FabricaCarros(IFabricaCarros fabricante) {
            this.fabricante = fabricante;
        }
        public void setFabrica(IFabricaCarros fabricante) {
            this.fabricante = fabricante;
        }
        public Carro crearCarro() {
            return fabricante.crearCarro();
        }
    }
}
