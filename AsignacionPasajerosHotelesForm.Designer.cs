namespace grupo3.prototipos.CAI
{
    partial class AsignacionPasajerosHotelesForm
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
            AgregarPersonaBtn = new Button();
            EliminarPasajeroButton = new Button();
            NumeroItinerarioLabel = new Label();
            lblNumeroItinerario = new Label();
            HotelesListView = new ListView();
            CodigoHotelHeader = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            CódigoCiudadHeader = new ColumnHeader();
            DirecciónHeader = new ColumnHeader();
            CalificacionHeader = new ColumnHeader();
            NombreHabitacionHeader = new ColumnHeader();
            TarifaPorDiaHeader = new ColumnHeader();
            label7 = new Label();
            listView1 = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // AgregarPersonaBtn
            // 
            AgregarPersonaBtn.Location = new Point(16, 239);
            AgregarPersonaBtn.Margin = new Padding(3, 4, 3, 4);
            AgregarPersonaBtn.Name = "AgregarPersonaBtn";
            AgregarPersonaBtn.Size = new Size(158, 41);
            AgregarPersonaBtn.TabIndex = 37;
            AgregarPersonaBtn.Text = "Agregar pasajero";
            AgregarPersonaBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarPasajeroButton
            // 
            EliminarPasajeroButton.Location = new Point(16, 506);
            EliminarPasajeroButton.Margin = new Padding(3, 4, 3, 4);
            EliminarPasajeroButton.Name = "EliminarPasajeroButton";
            EliminarPasajeroButton.Size = new Size(158, 41);
            EliminarPasajeroButton.TabIndex = 38;
            EliminarPasajeroButton.Text = "Eliminar pasajero";
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
            // HotelesListView
            // 
            HotelesListView.Columns.AddRange(new ColumnHeader[] { CodigoHotelHeader, columnHeader1, CódigoCiudadHeader, DirecciónHeader, CalificacionHeader, NombreHabitacionHeader, TarifaPorDiaHeader });
            HotelesListView.FullRowSelect = true;
            HotelesListView.GridLines = true;
            HotelesListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            HotelesListView.Location = new Point(16, 83);
            HotelesListView.Margin = new Padding(3, 4, 3, 4);
            HotelesListView.MultiSelect = false;
            HotelesListView.Name = "HotelesListView";
            HotelesListView.Size = new Size(1076, 139);
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
            label7.Location = new Point(12, 50);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 49;
            label7.Text = "Hoteles";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(16, 354);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(1076, 128);
            listView1.TabIndex = 45;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Código Hotel";
            columnHeader6.Width = 120;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 320);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 52;
            label1.Text = "Pasajeros";
            // 
            // AsignacionPasajerosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 560);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(AgregarPersonaBtn);
            Controls.Add(HotelesListView);
            Controls.Add(EliminarPasajeroButton);
            Controls.Add(label7);
            Controls.Add(NumeroItinerarioLabel);
            Controls.Add(lblNumeroItinerario);
            Name = "AsignacionPasajerosForm";
            Text = "Realizar Prereserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AgregarPersonaBtn;
        private Button EliminarPasajeroButton;
        private Label NumeroItinerarioLabel;
        private Label lblNumeroItinerario;
        private ListView HotelesListView;
        private ColumnHeader CodigoHotelHeader;
        private ColumnHeader columnHeader1;
        private ColumnHeader CódigoCiudadHeader;
        private ColumnHeader DirecciónHeader;
        private ColumnHeader CalificacionHeader;
        private ColumnHeader NombreHabitacionHeader;
        private ColumnHeader TarifaPorDiaHeader;
        private Label label7;
        private ListView listView1;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label1;
    }
}