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
            label9 = new Label();
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
            label5 = new Label();
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
            ValorDeLaCotizacionLabel = new Label();
            GuardarItinerarioButton = new Button();
            CotizarButton = new Button();
            EliminarHotelButton = new Button();
            EliminarPaqueteButton = new Button();
            EliminarVueloButton = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            ConsultaDisponibilidadHotelesBtn = new Button();
            ConsultaDisponibilidadVuelosBtn = new Button();
            ConsultaDisponibilidadPaquetesBtn = new Button();
            RealizarReservaButton = new Button();
            RealizarPrereservaButton = new Button();
            label3 = new Label();
            label2 = new Label();
            NumeroItinerarioLabel = new Label();
            label1 = new Label();
            CantidadAdultosTextBox = new TextBox();
            lblNumeroItinerario = new Label();
            groupBox1 = new GroupBox();
            CantidadMenoresTextBox = new TextBox();
            CantidadInfantesTextBox = new TextBox();
            label4 = new Label();
            CargaPasajerosGroupBox = new GroupBox();
            label11 = new Label();
            listView4 = new ListView();
            nombreHeader = new ColumnHeader();
            apellidoHeader = new ColumnHeader();
            TipoPasajero = new ColumnHeader();
            AgregarPersonaBtn = new Button();
            EliminarPasajeroButton = new Button();
            grpMenu.SuspendLayout();
            groupBox1.SuspendLayout();
            CargaPasajerosGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(AdicionalesPaqueteListView);
            grpMenu.Controls.Add(PaquetesListView);
            grpMenu.Controls.Add(label10);
            grpMenu.Controls.Add(label9);
            grpMenu.Controls.Add(HotelesListView);
            grpMenu.Controls.Add(ServiciosExtraHotelesListView);
            grpMenu.Controls.Add(label5);
            grpMenu.Controls.Add(ServiciosExtraVuelosListView);
            grpMenu.Controls.Add(VuelosListView);
            grpMenu.Controls.Add(ValorDeLaCotizacionLabel);
            grpMenu.Controls.Add(GuardarItinerarioButton);
            grpMenu.Controls.Add(CotizarButton);
            grpMenu.Controls.Add(EliminarHotelButton);
            grpMenu.Controls.Add(EliminarPaqueteButton);
            grpMenu.Controls.Add(EliminarVueloButton);
            grpMenu.Controls.Add(label8);
            grpMenu.Controls.Add(label7);
            grpMenu.Controls.Add(label6);
            grpMenu.Controls.Add(ConsultaDisponibilidadHotelesBtn);
            grpMenu.Controls.Add(ConsultaDisponibilidadVuelosBtn);
            grpMenu.Controls.Add(ConsultaDisponibilidadPaquetesBtn);
            grpMenu.Location = new Point(12, 144);
            grpMenu.Margin = new Padding(3, 4, 3, 4);
            grpMenu.Name = "grpMenu";
            grpMenu.Padding = new Padding(3, 4, 3, 4);
            grpMenu.Size = new Size(1675, 544);
            grpMenu.TabIndex = 0;
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
            label10.Location = new Point(1007, 330);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 48;
            label10.Text = "Adicionales";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1006, 180);
            label9.Name = "label9";
            label9.Size = new Size(111, 20);
            label9.TabIndex = 47;
            label9.Text = "Servicios extra";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1009, 24);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 44;
            label5.Text = "Servicios extra";
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
            // ValorDeLaCotizacionLabel
            // 
            ValorDeLaCotizacionLabel.AutoSize = true;
            ValorDeLaCotizacionLabel.Location = new Point(152, 495);
            ValorDeLaCotizacionLabel.Name = "ValorDeLaCotizacionLabel";
            ValorDeLaCotizacionLabel.Size = new Size(152, 20);
            ValorDeLaCotizacionLabel.TabIndex = 39;
            ValorDeLaCotizacionLabel.Text = "Valor de la cotización";
            // 
            // GuardarItinerarioButton
            // 
            GuardarItinerarioButton.Location = new Point(826, 485);
            GuardarItinerarioButton.Margin = new Padding(3, 4, 3, 4);
            GuardarItinerarioButton.Name = "GuardarItinerarioButton";
            GuardarItinerarioButton.Size = new Size(165, 45);
            GuardarItinerarioButton.TabIndex = 35;
            GuardarItinerarioButton.Text = "Guardar itinerario";
            GuardarItinerarioButton.UseVisualStyleBackColor = true;
            GuardarItinerarioButton.Click += GuardarItinerarioButton_Click;
            // 
            // CotizarButton
            // 
            CotizarButton.Location = new Point(14, 485);
            CotizarButton.Margin = new Padding(3, 4, 3, 4);
            CotizarButton.Name = "CotizarButton";
            CotizarButton.Size = new Size(112, 45);
            CotizarButton.TabIndex = 30;
            CotizarButton.Text = "Cotizar";
            CotizarButton.UseVisualStyleBackColor = true;
            // 
            // EliminarHotelButton
            // 
            EliminarHotelButton.Location = new Point(1502, 272);
            EliminarHotelButton.Margin = new Padding(3, 4, 3, 4);
            EliminarHotelButton.Name = "EliminarHotelButton";
            EliminarHotelButton.Size = new Size(158, 41);
            EliminarHotelButton.TabIndex = 29;
            EliminarHotelButton.Text = "Eliminar";
            EliminarHotelButton.UseVisualStyleBackColor = true;
            // 
            // EliminarPaqueteButton
            // 
            EliminarPaqueteButton.Location = new Point(1502, 429);
            EliminarPaqueteButton.Margin = new Padding(3, 4, 3, 4);
            EliminarPaqueteButton.Name = "EliminarPaqueteButton";
            EliminarPaqueteButton.Size = new Size(158, 41);
            EliminarPaqueteButton.TabIndex = 27;
            EliminarPaqueteButton.Text = "Eliminar";
            EliminarPaqueteButton.UseVisualStyleBackColor = true;
            // 
            // EliminarVueloButton
            // 
            EliminarVueloButton.Location = new Point(1502, 119);
            EliminarVueloButton.Margin = new Padding(3, 4, 3, 4);
            EliminarVueloButton.Name = "EliminarVueloButton";
            EliminarVueloButton.Size = new Size(158, 41);
            EliminarVueloButton.TabIndex = 25;
            EliminarVueloButton.Text = "Eliminar";
            EliminarVueloButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(10, 325);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 24;
            label8.Text = "Paquetes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(10, 173);
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
            // ConsultaDisponibilidadHotelesBtn
            // 
            ConsultaDisponibilidadHotelesBtn.Location = new Point(1502, 209);
            ConsultaDisponibilidadHotelesBtn.Margin = new Padding(3, 4, 3, 4);
            ConsultaDisponibilidadHotelesBtn.Name = "ConsultaDisponibilidadHotelesBtn";
            ConsultaDisponibilidadHotelesBtn.Size = new Size(158, 37);
            ConsultaDisponibilidadHotelesBtn.TabIndex = 3;
            ConsultaDisponibilidadHotelesBtn.Text = "Agregar";
            ConsultaDisponibilidadHotelesBtn.UseVisualStyleBackColor = true;
            ConsultaDisponibilidadHotelesBtn.Click += ConsultaDisponibilidadHotelesBtn_Click;
            // 
            // ConsultaDisponibilidadVuelosBtn
            // 
            ConsultaDisponibilidadVuelosBtn.Location = new Point(1502, 54);
            ConsultaDisponibilidadVuelosBtn.Margin = new Padding(3, 4, 3, 4);
            ConsultaDisponibilidadVuelosBtn.Name = "ConsultaDisponibilidadVuelosBtn";
            ConsultaDisponibilidadVuelosBtn.Size = new Size(158, 39);
            ConsultaDisponibilidadVuelosBtn.TabIndex = 1;
            ConsultaDisponibilidadVuelosBtn.Text = "Agregar";
            ConsultaDisponibilidadVuelosBtn.UseVisualStyleBackColor = true;
            ConsultaDisponibilidadVuelosBtn.Click += ConsultaDisponibilidadVuelosBtn_Click;
            // 
            // ConsultaDisponibilidadPaquetesBtn
            // 
            ConsultaDisponibilidadPaquetesBtn.Location = new Point(1502, 359);
            ConsultaDisponibilidadPaquetesBtn.Margin = new Padding(3, 4, 3, 4);
            ConsultaDisponibilidadPaquetesBtn.Name = "ConsultaDisponibilidadPaquetesBtn";
            ConsultaDisponibilidadPaquetesBtn.Size = new Size(158, 41);
            ConsultaDisponibilidadPaquetesBtn.TabIndex = 2;
            ConsultaDisponibilidadPaquetesBtn.Text = "Agregar";
            ConsultaDisponibilidadPaquetesBtn.UseVisualStyleBackColor = true;
            ConsultaDisponibilidadPaquetesBtn.Click += ConsultaDisponibilidadPaquetesBtn_Click;
            // 
            // RealizarReservaButton
            // 
            RealizarReservaButton.Location = new Point(192, 912);
            RealizarReservaButton.Margin = new Padding(3, 4, 3, 4);
            RealizarReservaButton.Name = "RealizarReservaButton";
            RealizarReservaButton.Size = new Size(165, 45);
            RealizarReservaButton.TabIndex = 41;
            RealizarReservaButton.Text = "Realizar reserva";
            RealizarReservaButton.UseVisualStyleBackColor = true;
            RealizarReservaButton.Click += RealizarReservaButton_Click;
            // 
            // RealizarPrereservaButton
            // 
            RealizarPrereservaButton.Location = new Point(12, 911);
            RealizarPrereservaButton.Margin = new Padding(3, 4, 3, 4);
            RealizarPrereservaButton.Name = "RealizarPrereservaButton";
            RealizarPrereservaButton.Size = new Size(165, 45);
            RealizarPrereservaButton.TabIndex = 40;
            RealizarPrereservaButton.Text = "Realizar prereserva";
            RealizarPrereservaButton.UseVisualStyleBackColor = true;
            RealizarPrereservaButton.Click += RealizarPrereservaButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 61);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 14;
            label3.Text = "Infantes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 61);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 13;
            label2.Text = "Menores:";
            // 
            // NumeroItinerarioLabel
            // 
            NumeroItinerarioLabel.AutoSize = true;
            NumeroItinerarioLabel.Location = new Point(241, 14);
            NumeroItinerarioLabel.Name = "NumeroItinerarioLabel";
            NumeroItinerarioLabel.Size = new Size(127, 20);
            NumeroItinerarioLabel.TabIndex = 39;
            NumeroItinerarioLabel.Text = "Número itinerario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 61);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 12;
            label1.Text = "Adultos:";
            // 
            // CantidadAdultosTextBox
            // 
            CantidadAdultosTextBox.Location = new Point(83, 58);
            CantidadAdultosTextBox.Margin = new Padding(3, 4, 3, 4);
            CantidadAdultosTextBox.Name = "CantidadAdultosTextBox";
            CantidadAdultosTextBox.Size = new Size(29, 27);
            CantidadAdultosTextBox.TabIndex = 9;
            CantidadAdultosTextBox.KeyPress += CantidadAdultosTextBox_KeyPress;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(CantidadMenoresTextBox);
            groupBox1.Controls.Add(CantidadInfantesTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(CantidadAdultosTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1675, 100);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            // 
            // CantidadMenoresTextBox
            // 
            CantidadMenoresTextBox.Location = new Point(362, 58);
            CantidadMenoresTextBox.Margin = new Padding(3, 4, 3, 4);
            CantidadMenoresTextBox.Name = "CantidadMenoresTextBox";
            CantidadMenoresTextBox.Size = new Size(29, 27);
            CantidadMenoresTextBox.TabIndex = 16;
            CantidadMenoresTextBox.KeyPress += CantidadMenoresTextBox_KeyPress;
            // 
            // CantidadInfantesTextBox
            // 
            CantidadInfantesTextBox.Location = new Point(222, 58);
            CantidadInfantesTextBox.Margin = new Padding(3, 4, 3, 4);
            CantidadInfantesTextBox.Name = "CantidadInfantesTextBox";
            CantidadInfantesTextBox.Size = new Size(29, 27);
            CantidadInfantesTextBox.TabIndex = 15;
            CantidadInfantesTextBox.KeyPress += CantidadInfantesTextBox_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 23);
            label4.Name = "label4";
            label4.Size = new Size(162, 20);
            label4.TabIndex = 13;
            label4.Text = "Cantidad de pasajeros";
            // 
            // CargaPasajerosGroupBox
            // 
            CargaPasajerosGroupBox.Controls.Add(label11);
            CargaPasajerosGroupBox.Controls.Add(listView4);
            CargaPasajerosGroupBox.Controls.Add(AgregarPersonaBtn);
            CargaPasajerosGroupBox.Controls.Add(EliminarPasajeroButton);
            CargaPasajerosGroupBox.Location = new Point(12, 690);
            CargaPasajerosGroupBox.Name = "CargaPasajerosGroupBox";
            CargaPasajerosGroupBox.Size = new Size(671, 211);
            CargaPasajerosGroupBox.TabIndex = 43;
            CargaPasajerosGroupBox.TabStop = false;
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
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { nombreHeader, apellidoHeader, TipoPasajero });
            listView4.GridLines = true;
            listView4.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView4.Location = new Point(14, 60);
            listView4.Margin = new Padding(3, 4, 3, 4);
            listView4.Name = "listView4";
            listView4.Size = new Size(461, 128);
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
            AgregarPersonaBtn.Click += AgregarPersonaBtn_Click;
            // 
            // EliminarPasajeroButton
            // 
            EliminarPasajeroButton.Location = new Point(489, 147);
            EliminarPasajeroButton.Margin = new Padding(3, 4, 3, 4);
            EliminarPasajeroButton.Name = "EliminarPasajeroButton";
            EliminarPasajeroButton.Size = new Size(158, 41);
            EliminarPasajeroButton.TabIndex = 38;
            EliminarPasajeroButton.Text = "Eliminar";
            EliminarPasajeroButton.UseVisualStyleBackColor = true;
            // 
            // CrearItinerario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1699, 971);
            Controls.Add(CargaPasajerosGroupBox);
            Controls.Add(groupBox1);
            Controls.Add(NumeroItinerarioLabel);
            Controls.Add(grpMenu);
            Controls.Add(lblNumeroItinerario);
            Controls.Add(RealizarPrereservaButton);
            Controls.Add(RealizarReservaButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrearItinerario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear itinerario";
            Load += CrearItinerario_Load;
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            CargaPasajerosGroupBox.ResumeLayout(false);
            CargaPasajerosGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpMenu;
        private Button ConsultaDisponibilidadHotelesBtn;
        private Button ConsultaDisponibilidadPaquetesBtn;
        private Button ConsultaDisponibilidadVuelosBtn;
        private Label lblNumeroItinerario;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox CantidadAdultosTextBox;
        private Button EliminarHotelButton;
        private Button EliminarPaqueteButton;
        private Button EliminarVueloButton;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button GuardarItinerarioButton;
        private Button CotizarButton;
        private Label NumeroItinerarioLabel;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox CantidadMenoresTextBox;
        private TextBox CantidadInfantesTextBox;
        private Label ValorDeLaCotizacionLabel;
        private Button RealizarReservaButton;
        private Button RealizarPrereservaButton;
        private GroupBox CargaPasajerosGroupBox;
        private ListView listView4;
        private ColumnHeader nombreHeader;
        private ColumnHeader apellidoHeader;
        private ColumnHeader TipoPasajero;
        private Button AgregarPersonaBtn;
        private Button EliminarPasajeroButton;
        private ListView VuelosListView;
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
        private Label label5;
        private ListView ServiciosExtraVuelosListView;
        private ColumnHeader CodigoServicioHeader;
        private ColumnHeader DescripcionServicioHeader;
        private ColumnHeader TarifaServicioHeader;
        private ListView ServiciosExtraHotelesListView;
        private ColumnHeader CodigoHeader;
        private ColumnHeader DescripcionHeader;
        private ColumnHeader TarifaHeader;
        private ColumnHeader PrecioPorPasajeroHeader;
        private Label label10;
        private Label label9;
        private ListView HotelesListView;
        private ColumnHeader CodigoHotelHeader;
        private ColumnHeader columnHeader1;
        private ColumnHeader CódigoCiudadHeader;
        private ColumnHeader DirecciónHeader;
        private ColumnHeader CalificacionHeader;
        private ColumnHeader NombreHabitacionHeader;
        private ColumnHeader TarifaPorDiaHeader;
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
        private ListView AdicionalesPaqueteListView;
        private ColumnHeader CodigoAdicionalHeader;
        private ColumnHeader DescripcionAdicionalHeader;
        private ColumnHeader TarifaAdicionalHeader;
        private Label label11;
    }
}