namespace grupo3.prototipos.CAI
{
    partial class HotelesForm
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
            grpHotel = new GroupBox();
            AñadirAlItinerarioHotelesButton = new Button();
            lblHotelesDisponibles = new Label();
            InformacionHotelesButton = new Button();
            listViewHoteles = new ListView();
            CodigoHotelHeader = new ColumnHeader();
            NombreHeader = new ColumnHeader();
            CódigoCiudadHeader = new ColumnHeader();
            DirecciónHeader = new ColumnHeader();
            CalificacionHeader = new ColumnHeader();
            NombreHabitacionHeader = new ColumnHeader();
            TarifaPorDiaHeader = new ColumnHeader();
            button1 = new Button();
            lblServiciosExtra = new Label();
            lblDisponibilidad = new Label();
            ServiciosExtraListView = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            DisponibilidadListView = new ListView();
            Nombre = new ColumnHeader();
            Tarifa = new ColumnHeader();
            Capacidad = new ColumnHeader();
            Adultos = new ColumnHeader();
            Menores = new ColumnHeader();
            Infantes = new ColumnHeader();
            CheckIn = new ColumnHeader();
            CheckOut = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            MasInformacionHotelesGrp = new GroupBox();
            AñadirServicioExtraButton = new Button();
            label1 = new Label();
            label5 = new Label();
            lblDisponibilidadHoteles = new Label();
            listView1 = new ListView();
            CodigoHeader = new ColumnHeader();
            DescripcionHeader = new ColumnHeader();
            TarifaHeader = new ColumnHeader();
            PrecioPorPasajeroHeader = new ColumnHeader();
            TarifasListView = new ListView();
            NombreHotelHeader = new ColumnHeader();
            TarifaHotelHeader = new ColumnHeader();
            CapacidadHotelHeader = new ColumnHeader();
            MaxAdultosHotelHeader = new ColumnHeader();
            MaxMenoresHotelHeader = new ColumnHeader();
            MaxInfantesHotelHeader = new ColumnHeader();
            FechaDesdeHotelHeader = new ColumnHeader();
            FechaHastaHotelHeader = new ColumnHeader();
            DisponibilidadHotelHeader = new ColumnHeader();
            FechaDesdeHeader = new ColumnHeader();
            FechaHastaHeader = new ColumnHeader();
            DisponibilidadHeader = new ColumnHeader();
            lblTituloHoteles = new Label();
            grpFiltrosHotel = new GroupBox();
            dtpFinHotel = new DateTimePicker();
            lblDestinoHotel = new Label();
            txtDestinoHotel = new TextBox();
            lblOrigenHotel = new Label();
            txtOrigenHotel = new TextBox();
            BuscarHotelButton = new Button();
            lblRangoHotel = new Label();
            dtpInicioHotel = new DateTimePicker();
            grpHotel.SuspendLayout();
            MasInformacionHotelesGrp.SuspendLayout();
            grpFiltrosHotel.SuspendLayout();
            SuspendLayout();
            // 
            // grpHotel
            // 
            grpHotel.Controls.Add(AñadirAlItinerarioHotelesButton);
            grpHotel.Controls.Add(lblHotelesDisponibles);
            grpHotel.Controls.Add(InformacionHotelesButton);
            grpHotel.Controls.Add(listViewHoteles);
            grpHotel.Location = new Point(14, 129);
            grpHotel.Margin = new Padding(3, 4, 3, 4);
            grpHotel.Name = "grpHotel";
            grpHotel.Padding = new Padding(3, 4, 3, 4);
            grpHotel.Size = new Size(1229, 319);
            grpHotel.TabIndex = 5;
            grpHotel.TabStop = false;
            // 
            // AñadirAlItinerarioHotelesButton
            // 
            AñadirAlItinerarioHotelesButton.Location = new Point(174, 260);
            AñadirAlItinerarioHotelesButton.Margin = new Padding(3, 4, 3, 4);
            AñadirAlItinerarioHotelesButton.Name = "AñadirAlItinerarioHotelesButton";
            AñadirAlItinerarioHotelesButton.Size = new Size(155, 39);
            AñadirAlItinerarioHotelesButton.TabIndex = 18;
            AñadirAlItinerarioHotelesButton.Text = "Añadir a itinerario";
            AñadirAlItinerarioHotelesButton.UseVisualStyleBackColor = true;
            // 
            // lblHotelesDisponibles
            // 
            lblHotelesDisponibles.AutoSize = true;
            lblHotelesDisponibles.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHotelesDisponibles.Location = new Point(11, 19);
            lblHotelesDisponibles.Name = "lblHotelesDisponibles";
            lblHotelesDisponibles.Size = new Size(145, 20);
            lblHotelesDisponibles.TabIndex = 21;
            lblHotelesDisponibles.Text = "Hoteles disponibles";
            // 
            // InformacionHotelesButton
            // 
            InformacionHotelesButton.Location = new Point(12, 260);
            InformacionHotelesButton.Name = "InformacionHotelesButton";
            InformacionHotelesButton.Size = new Size(155, 40);
            InformacionHotelesButton.TabIndex = 17;
            InformacionHotelesButton.Text = "Ver más información";
            InformacionHotelesButton.UseVisualStyleBackColor = true;
            InformacionHotelesButton.Click += InformacionHotelesButton_Click;
            // 
            // listViewHoteles
            // 
            listViewHoteles.Columns.AddRange(new ColumnHeader[] { CodigoHotelHeader, NombreHeader, CódigoCiudadHeader, DirecciónHeader, CalificacionHeader, NombreHabitacionHeader, TarifaPorDiaHeader });
            listViewHoteles.FullRowSelect = true;
            listViewHoteles.GridLines = true;
            listViewHoteles.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewHoteles.Location = new Point(14, 47);
            listViewHoteles.Margin = new Padding(3, 4, 3, 4);
            listViewHoteles.MultiSelect = false;
            listViewHoteles.Name = "listViewHoteles";
            listViewHoteles.Size = new Size(1198, 201);
            listViewHoteles.TabIndex = 0;
            listViewHoteles.UseCompatibleStateImageBehavior = false;
            listViewHoteles.View = View.Details;
            // 
            // CodigoHotelHeader
            // 
            CodigoHotelHeader.Text = "Código";
            CodigoHotelHeader.Width = 120;
            // 
            // NombreHeader
            // 
            NombreHeader.Text = "Nombre";
            NombreHeader.TextAlign = HorizontalAlignment.Center;
            NombreHeader.Width = 120;
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
            // button1
            // 
            button1.Location = new Point(746, 262);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 11;
            button1.Text = "Aplicar";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblServiciosExtra
            // 
            lblServiciosExtra.AutoSize = true;
            lblServiciosExtra.Location = new Point(6, 159);
            lblServiciosExtra.Name = "lblServiciosExtra";
            lblServiciosExtra.Size = new Size(85, 15);
            lblServiciosExtra.TabIndex = 5;
            lblServiciosExtra.Text = "Servicios extra:";
            // 
            // lblDisponibilidad
            // 
            lblDisponibilidad.AutoSize = true;
            lblDisponibilidad.Location = new Point(8, 30);
            lblDisponibilidad.Name = "lblDisponibilidad";
            lblDisponibilidad.Size = new Size(83, 15);
            lblDisponibilidad.TabIndex = 4;
            lblDisponibilidad.Text = "Disponibilidad";
            // 
            // ServiciosExtraListView
            // 
            ServiciosExtraListView.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            ServiciosExtraListView.Location = new Point(8, 187);
            ServiciosExtraListView.Name = "ServiciosExtraListView";
            ServiciosExtraListView.Size = new Size(712, 97);
            ServiciosExtraListView.TabIndex = 2;
            ServiciosExtraListView.UseCompatibleStateImageBehavior = false;
            ServiciosExtraListView.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Código";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Descripción";
            columnHeader8.Width = 130;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Tarifa";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Por pasajero";
            columnHeader10.Width = 80;
            // 
            // DisponibilidadListView
            // 
            DisponibilidadListView.Columns.AddRange(new ColumnHeader[] { Nombre, Tarifa, Capacidad, Adultos, Menores, Infantes, CheckIn, CheckOut, columnHeader6 });
            DisponibilidadListView.Location = new Point(8, 48);
            DisponibilidadListView.Name = "DisponibilidadListView";
            DisponibilidadListView.Size = new Size(712, 93);
            DisponibilidadListView.TabIndex = 1;
            DisponibilidadListView.UseCompatibleStateImageBehavior = false;
            DisponibilidadListView.View = View.Details;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.Width = 100;
            // 
            // Tarifa
            // 
            Tarifa.Text = "Tarifa";
            // 
            // Capacidad
            // 
            Capacidad.Text = "Capacidad";
            Capacidad.Width = 70;
            // 
            // Adultos
            // 
            Adultos.Text = "Adultos";
            // 
            // Menores
            // 
            Menores.Text = "Menores";
            // 
            // Infantes
            // 
            Infantes.Text = "Infantes";
            // 
            // CheckIn
            // 
            CheckIn.Text = "Check in";
            CheckIn.Width = 95;
            // 
            // CheckOut
            // 
            CheckOut.Text = "Check out";
            CheckOut.Width = 95;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Disponibilidad";
            columnHeader6.Width = 90;
            // 
            // MasInformacionHotelesGrp
            // 
            MasInformacionHotelesGrp.Controls.Add(AñadirServicioExtraButton);
            MasInformacionHotelesGrp.Controls.Add(label1);
            MasInformacionHotelesGrp.Controls.Add(label5);
            MasInformacionHotelesGrp.Controls.Add(lblDisponibilidadHoteles);
            MasInformacionHotelesGrp.Controls.Add(listView1);
            MasInformacionHotelesGrp.Controls.Add(TarifasListView);
            MasInformacionHotelesGrp.Location = new Point(14, 453);
            MasInformacionHotelesGrp.Margin = new Padding(3, 4, 3, 4);
            MasInformacionHotelesGrp.Name = "MasInformacionHotelesGrp";
            MasInformacionHotelesGrp.Padding = new Padding(3, 4, 3, 4);
            MasInformacionHotelesGrp.Size = new Size(1229, 245);
            MasInformacionHotelesGrp.TabIndex = 20;
            MasInformacionHotelesGrp.TabStop = false;
            // 
            // AñadirServicioExtraButton
            // 
            AñadirServicioExtraButton.Location = new Point(755, 198);
            AñadirServicioExtraButton.Margin = new Padding(3, 4, 3, 4);
            AñadirServicioExtraButton.Name = "AñadirServicioExtraButton";
            AñadirServicioExtraButton.Size = new Size(155, 39);
            AñadirServicioExtraButton.TabIndex = 25;
            AñadirServicioExtraButton.Text = "Agregar servicio";
            AñadirServicioExtraButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(752, 52);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 24;
            label1.Text = "Servicios extra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 23);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 23;
            label5.Text = "Información adicional";
            // 
            // lblDisponibilidadHoteles
            // 
            lblDisponibilidadHoteles.AutoSize = true;
            lblDisponibilidadHoteles.Location = new Point(12, 53);
            lblDisponibilidadHoteles.Name = "lblDisponibilidadHoteles";
            lblDisponibilidadHoteles.Size = new Size(107, 20);
            lblDisponibilidadHoteles.TabIndex = 4;
            lblDisponibilidadHoteles.Text = "Disponibilidad";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { CodigoHeader, DescripcionHeader, TarifaHeader, PrecioPorPasajeroHeader });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(755, 86);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(457, 104);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // CodigoHeader
            // 
            CodigoHeader.Text = "Código";
            CodigoHeader.Width = 100;
            // 
            // DescripcionHeader
            // 
            DescripcionHeader.Text = "Descripción";
            DescripcionHeader.TextAlign = HorizontalAlignment.Center;
            DescripcionHeader.Width = 100;
            // 
            // TarifaHeader
            // 
            TarifaHeader.Text = "Tarifa";
            TarifaHeader.TextAlign = HorizontalAlignment.Center;
            TarifaHeader.Width = 100;
            // 
            // PrecioPorPasajeroHeader
            // 
            PrecioPorPasajeroHeader.Text = "Precio Por Pasajero";
            PrecioPorPasajeroHeader.TextAlign = HorizontalAlignment.Center;
            PrecioPorPasajeroHeader.Width = 150;
            // 
            // TarifasListView
            // 
            TarifasListView.Columns.AddRange(new ColumnHeader[] { NombreHotelHeader, TarifaHotelHeader, CapacidadHotelHeader, MaxAdultosHotelHeader, MaxMenoresHotelHeader, MaxInfantesHotelHeader, FechaDesdeHotelHeader, FechaHastaHotelHeader, DisponibilidadHotelHeader });
            TarifasListView.GridLines = true;
            TarifasListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            TarifasListView.Location = new Point(14, 86);
            TarifasListView.Margin = new Padding(3, 4, 3, 4);
            TarifasListView.Name = "TarifasListView";
            TarifasListView.Size = new Size(720, 151);
            TarifasListView.TabIndex = 1;
            TarifasListView.UseCompatibleStateImageBehavior = false;
            TarifasListView.View = View.Details;
            // 
            // NombreHotelHeader
            // 
            NombreHotelHeader.Text = "Nombre";
            NombreHotelHeader.Width = 100;
            // 
            // TarifaHotelHeader
            // 
            TarifaHotelHeader.Text = "Tarifa";
            TarifaHotelHeader.TextAlign = HorizontalAlignment.Center;
            TarifaHotelHeader.Width = 100;
            // 
            // CapacidadHotelHeader
            // 
            CapacidadHotelHeader.Text = "Capacidad";
            CapacidadHotelHeader.TextAlign = HorizontalAlignment.Center;
            CapacidadHotelHeader.Width = 100;
            // 
            // MaxAdultosHotelHeader
            // 
            MaxAdultosHotelHeader.Text = "Max. Adultos";
            MaxAdultosHotelHeader.Width = 100;
            // 
            // MaxMenoresHotelHeader
            // 
            MaxMenoresHotelHeader.Text = "Max. Menores";
            MaxMenoresHotelHeader.TextAlign = HorizontalAlignment.Center;
            MaxMenoresHotelHeader.Width = 110;
            // 
            // MaxInfantesHotelHeader
            // 
            MaxInfantesHotelHeader.Text = "Max. Infantes";
            MaxInfantesHotelHeader.Width = 100;
            // 
            // FechaDesdeHotelHeader
            // 
            FechaDesdeHotelHeader.Text = "Fecha desde";
            FechaDesdeHotelHeader.Width = 100;
            // 
            // FechaHastaHotelHeader
            // 
            FechaHastaHotelHeader.Text = "Fecha hasta";
            FechaHastaHotelHeader.TextAlign = HorizontalAlignment.Center;
            FechaHastaHotelHeader.Width = 100;
            // 
            // DisponibilidadHotelHeader
            // 
            DisponibilidadHotelHeader.Text = "Disponibilidad";
            DisponibilidadHotelHeader.TextAlign = HorizontalAlignment.Center;
            DisponibilidadHotelHeader.Width = 110;
            // 
            // FechaDesdeHeader
            // 
            FechaDesdeHeader.Text = "Fecha Desde";
            FechaDesdeHeader.TextAlign = HorizontalAlignment.Center;
            FechaDesdeHeader.Width = 120;
            // 
            // FechaHastaHeader
            // 
            FechaHastaHeader.Text = "Fecha Hasta";
            FechaHastaHeader.TextAlign = HorizontalAlignment.Center;
            FechaHastaHeader.Width = 120;
            // 
            // DisponibilidadHeader
            // 
            DisponibilidadHeader.Text = "Disponibilidad";
            DisponibilidadHeader.TextAlign = HorizontalAlignment.Center;
            DisponibilidadHeader.Width = 120;
            // 
            // lblTituloHoteles
            // 
            lblTituloHoteles.AutoSize = true;
            lblTituloHoteles.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloHoteles.Location = new Point(7, 18);
            lblTituloHoteles.Name = "lblTituloHoteles";
            lblTituloHoteles.Size = new Size(237, 20);
            lblTituloHoteles.TabIndex = 1;
            lblTituloHoteles.Text = "Búsqueda de hoteles disponibles";
            // 
            // grpFiltrosHotel
            // 
            grpFiltrosHotel.Controls.Add(dtpFinHotel);
            grpFiltrosHotel.Controls.Add(lblDestinoHotel);
            grpFiltrosHotel.Controls.Add(txtDestinoHotel);
            grpFiltrosHotel.Controls.Add(lblOrigenHotel);
            grpFiltrosHotel.Controls.Add(txtOrigenHotel);
            grpFiltrosHotel.Controls.Add(BuscarHotelButton);
            grpFiltrosHotel.Controls.Add(lblRangoHotel);
            grpFiltrosHotel.Controls.Add(dtpInicioHotel);
            grpFiltrosHotel.Controls.Add(lblTituloHoteles);
            grpFiltrosHotel.Location = new Point(14, 1);
            grpFiltrosHotel.Margin = new Padding(3, 4, 3, 4);
            grpFiltrosHotel.Name = "grpFiltrosHotel";
            grpFiltrosHotel.Padding = new Padding(3, 4, 3, 4);
            grpFiltrosHotel.Size = new Size(1229, 129);
            grpFiltrosHotel.TabIndex = 22;
            grpFiltrosHotel.TabStop = false;
            // 
            // dtpFinHotel
            // 
            dtpFinHotel.Format = DateTimePickerFormat.Short;
            dtpFinHotel.Location = new Point(477, 76);
            dtpFinHotel.Name = "dtpFinHotel";
            dtpFinHotel.Size = new Size(121, 27);
            dtpFinHotel.TabIndex = 27;
            // 
            // lblDestinoHotel
            // 
            lblDestinoHotel.AutoSize = true;
            lblDestinoHotel.Location = new Point(161, 49);
            lblDestinoHotel.Name = "lblDestinoHotel";
            lblDestinoHotel.Size = new Size(122, 20);
            lblDestinoHotel.TabIndex = 26;
            lblDestinoHotel.Text = "Lugar de Destino";
            // 
            // txtDestinoHotel
            // 
            txtDestinoHotel.Location = new Point(163, 76);
            txtDestinoHotel.Name = "txtDestinoHotel";
            txtDestinoHotel.Size = new Size(125, 27);
            txtDestinoHotel.TabIndex = 25;
            // 
            // lblOrigenHotel
            // 
            lblOrigenHotel.AutoSize = true;
            lblOrigenHotel.Location = new Point(10, 49);
            lblOrigenHotel.Name = "lblOrigenHotel";
            lblOrigenHotel.Size = new Size(116, 20);
            lblOrigenHotel.TabIndex = 24;
            lblOrigenHotel.Text = "Lugar de Origen";
            // 
            // txtOrigenHotel
            // 
            txtOrigenHotel.Location = new Point(13, 76);
            txtOrigenHotel.Name = "txtOrigenHotel";
            txtOrigenHotel.Size = new Size(125, 27);
            txtOrigenHotel.TabIndex = 23;
            // 
            // BuscarHotelButton
            // 
            BuscarHotelButton.Location = new Point(626, 74);
            BuscarHotelButton.Name = "BuscarHotelButton";
            BuscarHotelButton.Size = new Size(122, 29);
            BuscarHotelButton.TabIndex = 21;
            BuscarHotelButton.Text = "Buscar hoteles";
            BuscarHotelButton.UseVisualStyleBackColor = true;
            BuscarHotelButton.Click += AplicarFiltrosHotelButton_Click;
            // 
            // lblRangoHotel
            // 
            lblRangoHotel.AutoSize = true;
            lblRangoHotel.Location = new Point(335, 47);
            lblRangoHotel.Name = "lblRangoHotel";
            lblRangoHotel.Size = new Size(124, 20);
            lblRangoHotel.TabIndex = 22;
            lblRangoHotel.Text = "Rango de Fechas:";
            // 
            // dtpInicioHotel
            // 
            dtpInicioHotel.Format = DateTimePickerFormat.Short;
            dtpInicioHotel.Location = new Point(338, 76);
            dtpInicioHotel.Name = "dtpInicioHotel";
            dtpInicioHotel.Size = new Size(121, 27);
            dtpInicioHotel.TabIndex = 20;
            // 
            // HotelesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 713);
            Controls.Add(grpFiltrosHotel);
            Controls.Add(MasInformacionHotelesGrp);
            Controls.Add(grpHotel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HotelesForm";
            Text = "HotelesForm";
            Load += HotelesForm_Load;
            grpHotel.ResumeLayout(false);
            grpHotel.PerformLayout();
            MasInformacionHotelesGrp.ResumeLayout(false);
            MasInformacionHotelesGrp.PerformLayout();
            grpFiltrosHotel.ResumeLayout(false);
            grpFiltrosHotel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpHotel;
        private ListView listViewHoteles;
        private ColumnHeader CodigoHotelHeader;
        private ColumnHeader NombreHeader;
        private ColumnHeader CódigoCiudadHeader;
        private ColumnHeader DirecciónHeader;
        private ColumnHeader CalificacionHeader;
        private GroupBox MasInformacionHotelesGrp;
        private Button button1;
        private Label lblServiciosExtra;
        private Label lblDisponibilidad;
        private Label lblParadas;
        private ListView ServiciosExtraListView;
        private ListView DisponibilidadListView;
        private ListView ParadasListView;
        private ColumnHeader Nombre;
        private ColumnHeader Tarifa;
        private ColumnHeader Capacidad;
        private ColumnHeader Adultos;
        private ColumnHeader Menores;
        private ColumnHeader Infantes;
        private ColumnHeader CheckIn;
        private ColumnHeader CheckOut;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Button InformacionHotelesButton;
        private Label lblDisponibilidadHoteles;
        private ListView listView1;
        private ColumnHeader CodigoHeader;
        private ColumnHeader DescripcionHeader;
        private ColumnHeader TarifaHeader;
        private ListView TarifasListView;
        private ColumnHeader ClaseTarifaHeader;
        private ColumnHeader ItinerarioTarifaHeader;
        private ColumnHeader TipoPasajeroTarifaHeader;
        private ColumnHeader BaseTarifaHeader;
        private ColumnHeader ImpuestosTarifaHeader;
        private ColumnHeader ComisionTarifaHeader;
        private ColumnHeader FechaDesdeHeader;
        private ColumnHeader PrecioPorPasajeroHeader;
        private ColumnHeader FechaHastaHeader;
        private ColumnHeader DisponibilidadHeader;
        private ColumnHeader AeropuertoParadaHeader;
        private ColumnHeader TiempoParadaHeader;
        private ColumnHeader NombreHotelHeader;
        private ColumnHeader TarifaHotelHeader;
        private ColumnHeader CapacidadHotelHeader;
        private ColumnHeader MaxAdultosHotelHeader;
        private ColumnHeader MaxMenoresHotelHeader;
        private ColumnHeader MaxInfantesHotelHeader;
        private ColumnHeader FechaDesdeHotelHeader;
        private ColumnHeader FechaHastaHotelHeader;
        private ColumnHeader DisponibilidadHotelHeader;
        private Label lblTituloHoteles;
        private GroupBox grpFiltrosHotel;
        private DateTimePicker dtpFinHotel;
        private Label lblDestinoHotel;
        private TextBox txtDestinoHotel;
        private Label lblOrigenHotel;
        private TextBox txtOrigenHotel;
        private Button BuscarHotelButton;
        private Label lblRangoHotel;
        private DateTimePicker dtpInicioHotel;
        private Label lblHotelesDisponibles;
        private ColumnHeader NombreHabitacionHeader;
        private ColumnHeader TarifaPorDiaHeader;
        private Button AñadirAlItinerarioHotelesButton;
        private Label label5;
        private Label label1;
        private Button AñadirServicioExtraButton;
    }
}