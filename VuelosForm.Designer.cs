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
            grpVuelo.SuspendLayout();
            MasInformacionGrp.SuspendLayout();
            SuspendLayout();
            // 
            // grpVuelo
            // 
            grpVuelo.Controls.Add(VuelosListView);
            grpVuelo.Location = new Point(6, 37);
            grpVuelo.Name = "grpVuelo";
            grpVuelo.Size = new Size(1049, 184);
            grpVuelo.TabIndex = 4;
            grpVuelo.TabStop = false;
            grpVuelo.Text = "Seleccione un vuelo disponible:";
            // 
            // VuelosListView
            // 
            VuelosListView.Columns.AddRange(new ColumnHeader[] { CodigoVueloHeader, OrigenVueloHeader, DestinoVueloHeader, FechaSalidaVueloHeader, FechaArriboVueloHeader, TiempoVueloHeader, CodigoAerolineaVueloHeader });
            VuelosListView.FullRowSelect = true;
            VuelosListView.Location = new Point(6, 20);
            VuelosListView.MultiSelect = false;
            VuelosListView.Name = "VuelosListView";
            VuelosListView.Size = new Size(1023, 158);
            VuelosListView.TabIndex = 0;
            VuelosListView.UseCompatibleStateImageBehavior = false;
            VuelosListView.View = View.Details;
            // 
            // CodigoVueloHeader
            // 
            CodigoVueloHeader.Text = "CodigoVuelo";
            CodigoVueloHeader.Width = 120;
            // 
            // OrigenVueloHeader
            // 
            OrigenVueloHeader.Text = "OrigenVuelo";
            OrigenVueloHeader.Width = 120;
            // 
            // DestinoVueloHeader
            // 
            DestinoVueloHeader.Text = "DestinoVuelo";
            DestinoVueloHeader.Width = 120;
            // 
            // FechaSalidaVueloHeader
            // 
            FechaSalidaVueloHeader.Text = "FechaSalida(mes/dia/año/hora)";
            FechaSalidaVueloHeader.Width = 250;
            // 
            // FechaArriboVueloHeader
            // 
            FechaArriboVueloHeader.Text = "FechaArribo(mes/dia/año/hora)";
            FechaArriboVueloHeader.Width = 250;
            // 
            // TiempoVueloHeader
            // 
            TiempoVueloHeader.Text = "Tiempo";
            TiempoVueloHeader.Width = 100;
            // 
            // CodigoAerolineaVueloHeader
            // 
            CodigoAerolineaVueloHeader.Text = "CodigoAerolinea";
            CodigoAerolineaVueloHeader.Width = 200;
            // 
            // InformacionVueloButton
            // 
            InformacionVueloButton.Location = new Point(12, 226);
            InformacionVueloButton.Margin = new Padding(3, 2, 3, 2);
            InformacionVueloButton.Name = "InformacionVueloButton";
            InformacionVueloButton.Size = new Size(168, 22);
            InformacionVueloButton.TabIndex = 6;
            InformacionVueloButton.Text = "Ver información del vuelo";
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
            MasInformacionGrp.Location = new Point(6, 261);
            MasInformacionGrp.Name = "MasInformacionGrp";
            MasInformacionGrp.Size = new Size(1049, 260);
            MasInformacionGrp.TabIndex = 7;
            MasInformacionGrp.TabStop = false;
            MasInformacionGrp.Text = "Más información:";
            // 
            // lblServiciosExtra
            // 
            lblServiciosExtra.AutoSize = true;
            lblServiciosExtra.Location = new Point(349, 27);
            lblServiciosExtra.Name = "lblServiciosExtra";
            lblServiciosExtra.Size = new Size(85, 15);
            lblServiciosExtra.TabIndex = 5;
            lblServiciosExtra.Text = "Servicios extra:";
            // 
            // lblTarifas
            // 
            lblTarifas.AutoSize = true;
            lblTarifas.Location = new Point(12, 124);
            lblTarifas.Name = "lblTarifas";
            lblTarifas.Size = new Size(43, 15);
            lblTarifas.TabIndex = 4;
            lblTarifas.Text = "Tarifas:";
            // 
            // lblParadas
            // 
            lblParadas.AutoSize = true;
            lblParadas.Location = new Point(12, 27);
            lblParadas.Name = "lblParadas";
            lblParadas.Size = new Size(51, 15);
            lblParadas.TabIndex = 3;
            lblParadas.Text = "Paradas:";
            // 
            // ServiciosExtraListView
            // 
            ServiciosExtraListView.Columns.AddRange(new ColumnHeader[] { CodigoServicioHeader, DescripcionServicioHeader, TarifaServicioHeader });
            ServiciosExtraListView.Location = new Point(349, 45);
            ServiciosExtraListView.Name = "ServiciosExtraListView";
            ServiciosExtraListView.Size = new Size(370, 66);
            ServiciosExtraListView.TabIndex = 2;
            ServiciosExtraListView.UseCompatibleStateImageBehavior = false;
            ServiciosExtraListView.View = View.Details;
            // 
            // CodigoServicioHeader
            // 
            CodigoServicioHeader.Text = "CodigoServicio";
            CodigoServicioHeader.Width = 100;
            // 
            // DescripcionServicioHeader
            // 
            DescripcionServicioHeader.Text = "DescripcionServicio";
            DescripcionServicioHeader.Width = 120;
            // 
            // TarifaServicioHeader
            // 
            TarifaServicioHeader.Text = "TarifaServicio";
            TarifaServicioHeader.TextAlign = HorizontalAlignment.Center;
            TarifaServicioHeader.Width = 100;
            // 
            // TarifasListView
            // 
            TarifasListView.Columns.AddRange(new ColumnHeader[] { ClaseTarifaHeader, ItinerarioTarifaHeader, TipoPasajeroTarifaHeader, BaseTarifaHeader, ImpuestosTarifaHeader, ComisionTarifaHeader, DisponibilidadTarifaHeader });
            TarifasListView.Location = new Point(12, 151);
            TarifasListView.Name = "TarifasListView";
            TarifasListView.Size = new Size(707, 79);
            TarifasListView.TabIndex = 1;
            TarifasListView.UseCompatibleStateImageBehavior = false;
            TarifasListView.View = View.Details;
            // 
            // ClaseTarifaHeader
            // 
            ClaseTarifaHeader.Text = "ClaseTarifa";
            ClaseTarifaHeader.Width = 80;
            // 
            // ItinerarioTarifaHeader
            // 
            ItinerarioTarifaHeader.Text = "ItinerarioTarifa";
            ItinerarioTarifaHeader.Width = 100;
            // 
            // TipoPasajeroTarifaHeader
            // 
            TipoPasajeroTarifaHeader.Text = "TipoPasajeroTarifa";
            TipoPasajeroTarifaHeader.Width = 125;
            // 
            // BaseTarifaHeader
            // 
            BaseTarifaHeader.Text = "BaseTarifa";
            BaseTarifaHeader.Width = 80;
            // 
            // ImpuestosTarifaHeader
            // 
            ImpuestosTarifaHeader.Text = "ImpuestoTarifa";
            ImpuestosTarifaHeader.Width = 100;
            // 
            // ComisionTarifaHeader
            // 
            ComisionTarifaHeader.Text = "ComisionTarifa";
            ComisionTarifaHeader.Width = 100;
            // 
            // DisponibilidadTarifaHeader
            // 
            DisponibilidadTarifaHeader.Text = "DisponibilidadTarifa";
            DisponibilidadTarifaHeader.Width = 120;
            // 
            // ParadasListView
            // 
            ParadasListView.Columns.AddRange(new ColumnHeader[] { AeropuertoParadaHeader, TiempoParadaHeader });
            ParadasListView.Location = new Point(12, 45);
            ParadasListView.Name = "ParadasListView";
            ParadasListView.Size = new Size(244, 66);
            ParadasListView.TabIndex = 0;
            ParadasListView.UseCompatibleStateImageBehavior = false;
            ParadasListView.View = View.Details;
            // 
            // AeropuertoParadaHeader
            // 
            AeropuertoParadaHeader.Text = "AeropuertoParada";
            AeropuertoParadaHeader.Width = 150;
            // 
            // TiempoParadaHeader
            // 
            TiempoParadaHeader.Text = "TiempoParada";
            TiempoParadaHeader.Width = 150;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(138, 9);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(255, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // AplicarFiltrosButton
            // 
            AplicarFiltrosButton.Location = new Point(413, 9);
            AplicarFiltrosButton.Margin = new Padding(3, 2, 3, 2);
            AplicarFiltrosButton.Name = "AplicarFiltrosButton";
            AplicarFiltrosButton.Size = new Size(102, 27);
            AplicarFiltrosButton.TabIndex = 10;
            AplicarFiltrosButton.Text = "Aplicar filtro";
            AplicarFiltrosButton.UseVisualStyleBackColor = true;
            AplicarFiltrosButton.Click += AplicarFiltrosButton_Click;
            // 
            // lblFechaSalida
            // 
            lblFechaSalida.AutoSize = true;
            lblFechaSalida.Location = new Point(6, 9);
            lblFechaSalida.Name = "lblFechaSalida";
            lblFechaSalida.Size = new Size(126, 15);
            lblFechaSalida.TabIndex = 14;
            lblFechaSalida.Text = "Filtrar por FechaSalida:";
            // 
            // VuelosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 536);
            Controls.Add(lblFechaSalida);
            Controls.Add(AplicarFiltrosButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(MasInformacionGrp);
            Controls.Add(InformacionVueloButton);
            Controls.Add(grpVuelo);
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
    }
}