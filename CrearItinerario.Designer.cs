namespace grupo3.prototipos.CAI
{
    partial class CrearItinerario
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
            HotelesListView = new ListView();
            CodigoHotelHeader = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            CódigoCiudadHeader = new ColumnHeader();
            DirecciónHeader = new ColumnHeader();
            CalificacionHeader = new ColumnHeader();
            NombreHabitacionHeader = new ColumnHeader();
            TarifaPorDiaHeader = new ColumnHeader();
            VuelosListView = new ListView();
            CodigoVueloHeader = new ColumnHeader();
            CodigoOrigenVueloHeader = new ColumnHeader();
            CodigoDestinoVueloHeader = new ColumnHeader();
            FechaSalidaVueloHeader = new ColumnHeader();
            FechaArriboVueloHeader = new ColumnHeader();
            TiempoVueloHeader = new ColumnHeader();
            CodigoAerolineaVueloHeader = new ColumnHeader();
            ClaseTarifaVueloHeader = new ColumnHeader();
            TipoPasajeroHeader = new ColumnHeader();
            PrecioVueloHeader = new ColumnHeader();
            DisponibilidadVueloHeader = new ColumnHeader();
            ValorDeLaCotizacionLabel = new Label();
            CotizarButton = new Button();
            EliminarHotelButton = new Button();
            EliminarVueloButton = new Button();
            label7 = new Label();
            label6 = new Label();
            AgregarHotelButton = new Button();
            AgregarVueloButton = new Button();
            MenuPrincipalButton = new Button();
            NumeroItinerarioLabel = new Label();
            lblNumeroItinerario = new Label();
            CargaPasajerosGroupBox = new GroupBox();
            CargarPasajeroHotelButton = new Button();
            label11 = new Label();
            CargarPasajeroVueloButton = new Button();
            CopiarNumeroItinerario = new Button();
            grpMenu.SuspendLayout();
            CargaPasajerosGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(HotelesListView);
            grpMenu.Controls.Add(VuelosListView);
            grpMenu.Controls.Add(ValorDeLaCotizacionLabel);
            grpMenu.Controls.Add(CotizarButton);
            grpMenu.Controls.Add(EliminarHotelButton);
            grpMenu.Controls.Add(EliminarVueloButton);
            grpMenu.Controls.Add(label7);
            grpMenu.Controls.Add(label6);
            grpMenu.Controls.Add(AgregarHotelButton);
            grpMenu.Controls.Add(AgregarVueloButton);
            grpMenu.Location = new Point(12, 37);
            grpMenu.Margin = new Padding(3, 4, 3, 4);
            grpMenu.Name = "grpMenu";
            grpMenu.Padding = new Padding(3, 4, 3, 4);
            grpMenu.Size = new Size(1493, 507);
            grpMenu.TabIndex = 0;
            grpMenu.TabStop = false;
            // 
            // HotelesListView
            // 
            HotelesListView.Columns.AddRange(new ColumnHeader[] { CodigoHotelHeader, columnHeader1, CódigoCiudadHeader, DirecciónHeader, CalificacionHeader, NombreHabitacionHeader, TarifaPorDiaHeader });
            HotelesListView.FullRowSelect = true;
            HotelesListView.GridLines = true;
            HotelesListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            HotelesListView.Location = new Point(14, 272);
            HotelesListView.Margin = new Padding(3, 4, 3, 4);
            HotelesListView.MultiSelect = false;
            HotelesListView.Name = "HotelesListView";
            HotelesListView.Size = new Size(1463, 104);
            HotelesListView.TabIndex = 46;
            HotelesListView.UseCompatibleStateImageBehavior = false;
            HotelesListView.View = View.Details;
            // 
            // CodigoHotelHeader
            // 
            CodigoHotelHeader.Text = "Código";
            CodigoHotelHeader.Width = 120;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 120;
            // 
            // CódigoCiudadHeader
            // 
            CódigoCiudadHeader.Text = "Código Ciudad";
            CódigoCiudadHeader.TextAlign = HorizontalAlignment.Center;
            CódigoCiudadHeader.Width = 120;
            // 
            // DirecciónHeader
            // 
            DirecciónHeader.Text = "Dirección";
            DirecciónHeader.TextAlign = HorizontalAlignment.Center;
            DirecciónHeader.Width = 120;
            // 
            // CalificacionHeader
            // 
            CalificacionHeader.Text = "Calificación";
            CalificacionHeader.Width = 100;
            // 
            // NombreHabitacionHeader
            // 
            NombreHabitacionHeader.Text = "Nombre habitación";
            NombreHabitacionHeader.TextAlign = HorizontalAlignment.Center;
            NombreHabitacionHeader.Width = 150;
            // 
            // TarifaPorDiaHeader
            // 
            TarifaPorDiaHeader.Text = "Tarifa por día";
            TarifaPorDiaHeader.TextAlign = HorizontalAlignment.Center;
            TarifaPorDiaHeader.Width = 150;
            // 
            // VuelosListView
            // 
            VuelosListView.Columns.AddRange(new ColumnHeader[] { CodigoVueloHeader, CodigoOrigenVueloHeader, CodigoDestinoVueloHeader, FechaSalidaVueloHeader, FechaArriboVueloHeader, TiempoVueloHeader, CodigoAerolineaVueloHeader, ClaseTarifaVueloHeader, TipoPasajeroHeader, PrecioVueloHeader, DisponibilidadVueloHeader });
            VuelosListView.FullRowSelect = true;
            VuelosListView.GridLines = true;
            VuelosListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            VuelosListView.LabelWrap = false;
            VuelosListView.Location = new Point(14, 54);
            VuelosListView.Margin = new Padding(3, 4, 3, 4);
            VuelosListView.MultiSelect = false;
            VuelosListView.Name = "VuelosListView";
            VuelosListView.Size = new Size(1463, 106);
            VuelosListView.TabIndex = 42;
            VuelosListView.UseCompatibleStateImageBehavior = false;
            VuelosListView.View = View.Details;
            VuelosListView.SelectedIndexChanged += VuelosListView_SelectedIndexChanged;
            // 
            // CodigoVueloHeader
            // 
            CodigoVueloHeader.Text = "Código de vuelo";
            CodigoVueloHeader.Width = 140;
            // 
            // CodigoOrigenVueloHeader
            // 
            CodigoOrigenVueloHeader.Text = "Origen";
            CodigoOrigenVueloHeader.TextAlign = HorizontalAlignment.Center;
            CodigoOrigenVueloHeader.Width = 120;
            // 
            // CodigoDestinoVueloHeader
            // 
            CodigoDestinoVueloHeader.Text = "Destino";
            CodigoDestinoVueloHeader.TextAlign = HorizontalAlignment.Center;
            CodigoDestinoVueloHeader.Width = 120;
            // 
            // FechaSalidaVueloHeader
            // 
            FechaSalidaVueloHeader.Text = "Fecha de salida";
            FechaSalidaVueloHeader.TextAlign = HorizontalAlignment.Center;
            FechaSalidaVueloHeader.Width = 150;
            // 
            // FechaArriboVueloHeader
            // 
            FechaArriboVueloHeader.Text = "Fecha de arribo";
            FechaArriboVueloHeader.TextAlign = HorizontalAlignment.Center;
            FechaArriboVueloHeader.Width = 150;
            // 
            // TiempoVueloHeader
            // 
            TiempoVueloHeader.Text = "Tiempo de vuelo";
            TiempoVueloHeader.TextAlign = HorizontalAlignment.Center;
            TiempoVueloHeader.Width = 140;
            // 
            // CodigoAerolineaVueloHeader
            // 
            CodigoAerolineaVueloHeader.Text = "Código de aerolínea";
            CodigoAerolineaVueloHeader.TextAlign = HorizontalAlignment.Center;
            CodigoAerolineaVueloHeader.Width = 160;
            // 
            // ClaseTarifaVueloHeader
            // 
            ClaseTarifaVueloHeader.Text = "Clase Tarifa";
            ClaseTarifaVueloHeader.TextAlign = HorizontalAlignment.Center;
            ClaseTarifaVueloHeader.Width = 100;
            // 
            // TipoPasajeroHeader
            // 
            TipoPasajeroHeader.Text = "Tipo Pasajero";
            TipoPasajeroHeader.TextAlign = HorizontalAlignment.Center;
            TipoPasajeroHeader.Width = 120;
            // 
            // PrecioVueloHeader
            // 
            PrecioVueloHeader.Text = "Precio";
            PrecioVueloHeader.TextAlign = HorizontalAlignment.Center;
            PrecioVueloHeader.Width = 100;
            // 
            // DisponibilidadVueloHeader
            // 
            DisponibilidadVueloHeader.Text = "Disponibilidad";
            DisponibilidadVueloHeader.TextAlign = HorizontalAlignment.Center;
            DisponibilidadVueloHeader.Width = 120;
            // 
            // ValorDeLaCotizacionLabel
            // 
            ValorDeLaCotizacionLabel.AutoSize = true;
            ValorDeLaCotizacionLabel.Location = new Point(150, 459);
            ValorDeLaCotizacionLabel.Name = "ValorDeLaCotizacionLabel";
            ValorDeLaCotizacionLabel.Size = new Size(152, 20);
            ValorDeLaCotizacionLabel.TabIndex = 39;
            ValorDeLaCotizacionLabel.Text = "Valor de la cotización";
            // 
            // CotizarButton
            // 
            CotizarButton.Location = new Point(14, 447);
            CotizarButton.Margin = new Padding(3, 4, 3, 4);
            CotizarButton.Name = "CotizarButton";
            CotizarButton.Size = new Size(112, 45);
            CotizarButton.TabIndex = 30;
            CotizarButton.Text = "Cotizar";
            CotizarButton.UseVisualStyleBackColor = true;
            CotizarButton.Click += CotizarButton_Click;
            // 
            // EliminarHotelButton
            // 
            EliminarHotelButton.Location = new Point(178, 384);
            EliminarHotelButton.Margin = new Padding(3, 4, 3, 4);
            EliminarHotelButton.Name = "EliminarHotelButton";
            EliminarHotelButton.Size = new Size(158, 37);
            EliminarHotelButton.TabIndex = 29;
            EliminarHotelButton.Text = "Eliminar";
            EliminarHotelButton.UseVisualStyleBackColor = true;
            // 
            // EliminarVueloButton
            // 
            EliminarVueloButton.Location = new Point(178, 168);
            EliminarVueloButton.Margin = new Padding(3, 4, 3, 4);
            EliminarVueloButton.Name = "EliminarVueloButton";
            EliminarVueloButton.Size = new Size(158, 39);
            EliminarVueloButton.TabIndex = 25;
            EliminarVueloButton.Text = "Eliminar";
            EliminarVueloButton.UseVisualStyleBackColor = true;
            EliminarVueloButton.Click += EliminarVueloButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 243);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 22;
            label7.Text = "Hoteles";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(10, 24);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 20;
            label6.Text = "Vuelos";
            // 
            // AgregarHotelButton
            // 
            AgregarHotelButton.Location = new Point(14, 384);
            AgregarHotelButton.Margin = new Padding(3, 4, 3, 4);
            AgregarHotelButton.Name = "AgregarHotelButton";
            AgregarHotelButton.Size = new Size(158, 37);
            AgregarHotelButton.TabIndex = 3;
            AgregarHotelButton.Text = "Agregar";
            AgregarHotelButton.UseVisualStyleBackColor = true;
            AgregarHotelButton.Click += ConsultaDisponibilidadHotelesBtn_Click;
            // 
            // AgregarVueloButton
            // 
            AgregarVueloButton.Location = new Point(14, 168);
            AgregarVueloButton.Margin = new Padding(3, 4, 3, 4);
            AgregarVueloButton.Name = "AgregarVueloButton";
            AgregarVueloButton.Size = new Size(158, 39);
            AgregarVueloButton.TabIndex = 1;
            AgregarVueloButton.Text = "Agregar";
            AgregarVueloButton.UseVisualStyleBackColor = true;
            AgregarVueloButton.Click += ConsultaDisponibilidadVuelosBtn_Click;
            // 
            // MenuPrincipalButton
            // 
            MenuPrincipalButton.Location = new Point(1324, 651);
            MenuPrincipalButton.Margin = new Padding(3, 4, 3, 4);
            MenuPrincipalButton.Name = "MenuPrincipalButton";
            MenuPrincipalButton.Size = new Size(165, 41);
            MenuPrincipalButton.TabIndex = 41;
            MenuPrincipalButton.Text = "Menú principal";
            MenuPrincipalButton.UseVisualStyleBackColor = true;
            MenuPrincipalButton.Click += MenuPrincipalButton_Click;
            // 
            // NumeroItinerarioLabel
            // 
            NumeroItinerarioLabel.AutoSize = true;
            NumeroItinerarioLabel.Location = new Point(241, 14);
            NumeroItinerarioLabel.Name = "NumeroItinerarioLabel";
            NumeroItinerarioLabel.Size = new Size(63, 20);
            NumeroItinerarioLabel.TabIndex = 39;
            NumeroItinerarioLabel.Text = "Número";
            // 
            // lblNumeroItinerario
            // 
            lblNumeroItinerario.AutoSize = true;
            lblNumeroItinerario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroItinerario.Location = new Point(12, 13);
            lblNumeroItinerario.Name = "lblNumeroItinerario";
            lblNumeroItinerario.Size = new Size(227, 20);
            lblNumeroItinerario.TabIndex = 8;
            lblNumeroItinerario.Text = "Número de itinerario asignado:";
            // 
            // CargaPasajerosGroupBox
            // 
            CargaPasajerosGroupBox.Controls.Add(CargarPasajeroHotelButton);
            CargaPasajerosGroupBox.Controls.Add(label11);
            CargaPasajerosGroupBox.Controls.Add(CargarPasajeroVueloButton);
            CargaPasajerosGroupBox.Location = new Point(12, 551);
            CargaPasajerosGroupBox.Name = "CargaPasajerosGroupBox";
            CargaPasajerosGroupBox.Size = new Size(671, 141);
            CargaPasajerosGroupBox.TabIndex = 43;
            CargaPasajerosGroupBox.TabStop = false;
            // 
            // CargarPasajeroHotelButton
            // 
            CargarPasajeroHotelButton.Location = new Point(233, 81);
            CargarPasajeroHotelButton.Margin = new Padding(3, 4, 3, 4);
            CargarPasajeroHotelButton.Name = "CargarPasajeroHotelButton";
            CargarPasajeroHotelButton.Size = new Size(229, 41);
            CargarPasajeroHotelButton.TabIndex = 45;
            CargarPasajeroHotelButton.Text = "Cargar pasajeros para hoteles";
            CargarPasajeroHotelButton.UseVisualStyleBackColor = true;
            CargarPasajeroHotelButton.Click += CargarPasajeroHotelButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(14, 25);
            label11.Name = "label11";
            label11.Size = new Size(162, 20);
            label11.TabIndex = 44;
            label11.Text = "Carga datos pasajeros";
            // 
            // CargarPasajeroVueloButton
            // 
            CargarPasajeroVueloButton.Location = new Point(14, 81);
            CargarPasajeroVueloButton.Margin = new Padding(3, 4, 3, 4);
            CargarPasajeroVueloButton.Name = "CargarPasajeroVueloButton";
            CargarPasajeroVueloButton.Size = new Size(213, 41);
            CargarPasajeroVueloButton.TabIndex = 37;
            CargarPasajeroVueloButton.Text = "Cargar pasajeros para vuelos";
            CargarPasajeroVueloButton.UseVisualStyleBackColor = true;
            CargarPasajeroVueloButton.Click += CargarPasajeroVueloButton_Click;
            // 
            // CopiarNumeroItinerario
            // 
            CopiarNumeroItinerario.Location = new Point(320, 9);
            CopiarNumeroItinerario.Name = "CopiarNumeroItinerario";
            CopiarNumeroItinerario.Size = new Size(94, 29);
            CopiarNumeroItinerario.TabIndex = 44;
            CopiarNumeroItinerario.Text = "Copiar";
            CopiarNumeroItinerario.UseVisualStyleBackColor = true;
            CopiarNumeroItinerario.Click += CopiarNumeroItinerario_Click;
            // 
            // CrearItinerario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 709);
            Controls.Add(CopiarNumeroItinerario);
            Controls.Add(CargaPasajerosGroupBox);
            Controls.Add(NumeroItinerarioLabel);
            Controls.Add(grpMenu);
            Controls.Add(lblNumeroItinerario);
            Controls.Add(MenuPrincipalButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrearItinerario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear itinerario";
            Load += CrearItinerario_Load;
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            CargaPasajerosGroupBox.ResumeLayout(false);
            CargaPasajerosGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpMenu;
        private Button AgregarHotelButton;
        private Button AgregarVueloButton;
        private Label lblNumeroItinerario;
        private Button EliminarHotelButton;
        private Button EliminarVueloButton;
        private Label label7;
        private Label label6;
        private Button CotizarButton;
        private Label NumeroItinerarioLabel;
        private Label ValorDeLaCotizacionLabel;
        private Button MenuPrincipalButton;
        private GroupBox CargaPasajerosGroupBox;
        private ListView listView4;
        private ColumnHeader nombreHeader;
        private ColumnHeader apellidoHeader;
        private ColumnHeader TipoPasajero;
        private Button CargarPasajeroVueloButton;
        private Button EliminarPasajeroButton;
        private ColumnHeader CodigoVueloHeader;
        private ColumnHeader CodigoOrigenVueloHeader;
        private ColumnHeader CodigoDestinoVueloHeader;
        private ColumnHeader FechaSalidaVueloHeader;
        private ColumnHeader FechaArriboVueloHeader;
        private ColumnHeader TiempoVueloHeader;
        private ColumnHeader CodigoAerolineaVueloHeader;
        private ColumnHeader ClaseTarifaVueloHeader;
        private ColumnHeader TipoPasajeroHeader;
        private ColumnHeader PrecioVueloHeader;
        private ColumnHeader DisponibilidadVueloHeader;
        private ListView HotelesListView;
        private ColumnHeader CodigoHotelHeader;
        private ColumnHeader columnHeader1;
        private ColumnHeader CódigoCiudadHeader;
        private ColumnHeader DirecciónHeader;
        private ColumnHeader CalificacionHeader;
        private ColumnHeader NombreHabitacionHeader;
        private ColumnHeader TarifaPorDiaHeader;
        private Label label11;
        private ColumnHeader DNIHeader;
        private Button CargarPasajeroHotelButton;
        public ListView VuelosListView;
        private Button CopiarNumeroItinerario;
    }
}