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
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            dateTimePicker2 = new DateTimePicker();
            labelIngreso = new Label();
            this.AplicarFiltrosHotelButton = new Button();
            this.InformacionGrp = new GroupBox();
            button1 = new Button();
            lblServiciosExtra = new Label();
            lblDisponibilidad = new Label();
            ServiciosExtraListView = new ListView();
            DisponibilidadListView = new ListView();
            InformacionHotelButton = new Button();
            Nombre = new ColumnHeader();
            Tarifa = new ColumnHeader();
            Capacidad = new ColumnHeader();
            Adultos = new ColumnHeader();
            Menores = new ColumnHeader();
            Infantes = new ColumnHeader();
            CheckIn = new ColumnHeader();
            CheckOut = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            grpHotel.SuspendLayout();
            this.InformacionGrp.SuspendLayout();
            SuspendLayout();
            // 
            // grpHotel
            // 
            grpHotel.Controls.Add(listViewHoteles);
            grpHotel.Location = new Point(15, 30);
            grpHotel.Name = "grpHotel";
            grpHotel.Size = new Size(730, 184);
            grpHotel.TabIndex = 5;
            grpHotel.TabStop = false;
            grpHotel.Text = "Hoteles disponibles:";
            // 
            // listViewHoteles
            // 
            listViewHoteles.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewHoteles.FullRowSelect = true;
            listViewHoteles.Location = new Point(12, 21);
            listViewHoteles.MultiSelect = false;
            listViewHoteles.Name = "listViewHoteles";
            listViewHoteles.Size = new Size(718, 158);
            listViewHoteles.TabIndex = 0;
            listViewHoteles.UseCompatibleStateImageBehavior = false;
            listViewHoteles.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "CódigoHotel";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "NombreHotel";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "CódigoCiudad";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Dirección";
            columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Estrellas";
            columnHeader5.Width = 100;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(27, 252);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(255, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // labelIngreso
            // 
            labelIngreso.AutoSize = true;
            labelIngreso.Location = new Point(27, 235);
            labelIngreso.Name = "labelIngreso";
            labelIngreso.Size = new Size(112, 15);
            labelIngreso.TabIndex = 15;
            labelIngreso.Text = "Fecha ingreso Hotel";
            // 
            // AplicarFiltrosHotelButton
            // 
            this.AplicarFiltrosHotelButton.Location = new Point(663, 263);
            this.AplicarFiltrosHotelButton.Margin = new Padding(3, 2, 3, 2);
            this.AplicarFiltrosHotelButton.Name = "AplicarFiltrosHotelButton";
            this.AplicarFiltrosHotelButton.Size = new Size(82, 22);
            this.AplicarFiltrosHotelButton.TabIndex = 18;
            this.AplicarFiltrosHotelButton.Text = "Aplicar";
            this.AplicarFiltrosHotelButton.UseVisualStyleBackColor = true;
            // 
            // InformacionGrp
            // 
            this.InformacionGrp.Controls.Add(button1);
            this.InformacionGrp.Controls.Add(lblServiciosExtra);
            this.InformacionGrp.Controls.Add(lblDisponibilidad);
            this.InformacionGrp.Controls.Add(ServiciosExtraListView);
            this.InformacionGrp.Controls.Add(DisponibilidadListView);
            this.InformacionGrp.Location = new Point(27, 290);
            this.InformacionGrp.Name = "InformacionGrp";
            this.InformacionGrp.Size = new Size(892, 306);
            this.InformacionGrp.TabIndex = 17;
            this.InformacionGrp.TabStop = false;
            this.InformacionGrp.Text = "Hotel seleccionado:";
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
            // InformacionHotelButton
            // 
            InformacionHotelButton.Location = new Point(751, 263);
            InformacionHotelButton.Margin = new Padding(3, 2, 3, 2);
            InformacionHotelButton.Name = "InformacionHotelButton";
            InformacionHotelButton.Size = new Size(168, 22);
            InformacionHotelButton.TabIndex = 16;
            InformacionHotelButton.Text = "Ver información Hotel";
            InformacionHotelButton.UseVisualStyleBackColor = true;
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
            // HotelesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 622);
            Controls.Add(this.AplicarFiltrosHotelButton);
            Controls.Add(this.InformacionGrp);
            Controls.Add(InformacionHotelButton);
            Controls.Add(labelIngreso);
            Controls.Add(dateTimePicker2);
            Controls.Add(grpHotel);
            Name = "HotelesForm";
            Text = "HotelesForm";
            grpHotel.ResumeLayout(false);
            this.InformacionGrp.ResumeLayout(false);
            this.InformacionGrp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpHotel;
        private ListView listViewHoteles;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
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