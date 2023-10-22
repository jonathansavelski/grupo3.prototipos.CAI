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
            CodigoOrigenVueloHeader = new ColumnHeader();
            CodigoDestinoVueloHeader = new ColumnHeader();
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
            label5 = new Label();
            lblParadas = new Label();
            ParadasVueloListView = new ListView();
            AeropuertoParadaHeader = new ColumnHeader();
            TiempoParadaHeader = new ColumnHeader();
            RangoDesdeVueloDateTimePicker = new DateTimePicker();
            BuscarVuelosButton = new Button();
            lblFechaSalida = new Label();
            groupBox1 = new GroupBox();
            label10 = new Label();
            TipoPasajeroVueloComboBox = new ComboBox();
            RangoHastaVueloDateTimePicker = new DateTimePicker();
            label3 = new Label();
            CiudadDestinoVueloTextBox = new TextBox();
            label2 = new Label();
            CiudadOrigenVueloTextBox = new TextBox();
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
            VuelosListView.Columns.AddRange(new ColumnHeader[] { CodigoVueloHeader, CodigoOrigenVueloHeader, CodigoDestinoVueloHeader, FechaSalidaVueloHeader, FechaArriboVueloHeader, TiempoVueloHeader, CodigoAerolineaVueloHeader, ClaseTarifaVueloHeader, ItinerarioVueloHeader, TipoPasajeroHeader, BaseVueloHeader, ImpuestoVueloHeader, ComisionVueloHeader, DisponibilidadVueloHeader });
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
            InformacionAdicionalVuelosGroupBox.Controls.Add(label5);
            InformacionAdicionalVuelosGroupBox.Controls.Add(lblParadas);
            InformacionAdicionalVuelosGroupBox.Controls.Add(ParadasVueloListView);
            InformacionAdicionalVuelosGroupBox.Location = new Point(14, 403);
            InformacionAdicionalVuelosGroupBox.Margin = new Padding(3, 4, 3, 4);
            InformacionAdicionalVuelosGroupBox.Name = "InformacionAdicionalVuelosGroupBox";
            InformacionAdicionalVuelosGroupBox.Padding = new Padding(3, 4, 3, 4);
            InformacionAdicionalVuelosGroupBox.Size = new Size(1206, 254);
            InformacionAdicionalVuelosGroupBox.TabIndex = 7;
            InformacionAdicionalVuelosGroupBox.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 21);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 21;
            label5.Text = "Información adicional";
            label5.Click += label5_Click;
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
            // RangoDesdeVueloDateTimePicker
            // 
            RangoDesdeVueloDateTimePicker.Format = DateTimePickerFormat.Short;
            RangoDesdeVueloDateTimePicker.Location = new Point(337, 75);
            RangoDesdeVueloDateTimePicker.Name = "RangoDesdeVueloDateTimePicker";
            RangoDesdeVueloDateTimePicker.Size = new Size(121, 27);
            RangoDesdeVueloDateTimePicker.TabIndex = 8;
            // 
            // BuscarVuelosButton
            // 
            BuscarVuelosButton.Location = new Point(795, 63);
            BuscarVuelosButton.Name = "BuscarVuelosButton";
            BuscarVuelosButton.Size = new Size(155, 39);
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
            lblFechaSalida.Size = new Size(121, 20);
            lblFechaSalida.TabIndex = 14;
            lblFechaSalida.Text = "Rango de Fechas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(TipoPasajeroVueloComboBox);
            groupBox1.Controls.Add(RangoHastaVueloDateTimePicker);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(CiudadDestinoVueloTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(CiudadOrigenVueloTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BuscarVuelosButton);
            groupBox1.Controls.Add(lblFechaSalida);
            groupBox1.Controls.Add(RangoDesdeVueloDateTimePicker);
            groupBox1.Location = new Point(14, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1206, 115);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(629, 46);
            label10.Name = "label10";
            label10.Size = new Size(119, 20);
            label10.TabIndex = 43;
            label10.Text = "Tipo de Pasajero";
            // 
            // TipoPasajeroVueloComboBox
            // 
            TipoPasajeroVueloComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TipoPasajeroVueloComboBox.FormattingEnabled = true;
            TipoPasajeroVueloComboBox.Items.AddRange(new object[] { "Adulto", "Menor", "Infante" });
            TipoPasajeroVueloComboBox.Location = new Point(629, 74);
            TipoPasajeroVueloComboBox.Name = "TipoPasajeroVueloComboBox";
            TipoPasajeroVueloComboBox.Size = new Size(151, 28);
            TipoPasajeroVueloComboBox.TabIndex = 42;
            // 
            // RangoHastaVueloDateTimePicker
            // 
            RangoHastaVueloDateTimePicker.Format = DateTimePickerFormat.Short;
            RangoHastaVueloDateTimePicker.Location = new Point(476, 75);
            RangoHastaVueloDateTimePicker.Name = "RangoHastaVueloDateTimePicker";
            RangoHastaVueloDateTimePicker.Size = new Size(121, 27);
            RangoHastaVueloDateTimePicker.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 48);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 18;
            label3.Text = "Ciudad de Destino";
            // 
            // CiudadDestinoVueloTextBox
            // 
            CiudadDestinoVueloTextBox.Location = new Point(162, 75);
            CiudadDestinoVueloTextBox.Name = "CiudadDestinoVueloTextBox";
            CiudadDestinoVueloTextBox.Size = new Size(125, 27);
            CiudadDestinoVueloTextBox.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 48);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 16;
            label2.Text = "Ciudad de Origen";
            // 
            // CiudadOrigenVueloTextBox
            // 
            CiudadOrigenVueloTextBox.AutoCompleteCustomSource.AddRange(new string[] { "Brasil" });
            CiudadOrigenVueloTextBox.AutoCompleteSource = AutoCompleteSource.FileSystemDirectories;
            CiudadOrigenVueloTextBox.Location = new Point(12, 75);
            CiudadOrigenVueloTextBox.Name = "CiudadOrigenVueloTextBox";
            CiudadOrigenVueloTextBox.Size = new Size(125, 27);
            CiudadOrigenVueloTextBox.TabIndex = 15;
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
        private ColumnHeader CodigoOrigenVueloHeader;
        private ColumnHeader CodigoDestinoVueloHeader;
        private ColumnHeader FechaSalidaVueloHeader;
        private ColumnHeader FechaArriboVueloHeader;
        private ColumnHeader TiempoVueloHeader;
        private ColumnHeader CodigoAerolineaVueloHeader;
        private Button VerMasInformacionVueloButton;
        private GroupBox InformacionAdicionalVuelosGroupBox;
        private Label lblParadas;
        private ListView ParadasVueloListView;
        private DateTimePicker RangoDesdeVueloDateTimePicker;
        private Button BuscarVuelosButton;
        private Label lblFechaSalida;
        private ColumnHeader AeropuertoParadaHeader;
        private ColumnHeader TiempoParadaHeader;
        private Button AñadirAlItinerarioVueloButton;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox CiudadDestinoVueloTextBox;
        private Label label2;
        private TextBox CiudadOrigenVueloTextBox;
        private Label label1;
        private DateTimePicker RangoHastaVueloDateTimePicker;
        private Label label4;
        private ColumnHeader ClaseTarifaVueloHeader;
        private ColumnHeader ItinerarioVueloHeader;
        private ColumnHeader TipoPasajeroHeader;
        private ColumnHeader BaseVueloHeader;
        private ColumnHeader ImpuestoVueloHeader;
        private ColumnHeader ComisionVueloHeader;
        private ColumnHeader DisponibilidadVueloHeader;
        private Label label5;
        private Label label10;
        private ComboBox TipoPasajeroVueloComboBox;
    }
}