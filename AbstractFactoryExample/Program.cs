using System;
using AbstractFactoryExample.Base;
using AbstractFactoryExample.Base.Chevrolet;
using AbstractFactoryExample.Base.Ford;

namespace AbstractFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaCarros fabrica = null;
            Carro carro = null ;
            string marca = "ford";
            switch (marca) {
                case "chevrolet":
                    fabrica = new FabricaCarros(new Chevrolet());
                    break;
                case "ford":
                    fabrica = new FabricaCarros(new Ford());
                    break;
            }
            carro = fabrica.crearCarro();
            Console.WriteLine("Has comprado un " + carro.nombre);
        }
    }
}
