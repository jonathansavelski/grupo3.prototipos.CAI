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
            InformacionHotelButton = new Button();
            grpHotel.SuspendLayout();
            SuspendLayout();
            // 
            // grpHotel
            // 
            grpHotel.Controls.Add(listViewHoteles);
            grpHotel.Location = new Point(17, 40);
            grpHotel.Margin = new Padding(3, 4, 3, 4);
            grpHotel.Name = "grpHotel";
            grpHotel.Padding = new Padding(3, 4, 3, 4);
            grpHotel.Size = new Size(834, 245);
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
            listViewHoteles.Size = new Size(820, 209);
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
            dateTimePicker2.Location = new Point(31, 336);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(291, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // labelIngreso
            // 
            labelIngreso.AutoSize = true;
            labelIngreso.Location = new Point(31, 313);
            labelIngreso.Name = "labelIngreso";
            labelIngreso.Size = new Size(141, 20);
            labelIngreso.TabIndex = 15;
            labelIngreso.Text = "Fecha ingreso Hotel";
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
            // InformacionHotelButton
            // 
            InformacionHotelButton.Location = new Point(858, 351);
            InformacionHotelButton.Name = "InformacionHotelButton";
            InformacionHotelButton.Size = new Size(192, 29);
            InformacionHotelButton.TabIndex = 16;
            InformacionHotelButton.Text = "Ver información Hotel";
            InformacionHotelButton.UseVisualStyleBackColor = true;
            // 
            // HotelesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 561);
            Controls.Add(InformacionHotelButton);
            Controls.Add(labelIngreso);
            Controls.Add(dateTimePicker2);
            Controls.Add(grpHotel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HotelesForm";
            Text = "HotelesForm";
            grpHotel.ResumeLayout(false);
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
        private Button InformacionHotelButton;
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
    }
}