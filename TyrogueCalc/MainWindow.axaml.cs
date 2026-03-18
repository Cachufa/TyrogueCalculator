using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using System;
using System.Collections.Generic;

namespace TyrogueEvolutionCalculator
{
    public partial class MainWindow : Window
    {
        private Evolution _selectedEvolution = Evolution.None;

        public MainWindow()
        {
            InitializeComponent();
            CargarNaturalezas();
            
            btnHitmonlee.Click += (s, e) => SeleccionarEvolucion(Evolution.Hitmonlee);
            btnHitmonchan.Click += (s, e) => SeleccionarEvolucion(Evolution.Hitmonchan);
            btnHitmontop.Click += (s, e) => SeleccionarEvolucion(Evolution.Hitmontop);
            btnCalcular.Click += BtnCalcular_Click;
        }

        private void CargarNaturalezas()
        {
            var naturalezas = new List<string>
            {
                "Neutral (Sin modificadores)",
                "Lonely (+Atq -Def)",
                "Brave (+Atq -Vel)",
                "Adamant (+Atq -AtEsp)",
                "Naughty (+Atq -DefEsp)",
                "Bold (+Def -Atq)",
                "Relaxed (+Def -Vel)",
                "Impish (+Def -AtEsp)",
                "Lax (+Def -DefEsp)",
                "Modest (+AtEsp -Atq)",
                "Mild (+AtEsp -Def)",
                "Quiet (+AtEsp -Vel)",
                "Rash (+AtEsp -DefEsp)",
                "Calm (+DefEsp -Atq)",
                "Gentle (+DefEsp -Def)",
                "Sassy (+DefEsp -Vel)",
                "Careful (+DefEsp -AtEsp)",
                "Timid (+Vel -Atq)",
                "Hasty (+Vel -Def)",
                "Jolly (+Vel -AtEsp)",
                "Naive (+Vel -DefEsp)"
            };
            cmbNaturaleza.ItemsSource = naturalezas;
            cmbNaturaleza.SelectedIndex = 0;
        }

        private void SeleccionarEvolucion(Evolution evolution)
        {
            _selectedEvolution = evolution;
            ActualizarBotonesEvolucion();
        }

        private void ActualizarBotonesEvolucion()
        {
            btnHitmonlee.Background = _selectedEvolution == Evolution.Hitmonlee ? Brush.Parse("#38BDF8") : Brush.Parse("#334155");
            btnHitmonchan.Background = _selectedEvolution == Evolution.Hitmonchan ? Brush.Parse("#38BDF8") : Brush.Parse("#334155");
            btnHitmontop.Background = _selectedEvolution == Evolution.Hitmontop ? Brush.Parse("#38BDF8") : Brush.Parse("#334155");
        }

        private void BtnCalcular_Click(object? sender, RoutedEventArgs e)
        {
            if (_selectedEvolution == Evolution.None)
            {
                // En Avalonia no hay MessageBox.Show por defecto simple, usaríamos un diálogo o simplemente ignorar/mostrar texto
                return;
            }

            try
            {
                var tyrogue = new TyrogueData
                {
                    Nivel = (int)(numNivel.Value ?? 1),
                    NaturalezaIndex = cmbNaturaleza.SelectedIndex,
                    PS = (int)(numPS.Value ?? 0),
                    Ataque = (int)(numAtaque.Value ?? 0),
                    Defensa = (int)(numDefensa.Value ?? 0),
                    AtaqueEspecial = (int)(numAtEspecial.Value ?? 0),
                    DefensaEspecial = (int)(numDefEspecial.Value ?? 0),
                    Velocidad = (int)(numVelocidad.Value ?? 0)
                };

                var calculator = new TyrogueCalculator();
                var resultado = calculator.CalcularVitaminas(tyrogue, _selectedEvolution);

                MostrarResultados(resultado);
            }
            catch (Exception)
            {
                // Manejar error
            }
        }

        private void MostrarResultados(ResultadoCalculo resultado)
        {
            lblAtqActual.Text = resultado.AtaqueActual.ToString();
            lblDefActual.Text = resultado.DefensaActual.ToString();
            lblAtqFinal.Text = resultado.AtaqueObjetivo.ToString();
            lblDefFinal.Text = resultado.DefensaObjetivo.ToString();
            lblProteinas.Text = resultado.ProteinasNecesarias.ToString();
            lblHierros.Text = resultado.HierrosNecesarios.ToString();
            lblCosto.Text = $"{resultado.CostoTotal:N0}₽";
            
            lblIVAtaque.Text = resultado.IVAtaque.ToString();
            lblIVDefensa.Text = resultado.IVDefensa.ToString();

            if (resultado.TieneAdvertencia)
            {
                lblAdvertencia.Text = resultado.MensajeAdvertencia;
                lblAdvertencia.IsVisible = true;
            }
            else
            {
                lblAdvertencia.IsVisible = false;
            }

            borderResultados.IsVisible = true;
        }
    }
}
