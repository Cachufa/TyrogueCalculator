namespace TyrogueEvolutionCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.numVelocidad = new System.Windows.Forms.NumericUpDown();
            this.lblDefEspecial = new System.Windows.Forms.Label();
            this.numDefEspecial = new System.Windows.Forms.NumericUpDown();
            this.lblAtEspecial = new System.Windows.Forms.Label();
            this.numAtEspecial = new System.Windows.Forms.NumericUpDown();
            this.lblDefensa = new System.Windows.Forms.Label();
            this.numDefensa = new System.Windows.Forms.NumericUpDown();
            this.lblAtaque = new System.Windows.Forms.Label();
            this.numAtaque = new System.Windows.Forms.NumericUpDown();
            this.lblPS = new System.Windows.Forms.Label();
            this.numPS = new System.Windows.Forms.NumericUpDown();
            this.lblNaturaleza = new System.Windows.Forms.Label();
            this.cmbNaturaleza = new System.Windows.Forms.ComboBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.numNivel = new System.Windows.Forms.NumericUpDown();
            this.groupBoxEvolucion = new System.Windows.Forms.GroupBox();
            this.btnHitmontop = new System.Windows.Forms.Button();
            this.btnHitmonchan = new System.Windows.Forms.Button();
            this.btnHitmonlee = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panelResultados = new System.Windows.Forms.Panel();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.lblIVsLabel = new System.Windows.Forms.Label();
            this.lblResultIVAtaque = new System.Windows.Forms.Label();
            this.lblResultIVDefensa = new System.Windows.Forms.Label();
            this.lblCostoLabel = new System.Windows.Forms.Label();
            this.lblResultCosto = new System.Windows.Forms.Label();
            this.lblHierrosLabel = new System.Windows.Forms.Label();
            this.lblResultHierros = new System.Windows.Forms.Label();
            this.lblProteinasLabel = new System.Windows.Forms.Label();
            this.lblResultProteinas = new System.Windows.Forms.Label();
            this.lblDefObjetivoLabel = new System.Windows.Forms.Label();
            this.lblResultDefensaObjetivo = new System.Windows.Forms.Label();
            this.lblAtqObjetivoLabel = new System.Windows.Forms.Label();
            this.lblResultAtaqueObjetivo = new System.Windows.Forms.Label();
            this.lblDefActualLabel = new System.Windows.Forms.Label();
            this.lblResultDefensaActual = new System.Windows.Forms.Label();
            this.lblAtqActualLabel = new System.Windows.Forms.Label();
            this.lblResultAtaqueActual = new System.Windows.Forms.Label();
            this.lblResultTitle = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.numVelocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefEspecial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAtEspecial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefensa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAtaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).BeginInit();
            this.groupBoxDatos.SuspendLayout();
            this.groupBoxEvolucion.SuspendLayout();
            this.panelResultados.SuspendLayout();
            this.SuspendLayout();

            // groupBoxDatos
            this.groupBoxDatos.Controls.Add(this.lblVelocidad);
            this.groupBoxDatos.Controls.Add(this.numVelocidad);
            this.groupBoxDatos.Controls.Add(this.lblDefEspecial);
            this.groupBoxDatos.Controls.Add(this.numDefEspecial);
            this.groupBoxDatos.Controls.Add(this.lblAtEspecial);
            this.groupBoxDatos.Controls.Add(this.numAtEspecial);
            this.groupBoxDatos.Controls.Add(this.lblDefensa);
            this.groupBoxDatos.Controls.Add(this.numDefensa);
            this.groupBoxDatos.Controls.Add(this.lblAtaque);
            this.groupBoxDatos.Controls.Add(this.numAtaque);
            this.groupBoxDatos.Controls.Add(this.lblPS);
            this.groupBoxDatos.Controls.Add(this.numPS);
            this.groupBoxDatos.Controls.Add(this.lblNaturaleza);
            this.groupBoxDatos.Controls.Add(this.cmbNaturaleza);
            this.groupBoxDatos.Controls.Add(this.lblNivel);
            this.groupBoxDatos.Controls.Add(this.numNivel);
            this.groupBoxDatos.ForeColor = Color.FromArgb(56, 189, 248);
            this.groupBoxDatos.Location = new Point(20, 20);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new Size(360, 400);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "📊 Datos del Tyrogue";

            // lblNivel
            this.lblNivel.AutoSize = true;
            this.lblNivel.ForeColor = Color.FromArgb(203, 213, 225);
            this.lblNivel.Location = new Point(20, 35);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new Size(75, 15);
            this.lblNivel.TabIndex = 0;
            this.lblNivel.Text = "Nivel Actual:";

            // numNivel
            this.numNivel.BackColor = Color.FromArgb(51, 65, 85);
            this.numNivel.ForeColor = Color.FromArgb(241, 245, 249);
            this.numNivel.Location = new Point(140, 33);
            this.numNivel.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numNivel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numNivel.Name = "numNivel";
            this.numNivel.Size = new Size(180, 23);
            this.numNivel.TabIndex = 1;
            this.numNivel.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // lblNaturaleza
            this.lblNaturaleza.AutoSize = true;
            this.lblNaturaleza.ForeColor = Color.FromArgb(203, 213, 225);
            this.lblNaturaleza.Location = new Point(20, 70);
            this.lblNaturaleza.Name = "lblNaturaleza";
            this.lblNaturaleza.Size = new Size(70, 15);
            this.lblNaturaleza.TabIndex = 2;
            this.lblNaturaleza.Text = "Naturaleza:";

            // cmbNaturaleza
            this.cmbNaturaleza.BackColor = Color.FromArgb(51, 65, 85);
            this.cmbNaturaleza.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbNaturaleza.ForeColor = Color.FromArgb(241, 245, 249);
            this.cmbNaturaleza.FormattingEnabled = true;
            this.cmbNaturaleza.Location = new Point(20, 90);
            this.cmbNaturaleza.Name = "cmbNaturaleza";
            this.cmbNaturaleza.Size = new Size(300, 23);
            this.cmbNaturaleza.TabIndex = 3;

            // lblPS
            this.lblPS.AutoSize = true;
            this.lblPS.ForeColor = Color.FromArgb(203, 213, 225);
            this.lblPS.Location = new Point(20, 135);
            this.lblPS.Name = "lblPS";
            this.lblPS.Size = new Size(60, 15);
            this.lblPS.TabIndex = 4;
            this.lblPS.Text = "PS Actual:";

            // numPS
            this.numPS.BackColor = Color.FromArgb(51, 65, 85);
            this.numPS.ForeColor = Color.FromArgb(241, 245, 249);
            this.numPS.Location = new Point(140, 133);
            this.numPS.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.numPS.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numPS.Name = "numPS";
            this.numPS.Size = new Size(180, 23);
            this.numPS.TabIndex = 5;
            this.numPS.Value = new decimal(new int[] { 11, 0, 0, 0 });

            // lblAtaque
            this.lblAtaque.AutoSize = true;
            this.lblAtaque.ForeColor = Color.FromArgb(203, 213, 225);
            this.lblAtaque.Location = new Point(20, 170);
            this.lblAtaque.Name = "lblAtaque";
            this.lblAtaque.Size = new Size(85, 15);
            this.lblAtaque.TabIndex = 6;
            this.lblAtaque.Text = "Ataque Actual:";

            // numAtaque
            this.numAtaque.BackColor = Color.FromArgb(51, 65, 85);
            this.numAtaque.ForeColor = Color.FromArgb(241, 245, 249);
            this.numAtaque.Location = new Point(140, 168);
            this.numAtaque.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.numAtaque.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numAtaque.Name = "numAtaque";
            this.numAtaque.Size = new Size(180, 23);
            this.numAtaque.TabIndex = 7;
            this.numAtaque.Value = new decimal(new int[] { 6, 0, 0, 0 });

            // lblDefensa
            this.lblDefensa.AutoSize = true;
            this.lblDefensa.ForeColor = Color.FromArgb(203, 213, 225);
            this.lblDefensa.Location = new Point(20, 205);
            this.lblDefensa.Name = "lblDefensa";
            this.lblDefensa.Size = new Size(90, 15);
            this.lblDefensa.TabIndex = 8;
            this.lblDefensa.Text = "Defensa Actual:";

            // numDefensa
            this.numDefensa.BackColor = Color.FromArgb(51, 65, 85);
            this.numDefensa.ForeColor = Color.FromArgb(241, 245, 249);
            this.numDefensa.Location = new Point(140, 203);
            this.numDefensa.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.numDefensa.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numDefensa.Name = "numDefensa";
            this.numDefensa.Size = new Size(180, 23);
            this.numDefensa.TabIndex = 9;
            this.numDefensa.Value = new decimal(new int[] { 6, 0, 0, 0 });

            // lblAtEspecial
            this.lblAtEspecial.AutoSize = true;
            this.lblAtEspecial.ForeColor = Color.FromArgb(203, 213, 225);
            this.lblAtEspecial.Location = new Point(20, 240);
            this.lblAtEspecial.Name = "lblAtEspecial";
            this.lblAtEspecial.Size = new Size(110, 15);
            this.lblAtEspecial.TabIndex = 10;
            this.lblAtEspecial.Text = "At. Especial Actual:";

            // numAtEspecial
            this.numAtEspecial.BackColor = Color.FromArgb(51, 65, 85);
            this.numAtEspecial.ForeColor = Color.FromArgb(241, 245, 249);
            this.numAtEspecial.Location = new Point(140, 238);
            this.numAtEspecial.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.numAtEspecial.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numAtEspecial.Name = "numAtEspecial";
            this.numAtEspecial.Size = new Size(180, 23);
            this.numAtEspecial.TabIndex = 11;
            this.numAtEspecial.Value = new decimal(new int[] { 6, 0, 0, 0 });

            // lblDefEspecial
            this.lblDefEspecial.AutoSize = true;
            this.lblDefEspecial.ForeColor = Color.FromArgb(203, 213, 225);
            this.lblDefEspecial.Location = new Point(20, 275);
            this.lblDefEspecial.Name = "lblDefEspecial";
            this.lblDefEspecial.Size = new Size(120, 15);
            this.lblDefEspecial.TabIndex = 12;
            this.lblDefEspecial.Text = "Def. Especial Actual:";

            // numDefEspecial
            this.numDefEspecial.BackColor = Color.FromArgb(51, 65, 85);
            this.numDefEspecial.ForeColor = Color.FromArgb(241, 245, 249);
            this.numDefEspecial.Location = new Point(140, 273);
            this.numDefEspecial.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.numDefEspecial.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numDefEspecial.Name = "numDefEspecial";
            this.numDefEspecial.Size = new Size(180, 23);
            this.numDefEspecial.TabIndex = 13;
            this.numDefEspecial.Value = new decimal(new int[] { 6, 0, 0, 0 });

            // lblVelocidad
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.ForeColor = Color.FromArgb(203, 213, 225);
            this.lblVelocidad.Location = new Point(20, 310);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new Size(100, 15);
            this.lblVelocidad.TabIndex = 14;
            this.lblVelocidad.Text = "Velocidad Actual:";

            // numVelocidad
            this.numVelocidad.BackColor = Color.FromArgb(51, 65, 85);
            this.numVelocidad.ForeColor = Color.FromArgb(241, 245, 249);
            this.numVelocidad.Location = new Point(140, 308);
            this.numVelocidad.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.numVelocidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numVelocidad.Name = "numVelocidad";
            this.numVelocidad.Size = new Size(180, 23);
            this.numVelocidad.TabIndex = 15;
            this.numVelocidad.Value = new decimal(new int[] { 6, 0, 0, 0 });

            // groupBoxEvolucion
            this.groupBoxEvolucion.Controls.Add(this.btnHitmontop);
            this.groupBoxEvolucion.Controls.Add(this.btnHitmonchan);
            this.groupBoxEvolucion.Controls.Add(this.btnHitmonlee);
            this.groupBoxEvolucion.ForeColor = Color.FromArgb(56, 189, 248);
            this.groupBoxEvolucion.Location = new Point(400, 20);
            this.groupBoxEvolucion.Name = "groupBoxEvolucion";
            this.groupBoxEvolucion.Size = new Size(360, 200);
            this.groupBoxEvolucion.TabIndex = 1;
            this.groupBoxEvolucion.TabStop = false;
            this.groupBoxEvolucion.Text = "🎯 Evolución Deseada";

            // btnHitmonlee
            this.btnHitmonlee.BackColor = Color.FromArgb(51, 65, 85);
            this.btnHitmonlee.FlatStyle = FlatStyle.Flat;
            this.btnHitmonlee.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnHitmonlee.ForeColor = Color.FromArgb(241, 245, 249);
            this.btnHitmonlee.Location = new Point(20, 40);
            this.btnHitmonlee.Name = "btnHitmonlee";
            this.btnHitmonlee.Size = new Size(100, 120);
            this.btnHitmonlee.TabIndex = 0;
            this.btnHitmonlee.Text = "Hitmonlee\r\n\r\nAtaque > Defensa";
            this.btnHitmonlee.UseVisualStyleBackColor = false;
            this.btnHitmonlee.Click += new EventHandler(this.btnHitmonlee_Click);

            // btnHitmonchan
            this.btnHitmonchan.BackColor = Color.FromArgb(51, 65, 85);
            this.btnHitmonchan.FlatStyle = FlatStyle.Flat;
            this.btnHitmonchan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnHitmonchan.ForeColor = Color.FromArgb(241, 245, 249);
            this.btnHitmonchan.Location = new Point(130, 40);
            this.btnHitmonchan.Name = "btnHitmonchan";
            this.btnHitmonchan.Size = new Size(100, 120);
            this.btnHitmonchan.TabIndex = 1;
            this.btnHitmonchan.Text = "Hitmonchan\r\n\r\nDefensa > Ataque";
            this.btnHitmonchan.UseVisualStyleBackColor = false;
            this.btnHitmonchan.Click += new EventHandler(this.btnHitmonchan_Click);

            // btnHitmontop
            this.btnHitmontop.BackColor = Color.FromArgb(51, 65, 85);
            this.btnHitmontop.FlatStyle = FlatStyle.Flat;
            this.btnHitmontop.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnHitmontop.ForeColor = Color.FromArgb(241, 245, 249);
            this.btnHitmontop.Location = new Point(240, 40);
            this.btnHitmontop.Name = "btnHitmontop";
            this.btnHitmontop.Size = new Size(100, 120);
            this.btnHitmontop.TabIndex = 2;
            this.btnHitmontop.Text = "Hitmontop\r\n\r\nAtaque = Defensa";
            this.btnHitmontop.UseVisualStyleBackColor = false;
            this.btnHitmontop.Click += new EventHandler(this.btnHitmontop_Click);

            // btnCalcular
            this.btnCalcular.BackColor = Color.FromArgb(56, 189, 248);
            this.btnCalcular.FlatStyle = FlatStyle.Flat;
            this.btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnCalcular.ForeColor = Color.FromArgb(15, 23, 42);
            this.btnCalcular.Location = new Point(400, 240);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new Size(360, 50);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "⚡ Calcular Vitaminas";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new EventHandler(this.btnCalcular_Click);

            // panelResultados
            this.panelResultados.BackColor = Color.FromArgb(30, 41, 59);
            this.panelResultados.Controls.Add(this.lblAdvertencia);
            this.panelResultados.Controls.Add(this.lblIVsLabel);
            this.panelResultados.Controls.Add(this.lblResultIVAtaque);
            this.panelResultados.Controls.Add(this.lblResultIVDefensa);
            this.panelResultados.Controls.Add(this.lblCostoLabel);
            this.panelResultados.Controls.Add(this.lblResultCosto);
            this.panelResultados.Controls.Add(this.lblHierrosLabel);
            this.panelResultados.Controls.Add(this.lblResultHierros);
            this.panelResultados.Controls.Add(this.lblProteinasLabel);
            this.panelResultados.Controls.Add(this.lblResultProteinas);
            this.panelResultados.Controls.Add(this.lblDefObjetivoLabel);
            this.panelResultados.Controls.Add(this.lblResultDefensaObjetivo);
            this.panelResultados.Controls.Add(this.lblAtqObjetivoLabel);
            this.panelResultados.Controls.Add(this.lblResultAtaqueObjetivo);
            this.panelResultados.Controls.Add(this.lblDefActualLabel);
            this.panelResultados.Controls.Add(this.lblResultDefensaActual);
            this.panelResultados.Controls.Add(this.lblAtqActualLabel);
            this.panelResultados.Controls.Add(this.lblResultAtaqueActual);
            this.panelResultados.Controls.Add(this.lblResultTitle);
            this.panelResultados.Location = new Point(20, 440);
            this.panelResultados.Name = "panelResultados";
            this.panelResultados.Size = new Size(740, 280);
            this.panelResultados.TabIndex = 3;
            this.panelResultados.Visible = false;

            // lblResultTitle
            this.lblResultTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblResultTitle.ForeColor = Color.FromArgb(16, 185, 129);
            this.lblResultTitle.Location = new Point(0, 15);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new Size(740, 30);
            this.lblResultTitle.TabIndex = 0;
            this.lblResultTitle.Text = "✅ Resultado del Cálculo";
            this.lblResultTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblAtqActualLabel
            this.lblAtqActualLabel.AutoSize = true;
            this.lblAtqActualLabel.Font = new Font("Segoe UI", 10F);
            this.lblAtqActualLabel.ForeColor = Color.FromArgb(203, 213, 225);
            this.lblAtqActualLabel.Location = new Point(30, 60);
            this.lblAtqActualLabel.Name = "lblAtqActualLabel";
            this.lblAtqActualLabel.Size = new Size(100, 19);
            this.lblAtqActualLabel.TabIndex = 1;
            this.lblAtqActualLabel.Text = "Ataque Actual:";

            // lblResultAtaqueActual
            this.lblResultAtaqueActual.AutoSize = true;
            this.lblResultAtaqueActual.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblResultAtaqueActual.ForeColor = Color.FromArgb(56, 189, 248);
            this.lblResultAtaqueActual.Location = new Point(200, 60);
            this.lblResultAtaqueActual.Name = "lblResultAtaqueActual";
            this.lblResultAtaqueActual.Size = new Size(17, 19);
            this.lblResultAtaqueActual.TabIndex = 2;
            this.lblResultAtaqueActual.Text = "0";

            // lblDefActualLabel
            this.lblDefActualLabel.AutoSize = true;
            this.lblDefActualLabel.Font = new Font("Segoe UI", 10F);
            this.lblDefActualLabel.ForeColor = Color.FromArgb(203, 213, 225);
            this.lblDefActualLabel.Location = new Point(30, 90);
            this.lblDefActualLabel.Name = "lblDefActualLabel";
            this.lblDefActualLabel.Size = new Size(110, 19);
            this.lblDefActualLabel.TabIndex = 3;
            this.lblDefActualLabel.Text = "Defensa Actual:";

            // lblResultDefensaActual
            this.lblResultDefensaActual.AutoSize = true;
            this.lblResultDefensaActual.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblResultDefensaActual.ForeColor = Color.FromArgb(56, 189, 248);
            this.lblResultDefensaActual.Location = new Point(200, 90);
            this.lblResultDefensaActual.Name = "lblResultDefensaActual";
            this.lblResultDefensaActual.Size = new Size(17, 19);
            this.lblResultDefensaActual.TabIndex = 4;
            this.lblResultDefensaActual.Text = "0";

            // lblAtqObjetivoLabel
            this.lblAtqObjetivoLabel.AutoSize = true;
            this.lblAtqObjetivoLabel.Font = new Font("Segoe UI", 10F);
            this.lblAtqObjetivoLabel.ForeColor = Color.FromArgb(203, 213, 225);
            this.lblAtqObjetivoLabel.Location = new Point(380, 60);
            this.lblAtqObjetivoLabel.Name = "lblAtqObjetivoLabel";
            this.lblAtqObjetivoLabel.Size = new Size(120, 19);
            this.lblAtqObjetivoLabel.TabIndex = 5;
            this.lblAtqObjetivoLabel.Text = "Ataque Objetivo:";

            // lblResultAtaqueObjetivo
            this.lblResultAtaqueObjetivo.AutoSize = true;
            this.lblResultAtaqueObjetivo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblResultAtaqueObjetivo.ForeColor = Color.FromArgb(56, 189, 248);
            this.lblResultAtaqueObjetivo.Location = new Point(550, 60);
            this.lblResultAtaqueObjetivo.Name = "lblResultAtaqueObjetivo";
            this.lblResultAtaqueObjetivo.Size = new Size(17, 19);
            this.lblResultAtaqueObjetivo.TabIndex = 6;
            this.lblResultAtaqueObjetivo.Text = "0";

            // lblDefObjetivoLabel
            this.lblDefObjetivoLabel.AutoSize = true;
            this.lblDefObjetivoLabel.Font = new Font("Segoe UI", 10F);
            this.lblDefObjetivoLabel.ForeColor = Color.FromArgb(203, 213, 225);
            this.lblDefObjetivoLabel.Location = new Point(380, 90);
            this.lblDefObjetivoLabel.Name = "lblDefObjetivoLabel";
            this.lblDefObjetivoLabel.Size = new Size(130, 19);
            this.lblDefObjetivoLabel.TabIndex = 7;
            this.lblDefObjetivoLabel.Text = "Defensa Objetivo:";

            // lblResultDefensaObjetivo
            this.lblResultDefensaObjetivo.AutoSize = true;
            this.lblResultDefensaObjetivo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblResultDefensaObjetivo.ForeColor = Color.FromArgb(56, 189, 248);
            this.lblResultDefensaObjetivo.Location = new Point(550, 90);
            this.lblResultDefensaObjetivo.Name = "lblResultDefensaObjetivo";
            this.lblResultDefensaObjetivo.Size = new Size(17, 19);
            this.lblResultDefensaObjetivo.TabIndex = 8;
            this.lblResultDefensaObjetivo.Text = "0";

            // lblProteinasLabel
            this.lblProteinasLabel.AutoSize = true;
            this.lblProteinasLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblProteinasLabel.ForeColor = Color.FromArgb(241, 245, 249);
            this.lblProteinasLabel.Location = new Point(30, 140);
            this.lblProteinasLabel.Name = "lblProteinasLabel";
            this.lblProteinasLabel.Size = new Size(170, 20);
            this.lblProteinasLabel.TabIndex = 9;
            this.lblProteinasLabel.Text = "🥊 Proteínas (Ataque):";

            // lblResultProteinas
            this.lblResultProteinas.AutoSize = true;
            this.lblResultProteinas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblResultProteinas.ForeColor = Color.FromArgb(16, 185, 129);
            this.lblResultProteinas.Location = new Point(230, 140);
            this.lblResultProteinas.Name = "lblResultProteinas";
            this.lblResultProteinas.Size = new Size(18, 20);
            this.lblResultProteinas.TabIndex = 10;
            this.lblResultProteinas.Text = "0";

            // lblHierrosLabel
            this.lblHierrosLabel.AutoSize = true;
            this.lblHierrosLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblHierrosLabel.ForeColor = Color.FromArgb(241, 245, 249);
            this.lblHierrosLabel.Location = new Point(380, 140);
            this.lblHierrosLabel.Name = "lblHierrosLabel";
            this.lblHierrosLabel.Size = new Size(160, 20);
            this.lblHierrosLabel.TabIndex = 11;
            this.lblHierrosLabel.Text = "🛡️ Hierros (Defensa):";

            // lblResultHierros
            this.lblResultHierros.AutoSize = true;
            this.lblResultHierros.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblResultHierros.ForeColor = Color.FromArgb(16, 185, 129);
            this.lblResultHierros.Location = new Point(580, 140);
            this.lblResultHierros.Name = "lblResultHierros";
            this.lblResultHierros.Size = new Size(18, 20);
            this.lblResultHierros.TabIndex = 12;
            this.lblResultHierros.Text = "0";

            // lblIVsLabel
            this.lblIVsLabel.AutoSize = true;
            this.lblIVsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblIVsLabel.ForeColor = Color.FromArgb(203, 213, 225);
            this.lblIVsLabel.Location = new Point(30, 120);
            this.lblIVsLabel.Name = "lblIVsLabel";
            this.lblIVsLabel.Size = new Size(100, 19);
            this.lblIVsLabel.TabIndex = 16;
            this.lblIVsLabel.Text = "📊 IVs Calculados:";

            // lblResultIVAtaque
            this.lblResultIVAtaque.AutoSize = true;
            this.lblResultIVAtaque.Font = new Font("Segoe UI", 10F);
            this.lblResultIVAtaque.ForeColor = Color.FromArgb(255, 215, 0);
            this.lblResultIVAtaque.Location = new Point(200, 120);
            this.lblResultIVAtaque.Name = "lblResultIVAtaque";
            this.lblResultIVAtaque.Size = new Size(100, 19);
            this.lblResultIVAtaque.TabIndex = 17;
            this.lblResultIVAtaque.Text = "Ataque: 0";

            // lblResultIVDefensa
            this.lblResultIVDefensa.AutoSize = true;
            this.lblResultIVDefensa.Font = new Font("Segoe UI", 10F);
            this.lblResultIVDefensa.ForeColor = Color.FromArgb(255, 215, 0);
            this.lblResultIVDefensa.Location = new Point(380, 120);
            this.lblResultIVDefensa.Name = "lblResultIVDefensa";
            this.lblResultIVDefensa.Size = new Size(100, 19);
            this.lblResultIVDefensa.TabIndex = 18;
            this.lblResultIVDefensa.Text = "Defensa: 0";

            // lblCostoLabel
            this.lblCostoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblCostoLabel.ForeColor = Color.FromArgb(241, 245, 249);
            this.lblCostoLabel.Location = new Point(200, 185);
            this.lblCostoLabel.Name = "lblCostoLabel";
            this.lblCostoLabel.Size = new Size(150, 25);
            this.lblCostoLabel.TabIndex = 13;
            this.lblCostoLabel.Text = "💰 Coste Total:";
            this.lblCostoLabel.TextAlign = ContentAlignment.MiddleRight;

            // lblResultCosto
            this.lblResultCosto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblResultCosto.ForeColor = Color.FromArgb(56, 189, 248);
            this.lblResultCosto.Location = new Point(360, 185);
            this.lblResultCosto.Name = "lblResultCosto";
            this.lblResultCosto.Size = new Size(180, 25);
            this.lblResultCosto.TabIndex = 14;
            this.lblResultCosto.Text = "0₽";
            this.lblResultCosto.TextAlign = ContentAlignment.MiddleLeft;

            // lblAdvertencia
            this.lblAdvertencia.BackColor = Color.FromArgb(185, 28, 28);
            this.lblAdvertencia.Font = new Font("Segoe UI", 9F);
            this.lblAdvertencia.ForeColor = Color.White;
            this.lblAdvertencia.Location = new Point(20, 230);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Padding = new Padding(10);
            this.lblAdvertencia.Size = new Size(700, 40);
            this.lblAdvertencia.TabIndex = 15;
            this.lblAdvertencia.Text = "Advertencia";
            this.lblAdvertencia.TextAlign = ContentAlignment.MiddleCenter;
            this.lblAdvertencia.Visible = false;

            // Form1
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(15, 23, 42);
            this.ClientSize = new Size(800, 750);
            this.Controls.Add(this.panelResultados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBoxEvolucion);
            this.Controls.Add(this.groupBoxDatos);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "⚔️ Calculadora Evolución Tyrogue - BDSP";
            ((System.ComponentModel.ISupportInitialize)(this.numVelocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefEspecial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAtEspecial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefensa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAtaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).EndInit();
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.groupBoxEvolucion.ResumeLayout(false);
            this.panelResultados.ResumeLayout(false);
            this.panelResultados.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.NumericUpDown numVelocidad;
        private System.Windows.Forms.Label lblDefEspecial;
        private System.Windows.Forms.NumericUpDown numDefEspecial;
        private System.Windows.Forms.Label lblAtEspecial;
        private System.Windows.Forms.NumericUpDown numAtEspecial;
        private System.Windows.Forms.Label lblDefensa;
        private System.Windows.Forms.NumericUpDown numDefensa;
        private System.Windows.Forms.Label lblAtaque;
        private System.Windows.Forms.NumericUpDown numAtaque;
        private System.Windows.Forms.Label lblPS;
        private System.Windows.Forms.NumericUpDown numPS;
        private System.Windows.Forms.Label lblNaturaleza;
        private System.Windows.Forms.ComboBox cmbNaturaleza;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.NumericUpDown numNivel;
        private System.Windows.Forms.GroupBox groupBoxEvolucion;
        private System.Windows.Forms.Button btnHitmontop;
        private System.Windows.Forms.Button btnHitmonchan;
        private System.Windows.Forms.Button btnHitmonlee;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panelResultados;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.Label lblIVsLabel;
        private System.Windows.Forms.Label lblResultIVAtaque;
        private System.Windows.Forms.Label lblResultIVDefensa;
        private System.Windows.Forms.Label lblCostoLabel;
        private System.Windows.Forms.Label lblResultCosto;
        private System.Windows.Forms.Label lblHierrosLabel;
        private System.Windows.Forms.Label lblResultHierros;
        private System.Windows.Forms.Label lblProteinasLabel;
        private System.Windows.Forms.Label lblResultProteinas;
        private System.Windows.Forms.Label lblDefObjetivoLabel;
        private System.Windows.Forms.Label lblResultDefensaObjetivo;
        private System.Windows.Forms.Label lblAtqObjetivoLabel;
        private System.Windows.Forms.Label lblResultAtaqueObjetivo;
        private System.Windows.Forms.Label lblDefActualLabel;
        private System.Windows.Forms.Label lblResultDefensaActual;
        private System.Windows.Forms.Label lblAtqActualLabel;
        private System.Windows.Forms.Label lblResultAtaqueActual;
        private System.Windows.Forms.Label lblResultTitle;
    }
}