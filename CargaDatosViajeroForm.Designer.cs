namespace grupo3.prototipos.CAI
{
    partial class CargaDatosViajeroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCantAdultos = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblCantMenores = new Label();
            textBox3 = new TextBox();
            lblCantInfantes = new Label();
            grpCargaDatos = new GroupBox();
            btnAñadirDatosViajIt = new Button();
            grpCargaDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblCantAdultos
            // 
            lblCantAdultos.AutoSize = true;
            lblCantAdultos.Location = new Point(101, 68);
            lblCantAdultos.Name = "lblCantAdultos";
            lblCantAdultos.Size = new Size(100, 15);
            lblCantAdultos.TabIndex = 0;
            lblCantAdultos.Text = "Cantidad adultos:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // lblCantMenores
            // 
            lblCantMenores.AutoSize = true;
            lblCantMenores.Location = new Point(101, 126);
            lblCantMenores.Name = "lblCantMenores";
            lblCantMenores.Size = new Size(107, 15);
            lblCantMenores.TabIndex = 2;
            lblCantMenores.Text = "Cantidad menores:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(101, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // lblCantInfantes
            // 
            lblCantInfantes.AutoSize = true;
            lblCantInfantes.Location = new Point(101, 179);
            lblCantInfantes.Name = "lblCantInfantes";
            lblCantInfantes.Size = new Size(103, 15);
            lblCantInfantes.TabIndex = 4;
            lblCantInfantes.Text = "Cantidad infantes:";
            // 
            // grpCargaDatos
            // 
            grpCargaDatos.Controls.Add(btnAñadirDatosViajIt);
            grpCargaDatos.Controls.Add(lblCantAdultos);
            grpCargaDatos.Controls.Add(textBox2);
            grpCargaDatos.Controls.Add(lblCantInfantes);
            grpCargaDatos.Controls.Add(textBox3);
            grpCargaDatos.Controls.Add(textBox1);
            grpCargaDatos.Controls.Add(lblCantMenores);
            grpCargaDatos.Location = new Point(235, 58);
            grpCargaDatos.Name = "grpCargaDatos";
            grpCargaDatos.Size = new Size(329, 318);
            grpCargaDatos.TabIndex = 6;
            grpCargaDatos.TabStop = false;
            grpCargaDatos.Text = "Cargue datos de los viajeros:";
            // 
            // btnAñadirDatosViajIt
            // 
            btnAñadirDatosViajIt.Location = new Point(101, 241);
            btnAñadirDatosViajIt.Name = "btnAñadirDatosViajIt";
            btnAñadirDatosViajIt.Size = new Size(126, 33);
            btnAñadirDatosViajIt.TabIndex = 6;
            btnAñadirDatosViajIt.Text = "Añadir al itinerario";
            btnAñadirDatosViajIt.UseVisualStyleBackColor = true;
            // 
            // CargaDatosViajeroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpCargaDatos);
            Name = "CargaDatosViajeroForm";
            Text = "Carga de datos viajero";
            grpCargaDatos.ResumeLayout(false);
            grpCargaDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCantAdultos;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblCantMenores;
        private TextBox textBox3;
        private Label lblCantInfantes;
        private GroupBox grpCargaDatos;
        private Button btnAñadirDatosViajIt;
    }
}