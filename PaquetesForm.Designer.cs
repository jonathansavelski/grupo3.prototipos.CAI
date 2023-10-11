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
            lblFechaSalida.Location = new Point(9, 11);
            lblFechaSalida.Name = "lblFechaSalida";
            lblFechaSalida.Size = new Size(126, 15);
            lblFechaSalida.TabIndex = 17;
            lblFechaSalida.Text = "Filtrar por FechaSalida:";
            // 
            // AplicarFiltrosButton
            // 
            AplicarFiltrosButton.Location = new Point(416, 11);
            AplicarFiltrosButton.Margin = new Padding(3, 2, 3, 2);
            AplicarFiltrosButton.Name = "AplicarFiltrosButton";
            AplicarFiltrosButton.Size = new Size(102, 27);
            AplicarFiltrosButton.TabIndex = 16;
            AplicarFiltrosButton.Text = "Aplicar filtro";
            AplicarFiltrosButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(141, 11);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(255, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // grpPaquete
            // 
            grpPaquete.Controls.Add(lvPaquetes);
            grpPaquete.Location = new Point(9, 39);
            grpPaquete.Name = "grpPaquete";
            grpPaquete.Size = new Size(1043, 190);
            grpPaquete.TabIndex = 18;
            grpPaquete.TabStop = false;
            grpPaquete.Text = "Listado de paquetes disponibles. Seleccione:";
            // 
            // lvPaquetes
            // 
            lvPaquetes.Columns.AddRange(new ColumnHeader[] { CodigoPaqueteHeader, CodigoCiudadOrigenPaqueteHeader, CodigoCiudadDestinoPaqueteHeader, FechaInicioActHeader, FechaFinActHeader, CapacidadAdultosHeader, CapacidadMenoresHeader, CantidadPaquetesDisponiblesHeader });
            lvPaquetes.FullRowSelect = true;
            lvPaquetes.Location = new Point(3, 18);
            lvPaquetes.MultiSelect = false;
            lvPaquetes.Name = "lvPaquetes";
            lvPaquetes.Size = new Size(1023, 158);
            lvPaquetes.TabIndex = 1;
            lvPaquetes.UseCompatibleStateImageBehavior = false;
            lvPaquetes.View = View.Details;
            // 
            // CodigoPaqueteHeader
            // 
            CodigoPaqueteHeader.Text = "CodigoPaquete";
            CodigoPaqueteHeader.Width = 100;
            // 
            // CodigoCiudadOrigenPaqueteHeader
            // 
            CodigoCiudadOrigenPaqueteHeader.Text = "CodigoCiudadOrigen";
            CodigoCiudadOrigenPaqueteHeader.Width = 125;
            // 
            // CodigoCiudadDestinoPaqueteHeader
            // 
            CodigoCiudadDestinoPaqueteHeader.Text = "CodigoCiudadDestino";
            CodigoCiudadDestinoPaqueteHeader.Width = 130;
            // 
            // FechaInicioActHeader
            // 
            FechaInicioActHeader.Text = "FechaInicioActividades";
            FechaInicioActHeader.Width = 135;
            // 
            // FechaFinActHeader
            // 
            FechaFinActHeader.Text = "FechaFinActividades";
            FechaFinActHeader.Width = 120;
            // 
            // CapacidadAdultosHeader
            // 
            CapacidadAdultosHeader.Text = "CapacidadAdultos";
            CapacidadAdultosHeader.Width = 110;
            // 
            // CapacidadMenoresHeader
            // 
            CapacidadMenoresHeader.Text = "CapacidadMenores";
            CapacidadMenoresHeader.Width = 110;
            // 
            // CantidadPaquetesDisponiblesHeader
            // 
            CantidadPaquetesDisponiblesHeader.Text = "CantidadPaquetesDisponibles";
            CantidadPaquetesDisponiblesHeader.Width = 180;
            // 
            // btnAñadirItPaquete
            // 
            btnAñadirItPaquete.Location = new Point(151, 235);
            btnAñadirItPaquete.Name = "btnAñadirItPaquete";
            btnAñadirItPaquete.Size = new Size(136, 29);
            btnAñadirItPaquete.TabIndex = 20;
            btnAñadirItPaquete.Text = "Añadir a itinerario";
            btnAñadirItPaquete.UseVisualStyleBackColor = true;
            // 
            // btnMasInfoPaquete
            // 
            btnMasInfoPaquete.Location = new Point(9, 234);
            btnMasInfoPaquete.Margin = new Padding(3, 2, 3, 2);
            btnMasInfoPaquete.Name = "btnMasInfoPaquete";
            btnMasInfoPaquete.Size = new Size(136, 30);
            btnMasInfoPaquete.TabIndex = 19;
            btnMasInfoPaquete.Text = "Ver más información";
            btnMasInfoPaquete.UseVisualStyleBackColor = true;
            btnMasInfoPaquete.Click += btnMasInfoPaquete_Click;
            // 
            // txtActividades
            // 
            txtActividades.AcceptsReturn = true;
            txtActividades.Location = new Point(404, 42);
            txtActividades.Multiline = true;
            txtActividades.Name = "txtActividades";
            txtActividades.Size = new Size(273, 67);
            txtActividades.TabIndex = 21;
            // 
            // lvAdicionales
            // 
            lvAdicionales.Columns.AddRange(new ColumnHeader[] { CodigoAdicionalHeader, DescripcionAdicionalHeader });
            lvAdicionales.Location = new Point(6, 132);
            lvAdicionales.Name = "lvAdicionales";
            lvAdicionales.Size = new Size(384, 67);
            lvAdicionales.TabIndex = 22;
            lvAdicionales.UseCompatibleStateImageBehavior = false;
            lvAdicionales.View = View.Details;
            // 
            // CodigoAdicionalHeader
            // 
            CodigoAdicionalHeader.Text = "CodigoAdicional";
            CodigoAdicionalHeader.Width = 105;
            // 
            // DescripcionAdicionalHeader
            // 
            DescripcionAdicionalHeader.Text = "Descripción";
            DescripcionAdicionalHeader.Width = 150;
            // 
            // lvTarifas
            // 
            lvTarifas.Columns.AddRange(new ColumnHeader[] { TarifaAdultosHeader, TarifaMenoresHeader, TarifaInfantesHeader });
            lvTarifas.Location = new Point(6, 42);
            lvTarifas.Name = "lvTarifas";
            lvTarifas.Size = new Size(378, 67);
            lvTarifas.TabIndex = 23;
            lvTarifas.UseCompatibleStateImageBehavior = false;
            lvTarifas.View = View.Details;
            // 
            // TarifaAdultosHeader
            // 
            TarifaAdultosHeader.Text = "TarifaAdultos";
            TarifaAdultosHeader.Width = 100;
            // 
            // TarifaMenoresHeader
            // 
            TarifaMenoresHeader.Text = "TarifaMenores";
            TarifaMenoresHeader.Width = 100;
            // 
            // TarifaInfantesHeader
            // 
            TarifaInfantesHeader.Text = "TarifaInfantes";
            TarifaInfantesHeader.Width = 100;
            // 
            // grpMasInformacionPaquete
            // 
            grpMasInformacionPaquete.Controls.Add(lblTarifas);
            grpMasInformacionPaquete.Controls.Add(lblActividades);
            grpMasInformacionPaquete.Controls.Add(lblAdicionales);
            grpMasInformacionPaquete.Controls.Add(lvTarifas);
            grpMasInformacionPaquete.Controls.Add(txtActividades);
            grpMasInformacionPaquete.Controls.Add(lvAdicionales);
            grpMasInformacionPaquete.Location = new Point(12, 272);
            grpMasInformacionPaquete.Name = "grpMasInformacionPaquete";
            grpMasInformacionPaquete.Size = new Size(1040, 248);
            grpMasInformacionPaquete.TabIndex = 24;
            grpMasInformacionPaquete.TabStop = false;
            grpMasInformacionPaquete.Text = "Más información:";
            // 
            // lblTarifas
            // 
            lblTarifas.AutoSize = true;
            lblTarifas.Location = new Point(6, 24);
            lblTarifas.Name = "lblTarifas";
            lblTarifas.Size = new Size(108, 15);
            lblTarifas.TabIndex = 26;
            lblTarifas.Text = "Tarifas del paquete:";
            // 
            // lblActividades
            // 
            lblActividades.AutoSize = true;
            lblActividades.Location = new Point(404, 24);
            lblActividades.Name = "lblActividades";
            lblActividades.Size = new Size(136, 15);
            lblActividades.TabIndex = 25;
            lblActividades.Text = "Actividades del paquete:";
            // 
            // lblAdicionales
            // 
            lblAdicionales.AutoSize = true;
            lblAdicionales.Location = new Point(6, 114);
            lblAdicionales.Name = "lblAdicionales";
            lblAdicionales.Size = new Size(71, 15);
            lblAdicionales.TabIndex = 24;
            lblAdicionales.Text = "Adicionales:";
            // 
            // PaquetesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 532);
            Controls.Add(grpMasInformacionPaquete);
            Controls.Add(btnAñadirItPaquete);
            Controls.Add(btnMasInfoPaquete);
            Controls.Add(grpPaquete);
            Controls.Add(lblFechaSalida);
            Controls.Add(AplicarFiltrosButton);
            Controls.Add(dateTimePicker1);
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