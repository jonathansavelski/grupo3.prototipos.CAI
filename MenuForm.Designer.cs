namespace grupo3.prototipos.CAI
{
    partial class MenuForm
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
            grpMenu = new GroupBox();
            btnMenu7 = new Button();
            btnMenu6 = new Button();
            btnMenu4 = new Button();
            btnMenu3 = new Button();
            btnMenu5 = new Button();
            btnMenu2 = new Button();
            btnMenu1 = new Button();
            grpMenu.SuspendLayout();
            SuspendLayout();
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(btnMenu7);
            grpMenu.Controls.Add(btnMenu6);
            grpMenu.Controls.Add(btnMenu4);
            grpMenu.Controls.Add(btnMenu3);
            grpMenu.Controls.Add(btnMenu5);
            grpMenu.Controls.Add(btnMenu2);
            grpMenu.Controls.Add(btnMenu1);
            grpMenu.Location = new Point(97, 29);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(518, 380);
            grpMenu.TabIndex = 0;
            grpMenu.TabStop = false;
            grpMenu.Text = "Menú principal";
            // 
            // btnMenu7
            // 
            btnMenu7.Location = new Point(146, 294);
            btnMenu7.Name = "btnMenu7";
            btnMenu7.Size = new Size(257, 28);
            btnMenu7.TabIndex = 6;
            btnMenu7.Text = "Prereserva/reserva";
            btnMenu7.UseVisualStyleBackColor = true;
            // 
            // btnMenu6
            // 
            btnMenu6.Location = new Point(146, 260);
            btnMenu6.Name = "btnMenu6";
            btnMenu6.Size = new Size(257, 28);
            btnMenu6.TabIndex = 5;
            btnMenu6.Text = "Itinerario";
            btnMenu6.UseVisualStyleBackColor = true;
            // 
            // btnMenu4
            // 
            btnMenu4.Location = new Point(148, 171);
            btnMenu4.Name = "btnMenu4";
            btnMenu4.Size = new Size(255, 28);
            btnMenu4.TabIndex = 4;
            btnMenu4.Text = "Consulta disponibilidad cruceros";
            btnMenu4.UseVisualStyleBackColor = true;
            // 
            // btnMenu3
            // 
            btnMenu3.Location = new Point(148, 137);
            btnMenu3.Name = "btnMenu3";
            btnMenu3.Size = new Size(255, 28);
            btnMenu3.TabIndex = 3;
            btnMenu3.Text = "Consulta disponibilidad hoteles";
            btnMenu3.UseVisualStyleBackColor = true;
            // 
            // btnMenu5
            // 
            btnMenu5.Location = new Point(148, 205);
            btnMenu5.Name = "btnMenu5";
            btnMenu5.Size = new Size(255, 31);
            btnMenu5.TabIndex = 2;
            btnMenu5.Text = "Consulta disponibilidad paquetes";
            btnMenu5.UseVisualStyleBackColor = true;
            btnMenu5.Click += btnMenu5_Click;
            // 
            // btnMenu2
            // 
            btnMenu2.Location = new Point(146, 102);
            btnMenu2.Name = "btnMenu2";
            btnMenu2.Size = new Size(257, 29);
            btnMenu2.TabIndex = 1;
            btnMenu2.Text = "Consulta disponibilidad vuelos";
            btnMenu2.UseVisualStyleBackColor = true;
            btnMenu2.Click += btnMenu2_Click;
            // 
            // btnMenu1
            // 
            btnMenu1.Location = new Point(146, 34);
            btnMenu1.Name = "btnMenu1";
            btnMenu1.Size = new Size(257, 39);
            btnMenu1.TabIndex = 0;
            btnMenu1.Text = "Carga datos pasajero";
            btnMenu1.UseVisualStyleBackColor = true;
            btnMenu1.Click += btnMenu1_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpMenu);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú";
            grpMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMenu;
        private Button btnMenu1;
        private Button btnMenu7;
        private Button btnMenu6;
        private Button btnMenu4;
        private Button btnMenu3;
        private Button btnMenu5;
        private Button btnMenu2;
    }
}