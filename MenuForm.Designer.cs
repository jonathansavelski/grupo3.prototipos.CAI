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
            ConsultaDisponibilidadCrucerosBtn = new Button();
            ConsultaDisponibilidadHotelesBtn = new Button();
            ConsultaDisponibilidadPaquetesBtn = new Button();
            ConsultaDisponibilidadVuelosBtn = new Button();
            CargaDatosBtn = new Button();
            grpMenu.SuspendLayout();
            SuspendLayout();
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(btnMenu7);
            grpMenu.Controls.Add(btnMenu6);
            grpMenu.Controls.Add(ConsultaDisponibilidadCrucerosBtn);
            grpMenu.Controls.Add(ConsultaDisponibilidadHotelesBtn);
            grpMenu.Controls.Add(ConsultaDisponibilidadPaquetesBtn);
            grpMenu.Controls.Add(ConsultaDisponibilidadVuelosBtn);
            grpMenu.Controls.Add(CargaDatosBtn);
            grpMenu.Location = new Point(111, 39);
            grpMenu.Margin = new Padding(3, 4, 3, 4);
            grpMenu.Name = "grpMenu";
            grpMenu.Padding = new Padding(3, 4, 3, 4);
            grpMenu.Size = new Size(592, 507);
            grpMenu.TabIndex = 0;
            grpMenu.TabStop = false;
            grpMenu.Text = "Menú principal";
            // 
            // btnMenu7
            // 
            btnMenu7.Location = new Point(167, 392);
            btnMenu7.Margin = new Padding(3, 4, 3, 4);
            btnMenu7.Name = "btnMenu7";
            btnMenu7.Size = new Size(294, 37);
            btnMenu7.TabIndex = 6;
            btnMenu7.Text = "Prereserva/reserva";
            btnMenu7.UseVisualStyleBackColor = true;
            // 
            // btnMenu6
            // 
            btnMenu6.Location = new Point(167, 347);
            btnMenu6.Margin = new Padding(3, 4, 3, 4);
            btnMenu6.Name = "btnMenu6";
            btnMenu6.Size = new Size(294, 37);
            btnMenu6.TabIndex = 5;
            btnMenu6.Text = "Itinerario";
            btnMenu6.UseVisualStyleBackColor = true;
            // 
            // ConsultaDisponibilidadCrucerosBtn
            // 
            ConsultaDisponibilidadCrucerosBtn.Location = new Point(169, 228);
            ConsultaDisponibilidadCrucerosBtn.Margin = new Padding(3, 4, 3, 4);
            ConsultaDisponibilidadCrucerosBtn.Name = "ConsultaDisponibilidadCrucerosBtn";
            ConsultaDisponibilidadCrucerosBtn.Size = new Size(291, 37);
            ConsultaDisponibilidadCrucerosBtn.TabIndex = 4;
            ConsultaDisponibilidadCrucerosBtn.Text = "Consulta disponibilidad cruceros";
            ConsultaDisponibilidadCrucerosBtn.UseVisualStyleBackColor = true;
            ConsultaDisponibilidadCrucerosBtn.Click += ConsultaDisponibilidadCrucerosBtn_Click;
            // 
            // ConsultaDisponibilidadHotelesBtn
            // 
            ConsultaDisponibilidadHotelesBtn.Location = new Point(169, 183);
            ConsultaDisponibilidadHotelesBtn.Margin = new Padding(3, 4, 3, 4);
            ConsultaDisponibilidadHotelesBtn.Name = "ConsultaDisponibilidadHotelesBtn";
            ConsultaDisponibilidadHotelesBtn.Size = new Size(291, 37);
            ConsultaDisponibilidadHotelesBtn.TabIndex = 3;
            ConsultaDisponibilidadHotelesBtn.Text = "Consulta disponibilidad hoteles";
            ConsultaDisponibilidadHotelesBtn.UseVisualStyleBackColor = true;
            ConsultaDisponibilidadHotelesBtn.Click += ConsultaDisponibilidadHotelesBtn_Click;
            // 
            // ConsultaDisponibilidadPaquetesBtn
            // 
            ConsultaDisponibilidadPaquetesBtn.Location = new Point(169, 273);
            ConsultaDisponibilidadPaquetesBtn.Margin = new Padding(3, 4, 3, 4);
            ConsultaDisponibilidadPaquetesBtn.Name = "ConsultaDisponibilidadPaquetesBtn";
            ConsultaDisponibilidadPaquetesBtn.Size = new Size(291, 41);
            ConsultaDisponibilidadPaquetesBtn.TabIndex = 2;
            ConsultaDisponibilidadPaquetesBtn.Text = "Consulta disponibilidad paquetes";
            ConsultaDisponibilidadPaquetesBtn.UseVisualStyleBackColor = true;
            ConsultaDisponibilidadPaquetesBtn.Click += ConsultaDisponibilidadPaquetesBtn_Click;
            // 
            // ConsultaDisponibilidadVuelosBtn
            // 
            ConsultaDisponibilidadVuelosBtn.Location = new Point(167, 136);
            ConsultaDisponibilidadVuelosBtn.Margin = new Padding(3, 4, 3, 4);
            ConsultaDisponibilidadVuelosBtn.Name = "ConsultaDisponibilidadVuelosBtn";
            ConsultaDisponibilidadVuelosBtn.Size = new Size(294, 39);
            ConsultaDisponibilidadVuelosBtn.TabIndex = 1;
            ConsultaDisponibilidadVuelosBtn.Text = "Consulta disponibilidad vuelos";
            ConsultaDisponibilidadVuelosBtn.UseVisualStyleBackColor = true;
            ConsultaDisponibilidadVuelosBtn.Click += ConsultaDisponibilidadVuelosBtn_Click;
            // 
            // CargaDatosBtn
            // 
            CargaDatosBtn.Location = new Point(167, 45);
            CargaDatosBtn.Margin = new Padding(3, 4, 3, 4);
            CargaDatosBtn.Name = "CargaDatosBtn";
            CargaDatosBtn.Size = new Size(294, 52);
            CargaDatosBtn.TabIndex = 0;
            CargaDatosBtn.Text = "Carga datos pasajero";
            CargaDatosBtn.UseVisualStyleBackColor = true;
            CargaDatosBtn.Click += CargaDatosBtn_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(grpMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú";
            grpMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMenu;
        private Button CargaDatosBtn;
        private Button btnMenu7;
        private Button btnMenu6;
        private Button ConsultaDisponibilidadCrucerosBtn;
        private Button ConsultaDisponibilidadHotelesBtn;
        private Button ConsultaDisponibilidadPaquetesBtn;
        private Button ConsultaDisponibilidadVuelosBtn;
    }
}