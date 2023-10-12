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
            listViewHoteles = new ListView();
            CodigoHotelHeader = new ColumnHeader();
            NombreHeader = new ColumnHeader();
            CódigoCiudadHeader = new ColumnHeader();
            DirecciónHeader = new ColumnHeader();
            CalificacionHeader = new ColumnHeader();
            dateTimePicker2 = new DateTimePicker();
            labelIngreso = new Label();
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
            AñadirAlItinerarioHotelesButton = new Button();
            InformacionHotelesButton = new Button();
            AplicarFiltrosButton = new Button();
            MasInformacionGrp = new GroupBox();
            label1 = new Label();
            lblTarifas = new Label();
            listView1 = new ListView();
            CodigoHeader = new ColumnHeader();
            DescripcionHeader = new ColumnHeader();
            TarifaHeader = new ColumnHeader();
            PrecioPorPasajeroHeader = new ColumnHeader();
            TarifasListView = new ListView();
            NombreHotelHeader = new ColumnHeader();
            TarifaHotelHeader = new ColumnHeader();
            FechaDesdeHeader = new ColumnHeader();
            FechaHastaHeader = new ColumnHeader();
            DisponibilidadHeader = new ColumnHeader();
            CapacidadHotelHeader = new ColumnHeader();
            MaxAdultosHotelHeader = new ColumnHeader();
            MaxMenoresHotelHeader = new ColumnHeader();
            MaxInfantesHotelHeader = new ColumnHeader();
            FechaDesdeHotelHeader = new ColumnHeader();
            FechaHastaHotelHeader = new ColumnHeader();
            DisponibilidadHotelHeader = new ColumnHeader();
            grpHotel.SuspendLayout();
            MasInformacionGrp.SuspendLayout();
            SuspendLayout();
            // 
            // grpHotel
            // 
            grpHotel.Controls.Add(listViewHoteles);
            grpHotel.Location = new Point(11, 70);
            grpHotel.Margin = new Padding(3, 4, 3, 4);
            grpHotel.Name = "grpHotel";
            grpHotel.Padding = new Padding(3, 4, 3, 4);
            grpHotel.Size = new Size(1229, 245);
            grpHotel.TabIndex = 5;
            grpHotel.TabStop = false;
            grpHotel.Text = "Hoteles disponibles:";
            // 
            // listViewHoteles
            // 
            listViewHoteles.Columns.AddRange(new ColumnHeader[] { CodigoHotelHeader, NombreHeader, CódigoCiudadHeader, DirecciónHeader, CalificacionHeader });
            listViewHoteles.FullRowSelect = true;
            listViewHoteles.Location = new Point(14, 28);
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
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(221, 22);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(291, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // labelIngreso
            // 
            labelIngreso.AutoSize = true;
            labelIngreso.Location = new Point(25, 22);
            labelIngreso.Name = "labelIngreso";
            labelIngreso.Size = new Size(190, 20);
            labelIngreso.TabIndex = 15;
            labelIngreso.Text = "Filtrar por Fecha de Ingreso";
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
            lblDisponibilidad.Click += lblTarifas_Click;
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
            // AñadirAlItinerarioHotelesButton
            // 
            AñadirAlItinerarioHotelesButton.Location = new Point(173, 322);
            AñadirAlItinerarioHotelesButton.Margin = new Padding(3, 4, 3, 4);
            AñadirAlItinerarioHotelesButton.Name = "AñadirAlItinerarioHotelesButton";
            AñadirAlItinerarioHotelesButton.Size = new Size(155, 39);
            AñadirAlItinerarioHotelesButton.TabIndex = 18;
            AñadirAlItinerarioHotelesButton.Text = "Añadir a itinerario";
            AñadirAlItinerarioHotelesButton.UseVisualStyleBackColor = true;
            // 
            // InformacionHotelesButton
            // 
            InformacionHotelesButton.Location = new Point(11, 322);
            InformacionHotelesButton.Name = "InformacionHotelesButton";
            InformacionHotelesButton.Size = new Size(155, 40);
            InformacionHotelesButton.TabIndex = 17;
            InformacionHotelesButton.Text = "Ver más información";
            InformacionHotelesButton.UseVisualStyleBackColor = true;
            // 
            // AplicarFiltrosButton
            // 
            AplicarFiltrosButton.Location = new Point(529, 19);
            AplicarFiltrosButton.Name = "AplicarFiltrosButton";
            AplicarFiltrosButton.Size = new Size(122, 32);
            AplicarFiltrosButton.TabIndex = 19;
            AplicarFiltrosButton.Text = "Aplicar filtro";
            AplicarFiltrosButton.UseVisualStyleBackColor = true;
            // 
            // MasInformacionGrp
            // 
            MasInformacionGrp.Controls.Add(label1);
            MasInformacionGrp.Controls.Add(lblTarifas);
            MasInformacionGrp.Controls.Add(listView1);
            MasInformacionGrp.Controls.Add(TarifasListView);
            MasInformacionGrp.Location = new Point(12, 387);
            MasInformacionGrp.Margin = new Padding(3, 4, 3, 4);
            MasInformacionGrp.Name = "MasInformacionGrp";
            MasInformacionGrp.Padding = new Padding(3, 4, 3, 4);
            MasInformacionGrp.Size = new Size(1228, 329);
            MasInformacionGrp.TabIndex = 20;
            MasInformacionGrp.TabStop = false;
            MasInformacionGrp.Text = "Más información:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 36);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 5;
            label1.Text = "Servicios extra:";
            // 
            // lblTarifas
            // 
            lblTarifas.AutoSize = true;
            lblTarifas.Location = new Point(14, 178);
            lblTarifas.Name = "lblTarifas";
            lblTarifas.Size = new Size(110, 20);
            lblTarifas.TabIndex = 4;
            lblTarifas.Text = "Disponibilidad:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { CodigoHeader, DescripcionHeader, TarifaHeader, PrecioPorPasajeroHeader });
            listView1.Location = new Point(14, 60);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(1197, 100);
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
            TarifasListView.Location = new Point(14, 201);
            TarifasListView.Margin = new Padding(3, 4, 3, 4);
            TarifasListView.Name = "TarifasListView";
            TarifasListView.Size = new Size(1197, 104);
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
            // HotelesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 732);
            Controls.Add(MasInformacionGrp);
            Controls.Add(AplicarFiltrosButton);
            Controls.Add(AñadirAlItinerarioHotelesButton);
            Controls.Add(InformacionHotelesButton);
            Controls.Add(labelIngreso);
            Controls.Add(dateTimePicker2);
            Controls.Add(grpHotel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HotelesForm";
            Text = "HotelesForm";
            grpHotel.ResumeLayout(false);
            MasInformacionGrp.ResumeLayout(false);
            MasInformacionGrp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpHotel;
        private ListView listViewHoteles;
        private ColumnHeader CodigoHotelHeader;
        private ColumnHeader NombreHeader;
        private ColumnHeader CódigoCiudadHeader;
        private ColumnHeader DirecciónHeader;
        private ColumnHeader CalificacionHeader;
        private DateTimePicker dateTimePicker2;
        private Label labelIngreso;
        private Button AplicarFiltrosButton;
        private GroupBox MasInformacionGrp;
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
        private Button AñadirAlItinerarioHotelesButton;
        private Button InformacionHotelesButton;
        private Label label1;
        private Label lblTarifas;
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
    }
}