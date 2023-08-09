namespace In_out
{
    class Coche
    {
        int Ruedas { get; set; }
        string Dimensiones { get; set; }
        int Fuerza { get; set; }
        string Motor { get; set; }
        int Peso { get; set; }
        int PesoCarroceria { get; set; }
        bool AsientosCuero { get; set; }
        public Coche(
            string dimensiones = "3x8 metros",
            int fuerza = 500,
            int pc = 1000,
            int ruedas = 4,
            string motor = "15 cilindros"
            )
        {
            this.Dimensiones = dimensiones;
            this.Ruedas = ruedas;
            this.Fuerza = fuerza;
            this.Motor = motor;
            this.PesoCarroceria = pc;
            this.SetPeso();
        }
        public int GetRuedas() { return this.Ruedas; }
        public int GetFuerza() { return this.Fuerza; }
        public string GetDimensiones() { return this.Dimensiones; }
        public string GetMotor() { return this.Motor; }
        public int GetPeso() { return this.Peso; }
        public int GetPesoCarroceria() { return this.PesoCarroceria; }
        public void SetRuedas(int ruedas) { this.Ruedas = ruedas; }
        public void SetFuerza(int fuerza) { this.Fuerza = fuerza; }
        public void SetDimensiones(string dimensiones) { this.Dimensiones = dimensiones; }
        public void SetMotor(string motor) { this.Motor = motor; }
        public void SetPeso()
        {
            int Peso_inicial = 500;
            int PesoTotal = Peso_inicial + this.PesoCarroceria;

            if (this.AsientosCuero)
            {
                PesoTotal += 30;
            }
        }
        public void SetPesoCarroceria(int pesoplataforma) { this.PesoCarroceria = pesoplataforma; }
        public void SetAsientosCuero(string asientoscuerochar = "no", bool asientoscuerobool = false)
        {
            if (asientoscuerochar.ToLower().Equals("si") || asientoscuerobool)
            {
                this.AsientosCuero = true;
            }
            this.AsientosCuero = false;
        }
        public string GetAsientosCuero()
        {
            if (this.AsientosCuero)
            {
                return "El carro tiene asientos de cuero.";
            }
            return "El carro no tiene asientos de cuero";
        }
        public int GetPrecio()
        {
            int Precio_inicial = 10000;
            int PrecioTotal = Precio_inicial;
            if (this.AsientosCuero)
            {
                PrecioTotal += 200;
            }

            return PrecioTotal;
        }
        public void Drive()
        {
            Console.WriteLine("RRRRRRRUMMMMM");
        }
        public string Describe()
        {
            string exit = $"Este carro tiene {this.Ruedas} ruedas, y su plataforma pesa {this.PesoCarroceria}. Sus dimensiones son {this.Dimensiones}. Tiene el motor {this.Motor} y pesa {this.Peso} kg";
            Console.WriteLine(exit);
            return exit;
        }
    }

}