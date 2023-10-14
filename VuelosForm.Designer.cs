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
            ClaseTarifaVueloHeader = new ColumnHeader();
            ItinerarioVueloHeader = new ColumnHeader();
            TipoPasajeroHeader = new ColumnHeader();
            BaseVueloHeader = new ColumnHeader();
            ImpuestoVueloHeader = new ColumnHeader();
            ComisionVueloHeader = new ColumnHeader();
            DisponibilidadVueloHeader = new ColumnHeader();
            VerMasInformacionVueloButton = new Button();
            InformacionAdicionalVuelosGroupBox = new GroupBox();
            AñadirServicioExtraButton = new Button();
            label5 = new Label();
            lblServiciosExtra = new Label();
            lblParadas = new Label();
            ServiciosExtraListView = new ListView();
            CodigoServicioHeader = new ColumnHeader();
            DescripcionServicioHeader = new ColumnHeader();
            TarifaServicioHeader = new ColumnHeader();
            ParadasVueloListView = new ListView();
            AeropuertoParadaHeader = new ColumnHeader();
            TiempoParadaHeader = new ColumnHeader();
            dateTimePicker1 = new DateTimePicker();
            BuscarVuelosButton = new Button();
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
            VuelosDisponiblesGroupBox.Size = new Size(1206, 275);
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
            AñadirAlItinerarioVueloButton.Location = new Point(173, 225);
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
            VuelosListView.Columns.AddRange(new ColumnHeader[] { CodigoVueloHeader, OrigenVueloHeader, DestinoVueloHeader, FechaSalidaVueloHeader, FechaArriboVueloHeader, TiempoVueloHeader, CodigoAerolineaVueloHeader, ClaseTarifaVueloHeader, ItinerarioVueloHeader, TipoPasajeroHeader, BaseVueloHeader, ImpuestoVueloHeader, ComisionVueloHeader, DisponibilidadVueloHeader });
            VuelosListView.FullRowSelect = true;
            VuelosListView.GridLines = true;
            VuelosListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            VuelosListView.LabelWrap = false;
            VuelosListView.Location = new Point(14, 46);
            VuelosListView.Margin = new Padding(3, 4, 3, 4);
            VuelosListView.MultiSelect = false;
            VuelosListView.Name = "VuelosListView";
            VuelosListView.Size = new Size(1176, 171);
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
            OrigenVueloHeader.Width = 120;
            // 
            // DestinoVueloHeader
            // 
            DestinoVueloHeader.Text = "Destino";
            DestinoVueloHeader.TextAlign = HorizontalAlignment.Center;
            DestinoVueloHeader.Width = 120;
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
            // ItinerarioVueloHeader
            // 
            ItinerarioVueloHeader.Text = "Itinerario";
            ItinerarioVueloHeader.TextAlign = HorizontalAlignment.Center;
            ItinerarioVueloHeader.Width = 100;
            // 
            // TipoPasajeroHeader
            // 
            TipoPasajeroHeader.Text = "Tipo Pasajero";
            TipoPasajeroHeader.TextAlign = HorizontalAlignment.Center;
            TipoPasajeroHeader.Width = 120;
            // 
            // BaseVueloHeader
            // 
            BaseVueloHeader.Text = "Base";
            BaseVueloHeader.TextAlign = HorizontalAlignment.Center;
            BaseVueloHeader.Width = 100;
            // 
            // ImpuestoVueloHeader
            // 
            ImpuestoVueloHeader.Text = "Impuesto";
            ImpuestoVueloHeader.TextAlign = HorizontalAlignment.Center;
            ImpuestoVueloHeader.Width = 100;
            // 
            // ComisionVueloHeader
            // 
            ComisionVueloHeader.Text = "Comision";
            ComisionVueloHeader.TextAlign = HorizontalAlignment.Center;
            ComisionVueloHeader.Width = 100;
            // 
            // DisponibilidadVueloHeader
            // 
            DisponibilidadVueloHeader.Text = "Disponibilidad";
            DisponibilidadVueloHeader.TextAlign = HorizontalAlignment.Center;
            DisponibilidadVueloHeader.Width = 120;
            // 
            // VerMasInformacionVueloButton
            // 
            VerMasInformacionVueloButton.Location = new Point(12, 225);
            VerMasInformacionVueloButton.Name = "VerMasInformacionVueloButton";
            VerMasInformacionVueloButton.Size = new Size(155, 40);
            VerMasInformacionVueloButton.TabIndex = 6;
            VerMasInformacionVueloButton.Text = "Ver más información";
            VerMasInformacionVueloButton.UseVisualStyleBackColor = true;
            VerMasInformacionVueloButton.Click += InformacionVueloButton_Click;
            // 
            // InformacionAdicionalVuelosGroupBox
            // 
            InformacionAdicionalVuelosGroupBox.Controls.Add(AñadirServicioExtraButton);
            InformacionAdicionalVuelosGroupBox.Controls.Add(label5);
            InformacionAdicionalVuelosGroupBox.Controls.Add(lblServiciosExtra);
            InformacionAdicionalVuelosGroupBox.Controls.Add(lblParadas);
            InformacionAdicionalVuelosGroupBox.Controls.Add(ServiciosExtraListView);
            InformacionAdicionalVuelosGroupBox.Controls.Add(ParadasVueloListView);
            InformacionAdicionalVuelosGroupBox.Location = new Point(14, 403);
            InformacionAdicionalVuelosGroupBox.Margin = new Padding(3, 4, 3, 4);
            InformacionAdicionalVuelosGroupBox.Name = "InformacionAdicionalVuelosGroupBox";
            InformacionAdicionalVuelosGroupBox.Padding = new Padding(3, 4, 3, 4);
            InformacionAdicionalVuelosGroupBox.Size = new Size(1206, 254);
            InformacionAdicionalVuelosGroupBox.TabIndex = 7;
            InformacionAdicionalVuelosGroupBox.TabStop = false;
            // 
            // AñadirServicioExtraButton
            // 
            AñadirServicioExtraButton.Location = new Point(375, 193);
            AñadirServicioExtraButton.Margin = new Padding(3, 4, 3, 4);
            AñadirServicioExtraButton.Name = "AñadirServicioExtraButton";
            AñadirServicioExtraButton.Size = new Size(155, 39);
            AñadirServicioExtraButton.TabIndex = 21;
            AñadirServicioExtraButton.Text = "Agregar servicio";
            AñadirServicioExtraButton.UseVisualStyleBackColor = true;
            AñadirServicioExtraButton.Click += AñadirServicioExtraButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 16);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 21;
            label5.Text = "Información adicional";
            // 
            // lblServiciosExtra
            // 
            lblServiciosExtra.AutoSize = true;
            lblServiciosExtra.Location = new Point(375, 51);
            lblServiciosExtra.Name = "lblServiciosExtra";
            lblServiciosExtra.Size = new Size(104, 20);
            lblServiciosExtra.TabIndex = 5;
            lblServiciosExtra.Text = "Servicios extra";
            // 
            // lblParadas
            // 
            lblParadas.AutoSize = true;
            lblParadas.Location = new Point(11, 51);
            lblParadas.Name = "lblParadas";
            lblParadas.Size = new Size(60, 20);
            lblParadas.TabIndex = 3;
            lblParadas.Text = "Paradas";
            // 
            // ServiciosExtraListView
            // 
            ServiciosExtraListView.Columns.AddRange(new ColumnHeader[] { CodigoServicioHeader, DescripcionServicioHeader, TarifaServicioHeader });
            ServiciosExtraListView.FullRowSelect = true;
            ServiciosExtraListView.GridLines = true;
            ServiciosExtraListView.Location = new Point(375, 81);
            ServiciosExtraListView.Margin = new Padding(3, 4, 3, 4);
            ServiciosExtraListView.Name = "ServiciosExtraListView";
            ServiciosExtraListView.Size = new Size(567, 100);
            ServiciosExtraListView.TabIndex = 2;
            ServiciosExtraListView.UseCompatibleStateImageBehavior = false;
            ServiciosExtraListView.View = View.Details;
            ServiciosExtraListView.SelectedIndexChanged += ServiciosExtraListView_SelectedIndexChanged;
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
            DescripcionServicioHeader.Width = 250;
            // 
            // TarifaServicioHeader
            // 
            TarifaServicioHeader.Text = "Tarifa servicio";
            TarifaServicioHeader.TextAlign = HorizontalAlignment.Center;
            TarifaServicioHeader.Width = 150;
            // 
            // ParadasVueloListView
            // 
            ParadasVueloListView.Columns.AddRange(new ColumnHeader[] { AeropuertoParadaHeader, TiempoParadaHeader });
            ParadasVueloListView.GridLines = true;
            ParadasVueloListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ParadasVueloListView.LabelWrap = false;
            ParadasVueloListView.Location = new Point(14, 81);
            ParadasVueloListView.Margin = new Padding(3, 4, 3, 4);
            ParadasVueloListView.Name = "ParadasVueloListView";
            ParadasVueloListView.Size = new Size(337, 151);
            ParadasVueloListView.TabIndex = 0;
            ParadasVueloListView.UseCompatibleStateImageBehavior = false;
            ParadasVueloListView.View = View.Details;
            // 
            // AeropuertoParadaHeader
            // 
            AeropuertoParadaHeader.Text = "Aeropuerto de parada";
            AeropuertoParadaHeader.Width = 180;
            // 
            // TiempoParadaHeader
            // 
            TiempoParadaHeader.Text = "Tiempo de parada";
            TiempoParadaHeader.TextAlign = HorizontalAlignment.Center;
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
            // BuscarVuelosButton
            // 
            BuscarVuelosButton.Location = new Point(625, 72);
            BuscarVuelosButton.Name = "BuscarVuelosButton";
            BuscarVuelosButton.Size = new Size(122, 30);
            BuscarVuelosButton.TabIndex = 10;
            BuscarVuelosButton.Text = "Buscar vuelos";
            BuscarVuelosButton.UseVisualStyleBackColor = true;
            BuscarVuelosButton.Click += AplicarFiltrosButton_Click;
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
            groupBox1.Controls.Add(BuscarVuelosButton);
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
            ClientSize = new Size(1232, 670);
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
        private Label lblParadas;
        private ListView ServiciosExtraListView;
        private ListView ParadasVueloListView;
        private DateTimePicker dateTimePicker1;
        private Button BuscarVuelosButton;
        private Label lblFechaSalida;
        private ColumnHeader AeropuertoParadaHeader;
        private ColumnHeader TiempoParadaHeader;
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
        private ColumnHeader ClaseTarifaVueloHeader;
        private ColumnHeader ItinerarioVueloHeader;
        private ColumnHeader TipoPasajeroHeader;
        private ColumnHeader BaseVueloHeader;
        private ColumnHeader ImpuestoVueloHeader;
        private ColumnHeader ComisionVueloHeader;
        private ColumnHeader DisponibilidadVueloHeader;
        private Label label5;
        private Button AñadirServicioExtraButton;
    }
}