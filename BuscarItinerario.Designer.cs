namespace grupo3.prototipos.CAI
{
    partial class BusquedaItinerarioForm
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
            listView1 = new ListView();
            fechaCreacionItinerarioHeader = new ColumnHeader();
            CotizacionHeader = new ColumnHeader();
            EstadoItinerarioHeader = new ColumnHeader();
            lblBuscarNumeroItinerario = new Label();
            txtBuscarItinerario = new TextBox();
            BuscarItinerarioBtn = new Button();
            VerDetallesPreReservaBtn = new Button();
            groupBox1 = new GroupBox();
            RealizarPrereservaButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { fechaCreacionItinerarioHeader, CotizacionHeader, EstadoItinerarioHeader });
            listView1.Location = new Point(15, 68);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(412, 70);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // fechaCreacionItinerarioHeader
            // 
            fechaCreacionItinerarioHeader.Text = "Fecha de creación";
            fechaCreacionItinerarioHeader.TextAlign = HorizontalAlignment.Center;
            fechaCreacionItinerarioHeader.Width = 150;
            // 
            // CotizacionHeader
            // 
            CotizacionHeader.Text = "Cotización";
            CotizacionHeader.TextAlign = HorizontalAlignment.Center;
            CotizacionHeader.Width = 150;
            // 
            // EstadoItinerarioHeader
            // 
            EstadoItinerarioHeader.Text = "Estado";
            EstadoItinerarioHeader.TextAlign = HorizontalAlignment.Center;
            EstadoItinerarioHeader.Width = 100;
            // 
            // lblBuscarNumeroItinerario
            // 
            lblBuscarNumeroItinerario.AutoSize = true;
            lblBuscarNumeroItinerario.Location = new Point(13, 23);
            lblBuscarNumeroItinerario.Name = "lblBuscarNumeroItinerario";
            lblBuscarNumeroItinerario.Size = new Size(130, 20);
            lblBuscarNumeroItinerario.TabIndex = 1;
            lblBuscarNumeroItinerario.Text = "Número itinerario:";
            // 
            // txtBuscarItinerario
            // 
            txtBuscarItinerario.Location = new Point(161, 20);
            txtBuscarItinerario.Margin = new Padding(3, 4, 3, 4);
            txtBuscarItinerario.Name = "txtBuscarItinerario";
            txtBuscarItinerario.Size = new Size(114, 27);
            txtBuscarItinerario.TabIndex = 2;
            txtBuscarItinerario.KeyPress += txtBuscarItinerario_KeyPress;
            // 
            // BuscarItinerarioBtn
            // 
            BuscarItinerarioBtn.Location = new Point(298, 18);
            BuscarItinerarioBtn.Margin = new Padding(3, 4, 3, 4);
            BuscarItinerarioBtn.Name = "BuscarItinerarioBtn";
            BuscarItinerarioBtn.Size = new Size(129, 31);
            BuscarItinerarioBtn.TabIndex = 3;
            BuscarItinerarioBtn.Text = "Buscar";
            BuscarItinerarioBtn.UseVisualStyleBackColor = true;
            // 
            // VerDetallesPreReservaBtn
            // 
            VerDetallesPreReservaBtn.Location = new Point(14, 149);
            VerDetallesPreReservaBtn.Margin = new Padding(3, 4, 3, 4);
            VerDetallesPreReservaBtn.Name = "VerDetallesPreReservaBtn";
            VerDetallesPreReservaBtn.Size = new Size(147, 44);
            VerDetallesPreReservaBtn.TabIndex = 5;
            VerDetallesPreReservaBtn.Text = "Ver detalles";
            VerDetallesPreReservaBtn.UseVisualStyleBackColor = true;
            VerDetallesPreReservaBtn.Click += VerDetallesPreReservaBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RealizarPrereservaButton);
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(BuscarItinerarioBtn);
            groupBox1.Controls.Add(VerDetallesPreReservaBtn);
            groupBox1.Controls.Add(txtBuscarItinerario);
            groupBox1.Controls.Add(lblBuscarNumeroItinerario);
            groupBox1.Location = new Point(12, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 205);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // RealizarPrereservaButton
            // 
            RealizarPrereservaButton.Location = new Point(262, 149);
            RealizarPrereservaButton.Margin = new Padding(3, 4, 3, 4);
            RealizarPrereservaButton.Name = "RealizarPrereservaButton";
            RealizarPrereservaButton.Size = new Size(165, 44);
            RealizarPrereservaButton.TabIndex = 43;
            RealizarPrereservaButton.Text = "Realizar prereserva";
            RealizarPrereservaButton.UseVisualStyleBackColor = true;
            RealizarPrereservaButton.Click += RealizarPrereservaButton_Click;
            // 
            // BusquedaItinerarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 226);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BusquedaItinerarioForm";
            Text = "Buscar Itinerario";
            Load += ListaPrereservas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Label lblBuscarNumeroItinerario;
        private TextBox txtBuscarItinerario;
        private Button BuscarItinerarioBtn;
        private ColumnHeader fechaCreacionItinerarioHeader;
        private ColumnHeader CotizacionHeader;
        private Button VerDetallesPreReservaBtn;
        private GroupBox groupBox1;
        private ColumnHeader EstadoItinerarioHeader;
        private Button RealizarPrereservaButton;
    }
}