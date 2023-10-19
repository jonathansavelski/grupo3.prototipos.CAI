namespace grupo3.prototipos.CAI
{
    partial class AsignacionPasajerosForm
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
            CargaPasajerosGroupBox = new GroupBox();
            label11 = new Label();
            listView4 = new ListView();
            nombreHeader = new ColumnHeader();
            apellidoHeader = new ColumnHeader();
            DNIHeader = new ColumnHeader();
            TipoPasajero = new ColumnHeader();
            AgregarPersonaBtn = new Button();
            EliminarPasajeroButton = new Button();
            NumeroItinerarioLabel = new Label();
            lblNumeroItinerario = new Label();
            VuelosListView = new ListView();
            CodigoVueloHeader = new ColumnHeader();
            CodigoOrigenVueloHeader = new ColumnHeader();
            CodigoDestinoVueloHeader = new ColumnHeader();
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
            label6 = new Label();
            HotelesListView = new ListView();
            CodigoHotelHeader = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            CódigoCiudadHeader = new ColumnHeader();
            DirecciónHeader = new ColumnHeader();
            CalificacionHeader = new ColumnHeader();
            NombreHabitacionHeader = new ColumnHeader();
            TarifaPorDiaHeader = new ColumnHeader();
            label7 = new Label();
            RealizarPrereservaButton = new Button();
            listView1 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            CargaPasajerosGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CargaPasajerosGroupBox
            // 
            CargaPasajerosGroupBox.Controls.Add(label11);
            CargaPasajerosGroupBox.Controls.Add(listView4);
            CargaPasajerosGroupBox.Location = new Point(809, 55);
            CargaPasajerosGroupBox.Name = "CargaPasajerosGroupBox";
            CargaPasajerosGroupBox.Size = new Size(616, 320);
            CargaPasajerosGroupBox.TabIndex = 44;
            CargaPasajerosGroupBox.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(13, 25);
            label11.Name = "label11";
            label11.Size = new Size(120, 20);
            label11.TabIndex = 44;
            label11.Text = "Datos pasajeros";
            // 
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { nombreHeader, apellidoHeader, DNIHeader, TipoPasajero });
            listView4.GridLines = true;
            listView4.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView4.Location = new Point(16, 60);
            listView4.Margin = new Padding(3, 4, 3, 4);
            listView4.Name = "listView4";
            listView4.Size = new Size(594, 237);
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
            // DNIHeader
            // 
            DNIHeader.DisplayIndex = 3;
            DNIHeader.Text = "DNI";
            DNIHeader.Width = 100;
            // 
            // TipoPasajero
            // 
            TipoPasajero.DisplayIndex = 2;
            TipoPasajero.Text = "Tipo pasajero ";
            TipoPasajero.TextAlign = HorizontalAlignment.Center;
            TipoPasajero.Width = 120;
            // 
            // AgregarPersonaBtn
            // 
            AgregarPersonaBtn.Location = new Point(809, 382);
            AgregarPersonaBtn.Margin = new Padding(3, 4, 3, 4);
            AgregarPersonaBtn.Name = "AgregarPersonaBtn";
            AgregarPersonaBtn.Size = new Size(158, 41);
            AgregarPersonaBtn.TabIndex = 37;
            AgregarPersonaBtn.Text = "Agregar";
            AgregarPersonaBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarPasajeroButton
            // 
            EliminarPasajeroButton.Location = new Point(1267, 382);
            EliminarPasajeroButton.Margin = new Padding(3, 4, 3, 4);
            EliminarPasajeroButton.Name = "EliminarPasajeroButton";
            EliminarPasajeroButton.Size = new Size(158, 41);
            EliminarPasajeroButton.TabIndex = 38;
            EliminarPasajeroButton.Text = "Eliminar";
            EliminarPasajeroButton.UseVisualStyleBackColor = true;
            // 
            // NumeroItinerarioLabel
            // 
            NumeroItinerarioLabel.AutoSize = true;
            NumeroItinerarioLabel.Location = new Point(178, 13);
            NumeroItinerarioLabel.Name = "NumeroItinerarioLabel";
            NumeroItinerarioLabel.Size = new Size(127, 20);
            NumeroItinerarioLabel.TabIndex = 46;
            NumeroItinerarioLabel.Text = "Número itinerario";
            // 
            // lblNumeroItinerario
            // 
            lblNumeroItinerario.AutoSize = true;
            lblNumeroItinerario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroItinerario.Location = new Point(12, 13);
            lblNumeroItinerario.Name = "lblNumeroItinerario";
            lblNumeroItinerario.Size = new Size(160, 20);
            lblNumeroItinerario.TabIndex = 45;
            lblNumeroItinerario.Text = "Número de itinerario:";
            // 
            // VuelosListView
            // 
            VuelosListView.Columns.AddRange(new ColumnHeader[] { CodigoVueloHeader, CodigoOrigenVueloHeader, CodigoDestinoVueloHeader, FechaSalidaVueloHeader, FechaArriboVueloHeader, TiempoVueloHeader, CodigoAerolineaVueloHeader, ClaseTarifaVueloHeader, ItinerarioVueloHeader, TipoPasajeroHeader, BaseVueloHeader, ImpuestoVueloHeader, ComisionVueloHeader, DisponibilidadVueloHeader });
            VuelosListView.FullRowSelect = true;
            VuelosListView.GridLines = true;
            VuelosListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            VuelosListView.LabelWrap = false;
            VuelosListView.Location = new Point(12, 85);
            VuelosListView.Margin = new Padding(3, 4, 3, 4);
            VuelosListView.MultiSelect = false;
            VuelosListView.Name = "VuelosListView";
            VuelosListView.Size = new Size(744, 106);
            VuelosListView.TabIndex = 48;
            VuelosListView.UseCompatibleStateImageBehavior = false;
            VuelosListView.View = View.Details;
            // 
            // CodigoVueloHeader
            // 
            CodigoVueloHeader.Text = "Código de vuelo";
            CodigoVueloHeader.Width = 140;
            // 
            // CodigoOrigenVueloHeader
            // 
            CodigoOrigenVueloHeader.Text = "Origen";
            CodigoOrigenVueloHeader.TextAlign = HorizontalAlignment.Center;
            CodigoOrigenVueloHeader.Width = 120;
            // 
            // CodigoDestinoVueloHeader
            // 
            CodigoDestinoVueloHeader.Text = "Destino";
            CodigoDestinoVueloHeader.TextAlign = HorizontalAlignment.Center;
            CodigoDestinoVueloHeader.Width = 120;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(8, 55);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 47;
            label6.Text = "Vuelos";
            // 
            // HotelesListView
            // 
            HotelesListView.Columns.AddRange(new ColumnHeader[] { CodigoHotelHeader, columnHeader1, CódigoCiudadHeader, DirecciónHeader, CalificacionHeader, NombreHabitacionHeader, TarifaPorDiaHeader });
            HotelesListView.FullRowSelect = true;
            HotelesListView.GridLines = true;
            HotelesListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            HotelesListView.Location = new Point(12, 236);
            HotelesListView.Margin = new Padding(3, 4, 3, 4);
            HotelesListView.MultiSelect = false;
            HotelesListView.Name = "HotelesListView";
            HotelesListView.Size = new Size(744, 139);
            HotelesListView.TabIndex = 50;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 206);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 49;
            label7.Text = "Hoteles";
            // 
            // RealizarPrereservaButton
            // 
            RealizarPrereservaButton.Location = new Point(25, 656);
            RealizarPrereservaButton.Margin = new Padding(3, 4, 3, 4);
            RealizarPrereservaButton.Name = "RealizarPrereservaButton";
            RealizarPrereservaButton.Size = new Size(165, 44);
            RealizarPrereservaButton.TabIndex = 51;
            RealizarPrereservaButton.Text = "Realizar prereserva";
            RealizarPrereservaButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(196, 479);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(1076, 128);
            listView1.TabIndex = 45;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Apellido";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 4;
            columnHeader4.Text = "DNI";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 3;
            columnHeader5.Text = "Tipo pasajero ";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Código Vuelo";
            columnHeader6.Width = 120;
            // 
            // AsignacionPasajerosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 744);
            Controls.Add(listView1);
            Controls.Add(RealizarPrereservaButton);
            Controls.Add(AgregarPersonaBtn);
            Controls.Add(HotelesListView);
            Controls.Add(EliminarPasajeroButton);
            Controls.Add(label7);
            Controls.Add(VuelosListView);
            Controls.Add(label6);
            Controls.Add(NumeroItinerarioLabel);
            Controls.Add(CargaPasajerosGroupBox);
            Controls.Add(lblNumeroItinerario);
            Name = "AsignacionPasajerosForm";
            Text = "Realizar Prereserva";
            CargaPasajerosGroupBox.ResumeLayout(false);
            CargaPasajerosGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox CargaPasajerosGroupBox;
        private Label label11;
        private ListView listView4;
        private ColumnHeader nombreHeader;
        private ColumnHeader apellidoHeader;
        private ColumnHeader DNIHeader;
        private ColumnHeader TipoPasajero;
        private Button AgregarPersonaBtn;
        private Button EliminarPasajeroButton;
        private Label NumeroItinerarioLabel;
        private Label lblNumeroItinerario;
        private ListView VuelosListView;
        private ColumnHeader CodigoVueloHeader;
        private ColumnHeader CodigoOrigenVueloHeader;
        private ColumnHeader CodigoDestinoVueloHeader;
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
        private Label label6;
        private ListView HotelesListView;
        private ColumnHeader CodigoHotelHeader;
        private ColumnHeader columnHeader1;
        private ColumnHeader CódigoCiudadHeader;
        private ColumnHeader DirecciónHeader;
        private ColumnHeader CalificacionHeader;
        private ColumnHeader NombreHabitacionHeader;
        private ColumnHeader TarifaPorDiaHeader;
        private Label label7;
        private Button RealizarPrereservaButton;
        private ListView listView1;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}