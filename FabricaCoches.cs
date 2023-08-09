// using static In_out.Persona;

using System;

namespace In_out
{
    class FabricaCoche
    {
        static void Main(String[] args)
        {
            Coche corvette = new Coche(ruedas: 4, peso: 500, dimensiones: "5x4 metros", motor:"V6");
            Coche camaro = new Coche(ruedas: 4, peso: 550, dimensiones: "4x3 metros", motor: "V8");
            Coche lexus = new Coche(ruedas: 4, peso: 600, dimensiones: "5x4 metros", motor: "V8");

            //corvette.Describir();
            //camaro.Describir();
            //lexus.Describir();

            Furgoneta superduty = new Furgoneta(dimensiones: "5x4 metros",  ruedas: 4, motor: "V6", kgcarga: 1000, plazasextra: 2, pc: 2000);
            Furgoneta hilux_modificada = new Furgoneta(dimensiones: "6x5 metros", ruedas: 6, motor: "V8", kgcarga: 1500, plazasextra: 3, pc: 3000);
            Furgoneta previa = new Furgoneta(dimensiones: "5x4 metros", ruedas: 4, motor: "V6", kgcarga: 800, plazasextra: 3, pc: 2500);

            superduty.Caracteristicas();
            //hilux_modificada.Caracteristicas();
            //previa.Caracteristicas();
        }
    }
}
