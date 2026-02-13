using System;
using System.Collections.Generic;

namespace TyrogueEvolutionCalculator
{
    public class TyrogueCalculator
    {
        private static readonly Dictionary<int, NatureModifiers> _naturalezas = new()
        {
            { 0, new NatureModifiers() }, // Neutral
            { 1, new NatureModifiers { Ataque = 1.1, Defensa = 0.9 } }, // Lonely
            { 2, new NatureModifiers { Ataque = 1.1, Velocidad = 0.9 } }, // Brave
            { 3, new NatureModifiers { Ataque = 1.1, AtaqueEspecial = 0.9 } }, // Adamant
            { 4, new NatureModifiers { Ataque = 1.1, DefensaEspecial = 0.9 } }, // Naughty
            { 5, new NatureModifiers { Defensa = 1.1, Ataque = 0.9 } }, // Bold
            { 6, new NatureModifiers { Defensa = 1.1, Velocidad = 0.9 } }, // Relaxed
            { 7, new NatureModifiers { Defensa = 1.1, AtaqueEspecial = 0.9 } }, // Impish
            { 8, new NatureModifiers { Defensa = 1.1, DefensaEspecial = 0.9 } }, // Lax
            { 9, new NatureModifiers { AtaqueEspecial = 1.1, Ataque = 0.9 } }, // Modest
            { 10, new NatureModifiers { AtaqueEspecial = 1.1, Defensa = 0.9 } }, // Mild
            { 11, new NatureModifiers { AtaqueEspecial = 1.1, Velocidad = 0.9 } }, // Quiet
            { 12, new NatureModifiers { AtaqueEspecial = 1.1, DefensaEspecial = 0.9 } }, // Rash
            { 13, new NatureModifiers { DefensaEspecial = 1.1, Ataque = 0.9 } }, // Calm
            { 14, new NatureModifiers { DefensaEspecial = 1.1, Defensa = 0.9 } }, // Gentle
            { 15, new NatureModifiers { DefensaEspecial = 1.1, Velocidad = 0.9 } }, // Sassy
            { 16, new NatureModifiers { DefensaEspecial = 1.1, AtaqueEspecial = 0.9 } }, // Careful
            { 17, new NatureModifiers { Velocidad = 1.1, Ataque = 0.9 } }, // Timid
            { 18, new NatureModifiers { Velocidad = 1.1, Defensa = 0.9 } }, // Hasty
            { 19, new NatureModifiers { Velocidad = 1.1, AtaqueEspecial = 0.9 } }, // Jolly
            { 20, new NatureModifiers { Velocidad = 1.1, DefensaEspecial = 0.9 } } // Naive
        };

        private const int BASE_TYROGUE = 35;
        private const int NIVEL_EVOLUCION = 20;
        private const int COSTO_VITAMINA = 9800;

        public ResultadoCalculo CalcularVitaminas(TyrogueData tyrogue, Evolution evolucionDeseada)
        {
            var naturaleza = _naturalezas[tyrogue.NaturalezaIndex];

            // Siempre estimar IVs desde las estadísticas actuales
            int ivAtaque = EstimarIV(tyrogue.Nivel, tyrogue.Ataque, 0, naturaleza.Ataque);
            int ivDefensa = EstimarIV(tyrogue.Nivel, tyrogue.Defensa, 0, naturaleza.Defensa);

            // Calcular estadísticas al nivel 20 sin EVs
            int ataqueBase = CalcularEstadistica(NIVEL_EVOLUCION, ivAtaque, 0, naturaleza.Ataque);
            int defensaBase = CalcularEstadistica(NIVEL_EVOLUCION, ivDefensa, 0, naturaleza.Defensa);

            // Calcular EVs necesarios
            int evsAtaque = 0;
            int evsDefensa = 0;
            int ataqueObjetivo = ataqueBase;
            int defensaObjetivo = defensaBase;

            switch (evolucionDeseada)
            {
                case Evolution.Hitmonlee:
                    while (ataqueObjetivo <= defensaObjetivo && evsAtaque < 252)
                    {
                        evsAtaque += 4;
                        ataqueObjetivo = CalcularEstadistica(NIVEL_EVOLUCION, ivAtaque, evsAtaque, naturaleza.Ataque);
                    }
                    break;

                case Evolution.Hitmonchan:
                    while (defensaObjetivo <= ataqueObjetivo && evsDefensa < 252)
                    {
                        evsDefensa += 4;
                        defensaObjetivo = CalcularEstadistica(NIVEL_EVOLUCION, ivDefensa, evsDefensa, naturaleza.Defensa);
                    }
                    break;

                case Evolution.Hitmontop:
                    int diferencia = ataqueBase - defensaBase;
                    if (diferencia > 0)
                    {
                        while (defensaObjetivo < ataqueObjetivo && evsDefensa < 252)
                        {
                            evsDefensa += 4;
                            defensaObjetivo = CalcularEstadistica(NIVEL_EVOLUCION, ivDefensa, evsDefensa, naturaleza.Defensa);
                        }
                    }
                    else if (diferencia < 0)
                    {
                        while (ataqueObjetivo < defensaObjetivo && evsAtaque < 252)
                        {
                            evsAtaque += 4;
                            ataqueObjetivo = CalcularEstadistica(NIVEL_EVOLUCION, ivAtaque, evsAtaque, naturaleza.Ataque);
                        }
                    }
                    break;
            }

            int proteinas = (int)Math.Ceiling(evsAtaque / 10.0);
            int hierros = (int)Math.Ceiling(evsDefensa / 10.0);

            bool advertencia = false;
            string mensajeAdvertencia = "";

            if (ataqueObjetivo == defensaObjetivo && evolucionDeseada != Evolution.Hitmontop)
            {
                advertencia = true;
                mensajeAdvertencia = $"⚠️ ADVERTENCIA: Con estas vitaminas, Ataque y Defensa quedarán iguales, " +
                                    $"lo que causará evolución a Hitmontop en lugar de {evolucionDeseada}.";
            }

            return new ResultadoCalculo
            {
                AtaqueActual = tyrogue.Ataque,
                DefensaActual = tyrogue.Defensa,
                AtaqueObjetivo = ataqueObjetivo,
                DefensaObjetivo = defensaObjetivo,
                IVAtaque = ivAtaque,
                IVDefensa = ivDefensa,
                ProteinasNecesarias = proteinas,
                HierrosNecesarios = hierros,
                CostoTotal = (proteinas + hierros) * COSTO_VITAMINA,
                TieneAdvertencia = advertencia,
                MensajeAdvertencia = mensajeAdvertencia
            };
        }

        private int CalcularEstadistica(int nivel, int iv, int evs, double naturaleza)
        {
            return (int)Math.Floor(
                (Math.Floor((2 * BASE_TYROGUE + iv + Math.Floor(evs / 4.0)) * nivel / 100.0) + 5) * naturaleza
            );
        }

        private int EstimarIV(int nivel, int statActual, int evs, double naturaleza)
        {
            for (int iv = 31; iv >= 0; iv--)
            {
                int calculado = CalcularEstadistica(nivel, iv, evs, naturaleza);
                if (calculado == statActual)
                    return iv;
            }
            return 15;
        }
    }
}