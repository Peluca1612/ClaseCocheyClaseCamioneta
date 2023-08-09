namespace In_out
{
    class Furgoneta : Coche
    {
        private int Carga { get; set; }
        private int AsientosExtra { get; set; }

        public Furgoneta(
            int kgcarga,
            int plazasextra,
            int fuerza = 300,
            string dimensiones = "4x6 metros",
            int pc = 1000,
            int ruedas = 4,
            string motor = "15 cilindros") : base(dimensiones, fuerza, pc, ruedas, motor)
        {
            this.Carga = kgcarga;
            this.AsientosExtra = plazasextra;
        }

        public void SayHi()
        {
            Console.WriteLine($"Hola, tengo {this.GetDimensiones} de longitud");
        }
    }
}
