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
            VuelosDisponiblesGroupBox = new GroupBox();
            label4 = new Label();
            AñadirAlItinerarioVueloButton = new Button();
            VuelosListView = new ListView();
            CodigoVueloHeader = new ColumnHeader();
            OrigenVueloHeader = new ColumnHeader();
            DestinoVueloHeader = new ColumnHeader();
            FechaSalidaVueloHeader = new ColumnHeader();
            FechaArriboVueloHeader = new ColumnHeader();
            TiempoVueloHeader = new ColumnHeader();
            CodigoAerolineaVueloHeader = new ColumnHeader();
            VerMasInformacionVueloButton = new Button();
            InformacionAdicionalVuelosGroupBox = new GroupBox();
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
            AplicarFiltrosVuelosButton = new Button();
            lblFechaSalida = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            VuelosDisponiblesGroupBox.SuspendLayout();
            InformacionAdicionalVuelosGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // VuelosDisponiblesGroupBox
            // 
            VuelosDisponiblesGroupBox.Controls.Add(label4);
            VuelosDisponiblesGroupBox.Controls.Add(AñadirAlItinerarioVueloButton);
            VuelosDisponiblesGroupBox.Controls.Add(VuelosListView);
            VuelosDisponiblesGroupBox.Controls.Add(VerMasInformacionVueloButton);
            VuelosDisponiblesGroupBox.Location = new Point(14, 126);
            VuelosDisponiblesGroupBox.Margin = new Padding(3, 4, 3, 4);
            VuelosDisponiblesGroupBox.Name = "VuelosDisponiblesGroupBox";
            VuelosDisponiblesGroupBox.Padding = new Padding(3, 4, 3, 4);
            VuelosDisponiblesGroupBox.Size = new Size(1206, 208);
            VuelosDisponiblesGroupBox.TabIndex = 4;
            VuelosDisponiblesGroupBox.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 18);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 20;
            label4.Text = "Vuelos disponibles";
            // 
            // AñadirAlItinerarioVueloButton
            // 
            AñadirAlItinerarioVueloButton.Location = new Point(173, 159);
            AñadirAlItinerarioVueloButton.Margin = new Padding(3, 4, 3, 4);
            AñadirAlItinerarioVueloButton.Name = "AñadirAlItinerarioVueloButton";
            AñadirAlItinerarioVueloButton.Size = new Size(155, 39);
            AñadirAlItinerarioVueloButton.TabIndex = 15;
            AñadirAlItinerarioVueloButton.Text = "Añadir a itinerario";
            AñadirAlItinerarioVueloButton.UseVisualStyleBackColor = true;
            AñadirAlItinerarioVueloButton.Click += AñadirAlItinerarioVueloButton_Click;
            // 
            // VuelosListView
            // 
            VuelosListView.Columns.AddRange(new ColumnHeader[] { CodigoVueloHeader, OrigenVueloHeader, DestinoVueloHeader, FechaSalidaVueloHeader, FechaArriboVueloHeader, TiempoVueloHeader, CodigoAerolineaVueloHeader });
            VuelosListView.FullRowSelect = true;
            VuelosListView.Location = new Point(14, 46);
            VuelosListView.Margin = new Padding(3, 4, 3, 4);
            VuelosListView.MultiSelect = false;
            VuelosListView.Name = "VuelosListView";
            VuelosListView.Size = new Size(1176, 104);
            VuelosListView.TabIndex = 0;
            VuelosListView.UseCompatibleStateImageBehavior = false;
            VuelosListView.View = View.Details;
            VuelosListView.SelectedIndexChanged += VuelosListView_SelectedIndexChanged;
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
            // VerMasInformacionVueloButton
            // 
            VerMasInformacionVueloButton.Location = new Point(12, 159);
            VerMasInformacionVueloButton.Name = "VerMasInformacionVueloButton";
            VerMasInformacionVueloButton.Size = new Size(155, 40);
            VerMasInformacionVueloButton.TabIndex = 6;
            VerMasInformacionVueloButton.Text = "Ver más información";
            VerMasInformacionVueloButton.UseVisualStyleBackColor = true;
            VerMasInformacionVueloButton.Click += InformacionVueloButton_Click;
            // 
            // InformacionAdicionalVuelosGroupBox
            // 
            InformacionAdicionalVuelosGroupBox.Controls.Add(lblServiciosExtra);
            InformacionAdicionalVuelosGroupBox.Controls.Add(lblTarifas);
            InformacionAdicionalVuelosGroupBox.Controls.Add(lblParadas);
            InformacionAdicionalVuelosGroupBox.Controls.Add(ServiciosExtraListView);
            InformacionAdicionalVuelosGroupBox.Controls.Add(TarifasListView);
            InformacionAdicionalVuelosGroupBox.Controls.Add(ParadasListView);
            InformacionAdicionalVuelosGroupBox.Location = new Point(7, 348);
            InformacionAdicionalVuelosGroupBox.Margin = new Padding(3, 4, 3, 4);
            InformacionAdicionalVuelosGroupBox.Name = "InformacionAdicionalVuelosGroupBox";
            InformacionAdicionalVuelosGroupBox.Padding = new Padding(3, 4, 3, 4);
            InformacionAdicionalVuelosGroupBox.Size = new Size(1213, 347);
            InformacionAdicionalVuelosGroupBox.TabIndex = 7;
            InformacionAdicionalVuelosGroupBox.TabStop = false;
            InformacionAdicionalVuelosGroupBox.Text = "Más información:";
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
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(337, 75);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // AplicarFiltrosVuelosButton
            // 
            AplicarFiltrosVuelosButton.Location = new Point(625, 72);
            AplicarFiltrosVuelosButton.Name = "AplicarFiltrosVuelosButton";
            AplicarFiltrosVuelosButton.Size = new Size(122, 30);
            AplicarFiltrosVuelosButton.TabIndex = 10;
            AplicarFiltrosVuelosButton.Text = "Aplicar filtros";
            AplicarFiltrosVuelosButton.UseVisualStyleBackColor = true;
            AplicarFiltrosVuelosButton.Click += AplicarFiltrosButton_Click;
            // 
            // lblFechaSalida
            // 
            lblFechaSalida.AutoSize = true;
            lblFechaSalida.Location = new Point(334, 46);
            lblFechaSalida.Name = "lblFechaSalida";
            lblFechaSalida.Size = new Size(124, 20);
            lblFechaSalida.TabIndex = 14;
            lblFechaSalida.Text = "Rango de Fechas:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(AplicarFiltrosVuelosButton);
            groupBox1.Controls.Add(lblFechaSalida);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Location = new Point(14, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1206, 115);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(476, 75);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(121, 27);
            dateTimePicker2.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 48);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 18;
            label3.Text = "Lugar de Destino";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 48);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 16;
            label2.Text = "Lugar de Origen";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 17);
            label1.Name = "label1";
            label1.Size = new Size(231, 20);
            label1.TabIndex = 0;
            label1.Text = "Busqueda de vuelos disponibles";
            // 
            // VuelosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 728);
            Controls.Add(groupBox1);
            Controls.Add(InformacionAdicionalVuelosGroupBox);
            Controls.Add(VuelosDisponiblesGroupBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VuelosForm";
            Text = "FormVuelos";
            Load += Form1_Load;
            VuelosDisponiblesGroupBox.ResumeLayout(false);
            VuelosDisponiblesGroupBox.PerformLayout();
            InformacionAdicionalVuelosGroupBox.ResumeLayout(false);
            InformacionAdicionalVuelosGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox VuelosDisponiblesGroupBox;
        private ListView VuelosListView;
        private ColumnHeader CodigoVueloHeader;
        private ColumnHeader OrigenVueloHeader;
        private ColumnHeader DestinoVueloHeader;
        private ColumnHeader FechaSalidaVueloHeader;
        private ColumnHeader FechaArriboVueloHeader;
        private ColumnHeader TiempoVueloHeader;
        private ColumnHeader CodigoAerolineaVueloHeader;
        private Button VerMasInformacionVueloButton;
        private GroupBox InformacionAdicionalVuelosGroupBox;
        private Label lblServiciosExtra;
        private Label lblTarifas;
        private Label lblParadas;
        private ListView ServiciosExtraListView;
        private ListView TarifasListView;
        private ListView ParadasListView;
        private DateTimePicker dateTimePicker1;
        private Button AplicarFiltrosVuelosButton;
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
        private Button AñadirAlItinerarioVueloButton;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label4;
    }
}