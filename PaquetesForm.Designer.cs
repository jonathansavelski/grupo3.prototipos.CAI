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
            lblFechaSalida = new Label();
            AplicarFiltrosButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            grpPaquete = new GroupBox();
            lvPaquetes = new ListView();
            CodigoPaqueteHeader = new ColumnHeader();
            CodigoCiudadOrigenPaqueteHeader = new ColumnHeader();
            CodigoCiudadDestinoPaqueteHeader = new ColumnHeader();
            FechaInicioActHeader = new ColumnHeader();
            FechaFinActHeader = new ColumnHeader();
            CapacidadAdultosHeader = new ColumnHeader();
            CapacidadMenoresHeader = new ColumnHeader();
            CantidadPaquetesDisponiblesHeader = new ColumnHeader();
            btnAñadirItPaquete = new Button();
            btnMasInfoPaquete = new Button();
            txtActividades = new TextBox();
            lvAdicionales = new ListView();
            CodigoAdicionalHeader = new ColumnHeader();
            DescripcionAdicionalHeader = new ColumnHeader();
            lvTarifas = new ListView();
            TarifaAdultosHeader = new ColumnHeader();
            TarifaMenoresHeader = new ColumnHeader();
            TarifaInfantesHeader = new ColumnHeader();
            grpMasInformacionPaquete = new GroupBox();
            lblTarifas = new Label();
            lblActividades = new Label();
            lblAdicionales = new Label();
            grpPaquete.SuspendLayout();
            grpMasInformacionPaquete.SuspendLayout();
            SuspendLayout();
            // 
            // lblFechaSalida
            // 
            lblFechaSalida.AutoSize = true;
            lblFechaSalida.Location = new Point(10, 15);
            lblFechaSalida.Name = "lblFechaSalida";
            lblFechaSalida.Size = new Size(160, 20);
            lblFechaSalida.TabIndex = 17;
            lblFechaSalida.Text = "Filtrar por FechaSalida:";
            // 
            // AplicarFiltrosButton
            // 
            AplicarFiltrosButton.Location = new Point(475, 15);
            AplicarFiltrosButton.Name = "AplicarFiltrosButton";
            AplicarFiltrosButton.Size = new Size(117, 30);
            AplicarFiltrosButton.TabIndex = 16;
            AplicarFiltrosButton.Text = "Aplicar filtro";
            AplicarFiltrosButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(173, 15);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(291, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // grpPaquete
            // 
            grpPaquete.Controls.Add(lvPaquetes);
            grpPaquete.Location = new Point(10, 52);
            grpPaquete.Margin = new Padding(3, 4, 3, 4);
            grpPaquete.Name = "grpPaquete";
            grpPaquete.Padding = new Padding(3, 4, 3, 4);
            grpPaquete.Size = new Size(1293, 253);
            grpPaquete.TabIndex = 18;
            grpPaquete.TabStop = false;
            grpPaquete.Text = "Listado de paquetes disponibles. Seleccione:";
            // 
            // lvPaquetes
            // 
            lvPaquetes.Columns.AddRange(new ColumnHeader[] { CodigoPaqueteHeader, CodigoCiudadOrigenPaqueteHeader, CodigoCiudadDestinoPaqueteHeader, FechaInicioActHeader, FechaFinActHeader, CapacidadAdultosHeader, CapacidadMenoresHeader, CantidadPaquetesDisponiblesHeader });
            lvPaquetes.FullRowSelect = true;
            lvPaquetes.Location = new Point(11, 28);
            lvPaquetes.Margin = new Padding(3, 4, 3, 4);
            lvPaquetes.MultiSelect = false;
            lvPaquetes.Name = "lvPaquetes";
            lvPaquetes.Size = new Size(1267, 209);
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
            // btnAñadirItPaquete
            // 
            btnAñadirItPaquete.Location = new Point(173, 313);
            btnAñadirItPaquete.Margin = new Padding(3, 4, 3, 4);
            btnAñadirItPaquete.Name = "btnAñadirItPaquete";
            btnAñadirItPaquete.Size = new Size(155, 39);
            btnAñadirItPaquete.TabIndex = 20;
            btnAñadirItPaquete.Text = "Añadir a itinerario";
            btnAñadirItPaquete.UseVisualStyleBackColor = true;
            // 
            // btnMasInfoPaquete
            // 
            btnMasInfoPaquete.Location = new Point(10, 312);
            btnMasInfoPaquete.Name = "btnMasInfoPaquete";
            btnMasInfoPaquete.Size = new Size(155, 40);
            btnMasInfoPaquete.TabIndex = 19;
            btnMasInfoPaquete.Text = "Ver más información";
            btnMasInfoPaquete.UseVisualStyleBackColor = true;
            btnMasInfoPaquete.Click += btnMasInfoPaquete_Click;
            // 
            // txtActividades
            // 
            txtActividades.AcceptsReturn = true;
            txtActividades.Location = new Point(921, 49);
            txtActividades.Margin = new Padding(3, 4, 3, 4);
            txtActividades.Multiline = true;
            txtActividades.Name = "txtActividades";
            txtActividades.Size = new Size(353, 260);
            txtActividades.TabIndex = 21;
            // 
            // lvAdicionales
            // 
            lvAdicionales.Columns.AddRange(new ColumnHeader[] { CodigoAdicionalHeader, DescripcionAdicionalHeader });
            lvAdicionales.Location = new Point(11, 221);
            lvAdicionales.Margin = new Padding(3, 4, 3, 4);
            lvAdicionales.Name = "lvAdicionales";
            lvAdicionales.Size = new Size(893, 88);
            lvAdicionales.TabIndex = 22;
            lvAdicionales.UseCompatibleStateImageBehavior = false;
            lvAdicionales.View = View.Details;
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
            // lvTarifas
            // 
            lvTarifas.Columns.AddRange(new ColumnHeader[] { TarifaAdultosHeader, TarifaMenoresHeader, TarifaInfantesHeader });
            lvTarifas.Location = new Point(11, 56);
            lvTarifas.Margin = new Padding(3, 4, 3, 4);
            lvTarifas.Name = "lvTarifas";
            lvTarifas.Size = new Size(893, 133);
            lvTarifas.TabIndex = 23;
            lvTarifas.UseCompatibleStateImageBehavior = false;
            lvTarifas.View = View.Details;
            // 
            // TarifaAdultosHeader
            // 
            TarifaAdultosHeader.Text = "Tarifa adultos";
            TarifaAdultosHeader.Width = 150;
            // 
            // TarifaMenoresHeader
            // 
            TarifaMenoresHeader.Text = "Tarifa menores";
            TarifaMenoresHeader.TextAlign = HorizontalAlignment.Center;
            TarifaMenoresHeader.Width = 150;
            // 
            // TarifaInfantesHeader
            // 
            TarifaInfantesHeader.Text = "Tarifa infantes";
            TarifaInfantesHeader.TextAlign = HorizontalAlignment.Center;
            TarifaInfantesHeader.Width = 150;
            // 
            // grpMasInformacionPaquete
            // 
            grpMasInformacionPaquete.Controls.Add(lblTarifas);
            grpMasInformacionPaquete.Controls.Add(lblActividades);
            grpMasInformacionPaquete.Controls.Add(lblAdicionales);
            grpMasInformacionPaquete.Controls.Add(lvTarifas);
            grpMasInformacionPaquete.Controls.Add(txtActividades);
            grpMasInformacionPaquete.Controls.Add(lvAdicionales);
            grpMasInformacionPaquete.Location = new Point(10, 363);
            grpMasInformacionPaquete.Margin = new Padding(3, 4, 3, 4);
            grpMasInformacionPaquete.Name = "grpMasInformacionPaquete";
            grpMasInformacionPaquete.Padding = new Padding(3, 4, 3, 4);
            grpMasInformacionPaquete.Size = new Size(1293, 331);
            grpMasInformacionPaquete.TabIndex = 24;
            grpMasInformacionPaquete.TabStop = false;
            grpMasInformacionPaquete.Text = "Más información:";
            // 
            // lblTarifas
            // 
            lblTarifas.AutoSize = true;
            lblTarifas.Location = new Point(7, 32);
            lblTarifas.Name = "lblTarifas";
            lblTarifas.Size = new Size(138, 20);
            lblTarifas.TabIndex = 26;
            lblTarifas.Text = "Tarifas del paquete:";
            // 
            // lblActividades
            // 
            lblActividades.AutoSize = true;
            lblActividades.Location = new Point(921, 20);
            lblActividades.Name = "lblActividades";
            lblActividades.Size = new Size(173, 20);
            lblActividades.TabIndex = 25;
            lblActividades.Text = "Actividades del paquete:";
            // 
            // lblAdicionales
            // 
            lblAdicionales.AutoSize = true;
            lblAdicionales.Location = new Point(7, 193);
            lblAdicionales.Name = "lblAdicionales";
            lblAdicionales.Size = new Size(89, 20);
            lblAdicionales.TabIndex = 24;
            lblAdicionales.Text = "Adicionales:";
            // 
            // PaquetesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 709);
            Controls.Add(grpMasInformacionPaquete);
            Controls.Add(btnAñadirItPaquete);
            Controls.Add(btnMasInfoPaquete);
            Controls.Add(grpPaquete);
            Controls.Add(lblFechaSalida);
            Controls.Add(AplicarFiltrosButton);
            Controls.Add(dateTimePicker1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PaquetesForm";
            Text = "FormPaquetes";
            Load += PaquetesForm_Load;
            grpPaquete.ResumeLayout(false);
            grpMasInformacionPaquete.ResumeLayout(false);
            grpMasInformacionPaquete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFechaSalida;
        private Button AplicarFiltrosButton;
        private DateTimePicker dateTimePicker1;
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
        private TextBox txtActividades;
        private ListView lvAdicionales;
        private ListView lvTarifas;
        private GroupBox grpMasInformacionPaquete;
        private Label lblAdicionales;
        private ColumnHeader CodigoAdicionalHeader;
        private ColumnHeader DescripcionAdicionalHeader;
        private Label lblActividades;
        private ColumnHeader TarifaAdultosHeader;
        private ColumnHeader TarifaMenoresHeader;
        private ColumnHeader TarifaInfantesHeader;
        private Label lblTarifas;
    }
}