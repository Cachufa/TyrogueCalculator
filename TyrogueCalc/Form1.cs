using System;
using System.Windows.Forms;

namespace TyrogueEvolutionCalculator
{
    public partial class Form1 : Form
    {
        private Evolution _selectedEvolution = Evolution.None;

        public Form1()
        {
            InitializeComponent();
            CargarNaturalezas();
        }

        private void CargarNaturalezas()
        {
            cmbNaturaleza.Items.AddRange(new object[]
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
            });
            cmbNaturaleza.SelectedIndex = -1;
        }

        private void btnHitmonlee_Click(object sender, EventArgs e)
        {
            _selectedEvolution = Evolution.Hitmonlee;
            ActualizarBotonesEvolucion();
        }

        private void btnHitmonchan_Click(object sender, EventArgs e)
        {
            _selectedEvolution = Evolution.Hitmonchan;
            ActualizarBotonesEvolucion();
        }

        private void btnHitmontop_Click(object sender, EventArgs e)
        {
            _selectedEvolution = Evolution.Hitmontop;
            ActualizarBotonesEvolucion();
        }

        private void ActualizarBotonesEvolucion()
        {
            btnHitmonlee.BackColor = _selectedEvolution == Evolution.Hitmonlee 
                ? Color.FromArgb(56, 189, 248) 
                : Color.FromArgb(51, 65, 85);
            
            btnHitmonchan.BackColor = _selectedEvolution == Evolution.Hitmonchan 
                ? Color.FromArgb(56, 189, 248) 
                : Color.FromArgb(51, 65, 85);
            
            btnHitmontop.BackColor = _selectedEvolution == Evolution.Hitmontop 
                ? Color.FromArgb(56, 189, 248) 
                : Color.FromArgb(51, 65, 85);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (_selectedEvolution == Evolution.None)
            {
                MessageBox.Show("Por favor, selecciona una evolución deseada.", 
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var tyrogue = new TyrogueData
                {
                    Nivel = (int)numNivel.Value,
                    NaturalezaIndex = cmbNaturaleza.SelectedIndex,
                    PS = (int)numPS.Value,
                    Ataque = (int)numAtaque.Value,
                    Defensa = (int)numDefensa.Value,
                    AtaqueEspecial = (int)numAtEspecial.Value,
                    DefensaEspecial = (int)numDefEspecial.Value,
                    Velocidad = (int)numVelocidad.Value
                };

                var calculator = new TyrogueCalculator();
                var resultado = calculator.CalcularVitaminas(tyrogue, _selectedEvolution);

                MostrarResultados(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarResultados(ResultadoCalculo resultado)
        {
            lblResultAtaqueActual.Text = resultado.AtaqueActual.ToString();
            lblResultDefensaActual.Text = resultado.DefensaActual.ToString();
            lblResultAtaqueObjetivo.Text = resultado.AtaqueObjetivo.ToString();
            lblResultDefensaObjetivo.Text = resultado.DefensaObjetivo.ToString();
            lblResultProteinas.Text = resultado.ProteinasNecesarias.ToString();
            lblResultHierros.Text = resultado.HierrosNecesarios.ToString();
            lblResultCosto.Text = $"{resultado.CostoTotal:N0}₽";
            
            // Mostrar IVs calculados
            lblResultIVAtaque.Text = resultado.IVAtaque.ToString();
            lblResultIVDefensa.Text = resultado.IVDefensa.ToString();

            if (resultado.TieneAdvertencia)
            {
                lblAdvertencia.Text = resultado.MensajeAdvertencia;
                lblAdvertencia.Visible = true;
            }
            else
            {
                lblAdvertencia.Visible = false;
            }

            panelResultados.Visible = true;
        }
    }
}