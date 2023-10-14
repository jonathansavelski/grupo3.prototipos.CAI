namespace grupo3.prototipos.CAI
{
    partial class PaquetesForm
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
            grpPaquete = new GroupBox();
            lblPaquetesDisponibles = new Label();
            lvPaquetes = new ListView();
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
            btnAñadirItPaquete = new Button();
            btnMasInfoPaquete = new Button();
            txtActividadesPaquete = new TextBox();
            lvAdicionalesPaquete = new ListView();
            CodigoAdicionalHeader = new ColumnHeader();
            DescripcionAdicionalHeader = new ColumnHeader();
            grpMasInformacionPaquete = new GroupBox();
            lblActividadesPaquete = new Label();
            lblAdicionalesPaquete = new Label();
            grpFiltrosPaquete = new GroupBox();
            dtpFinPaquete = new DateTimePicker();
            lblDestinoPaquete = new Label();
            txtDestinoHotel = new TextBox();
            lblOrigenHotel = new Label();
            txtOrigenPaquete = new TextBox();
            lblTituloPaquetes = new Label();
            AplicarFiltrosPaqueteButton = new Button();
            lblRangoPaquete = new Label();
            dtpInicioPaquete = new DateTimePicker();
            grpPaquete.SuspendLayout();
            grpMasInformacionPaquete.SuspendLayout();
            grpFiltrosPaquete.SuspendLayout();
            SuspendLayout();
            // 
            // grpPaquete
            // 
            grpPaquete.Controls.Add(lblPaquetesDisponibles);
            grpPaquete.Controls.Add(lvPaquetes);
            grpPaquete.Location = new Point(14, 135);
            grpPaquete.Margin = new Padding(3, 4, 3, 4);
            grpPaquete.Name = "grpPaquete";
            grpPaquete.Padding = new Padding(3, 4, 3, 4);
            grpPaquete.Size = new Size(1646, 253);
            grpPaquete.TabIndex = 18;
            grpPaquete.TabStop = false;
            // 
            // lblPaquetesDisponibles
            // 
            lblPaquetesDisponibles.AutoSize = true;
            lblPaquetesDisponibles.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPaquetesDisponibles.Location = new Point(10, 0);
            lblPaquetesDisponibles.Name = "lblPaquetesDisponibles";
            lblPaquetesDisponibles.Size = new Size(160, 20);
            lblPaquetesDisponibles.TabIndex = 22;
            lblPaquetesDisponibles.Text = "Paquetes disponibles:";
            // 
            // lvPaquetes
            // 
            lvPaquetes.Columns.AddRange(new ColumnHeader[] { CodigoPaqueteHeader, CodigoCiudadOrigenPaqueteHeader, CodigoCiudadDestinoPaqueteHeader, FechaInicioActHeader, FechaFinActHeader, CapacidadAdultosHeader, CapacidadMenoresHeader, CantidadPaquetesDisponiblesHeader, TarifaAdultoHeader, TarifaMenorHeader, TarifaInfanteHeader });
            lvPaquetes.FullRowSelect = true;
            lvPaquetes.Location = new Point(11, 28);
            lvPaquetes.Margin = new Padding(3, 4, 3, 4);
            lvPaquetes.MultiSelect = false;
            lvPaquetes.Name = "lvPaquetes";
            lvPaquetes.Size = new Size(1625, 209);
            lvPaquetes.TabIndex = 1;
            lvPaquetes.UseCompatibleStateImageBehavior = false;
            lvPaquetes.View = View.Details;
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
            // btnAñadirItPaquete
            // 
            btnAñadirItPaquete.Location = new Point(176, 396);
            btnAñadirItPaquete.Margin = new Padding(3, 4, 3, 4);
            btnAñadirItPaquete.Name = "btnAñadirItPaquete";
            btnAñadirItPaquete.Size = new Size(155, 39);
            btnAñadirItPaquete.TabIndex = 20;
            btnAñadirItPaquete.Text = "Añadir a itinerario";
            btnAñadirItPaquete.UseVisualStyleBackColor = true;
            // 
            // btnMasInfoPaquete
            // 
            btnMasInfoPaquete.Location = new Point(14, 395);
            btnMasInfoPaquete.Name = "btnMasInfoPaquete";
            btnMasInfoPaquete.Size = new Size(155, 40);
            btnMasInfoPaquete.TabIndex = 19;
            btnMasInfoPaquete.Text = "Ver más información";
            btnMasInfoPaquete.UseVisualStyleBackColor = true;
            btnMasInfoPaquete.Click += btnMasInfoPaquete_Click;
            // 
            // txtActividadesPaquete
            // 
            txtActividadesPaquete.AcceptsReturn = true;
            txtActividadesPaquete.Location = new Point(921, 70);
            txtActividadesPaquete.Margin = new Padding(3, 4, 3, 4);
            txtActividadesPaquete.Multiline = true;
            txtActividadesPaquete.Name = "txtActividadesPaquete";
            txtActividadesPaquete.Size = new Size(715, 239);
            txtActividadesPaquete.TabIndex = 21;
            // 
            // lvAdicionalesPaquete
            // 
            lvAdicionalesPaquete.Columns.AddRange(new ColumnHeader[] { CodigoAdicionalHeader, DescripcionAdicionalHeader });
            lvAdicionalesPaquete.Location = new Point(13, 70);
            lvAdicionalesPaquete.Margin = new Padding(3, 4, 3, 4);
            lvAdicionalesPaquete.Name = "lvAdicionalesPaquete";
            lvAdicionalesPaquete.Size = new Size(893, 239);
            lvAdicionalesPaquete.TabIndex = 22;
            lvAdicionalesPaquete.UseCompatibleStateImageBehavior = false;
            lvAdicionalesPaquete.View = View.Details;
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
            // grpMasInformacionPaquete
            // 
            grpMasInformacionPaquete.Controls.Add(lblActividadesPaquete);
            grpMasInformacionPaquete.Controls.Add(lblAdicionalesPaquete);
            grpMasInformacionPaquete.Controls.Add(txtActividadesPaquete);
            grpMasInformacionPaquete.Controls.Add(lvAdicionalesPaquete);
            grpMasInformacionPaquete.Location = new Point(14, 471);
            grpMasInformacionPaquete.Margin = new Padding(3, 4, 3, 4);
            grpMasInformacionPaquete.Name = "grpMasInformacionPaquete";
            grpMasInformacionPaquete.Padding = new Padding(3, 4, 3, 4);
            grpMasInformacionPaquete.Size = new Size(1646, 330);
            grpMasInformacionPaquete.TabIndex = 24;
            grpMasInformacionPaquete.TabStop = false;
            grpMasInformacionPaquete.Text = "Más información:";
            // 
            // lblActividadesPaquete
            // 
            lblActividadesPaquete.AutoSize = true;
            lblActividadesPaquete.Location = new Point(921, 42);
            lblActividadesPaquete.Name = "lblActividadesPaquete";
            lblActividadesPaquete.Size = new Size(173, 20);
            lblActividadesPaquete.TabIndex = 25;
            lblActividadesPaquete.Text = "Actividades del paquete:";
            // 
            // lblAdicionalesPaquete
            // 
            lblAdicionalesPaquete.AutoSize = true;
            lblAdicionalesPaquete.Location = new Point(9, 42);
            lblAdicionalesPaquete.Name = "lblAdicionalesPaquete";
            lblAdicionalesPaquete.Size = new Size(89, 20);
            lblAdicionalesPaquete.TabIndex = 24;
            lblAdicionalesPaquete.Text = "Adicionales:";
            // 
            // grpFiltrosPaquete
            // 
            grpFiltrosPaquete.Controls.Add(dtpFinPaquete);
            grpFiltrosPaquete.Controls.Add(lblDestinoPaquete);
            grpFiltrosPaquete.Controls.Add(txtDestinoHotel);
            grpFiltrosPaquete.Controls.Add(lblOrigenHotel);
            grpFiltrosPaquete.Controls.Add(txtOrigenPaquete);
            grpFiltrosPaquete.Controls.Add(lblTituloPaquetes);
            grpFiltrosPaquete.Controls.Add(AplicarFiltrosPaqueteButton);
            grpFiltrosPaquete.Controls.Add(lblRangoPaquete);
            grpFiltrosPaquete.Controls.Add(dtpInicioPaquete);
            grpFiltrosPaquete.Location = new Point(14, -3);
            grpFiltrosPaquete.Margin = new Padding(3, 4, 3, 4);
            grpFiltrosPaquete.Name = "grpFiltrosPaquete";
            grpFiltrosPaquete.Padding = new Padding(3, 4, 3, 4);
            grpFiltrosPaquete.Size = new Size(1293, 129);
            grpFiltrosPaquete.TabIndex = 25;
            grpFiltrosPaquete.TabStop = false;
            // 
            // dtpFinPaquete
            // 
            dtpFinPaquete.Format = DateTimePickerFormat.Short;
            dtpFinPaquete.Location = new Point(477, 76);
            dtpFinPaquete.Name = "dtpFinPaquete";
            dtpFinPaquete.Size = new Size(121, 27);
            dtpFinPaquete.TabIndex = 27;
            // 
            // lblDestinoPaquete
            // 
            lblDestinoPaquete.AutoSize = true;
            lblDestinoPaquete.Location = new Point(161, 49);
            lblDestinoPaquete.Name = "lblDestinoPaquete";
            lblDestinoPaquete.Size = new Size(111, 20);
            lblDestinoPaquete.TabIndex = 26;
            lblDestinoPaquete.Text = "Código destino";
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
            lblOrigenHotel.Size = new Size(105, 20);
            lblOrigenHotel.TabIndex = 24;
            lblOrigenHotel.Text = "Código origen";
            // 
            // txtOrigenPaquete
            // 
            txtOrigenPaquete.Location = new Point(13, 76);
            txtOrigenPaquete.Name = "txtOrigenPaquete";
            txtOrigenPaquete.Size = new Size(125, 27);
            txtOrigenPaquete.TabIndex = 23;
            // 
            // lblTituloPaquetes
            // 
            lblTituloPaquetes.AutoSize = true;
            lblTituloPaquetes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloPaquetes.Location = new Point(11, 15);
            lblTituloPaquetes.Name = "lblTituloPaquetes";
            lblTituloPaquetes.Size = new Size(250, 20);
            lblTituloPaquetes.TabIndex = 1;
            lblTituloPaquetes.Text = "Búsqueda de paquetes disponibles";
            // 
            // AplicarFiltrosPaqueteButton
            // 
            AplicarFiltrosPaqueteButton.Location = new Point(626, 73);
            AplicarFiltrosPaqueteButton.Name = "AplicarFiltrosPaqueteButton";
            AplicarFiltrosPaqueteButton.Size = new Size(122, 29);
            AplicarFiltrosPaqueteButton.TabIndex = 21;
            AplicarFiltrosPaqueteButton.Text = "Aplicar filtros";
            AplicarFiltrosPaqueteButton.UseVisualStyleBackColor = true;
            AplicarFiltrosPaqueteButton.Click += AplicarFiltrosPaqueteButton_Click;
            // 
            // lblRangoPaquete
            // 
            lblRangoPaquete.AutoSize = true;
            lblRangoPaquete.Location = new Point(335, 47);
            lblRangoPaquete.Name = "lblRangoPaquete";
            lblRangoPaquete.Size = new Size(124, 20);
            lblRangoPaquete.TabIndex = 22;
            lblRangoPaquete.Text = "Rango de Fechas:";
            // 
            // dtpInicioPaquete
            // 
            dtpInicioPaquete.Format = DateTimePickerFormat.Short;
            dtpInicioPaquete.Location = new Point(338, 76);
            dtpInicioPaquete.Name = "dtpInicioPaquete";
            dtpInicioPaquete.Size = new Size(121, 27);
            dtpInicioPaquete.TabIndex = 20;
            // 
            // PaquetesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1666, 814);
            Controls.Add(grpFiltrosPaquete);
            Controls.Add(grpMasInformacionPaquete);
            Controls.Add(btnAñadirItPaquete);
            Controls.Add(btnMasInfoPaquete);
            Controls.Add(grpPaquete);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PaquetesForm";
            Text = "Paquetes";
            Load += PaquetesForm_Load;
            grpPaquete.ResumeLayout(false);
            grpPaquete.PerformLayout();
            grpMasInformacionPaquete.ResumeLayout(false);
            grpMasInformacionPaquete.PerformLayout();
            grpFiltrosPaquete.ResumeLayout(false);
            grpFiltrosPaquete.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpPaquete;
        private ListView lvPaquetes;
        private ColumnHeader CodigoPaqueteHeader;
        private ColumnHeader CodigoCiudadOrigenPaqueteHeader;
        private ColumnHeader CodigoCiudadDestinoPaqueteHeader;
        private ColumnHeader FechaInicioActHeader;
        private ColumnHeader FechaFinActHeader;
        private ColumnHeader CapacidadAdultosHeader;
        private ColumnHeader CapacidadMenoresHeader;
        private ColumnHeader CantidadPaquetesDisponiblesHeader;
        private Button btnAñadirItPaquete;
        private Button btnMasInfoPaquete;
        private TextBox txtActividadesPaquete;
        private ListView lvAdicionalesPaquete;
        private GroupBox grpMasInformacionPaquete;
        private Label lblAdicionalesPaquete;
        private ColumnHeader CodigoAdicionalHeader;
        private ColumnHeader DescripcionAdicionalHeader;
        private Label lblActividadesPaquete;
        private GroupBox grpFiltrosPaquete;
        private DateTimePicker dtpFinPaquete;
        private Label lblDestinoPaquete;
        private TextBox txtDestinoHotel;
        private Label lblOrigenHotel;
        private TextBox txtOrigenPaquete;
        private Label lblTituloPaquetes;
        private Button AplicarFiltrosPaqueteButton;
        private Label lblRangoPaquete;
        private DateTimePicker dtpInicioPaquete;
        private Label lblPaquetesDisponibles;
        private ColumnHeader TarifaAdultoHeader;
        private ColumnHeader TarifaMenorHeader;
        private ColumnHeader TarifaInfanteHeader;
    }
}