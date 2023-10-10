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
            grpVuelo = new GroupBox();
            VuelosListView = new ListView();
            CodigoVueloHeader = new ColumnHeader();
            OrigenVueloHeader = new ColumnHeader();
            DestinoVueloHeader = new ColumnHeader();
            FechaSalidaVueloHeader = new ColumnHeader();
            FechaArriboVueloHeader = new ColumnHeader();
            TiempoVueloHeader = new ColumnHeader();
            CodigoAerolineaVueloHeader = new ColumnHeader();
            InformacionVueloButton = new Button();
            MasInformacionGrp = new GroupBox();
            button1 = new Button();
            label2 = new Label();
            lblServiciosExtra = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            lblTarifas = new Label();
            lblParadas = new Label();
            PrecioMinimoVueloTextBox = new TextBox();
            ServiciosExtraListView = new ListView();
            TarifasListView = new ListView();
            ParadasListView = new ListView();
            dateTimePicker1 = new DateTimePicker();
            AplicarFiltrosButton = new Button();
            label3 = new Label();
            grpVuelo.SuspendLayout();
            MasInformacionGrp.SuspendLayout();
            SuspendLayout();
            // 
            // grpVuelo
            // 
            grpVuelo.Controls.Add(VuelosListView);
            grpVuelo.Location = new Point(12, 12);
            grpVuelo.Name = "grpVuelo";
            grpVuelo.Size = new Size(1049, 184);
            grpVuelo.TabIndex = 4;
            grpVuelo.TabStop = false;
            grpVuelo.Text = "Vuelos disponibles:";
            // 
            // VuelosListView
            // 
            VuelosListView.Columns.AddRange(new ColumnHeader[] { CodigoVueloHeader, OrigenVueloHeader, DestinoVueloHeader, FechaSalidaVueloHeader, FechaArriboVueloHeader, TiempoVueloHeader, CodigoAerolineaVueloHeader });
            VuelosListView.FullRowSelect = true;
            VuelosListView.Location = new Point(12, 21);
            VuelosListView.MultiSelect = false;
            VuelosListView.Name = "VuelosListView";
            VuelosListView.Size = new Size(1016, 158);
            VuelosListView.TabIndex = 0;
            VuelosListView.UseCompatibleStateImageBehavior = false;
            VuelosListView.View = View.Details;
            VuelosListView.SelectedIndexChanged += VuelosListView_SelectedIndexChanged;
            // 
            // CodigoVueloHeader
            // 
            CodigoVueloHeader.Text = "CodigoVuelo";
            CodigoVueloHeader.Width = 120;
            // 
            // OrigenVueloHeader
            // 
            OrigenVueloHeader.Text = "OrigenVuelo";
            OrigenVueloHeader.Width = 120;
            // 
            // DestinoVueloHeader
            // 
            DestinoVueloHeader.Text = "DestinoVuelo";
            DestinoVueloHeader.Width = 120;
            // 
            // FechaSalidaVueloHeader
            // 
            FechaSalidaVueloHeader.Text = "FechaSalida(mes/dia/año/hora)";
            FechaSalidaVueloHeader.Width = 250;
            // 
            // FechaArriboVueloHeader
            // 
            FechaArriboVueloHeader.Text = "FechaArribo(mes/dia/año/hora)";
            FechaArriboVueloHeader.Width = 250;
            // 
            // TiempoVueloHeader
            // 
            TiempoVueloHeader.Text = "Tiempo";
            TiempoVueloHeader.Width = 100;
            // 
            // CodigoAerolineaVueloHeader
            // 
            CodigoAerolineaVueloHeader.Text = "CodigoAerolinea";
            CodigoAerolineaVueloHeader.Width = 200;
            // 
            // InformacionVueloButton
            // 
            InformacionVueloButton.Location = new Point(893, 234);
            InformacionVueloButton.Margin = new Padding(3, 2, 3, 2);
            InformacionVueloButton.Name = "InformacionVueloButton";
            InformacionVueloButton.Size = new Size(168, 22);
            InformacionVueloButton.TabIndex = 6;
            InformacionVueloButton.Text = "Ver información del vuelo";
            InformacionVueloButton.UseVisualStyleBackColor = true;
            InformacionVueloButton.Click += InformacionVueloButton_Click;
            // 
            // MasInformacionGrp
            // 
            MasInformacionGrp.Controls.Add(button1);
            MasInformacionGrp.Controls.Add(label2);
            MasInformacionGrp.Controls.Add(lblServiciosExtra);
            MasInformacionGrp.Controls.Add(textBox1);
            MasInformacionGrp.Controls.Add(label1);
            MasInformacionGrp.Controls.Add(lblTarifas);
            MasInformacionGrp.Controls.Add(lblParadas);
            MasInformacionGrp.Controls.Add(PrecioMinimoVueloTextBox);
            MasInformacionGrp.Controls.Add(ServiciosExtraListView);
            MasInformacionGrp.Controls.Add(TarifasListView);
            MasInformacionGrp.Controls.Add(ParadasListView);
            MasInformacionGrp.Location = new Point(12, 261);
            MasInformacionGrp.Name = "MasInformacionGrp";
            MasInformacionGrp.Size = new Size(1049, 260);
            MasInformacionGrp.TabIndex = 7;
            MasInformacionGrp.TabStop = false;
            MasInformacionGrp.Text = "Más información:";
            // 
            // button1
            // 
            button1.Location = new Point(465, 225);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 11;
            button1.Text = "Aplicar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 209);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 13;
            label2.Text = "Máximo";
            // 
            // lblServiciosExtra
            // 
            lblServiciosExtra.AutoSize = true;
            lblServiciosExtra.Location = new Point(567, 124);
            lblServiciosExtra.Name = "lblServiciosExtra";
            lblServiciosExtra.Size = new Size(85, 15);
            lblServiciosExtra.TabIndex = 5;
            lblServiciosExtra.Text = "Servicios extra:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 226);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 12;
            textBox1.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 208);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 11;
            label1.Text = "Mínimo";
            // 
            // lblTarifas
            // 
            lblTarifas.AutoSize = true;
            lblTarifas.Location = new Point(12, 124);
            lblTarifas.Name = "lblTarifas";
            lblTarifas.Size = new Size(43, 15);
            lblTarifas.TabIndex = 4;
            lblTarifas.Text = "Tarifas:";
            // 
            // lblParadas
            // 
            lblParadas.AutoSize = true;
            lblParadas.Location = new Point(12, 27);
            lblParadas.Name = "lblParadas";
            lblParadas.Size = new Size(51, 15);
            lblParadas.TabIndex = 3;
            lblParadas.Text = "Paradas:";
            // 
            // PrecioMinimoVueloTextBox
            // 
            PrecioMinimoVueloTextBox.Location = new Point(16, 226);
            PrecioMinimoVueloTextBox.Margin = new Padding(3, 2, 3, 2);
            PrecioMinimoVueloTextBox.Name = "PrecioMinimoVueloTextBox";
            PrecioMinimoVueloTextBox.Size = new Size(110, 23);
            PrecioMinimoVueloTextBox.TabIndex = 9;
            PrecioMinimoVueloTextBox.Tag = "";
            // 
            // ServiciosExtraListView
            // 
            ServiciosExtraListView.Location = new Point(567, 151);
            ServiciosExtraListView.Name = "ServiciosExtraListView";
            ServiciosExtraListView.Size = new Size(462, 97);
            ServiciosExtraListView.TabIndex = 2;
            ServiciosExtraListView.UseCompatibleStateImageBehavior = false;
            // 
            // TarifasListView
            // 
            TarifasListView.Location = new Point(12, 151);
            TarifasListView.Name = "TarifasListView";
            TarifasListView.Size = new Size(535, 48);
            TarifasListView.TabIndex = 1;
            TarifasListView.UseCompatibleStateImageBehavior = false;
            // 
            // ParadasListView
            // 
            ParadasListView.Location = new Point(12, 45);
            ParadasListView.Name = "ParadasListView";
            ParadasListView.Size = new Size(1016, 66);
            ParadasListView.TabIndex = 0;
            ParadasListView.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(24, 233);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(255, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // AplicarFiltrosButton
            // 
            AplicarFiltrosButton.Location = new Point(806, 234);
            AplicarFiltrosButton.Margin = new Padding(3, 2, 3, 2);
            AplicarFiltrosButton.Name = "AplicarFiltrosButton";
            AplicarFiltrosButton.Size = new Size(82, 22);
            AplicarFiltrosButton.TabIndex = 10;
            AplicarFiltrosButton.Text = "Aplicar";
            AplicarFiltrosButton.UseVisualStyleBackColor = true;
            AplicarFiltrosButton.Click += AplicarFiltrosButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 208);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 14;
            label3.Text = "Fecha de Salida";
            // 
            // VuelosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 535);
            Controls.Add(label3);
            Controls.Add(AplicarFiltrosButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(MasInformacionGrp);
            Controls.Add(InformacionVueloButton);
            Controls.Add(grpVuelo);
            Name = "VuelosForm";
            Text = "FormVuelos";
            Load += Form1_Load;
            grpVuelo.ResumeLayout(false);
            MasInformacionGrp.ResumeLayout(false);
            MasInformacionGrp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox grpVuelo;
        private ListView VuelosListView;
        private ColumnHeader CodigoVueloHeader;
        private ColumnHeader OrigenVueloHeader;
        private ColumnHeader DestinoVueloHeader;
        private ColumnHeader FechaSalidaVueloHeader;
        private ColumnHeader FechaArriboVueloHeader;
        private ColumnHeader TiempoVueloHeader;
        private ColumnHeader CodigoAerolineaVueloHeader;
        private Button InformacionVueloButton;
        private GroupBox MasInformacionGrp;
        private Label lblServiciosExtra;
        private Label lblTarifas;
        private Label lblParadas;
        private ListView ServiciosExtraListView;
        private ListView TarifasListView;
        private ListView ParadasListView;
        private DateTimePicker dateTimePicker1;
        private TextBox PrecioMinimoVueloTextBox;
        private Button AplicarFiltrosButton;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label3;
    }
}