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
            CancelarAgregarPersonaButton = new Button();
            AgregarPersonaButton = new Button();
            ApellidoPersonaTextBox = new TextBox();
            label2 = new Label();
            NombrePersonaTextBox = new TextBox();
            label1 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(DNIPersonaTextBox);
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
            DNIPersonaTextBox.Location = new Point(25, 187);
            DNIPersonaTextBox.Margin = new Padding(3, 4, 3, 4);
            DNIPersonaTextBox.Name = "DNIPersonaTextBox";
            DNIPersonaTextBox.Size = new Size(114, 27);
            DNIPersonaTextBox.TabIndex = 47;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 237);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 49;
            label4.Text = "Edad:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(25, 267);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(46, 27);
            numericUpDown1.TabIndex = 50;
            // 
            // AgregarPasajero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 420);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarPasajero";
            Text = "Agregar personas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox ApellidoPersonaTextBox;
        private Label label2;
        private TextBox NombrePersonaTextBox;
        private Label label1;
        private Button CancelarAgregarPersonaButton;
        private Button AgregarPersonaButton;
        private Label label3;
        private TextBox DNIPersonaTextBox;
        private NumericUpDown numericUpDown1;
        private Label label4;
    }
}