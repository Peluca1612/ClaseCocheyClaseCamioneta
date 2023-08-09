namespace In_out
{
    class Furgoneta : Coche
    {
        private int Carga { get; set; }
        private int AsientosExtra { get; set; }

        public Furgoneta(
            int kgcarga = 500,
            int plazasextra = 4,
            int fuerza = 300,
            string dimensiones = "4x6 metros",
            int pc = 1000,
            int ruedas = 4,
            string motor = "15 cilindros") : base(dimensiones, fuerza, pc, ruedas, motor)
        {
            this.Carga = kgcarga;
            this.AsientosExtra = plazasextra;
        }

        public int GetKgCarga() { return this.Carga; }
        public int GetAsientosExtra() {  return this.AsientosExtra; }

        public void SetKgCarga(int kgcarga) { this.Carga = kgcarga;}
        public void SetPlazasExtras(int asientosextra) { this.AsientosExtra = asientosextra; }

        public string Caracteristicas()
        {
            string caract = $"La camioneta tiene por dimensiones: {this.GetDimensiones()}, tiene {this.GetRuedas()} y tiene {this.GetMotor()} caballos de fuerza. Tiene una capacidad de llevar {this.GetKgCarga()} kg, posee {this.GetAsientosExtra()} y pesa {this.GetPesoCarroceria()}";
            Console.WriteLine(caract);
            return caract;
        }   
    }
}
