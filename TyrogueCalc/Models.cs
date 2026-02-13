namespace TyrogueEvolutionCalculator
{
    public enum Evolution
    {
        None,
        Hitmonlee,
        Hitmonchan,
        Hitmontop
    }

    public class TyrogueData
    {
        public int Nivel { get; set; }
        public int NaturalezaIndex { get; set; }
        public int PS { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public int AtaqueEspecial { get; set; }
        public int DefensaEspecial { get; set; }
        public int Velocidad { get; set; }
    }

    public class ResultadoCalculo
    {
        public int AtaqueActual { get; set; }
        public int DefensaActual { get; set; }
        public int AtaqueObjetivo { get; set; }
        public int DefensaObjetivo { get; set; }
        public int IVAtaque { get; set; }
        public int IVDefensa { get; set; }
        public int ProteinasNecesarias { get; set; }
        public int HierrosNecesarios { get; set; }
        public int CostoTotal { get; set; }
        public bool TieneAdvertencia { get; set; }
        public string MensajeAdvertencia { get; set; }
    }

    public class NatureModifiers
    {
        public double Ataque { get; set; } = 1.0;
        public double Defensa { get; set; } = 1.0;
        public double AtaqueEspecial { get; set; } = 1.0;
        public double DefensaEspecial { get; set; } = 1.0;
        public double Velocidad { get; set; } = 1.0;
    }
}