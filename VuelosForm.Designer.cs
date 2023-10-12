namespace grupo3.prototipos.CAI
{
    partial class VuelosForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpVuelo = new GroupBox();
            VuelosListView = new ListView();
            CodigoVueloHeader = new ColumnHeader();
            OrigenVueloHeader = new ColumnHeader();
            DestinoVueloHeader = new ColumnHeader();
            FechaSalidaVueloHeader = new ColumnHeader();
            FechaArriboVueloHeader = new ColumnHeader();
            TiempoVueloHeader = new ColumnHeader();
            CodigoAerolineaVueloHeader = new ColumnHeader();
            InformacionVueloButton = new Button();
            MasInformacionGrp = new GroupBox();
            lblServiciosExtra = new Label();
            lblTarifas = new Label();
            lblParadas = new Label();
            ServiciosExtraListView = new ListView();
            CodigoServicioHeader = new ColumnHeader();
            DescripcionServicioHeader = new ColumnHeader();
            TarifaServicioHeader = new ColumnHeader();
            TarifasListView = new ListView();
            ClaseTarifaHeader = new ColumnHeader();
            ItinerarioTarifaHeader = new ColumnHeader();
            TipoPasajeroTarifaHeader = new ColumnHeader();
            BaseTarifaHeader = new ColumnHeader();
            ImpuestosTarifaHeader = new ColumnHeader();
            ComisionTarifaHeader = new ColumnHeader();
            DisponibilidadTarifaHeader = new ColumnHeader();
            ParadasListView = new ListView();
            AeropuertoParadaHeader = new ColumnHeader();
            TiempoParadaHeader = new ColumnHeader();
            dateTimePicker1 = new DateTimePicker();
            AplicarFiltrosButton = new Button();
            lblFechaSalida = new Label();
            AñadirAlItinerarioVuelosButton = new Button();
            grpVuelo.SuspendLayout();
            MasInformacionGrp.SuspendLayout();
            SuspendLayout();
            // 
            // grpVuelo
            // 
            grpVuelo.Controls.Add(VuelosListView);
            grpVuelo.Location = new Point(7, 49);
            grpVuelo.Margin = new Padding(3, 4, 3, 4);
            grpVuelo.Name = "grpVuelo";
            grpVuelo.Padding = new Padding(3, 4, 3, 4);
            grpVuelo.Size = new Size(1213, 245);
            grpVuelo.TabIndex = 4;
            grpVuelo.TabStop = false;
            grpVuelo.Text = "Seleccione un vuelo disponible:";
            // 
            // VuelosListView
            // 
            VuelosListView.Columns.AddRange(new ColumnHeader[] { CodigoVueloHeader, OrigenVueloHeader, DestinoVueloHeader, FechaSalidaVueloHeader, FechaArriboVueloHeader, TiempoVueloHeader, CodigoAerolineaVueloHeader });
            VuelosListView.FullRowSelect = true;
            VuelosListView.Location = new Point(7, 27);
            VuelosListView.Margin = new Padding(3, 4, 3, 4);
            VuelosListView.MultiSelect = false;
            VuelosListView.Name = "VuelosListView";
            VuelosListView.Size = new Size(1190, 209);
            VuelosListView.TabIndex = 0;
            VuelosListView.UseCompatibleStateImageBehavior = false;
            VuelosListView.View = View.Details;
            // 
            // CodigoVueloHeader
            // 
            CodigoVueloHeader.Text = "Código de vuelo";
            CodigoVueloHeader.Width = 140;
            // 
            // OrigenVueloHeader
            // 
            OrigenVueloHeader.Text = "Origen";
            OrigenVueloHeader.TextAlign = HorizontalAlignment.Center;
            OrigenVueloHeader.Width = 100;
            // 
            // DestinoVueloHeader
            // 
            DestinoVueloHeader.Text = "Destino";
            DestinoVueloHeader.TextAlign = HorizontalAlignment.Center;
            DestinoVueloHeader.Width = 100;
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
            // InformacionVueloButton
            // 
            InformacionVueloButton.Location = new Point(14, 301);
            InformacionVueloButton.Name = "InformacionVueloButton";
            InformacionVueloButton.Size = new Size(155, 40);
            InformacionVueloButton.TabIndex = 6;
            InformacionVueloButton.Text = "Ver más información";
            InformacionVueloButton.UseVisualStyleBackColor = true;
            InformacionVueloButton.Click += InformacionVueloButton_Click;
            // 
            // MasInformacionGrp
            // 
            MasInformacionGrp.Controls.Add(lblServiciosExtra);
            MasInformacionGrp.Controls.Add(lblTarifas);
            MasInformacionGrp.Controls.Add(lblParadas);
            MasInformacionGrp.Controls.Add(ServiciosExtraListView);
            MasInformacionGrp.Controls.Add(TarifasListView);
            MasInformacionGrp.Controls.Add(ParadasListView);
            MasInformacionGrp.Location = new Point(7, 348);
            MasInformacionGrp.Margin = new Padding(3, 4, 3, 4);
            MasInformacionGrp.Name = "MasInformacionGrp";
            MasInformacionGrp.Padding = new Padding(3, 4, 3, 4);
            MasInformacionGrp.Size = new Size(1213, 347);
            MasInformacionGrp.TabIndex = 7;
            MasInformacionGrp.TabStop = false;
            MasInformacionGrp.Text = "Más información:";
            // 
            // lblServiciosExtra
            // 
            lblServiciosExtra.AutoSize = true;
            lblServiciosExtra.Location = new Point(605, 36);
            lblServiciosExtra.Name = "lblServiciosExtra";
            lblServiciosExtra.Size = new Size(107, 20);
            lblServiciosExtra.TabIndex = 5;
            lblServiciosExtra.Text = "Servicios extra:";
            // 
            // lblTarifas
            // 
            lblTarifas.AutoSize = true;
            lblTarifas.Location = new Point(14, 177);
            lblTarifas.Name = "lblTarifas";
            lblTarifas.Size = new Size(54, 20);
            lblTarifas.TabIndex = 4;
            lblTarifas.Text = "Tarifas:";
            // 
            // lblParadas
            // 
            lblParadas.AutoSize = true;
            lblParadas.Location = new Point(14, 36);
            lblParadas.Name = "lblParadas";
            lblParadas.Size = new Size(63, 20);
            lblParadas.TabIndex = 3;
            lblParadas.Text = "Paradas:";
            // 
            // ServiciosExtraListView
            // 
            ServiciosExtraListView.Columns.AddRange(new ColumnHeader[] { CodigoServicioHeader, DescripcionServicioHeader, TarifaServicioHeader });
            ServiciosExtraListView.Location = new Point(609, 60);
            ServiciosExtraListView.Margin = new Padding(3, 4, 3, 4);
            ServiciosExtraListView.Name = "ServiciosExtraListView";
            ServiciosExtraListView.Size = new Size(588, 100);
            ServiciosExtraListView.TabIndex = 2;
            ServiciosExtraListView.UseCompatibleStateImageBehavior = false;
            ServiciosExtraListView.View = View.Details;
            // 
            // CodigoServicioHeader
            // 
            CodigoServicioHeader.Text = "Código de servicio";
            CodigoServicioHeader.Width = 150;
            // 
            // DescripcionServicioHeader
            // 
            DescripcionServicioHeader.Text = "Descripción servicio";
            DescripcionServicioHeader.TextAlign = HorizontalAlignment.Center;
            DescripcionServicioHeader.Width = 150;
            // 
            // TarifaServicioHeader
            // 
            TarifaServicioHeader.Text = "Tarifa servicio";
            TarifaServicioHeader.TextAlign = HorizontalAlignment.Center;
            TarifaServicioHeader.Width = 150;
            // 
            // TarifasListView
            // 
            TarifasListView.Columns.AddRange(new ColumnHeader[] { ClaseTarifaHeader, ItinerarioTarifaHeader, TipoPasajeroTarifaHeader, BaseTarifaHeader, ImpuestosTarifaHeader, ComisionTarifaHeader, DisponibilidadTarifaHeader });
            TarifasListView.Location = new Point(14, 201);
            TarifasListView.Margin = new Padding(3, 4, 3, 4);
            TarifasListView.Name = "TarifasListView";
            TarifasListView.Size = new Size(1183, 104);
            TarifasListView.TabIndex = 1;
            TarifasListView.UseCompatibleStateImageBehavior = false;
            TarifasListView.View = View.Details;
            // 
            // ClaseTarifaHeader
            // 
            ClaseTarifaHeader.Text = "Clase Tarifa";
            ClaseTarifaHeader.Width = 120;
            // 
            // ItinerarioTarifaHeader
            // 
            ItinerarioTarifaHeader.Text = "Itinerario";
            ItinerarioTarifaHeader.TextAlign = HorizontalAlignment.Center;
            ItinerarioTarifaHeader.Width = 100;
            // 
            // TipoPasajeroTarifaHeader
            // 
            TipoPasajeroTarifaHeader.Text = "Tipo pasajero";
            TipoPasajeroTarifaHeader.TextAlign = HorizontalAlignment.Center;
            TipoPasajeroTarifaHeader.Width = 125;
            // 
            // BaseTarifaHeader
            // 
            BaseTarifaHeader.Text = "Base";
            BaseTarifaHeader.TextAlign = HorizontalAlignment.Center;
            BaseTarifaHeader.Width = 80;
            // 
            // ImpuestosTarifaHeader
            // 
            ImpuestosTarifaHeader.Text = "Impuesto";
            ImpuestosTarifaHeader.TextAlign = HorizontalAlignment.Center;
            ImpuestosTarifaHeader.Width = 100;
            // 
            // ComisionTarifaHeader
            // 
            ComisionTarifaHeader.Text = "Comisión";
            ComisionTarifaHeader.TextAlign = HorizontalAlignment.Center;
            ComisionTarifaHeader.Width = 100;
            // 
            // DisponibilidadTarifaHeader
            // 
            DisponibilidadTarifaHeader.Text = "Disponibilidad";
            DisponibilidadTarifaHeader.TextAlign = HorizontalAlignment.Center;
            DisponibilidadTarifaHeader.Width = 120;
            // 
            // ParadasListView
            // 
            ParadasListView.Columns.AddRange(new ColumnHeader[] { AeropuertoParadaHeader, TiempoParadaHeader });
            ParadasListView.Location = new Point(14, 60);
            ParadasListView.Margin = new Padding(3, 4, 3, 4);
            ParadasListView.Name = "ParadasListView";
            ParadasListView.Size = new Size(568, 100);
            ParadasListView.TabIndex = 0;
            ParadasListView.UseCompatibleStateImageBehavior = false;
            ParadasListView.View = View.Details;
            // 
            // AeropuertoParadaHeader
            // 
            AeropuertoParadaHeader.Text = "Aeropuerto de parada";
            AeropuertoParadaHeader.Width = 180;
            // 
            // TiempoParadaHeader
            // 
            TiempoParadaHeader.Text = "Tiempo de parada";
            TiempoParadaHeader.Width = 150;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(176, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(291, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // AplicarFiltrosButton
            // 
            AplicarFiltrosButton.Location = new Point(473, 12);
            AplicarFiltrosButton.Name = "AplicarFiltrosButton";
            AplicarFiltrosButton.Size = new Size(122, 30);
            AplicarFiltrosButton.TabIndex = 10;
            AplicarFiltrosButton.Text = "Aplicar filtro";
            AplicarFiltrosButton.UseVisualStyleBackColor = true;
            AplicarFiltrosButton.Click += AplicarFiltrosButton_Click;
            // 
            // lblFechaSalida
            // 
            lblFechaSalida.AutoSize = true;
            lblFechaSalida.Location = new Point(7, 12);
            lblFechaSalida.Name = "lblFechaSalida";
            lblFechaSalida.Size = new Size(160, 20);
            lblFechaSalida.TabIndex = 14;
            lblFechaSalida.Text = "Filtrar por FechaSalida:";
            // 
            // AñadirAlItinerarioVuelosButton
            // 
            AñadirAlItinerarioVuelosButton.Location = new Point(176, 301);
            AñadirAlItinerarioVuelosButton.Margin = new Padding(3, 4, 3, 4);
            AñadirAlItinerarioVuelosButton.Name = "AñadirAlItinerarioVuelosButton";
            AñadirAlItinerarioVuelosButton.Size = new Size(155, 39);
            AñadirAlItinerarioVuelosButton.TabIndex = 15;
            AñadirAlItinerarioVuelosButton.Text = "Añadir a itinerario";
            AñadirAlItinerarioVuelosButton.UseVisualStyleBackColor = true;
            // 
            // VuelosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 715);
            Controls.Add(AñadirAlItinerarioVuelosButton);
            Controls.Add(lblFechaSalida);
            Controls.Add(AplicarFiltrosButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(MasInformacionGrp);
            Controls.Add(InformacionVueloButton);
            Controls.Add(grpVuelo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VuelosForm";
            Text = "FormVuelos";
            Load += Form1_Load;
            grpVuelo.ResumeLayout(false);
            MasInformacionGrp.ResumeLayout(false);
            MasInformacionGrp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox grpVuelo;
        private ListView VuelosListView;
        private ColumnHeader CodigoVueloHeader;
        private ColumnHeader OrigenVueloHeader;
        private ColumnHeader DestinoVueloHeader;
        private ColumnHeader FechaSalidaVueloHeader;
        private ColumnHeader FechaArriboVueloHeader;
        private ColumnHeader TiempoVueloHeader;
        private ColumnHeader CodigoAerolineaVueloHeader;
        private Button InformacionVueloButton;
        private GroupBox MasInformacionGrp;
        private Label lblServiciosExtra;
        private Label lblTarifas;
        private Label lblParadas;
        private ListView ServiciosExtraListView;
        private ListView TarifasListView;
        private ListView ParadasListView;
        private DateTimePicker dateTimePicker1;
        private Button AplicarFiltrosButton;
        private Label lblFechaSalida;
        private ColumnHeader AeropuertoParadaHeader;
        private ColumnHeader TiempoParadaHeader;
        private ColumnHeader ClaseTarifaHeader;
        private ColumnHeader ItinerarioTarifaHeader;
        private ColumnHeader TipoPasajeroTarifaHeader;
        private ColumnHeader BaseTarifaHeader;
        private ColumnHeader ImpuestosTarifaHeader;
        private ColumnHeader ComisionTarifaHeader;
        private ColumnHeader DisponibilidadTarifaHeader;
        private ColumnHeader CodigoServicioHeader;
        private ColumnHeader DescripcionServicioHeader;
        private ColumnHeader TarifaServicioHeader;
        private Button AñadirAlItinerarioVuelosButton;
    }
}