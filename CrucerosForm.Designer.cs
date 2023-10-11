namespace grupo3.prototipos.CAI
{
    partial class CrucerosForm
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
            button1 = new Button();
            lblFechaSalida = new Label();
            AplicarFiltrosButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            InformacionVueloButton = new Button();
            grpCrucero = new GroupBox();
            VuelosListView = new ListView();
            OrigenCruceroHeader = new ColumnHeader();
            DestinoCruceroHeader = new ColumnHeader();
            FechaSalidaCruceroHeader = new ColumnHeader();
            FechaArriboCruceroHeader = new ColumnHeader();
            MasInformacionGrp = new GroupBox();
            lblTarifas = new Label();
            lblParadas = new Label();
            TarifasListView = new ListView();
            NombreHeader = new ColumnHeader();
            TarifaHeader = new ColumnHeader();
            CapacidadHeader = new ColumnHeader();
            MaxAdultosHeader = new ColumnHeader();
            MaxMenoresHeader = new ColumnHeader();
            MaxInfantesHeader = new ColumnHeader();
            DisponibilidadHeader = new ColumnHeader();
            ParadasListView = new ListView();
            CódigoCiudadHeader = new ColumnHeader();
            DesdeDiaHeader = new ColumnHeader();
            HastaDiaHeader = new ColumnHeader();
            DesdeHoraHeader = new ColumnHeader();
            HastaHoraHeader = new ColumnHeader();
            grpCrucero.SuspendLayout();
            MasInformacionGrp.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(179, 333);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(155, 39);
            button1.TabIndex = 21;
            button1.Text = "Añadir a itinerario";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblFechaSalida
            // 
            lblFechaSalida.AutoSize = true;
            lblFechaSalida.Location = new Point(12, 24);
            lblFechaSalida.Name = "lblFechaSalida";
            lblFechaSalida.Size = new Size(160, 20);
            lblFechaSalida.TabIndex = 20;
            lblFechaSalida.Text = "Filtrar por FechaSalida:";
            // 
            // AplicarFiltrosButton
            // 
            AplicarFiltrosButton.Location = new Point(500, 20);
            AplicarFiltrosButton.Name = "AplicarFiltrosButton";
            AplicarFiltrosButton.Size = new Size(117, 28);
            AplicarFiltrosButton.TabIndex = 19;
            AplicarFiltrosButton.Text = "Aplicar filtro";
            AplicarFiltrosButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            dateTimePicker1.Location = new Point(190, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(290, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // InformacionVueloButton
            // 
            InformacionVueloButton.Location = new Point(18, 332);
            InformacionVueloButton.Name = "InformacionVueloButton";
            InformacionVueloButton.Size = new Size(155, 40);
            InformacionVueloButton.TabIndex = 17;
            InformacionVueloButton.Text = "Ver más información";
            InformacionVueloButton.UseVisualStyleBackColor = true;
            // 
            // grpCrucero
            // 
            grpCrucero.Controls.Add(VuelosListView);
            grpCrucero.Location = new Point(12, 80);
            grpCrucero.Margin = new Padding(3, 4, 3, 4);
            grpCrucero.Name = "grpCrucero";
            grpCrucero.Padding = new Padding(3, 4, 3, 4);
            grpCrucero.Size = new Size(1143, 245);
            grpCrucero.TabIndex = 16;
            grpCrucero.TabStop = false;
            grpCrucero.Text = "Seleccione un crucero disponible:";
            // 
            // VuelosListView
            // 
            VuelosListView.Columns.AddRange(new ColumnHeader[] { OrigenCruceroHeader, DestinoCruceroHeader, FechaSalidaCruceroHeader, FechaArriboCruceroHeader });
            VuelosListView.FullRowSelect = true;
            VuelosListView.Location = new Point(6, 28);
            VuelosListView.Margin = new Padding(3, 4, 3, 4);
            VuelosListView.MultiSelect = false;
            VuelosListView.Name = "VuelosListView";
            VuelosListView.Size = new Size(1131, 209);
            VuelosListView.TabIndex = 0;
            VuelosListView.UseCompatibleStateImageBehavior = false;
            VuelosListView.View = View.Details;
            // 
            // OrigenCruceroHeader
            // 
            OrigenCruceroHeader.Text = "Origen de Crucero";
            OrigenCruceroHeader.Width = 140;
            // 
            // DestinoCruceroHeader
            // 
            DestinoCruceroHeader.Text = "Destino de Crucero";
            DestinoCruceroHeader.TextAlign = HorizontalAlignment.Center;
            DestinoCruceroHeader.Width = 140;
            // 
            // FechaSalidaCruceroHeader
            // 
            FechaSalidaCruceroHeader.Text = "Fecha de Salida (mes/dia/año/hora)";
            FechaSalidaCruceroHeader.TextAlign = HorizontalAlignment.Center;
            FechaSalidaCruceroHeader.Width = 280;
            // 
            // FechaArriboCruceroHeader
            // 
            FechaArriboCruceroHeader.Text = "Fecha de Arribo (mes/dia/año/hora)";
            FechaArriboCruceroHeader.TextAlign = HorizontalAlignment.Center;
            FechaArriboCruceroHeader.Width = 280;
            // 
            // MasInformacionGrp
            // 
            MasInformacionGrp.Controls.Add(lblTarifas);
            MasInformacionGrp.Controls.Add(lblParadas);
            MasInformacionGrp.Controls.Add(TarifasListView);
            MasInformacionGrp.Controls.Add(ParadasListView);
            MasInformacionGrp.Location = new Point(12, 380);
            MasInformacionGrp.Margin = new Padding(3, 4, 3, 4);
            MasInformacionGrp.Name = "MasInformacionGrp";
            MasInformacionGrp.Padding = new Padding(3, 4, 3, 4);
            MasInformacionGrp.Size = new Size(1143, 321);
            MasInformacionGrp.TabIndex = 22;
            MasInformacionGrp.TabStop = false;
            MasInformacionGrp.Text = "Más información:";
            // 
            // lblTarifas
            // 
            lblTarifas.AutoSize = true;
            lblTarifas.Location = new Point(14, 178);
            lblTarifas.Name = "lblTarifas";
            lblTarifas.Size = new Size(54, 20);
            lblTarifas.TabIndex = 4;
            lblTarifas.Text = "Tarifas:";
            // 
            // lblParadas
            // 
            lblParadas.AutoSize = true;
            lblParadas.Location = new Point(14, 37);
            lblParadas.Name = "lblParadas";
            lblParadas.Size = new Size(63, 20);
            lblParadas.TabIndex = 3;
            lblParadas.Text = "Paradas:";
            // 
            // TarifasListView
            // 
            TarifasListView.Columns.AddRange(new ColumnHeader[] { NombreHeader, TarifaHeader, CapacidadHeader, MaxAdultosHeader, MaxMenoresHeader, MaxInfantesHeader, DisponibilidadHeader });
            TarifasListView.Location = new Point(14, 201);
            TarifasListView.Margin = new Padding(3, 4, 3, 4);
            TarifasListView.Name = "TarifasListView";
            TarifasListView.Size = new Size(1084, 104);
            TarifasListView.TabIndex = 1;
            TarifasListView.UseCompatibleStateImageBehavior = false;
            TarifasListView.View = View.Details;
            // 
            // NombreHeader
            // 
            NombreHeader.Text = "Nombre";
            NombreHeader.Width = 100;
            // 
            // TarifaHeader
            // 
            TarifaHeader.Text = "Tarifa";
            TarifaHeader.TextAlign = HorizontalAlignment.Center;
            TarifaHeader.Width = 100;
            // 
            // CapacidadHeader
            // 
            CapacidadHeader.Text = "Capacidad";
            CapacidadHeader.TextAlign = HorizontalAlignment.Center;
            CapacidadHeader.Width = 100;
            // 
            // MaxAdultosHeader
            // 
            MaxAdultosHeader.Text = "Max. Adultos";
            MaxAdultosHeader.TextAlign = HorizontalAlignment.Center;
            MaxAdultosHeader.Width = 100;
            // 
            // MaxMenoresHeader
            // 
            MaxMenoresHeader.Text = "Max. Menores";
            MaxMenoresHeader.TextAlign = HorizontalAlignment.Center;
            MaxMenoresHeader.Width = 120;
            // 
            // MaxInfantesHeader
            // 
            MaxInfantesHeader.Text = "Max. Infantes";
            MaxInfantesHeader.Width = 100;
            // 
            // DisponibilidadHeader
            // 
            DisponibilidadHeader.Text = "Disponibilidad";
            DisponibilidadHeader.TextAlign = HorizontalAlignment.Center;
            DisponibilidadHeader.Width = 120;
            // 
            // ParadasListView
            // 
            ParadasListView.Columns.AddRange(new ColumnHeader[] { CódigoCiudadHeader, DesdeDiaHeader, HastaDiaHeader, DesdeHoraHeader, HastaHoraHeader });
            ParadasListView.Location = new Point(14, 60);
            ParadasListView.Margin = new Padding(3, 4, 3, 4);
            ParadasListView.Name = "ParadasListView";
            ParadasListView.Size = new Size(1084, 87);
            ParadasListView.TabIndex = 0;
            ParadasListView.UseCompatibleStateImageBehavior = false;
            ParadasListView.View = View.Details;
            // 
            // CódigoCiudadHeader
            // 
            CódigoCiudadHeader.Text = "Código de Ciudad";
            CódigoCiudadHeader.Width = 150;
            // 
            // DesdeDiaHeader
            // 
            DesdeDiaHeader.Text = "Desde día";
            DesdeDiaHeader.TextAlign = HorizontalAlignment.Center;
            DesdeDiaHeader.Width = 100;
            // 
            // HastaDiaHeader
            // 
            HastaDiaHeader.Text = "Hasta día";
            HastaDiaHeader.TextAlign = HorizontalAlignment.Center;
            HastaDiaHeader.Width = 100;
            // 
            // DesdeHoraHeader
            // 
            DesdeHoraHeader.Text = "Desde hora";
            DesdeHoraHeader.TextAlign = HorizontalAlignment.Center;
            DesdeHoraHeader.Width = 100;
            // 
            // HastaHoraHeader
            // 
            HastaHoraHeader.Text = "Hasta hora";
            HastaHoraHeader.TextAlign = HorizontalAlignment.Center;
            HastaHoraHeader.Width = 100;
            // 
            // CrucerosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 714);
            Controls.Add(MasInformacionGrp);
            Controls.Add(button1);
            Controls.Add(lblFechaSalida);
            Controls.Add(AplicarFiltrosButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(InformacionVueloButton);
            Controls.Add(grpCrucero);
            Name = "CrucerosForm";
            Text = "CrucerosForm";
            grpCrucero.ResumeLayout(false);
            MasInformacionGrp.ResumeLayout(false);
            MasInformacionGrp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblFechaSalida;
        private Button AplicarFiltrosButton;
        private DateTimePicker dateTimePicker1;
        private Button InformacionVueloButton;
        private GroupBox grpCrucero;
        private ListView VuelosListView;
        private ColumnHeader OrigenCruceroHeader;
        private ColumnHeader DestinoCruceroHeader;
        private ColumnHeader FechaSalidaCruceroHeader;
        private ColumnHeader FechaArriboCruceroHeader;
        private GroupBox MasInformacionGrp;
        private Label lblTarifas;
        private Label lblParadas;
        private ListView TarifasListView;
        private ColumnHeader NombreHeader;
        private ColumnHeader TarifaHeader;
        private ColumnHeader CapacidadHeader;
        private ColumnHeader MaxAdultosHeader;
        private ColumnHeader MaxMenoresHeader;
        private ColumnHeader MaxInfantesHeader;
        private ColumnHeader DisponibilidadHeader;
        private ListView ParadasListView;
        private ColumnHeader CódigoCiudadHeader;
        private ColumnHeader DesdeDiaHeader;
        private ColumnHeader HastaDiaHeader;
        private ColumnHeader DesdeHoraHeader;
        private ColumnHeader HastaHoraHeader;
    }
}