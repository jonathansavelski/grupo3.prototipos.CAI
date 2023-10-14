namespace grupo3.prototipos.CAI
{
    partial class BusquedaItinerarioForm
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
            listView1 = new ListView();
            fechaCreacionItinerarioHeader = new ColumnHeader();
            CotizacionHeader = new ColumnHeader();
            EstadoItinerarioHeader = new ColumnHeader();
            lblBuscarNumeroItinerario = new Label();
            txtBuscarItinerario = new TextBox();
            BuscarItinerarioBtn = new Button();
            VerDetallesPreReservaBtn = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            RealizarReservaButton = new Button();
            RealizarPrereservaButton = new Button();
            grpMenu = new GroupBox();
            AdicionalesPaqueteListView = new ListView();
            CodigoAdicionalHeader = new ColumnHeader();
            DescripcionAdicionalHeader = new ColumnHeader();
            TarifaAdicionalHeader = new ColumnHeader();
            PaquetesListView = new ListView();
            CodigoPaqueteHeader = new ColumnHeader();
            CodigoCiudadOrigenPaqueteHeader = new ColumnHeader();
            CodigoCiudadDestinoPaqueteHeader = new ColumnHeader();
            FechaInicioActHeader = new ColumnHeader();
            FechaFinActHeader = new ColumnHeader();
            CapacidadAdultosHeader = new ColumnHeader();
            CapacidadMenoresHeader = new ColumnHeader();
            CantidadPaquetesDisponiblesHeader = new ColumnHeader();
            TarifaAdultoHeader = new ColumnHeader();
            TarifaMenorHeader = new ColumnHeader();
            TarifaInfanteHeader = new ColumnHeader();
            label10 = new Label();
            label4 = new Label();
            HotelesListView = new ListView();
            CodigoHotelHeader = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            CódigoCiudadHeader = new ColumnHeader();
            DirecciónHeader = new ColumnHeader();
            CalificacionHeader = new ColumnHeader();
            NombreHabitacionHeader = new ColumnHeader();
            TarifaPorDiaHeader = new ColumnHeader();
            ServiciosExtraHotelesListView = new ListView();
            CodigoHeader = new ColumnHeader();
            DescripcionHeader = new ColumnHeader();
            TarifaHeader = new ColumnHeader();
            PrecioPorPasajeroHeader = new ColumnHeader();
            label11 = new Label();
            ServiciosExtraVuelosListView = new ListView();
            CodigoServicioHeader = new ColumnHeader();
            DescripcionServicioHeader = new ColumnHeader();
            TarifaServicioHeader = new ColumnHeader();
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
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            button1 = new Button();
            button2 = new Button();
            CargaPasajerosGroupBox = new GroupBox();
            label1 = new Label();
            listView4 = new ListView();
            nombreHeader = new ColumnHeader();
            apellidoHeader = new ColumnHeader();
            TipoPasajero = new ColumnHeader();
            AgregarPersonaBtn = new Button();
            button8 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            grpMenu.SuspendLayout();
            CargaPasajerosGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { fechaCreacionItinerarioHeader, CotizacionHeader, EstadoItinerarioHeader });
            listView1.Location = new Point(15, 68);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(412, 70);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // fechaCreacionItinerarioHeader
            // 
            fechaCreacionItinerarioHeader.Text = "Fecha de creación";
            fechaCreacionItinerarioHeader.TextAlign = HorizontalAlignment.Center;
            fechaCreacionItinerarioHeader.Width = 150;
            // 
            // CotizacionHeader
            // 
            CotizacionHeader.Text = "Cotización";
            CotizacionHeader.TextAlign = HorizontalAlignment.Center;
            CotizacionHeader.Width = 150;
            // 
            // EstadoItinerarioHeader
            // 
            EstadoItinerarioHeader.Text = "Estado";
            EstadoItinerarioHeader.TextAlign = HorizontalAlignment.Center;
            EstadoItinerarioHeader.Width = 100;
            // 
            // lblBuscarNumeroItinerario
            // 
            lblBuscarNumeroItinerario.AutoSize = true;
            lblBuscarNumeroItinerario.Location = new Point(13, 23);
            lblBuscarNumeroItinerario.Name = "lblBuscarNumeroItinerario";
            lblBuscarNumeroItinerario.Size = new Size(130, 20);
            lblBuscarNumeroItinerario.TabIndex = 1;
            lblBuscarNumeroItinerario.Text = "Número itinerario:";
            // 
            // txtBuscarItinerario
            // 
            txtBuscarItinerario.Location = new Point(161, 20);
            txtBuscarItinerario.Margin = new Padding(3, 4, 3, 4);
            txtBuscarItinerario.Name = "txtBuscarItinerario";
            txtBuscarItinerario.Size = new Size(114, 27);
            txtBuscarItinerario.TabIndex = 2;
            txtBuscarItinerario.KeyPress += txtBuscarItinerario_KeyPress;
            // 
            // BuscarItinerarioBtn
            // 
            BuscarItinerarioBtn.Location = new Point(298, 18);
            BuscarItinerarioBtn.Margin = new Padding(3, 4, 3, 4);
            BuscarItinerarioBtn.Name = "BuscarItinerarioBtn";
            BuscarItinerarioBtn.Size = new Size(129, 31);
            BuscarItinerarioBtn.TabIndex = 3;
            BuscarItinerarioBtn.Text = "Buscar";
            BuscarItinerarioBtn.UseVisualStyleBackColor = true;
            // 
            // VerDetallesPreReservaBtn
            // 
            VerDetallesPreReservaBtn.Location = new Point(14, 149);
            VerDetallesPreReservaBtn.Margin = new Padding(3, 4, 3, 4);
            VerDetallesPreReservaBtn.Name = "VerDetallesPreReservaBtn";
            VerDetallesPreReservaBtn.Size = new Size(147, 44);
            VerDetallesPreReservaBtn.TabIndex = 5;
            VerDetallesPreReservaBtn.Text = "Ver detalles";
            VerDetallesPreReservaBtn.UseVisualStyleBackColor = true;
            VerDetallesPreReservaBtn.Click += VerDetallesPreReservaBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(BuscarItinerarioBtn);
            groupBox1.Controls.Add(VerDetallesPreReservaBtn);
            groupBox1.Controls.Add(txtBuscarItinerario);
            groupBox1.Controls.Add(lblBuscarNumeroItinerario);
            groupBox1.Location = new Point(12, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 249);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(514, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(989, 63);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(376, 23);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 5;
            label6.Text = "X Infantes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(272, 23);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 4;
            label7.Text = "X Menores";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(9, 23);
            label8.Name = "label8";
            label8.Size = new Size(166, 20);
            label8.TabIndex = 2;
            label8.Text = "Cantidad de Pasajeros:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(183, 23);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 3;
            label9.Text = "X Adultos";
            // 
            // RealizarReservaButton
            // 
            RealizarReservaButton.Location = new Point(11, 760);
            RealizarReservaButton.Margin = new Padding(3, 4, 3, 4);
            RealizarReservaButton.Name = "RealizarReservaButton";
            RealizarReservaButton.Size = new Size(165, 45);
            RealizarReservaButton.TabIndex = 42;
            RealizarReservaButton.Text = "Realizar reserva";
            RealizarReservaButton.UseVisualStyleBackColor = true;
            // 
            // RealizarPrereservaButton
            // 
            RealizarPrereservaButton.Location = new Point(182, 760);
            RealizarPrereservaButton.Margin = new Padding(3, 4, 3, 4);
            RealizarPrereservaButton.Name = "RealizarPrereservaButton";
            RealizarPrereservaButton.Size = new Size(165, 45);
            RealizarPrereservaButton.TabIndex = 43;
            RealizarPrereservaButton.Text = "Realizar prereserva";
            RealizarPrereservaButton.UseVisualStyleBackColor = true;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(AdicionalesPaqueteListView);
            grpMenu.Controls.Add(PaquetesListView);
            grpMenu.Controls.Add(label10);
            grpMenu.Controls.Add(label4);
            grpMenu.Controls.Add(HotelesListView);
            grpMenu.Controls.Add(ServiciosExtraHotelesListView);
            grpMenu.Controls.Add(label11);
            grpMenu.Controls.Add(ServiciosExtraVuelosListView);
            grpMenu.Controls.Add(VuelosListView);
            grpMenu.Controls.Add(label12);
            grpMenu.Controls.Add(label13);
            grpMenu.Controls.Add(label14);
            grpMenu.Location = new Point(12, 262);
            grpMenu.Margin = new Padding(3, 4, 3, 4);
            grpMenu.Name = "grpMenu";
            grpMenu.Padding = new Padding(3, 4, 3, 4);
            grpMenu.Size = new Size(1491, 490);
            grpMenu.TabIndex = 44;
            grpMenu.TabStop = false;
            // 
            // AdicionalesPaqueteListView
            // 
            AdicionalesPaqueteListView.Columns.AddRange(new ColumnHeader[] { CodigoAdicionalHeader, DescripcionAdicionalHeader, TarifaAdicionalHeader });
            AdicionalesPaqueteListView.Location = new Point(1009, 359);
            AdicionalesPaqueteListView.Margin = new Padding(3, 4, 3, 4);
            AdicionalesPaqueteListView.Name = "AdicionalesPaqueteListView";
            AdicionalesPaqueteListView.Size = new Size(464, 111);
            AdicionalesPaqueteListView.TabIndex = 50;
            AdicionalesPaqueteListView.UseCompatibleStateImageBehavior = false;
            AdicionalesPaqueteListView.View = View.Details;
            // 
            // CodigoAdicionalHeader
            // 
            CodigoAdicionalHeader.Text = "Codigo de adicional";
            CodigoAdicionalHeader.Width = 150;
            // 
            // DescripcionAdicionalHeader
            // 
            DescripcionAdicionalHeader.Text = "Descripción del adicional";
            DescripcionAdicionalHeader.TextAlign = HorizontalAlignment.Center;
            DescripcionAdicionalHeader.Width = 180;
            // 
            // TarifaAdicionalHeader
            // 
            TarifaAdicionalHeader.Text = "Tarifa Adicional";
            TarifaAdicionalHeader.Width = 150;
            // 
            // PaquetesListView
            // 
            PaquetesListView.Columns.AddRange(new ColumnHeader[] { CodigoPaqueteHeader, CodigoCiudadOrigenPaqueteHeader, CodigoCiudadDestinoPaqueteHeader, FechaInicioActHeader, FechaFinActHeader, CapacidadAdultosHeader, CapacidadMenoresHeader, CantidadPaquetesDisponiblesHeader, TarifaAdultoHeader, TarifaMenorHeader, TarifaInfanteHeader });
            PaquetesListView.FullRowSelect = true;
            PaquetesListView.GridLines = true;
            PaquetesListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            PaquetesListView.Location = new Point(14, 359);
            PaquetesListView.Margin = new Padding(3, 4, 3, 4);
            PaquetesListView.MultiSelect = false;
            PaquetesListView.Name = "PaquetesListView";
            PaquetesListView.Size = new Size(977, 111);
            PaquetesListView.TabIndex = 49;
            PaquetesListView.UseCompatibleStateImageBehavior = false;
            PaquetesListView.View = View.Details;
            // 
            // CodigoPaqueteHeader
            // 
            CodigoPaqueteHeader.Text = "Código";
            CodigoPaqueteHeader.Width = 70;
            // 
            // CodigoCiudadOrigenPaqueteHeader
            // 
            CodigoCiudadOrigenPaqueteHeader.Text = "Código ciudad origen";
            CodigoCiudadOrigenPaqueteHeader.TextAlign = HorizontalAlignment.Center;
            CodigoCiudadOrigenPaqueteHeader.Width = 180;
            // 
            // CodigoCiudadDestinoPaqueteHeader
            // 
            CodigoCiudadDestinoPaqueteHeader.Text = "Código ciudad destino";
            CodigoCiudadDestinoPaqueteHeader.TextAlign = HorizontalAlignment.Center;
            CodigoCiudadDestinoPaqueteHeader.Width = 180;
            // 
            // FechaInicioActHeader
            // 
            FechaInicioActHeader.Text = "Fecha inicio actividades";
            FechaInicioActHeader.TextAlign = HorizontalAlignment.Center;
            FechaInicioActHeader.Width = 180;
            // 
            // FechaFinActHeader
            // 
            FechaFinActHeader.Text = "Fecha fin actividades";
            FechaFinActHeader.TextAlign = HorizontalAlignment.Center;
            FechaFinActHeader.Width = 180;
            // 
            // CapacidadAdultosHeader
            // 
            CapacidadAdultosHeader.Text = "Capacidad adultos";
            CapacidadAdultosHeader.TextAlign = HorizontalAlignment.Center;
            CapacidadAdultosHeader.Width = 150;
            // 
            // CapacidadMenoresHeader
            // 
            CapacidadMenoresHeader.Text = "Capacidad menores";
            CapacidadMenoresHeader.TextAlign = HorizontalAlignment.Center;
            CapacidadMenoresHeader.Width = 150;
            // 
            // CantidadPaquetesDisponiblesHeader
            // 
            CantidadPaquetesDisponiblesHeader.Text = "Cantidad disponibles";
            CantidadPaquetesDisponiblesHeader.TextAlign = HorizontalAlignment.Center;
            CantidadPaquetesDisponiblesHeader.Width = 170;
            // 
            // TarifaAdultoHeader
            // 
            TarifaAdultoHeader.Text = "Tarifa adultos";
            TarifaAdultoHeader.TextAlign = HorizontalAlignment.Center;
            TarifaAdultoHeader.Width = 120;
            // 
            // TarifaMenorHeader
            // 
            TarifaMenorHeader.Text = "Tarifa menores";
            TarifaMenorHeader.TextAlign = HorizontalAlignment.Center;
            TarifaMenorHeader.Width = 120;
            // 
            // TarifaInfanteHeader
            // 
            TarifaInfanteHeader.Text = "Tarifa infantes";
            TarifaInfanteHeader.TextAlign = HorizontalAlignment.Center;
            TarifaInfanteHeader.Width = 120;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(1007, 331);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 48;
            label10.Text = "Adicionales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1006, 181);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 47;
            label4.Text = "Servicios extra";
            // 
            // HotelesListView
            // 
            HotelesListView.Columns.AddRange(new ColumnHeader[] { CodigoHotelHeader, columnHeader1, CódigoCiudadHeader, DirecciónHeader, CalificacionHeader, NombreHabitacionHeader, TarifaPorDiaHeader });
            HotelesListView.FullRowSelect = true;
            HotelesListView.GridLines = true;
            HotelesListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            HotelesListView.Location = new Point(14, 209);
            HotelesListView.Margin = new Padding(3, 4, 3, 4);
            HotelesListView.MultiSelect = false;
            HotelesListView.Name = "HotelesListView";
            HotelesListView.Size = new Size(977, 104);
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
            // ServiciosExtraHotelesListView
            // 
            ServiciosExtraHotelesListView.Columns.AddRange(new ColumnHeader[] { CodigoHeader, DescripcionHeader, TarifaHeader, PrecioPorPasajeroHeader });
            ServiciosExtraHotelesListView.FullRowSelect = true;
            ServiciosExtraHotelesListView.GridLines = true;
            ServiciosExtraHotelesListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ServiciosExtraHotelesListView.Location = new Point(1009, 209);
            ServiciosExtraHotelesListView.Margin = new Padding(3, 4, 3, 4);
            ServiciosExtraHotelesListView.Name = "ServiciosExtraHotelesListView";
            ServiciosExtraHotelesListView.Size = new Size(464, 104);
            ServiciosExtraHotelesListView.TabIndex = 45;
            ServiciosExtraHotelesListView.UseCompatibleStateImageBehavior = false;
            ServiciosExtraHotelesListView.View = View.Details;
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(1009, 25);
            label11.Name = "label11";
            label11.Size = new Size(111, 20);
            label11.TabIndex = 44;
            label11.Text = "Servicios extra";
            // 
            // ServiciosExtraVuelosListView
            // 
            ServiciosExtraVuelosListView.Columns.AddRange(new ColumnHeader[] { CodigoServicioHeader, DescripcionServicioHeader, TarifaServicioHeader });
            ServiciosExtraVuelosListView.FullRowSelect = true;
            ServiciosExtraVuelosListView.GridLines = true;
            ServiciosExtraVuelosListView.Location = new Point(1009, 54);
            ServiciosExtraVuelosListView.Margin = new Padding(3, 4, 3, 4);
            ServiciosExtraVuelosListView.Name = "ServiciosExtraVuelosListView";
            ServiciosExtraVuelosListView.Size = new Size(464, 106);
            ServiciosExtraVuelosListView.TabIndex = 43;
            ServiciosExtraVuelosListView.UseCompatibleStateImageBehavior = false;
            ServiciosExtraVuelosListView.View = View.Details;
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
            // VuelosListView
            // 
            VuelosListView.Columns.AddRange(new ColumnHeader[] { CodigoVueloHeader, OrigenVueloHeader, DestinoVueloHeader, FechaSalidaVueloHeader, FechaArriboVueloHeader, TiempoVueloHeader, CodigoAerolineaVueloHeader, ClaseTarifaVueloHeader, ItinerarioVueloHeader, TipoPasajeroHeader, BaseVueloHeader, ImpuestoVueloHeader, ComisionVueloHeader, DisponibilidadVueloHeader });
            VuelosListView.FullRowSelect = true;
            VuelosListView.GridLines = true;
            VuelosListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            VuelosListView.LabelWrap = false;
            VuelosListView.Location = new Point(14, 54);
            VuelosListView.Margin = new Padding(3, 4, 3, 4);
            VuelosListView.MultiSelect = false;
            VuelosListView.Name = "VuelosListView";
            VuelosListView.Size = new Size(977, 106);
            VuelosListView.TabIndex = 42;
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(10, 326);
            label12.Name = "label12";
            label12.Size = new Size(73, 20);
            label12.TabIndex = 24;
            label12.Text = "Paquetes";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(10, 174);
            label13.Name = "label13";
            label13.Size = new Size(62, 20);
            label13.TabIndex = 22;
            label13.Text = "Hoteles";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(10, 21);
            label14.Name = "label14";
            label14.Size = new Size(56, 20);
            label14.TabIndex = 20;
            label14.Text = "Vuelos";
            // 
            // button1
            // 
            button1.Location = new Point(1167, 759);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(165, 45);
            button1.TabIndex = 45;
            button1.Text = "Eliminar reserva";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1338, 759);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(165, 45);
            button2.TabIndex = 46;
            button2.Text = "Eliminar itinerario";
            button2.UseVisualStyleBackColor = true;
            // 
            // CargaPasajerosGroupBox
            // 
            CargaPasajerosGroupBox.Controls.Add(label1);
            CargaPasajerosGroupBox.Controls.Add(listView4);
            CargaPasajerosGroupBox.Controls.Add(AgregarPersonaBtn);
            CargaPasajerosGroupBox.Controls.Add(button8);
            CargaPasajerosGroupBox.Location = new Point(514, 73);
            CargaPasajerosGroupBox.Name = "CargaPasajerosGroupBox";
            CargaPasajerosGroupBox.Size = new Size(989, 180);
            CargaPasajerosGroupBox.TabIndex = 47;
            CargaPasajerosGroupBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 25);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 44;
            label1.Text = "Carga datos pasajeros";
            // 
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { nombreHeader, apellidoHeader, TipoPasajero });
            listView4.GridLines = true;
            listView4.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView4.Location = new Point(14, 60);
            listView4.Margin = new Padding(3, 4, 3, 4);
            listView4.Name = "listView4";
            listView4.Size = new Size(461, 100);
            listView4.TabIndex = 36;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.View = View.Details;
            // 
            // nombreHeader
            // 
            nombreHeader.Text = "Nombre";
            nombreHeader.Width = 100;
            // 
            // apellidoHeader
            // 
            apellidoHeader.Text = "Apellido";
            apellidoHeader.TextAlign = HorizontalAlignment.Center;
            apellidoHeader.Width = 100;
            // 
            // TipoPasajero
            // 
            TipoPasajero.Text = "Tipo pasajero ";
            TipoPasajero.TextAlign = HorizontalAlignment.Center;
            TipoPasajero.Width = 120;
            // 
            // AgregarPersonaBtn
            // 
            AgregarPersonaBtn.Location = new Point(489, 60);
            AgregarPersonaBtn.Margin = new Padding(3, 4, 3, 4);
            AgregarPersonaBtn.Name = "AgregarPersonaBtn";
            AgregarPersonaBtn.Size = new Size(158, 41);
            AgregarPersonaBtn.TabIndex = 37;
            AgregarPersonaBtn.Text = "Agregar";
            AgregarPersonaBtn.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(489, 119);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(158, 41);
            button8.TabIndex = 38;
            button8.Text = "Eliminar";
            button8.UseVisualStyleBackColor = true;
            // 
            // BusquedaItinerarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 814);
            Controls.Add(CargaPasajerosGroupBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(grpMenu);
            Controls.Add(RealizarPrereservaButton);
            Controls.Add(RealizarReservaButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BusquedaItinerarioForm";
            Text = "Buscar Itinerario";
            Load += ListaPrereservas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            CargaPasajerosGroupBox.ResumeLayout(false);
            CargaPasajerosGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Label lblBuscarNumeroItinerario;
        private TextBox txtBuscarItinerario;
        private Button BuscarItinerarioBtn;
        private ColumnHeader fechaCreacionItinerarioHeader;
        private ColumnHeader CotizacionHeader;
        private Button VerDetallesPreReservaBtn;
        private GroupBox groupBox1;
        private ColumnHeader EstadoItinerarioHeader;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button RealizarReservaButton;
        private Button RealizarPrereservaButton;
        private GroupBox grpMenu;
        private ListView AdicionalesPaqueteListView;
        private ColumnHeader CodigoAdicionalHeader;
        private ColumnHeader DescripcionAdicionalHeader;
        private ColumnHeader TarifaAdicionalHeader;
        private ListView PaquetesListView;
        private ColumnHeader CodigoPaqueteHeader;
        private ColumnHeader CodigoCiudadOrigenPaqueteHeader;
        private ColumnHeader CodigoCiudadDestinoPaqueteHeader;
        private ColumnHeader FechaInicioActHeader;
        private ColumnHeader FechaFinActHeader;
        private ColumnHeader CapacidadAdultosHeader;
        private ColumnHeader CapacidadMenoresHeader;
        private ColumnHeader CantidadPaquetesDisponiblesHeader;
        private ColumnHeader TarifaAdultoHeader;
        private ColumnHeader TarifaMenorHeader;
        private ColumnHeader TarifaInfanteHeader;
        private Label label10;
        private Label label4;
        private ListView HotelesListView;
        private ColumnHeader CodigoHotelHeader;
        private ColumnHeader columnHeader1;
        private ColumnHeader CódigoCiudadHeader;
        private ColumnHeader DirecciónHeader;
        private ColumnHeader CalificacionHeader;
        private ColumnHeader NombreHabitacionHeader;
        private ColumnHeader TarifaPorDiaHeader;
        private ListView ServiciosExtraHotelesListView;
        private ColumnHeader CodigoHeader;
        private ColumnHeader DescripcionHeader;
        private ColumnHeader TarifaHeader;
        private ColumnHeader PrecioPorPasajeroHeader;
        private Label label11;
        private ListView ServiciosExtraVuelosListView;
        private ColumnHeader CodigoServicioHeader;
        private ColumnHeader DescripcionServicioHeader;
        private ColumnHeader TarifaServicioHeader;
        private ColumnHeader CodigoVueloHeader;
        private ColumnHeader OrigenVueloHeader;
        private ColumnHeader DestinoVueloHeader;
        private ColumnHeader FechaSalidaVueloHeader;
        private ColumnHeader FechaArriboVueloHeader;
        private ColumnHeader TiempoVueloHeader;
        private ColumnHeader CodigoAerolineaVueloHeader;
        private ColumnHeader ClaseTarifaVueloHeader;
        private ColumnHeader ItinerarioVueloHeader;
        private ColumnHeader TipoPasajeroHeader;
        private ColumnHeader BaseVueloHeader;
        private ColumnHeader ImpuestoVueloHeader;
        private ColumnHeader ComisionVueloHeader;
        private ColumnHeader DisponibilidadVueloHeader;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button button1;
        private Button button2;
        private GroupBox CargaPasajerosGroupBox;
        private Label label1;
        private ListView listView4;
        private ColumnHeader nombreHeader;
        private ColumnHeader apellidoHeader;
        private ColumnHeader TipoPasajero;
        private Button AgregarPersonaBtn;
        private Button button8;
        public ListView VuelosListView;
    }
}