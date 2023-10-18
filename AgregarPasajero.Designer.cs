namespace grupo3.prototipos.CAI
{
    partial class AgregarPasajero
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            DNIPersonaTextBox = new TextBox();
            TipoDePasajeroGroupBox = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            CancelarAgregarPersonaButton = new Button();
            AgregarPersonaButton = new Button();
            ApellidoPersonaTextBox = new TextBox();
            label2 = new Label();
            NombrePersonaTextBox = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            TipoDePasajeroGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(DNIPersonaTextBox);
            groupBox1.Controls.Add(TipoDePasajeroGroupBox);
            groupBox1.Controls.Add(CancelarAgregarPersonaButton);
            groupBox1.Controls.Add(AgregarPersonaButton);
            groupBox1.Controls.Add(ApellidoPersonaTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(NombrePersonaTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(350, 390);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 163);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 48;
            label3.Text = "DNI:";
            // 
            // DNIPersonaTextBox
            // 
            DNIPersonaTextBox.Location = new Point(25, 191);
            DNIPersonaTextBox.Margin = new Padding(3, 4, 3, 4);
            DNIPersonaTextBox.Name = "DNIPersonaTextBox";
            DNIPersonaTextBox.Size = new Size(114, 27);
            DNIPersonaTextBox.TabIndex = 47;
            // 
            // TipoDePasajeroGroupBox
            // 
            TipoDePasajeroGroupBox.BackgroundImageLayout = ImageLayout.None;
            TipoDePasajeroGroupBox.Controls.Add(radioButton2);
            TipoDePasajeroGroupBox.Controls.Add(radioButton3);
            TipoDePasajeroGroupBox.Controls.Add(radioButton1);
            TipoDePasajeroGroupBox.ForeColor = SystemColors.ControlText;
            TipoDePasajeroGroupBox.Location = new Point(25, 229);
            TipoDePasajeroGroupBox.Name = "TipoDePasajeroGroupBox";
            TipoDePasajeroGroupBox.Size = new Size(296, 67);
            TipoDePasajeroGroupBox.TabIndex = 46;
            TipoDePasajeroGroupBox.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(206, 27);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 24);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "Infante";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(108, 27);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(73, 24);
            radioButton3.TabIndex = 6;
            radioButton3.Text = "Menor";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(7, 27);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Adulto";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // CancelarAgregarPersonaButton
            // 
            CancelarAgregarPersonaButton.Location = new Point(158, 310);
            CancelarAgregarPersonaButton.Margin = new Padding(3, 4, 3, 4);
            CancelarAgregarPersonaButton.Name = "CancelarAgregarPersonaButton";
            CancelarAgregarPersonaButton.Size = new Size(116, 45);
            CancelarAgregarPersonaButton.TabIndex = 45;
            CancelarAgregarPersonaButton.Text = "Cancelar";
            CancelarAgregarPersonaButton.UseVisualStyleBackColor = true;
            CancelarAgregarPersonaButton.Click += CancelarAgregarPersonaButton_Click;
            // 
            // AgregarPersonaButton
            // 
            AgregarPersonaButton.Location = new Point(25, 310);
            AgregarPersonaButton.Margin = new Padding(3, 4, 3, 4);
            AgregarPersonaButton.Name = "AgregarPersonaButton";
            AgregarPersonaButton.Size = new Size(116, 45);
            AgregarPersonaButton.TabIndex = 44;
            AgregarPersonaButton.Text = "Agregar";
            AgregarPersonaButton.UseVisualStyleBackColor = true;
            AgregarPersonaButton.Click += AgregarPersonaButton_Click;
            // 
            // ApellidoPersonaTextBox
            // 
            ApellidoPersonaTextBox.Location = new Point(25, 122);
            ApellidoPersonaTextBox.Margin = new Padding(3, 4, 3, 4);
            ApellidoPersonaTextBox.Name = "ApellidoPersonaTextBox";
            ApellidoPersonaTextBox.Size = new Size(114, 27);
            ApellidoPersonaTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 94);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // NombrePersonaTextBox
            // 
            NombrePersonaTextBox.Location = new Point(25, 52);
            NombrePersonaTextBox.Margin = new Padding(3, 4, 3, 4);
            NombrePersonaTextBox.Name = "NombrePersonaTextBox";
            NombrePersonaTextBox.Size = new Size(114, 27);
            NombrePersonaTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // AgregarPersona
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 416);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarPersona";
            Text = "Agregar personas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            TipoDePasajeroGroupBox.ResumeLayout(false);
            TipoDePasajeroGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox ApellidoPersonaTextBox;
        private Label label2;
        private TextBox NombrePersonaTextBox;
        private Label label1;
        private Button CancelarAgregarPersonaButton;
        private Button AgregarPersonaButton;
        private GroupBox TipoDePasajeroGroupBox;
        private Label label3;
        private TextBox DNIPersonaTextBox;
    }
}