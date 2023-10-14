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
            PresupuestoHeader = new ColumnHeader();
            lblBuscarNumeroItinerario = new Label();
            txtBuscarItinerario = new TextBox();
            BuscarItinerarioBtn = new Button();
            btnReservar = new Button();
            VerDetallesPreReservaBtn = new Button();
            listView2 = new ListView();
            listView3 = new ListView();
            listView4 = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            grpDetallesPrereserva = new GroupBox();
            label4 = new Label();
            listView5 = new ListView();
            groupBox1 = new GroupBox();
            grpDetallesPrereserva.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { fechaCreacionItinerarioHeader, PresupuestoHeader });
            listView1.Location = new Point(15, 68);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(771, 119);
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
            // PresupuestoHeader
            // 
            PresupuestoHeader.Text = "Presupuesto";
            PresupuestoHeader.TextAlign = HorizontalAlignment.Center;
            PresupuestoHeader.Width = 150;
            // 
            // lblBuscarNumeroItinerario
            // 
            lblBuscarNumeroItinerario.AutoSize = true;
            lblBuscarNumeroItinerario.Location = new Point(15, 23);
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
            // 
            // BuscarItinerarioBtn
            // 
            BuscarItinerarioBtn.Location = new Point(298, 18);
            BuscarItinerarioBtn.Margin = new Padding(3, 4, 3, 4);
            BuscarItinerarioBtn.Name = "BuscarItinerarioBtn";
            BuscarItinerarioBtn.Size = new Size(114, 31);
            BuscarItinerarioBtn.TabIndex = 3;
            BuscarItinerarioBtn.Text = "Buscar";
            BuscarItinerarioBtn.UseVisualStyleBackColor = true;
            // 
            // btnReservar
            // 
            btnReservar.Location = new Point(83, 827);
            btnReservar.Margin = new Padding(3, 4, 3, 4);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(86, 31);
            btnReservar.TabIndex = 4;
            btnReservar.Text = "RESERVAR";
            btnReservar.UseVisualStyleBackColor = true;
            // 
            // VerDetallesPreReservaBtn
            // 
            VerDetallesPreReservaBtn.Location = new Point(77, 260);
            VerDetallesPreReservaBtn.Margin = new Padding(3, 4, 3, 4);
            VerDetallesPreReservaBtn.Name = "VerDetallesPreReservaBtn";
            VerDetallesPreReservaBtn.Size = new Size(147, 44);
            VerDetallesPreReservaBtn.TabIndex = 5;
            VerDetallesPreReservaBtn.Text = "Ver detalles";
            VerDetallesPreReservaBtn.UseVisualStyleBackColor = true;
            VerDetallesPreReservaBtn.Click += VerDetallesPreReservaBtn_Click;
            // 
            // listView2
            // 
            listView2.Location = new Point(7, 87);
            listView2.Margin = new Padding(3, 4, 3, 4);
            listView2.Name = "listView2";
            listView2.Size = new Size(431, 79);
            listView2.TabIndex = 6;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            listView3.Location = new Point(7, 196);
            listView3.Margin = new Padding(3, 4, 3, 4);
            listView3.Name = "listView3";
            listView3.Size = new Size(431, 79);
            listView3.TabIndex = 7;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView4
            // 
            listView4.Location = new Point(8, 308);
            listView4.Margin = new Padding(3, 4, 3, 4);
            listView4.Name = "listView4";
            listView4.Size = new Size(431, 79);
            listView4.TabIndex = 8;
            listView4.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 56);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 9;
            label1.Text = "Lista vuelos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 171);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 10;
            label2.Text = "Lista hoteles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 280);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 11;
            label3.Text = "Lista paquetes";
            // 
            // grpDetallesPrereserva
            // 
            grpDetallesPrereserva.Controls.Add(label4);
            grpDetallesPrereserva.Controls.Add(label1);
            grpDetallesPrereserva.Controls.Add(label2);
            grpDetallesPrereserva.Controls.Add(listView2);
            grpDetallesPrereserva.Controls.Add(label3);
            grpDetallesPrereserva.Controls.Add(listView5);
            grpDetallesPrereserva.Controls.Add(listView3);
            grpDetallesPrereserva.Controls.Add(listView4);
            grpDetallesPrereserva.Location = new Point(86, 285);
            grpDetallesPrereserva.Margin = new Padding(3, 4, 3, 4);
            grpDetallesPrereserva.Name = "grpDetallesPrereserva";
            grpDetallesPrereserva.Padding = new Padding(3, 4, 3, 4);
            grpDetallesPrereserva.Size = new Size(587, 516);
            grpDetallesPrereserva.TabIndex = 12;
            grpDetallesPrereserva.TabStop = false;
            grpDetallesPrereserva.Text = "Detalles";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 392);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 14;
            label4.Text = "Lista personas";
            // 
            // listView5
            // 
            listView5.Location = new Point(8, 420);
            listView5.Margin = new Padding(3, 4, 3, 4);
            listView5.Name = "listView5";
            listView5.Size = new Size(431, 79);
            listView5.TabIndex = 13;
            listView5.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(BuscarItinerarioBtn);
            groupBox1.Controls.Add(VerDetallesPreReservaBtn);
            groupBox1.Controls.Add(txtBuscarItinerario);
            groupBox1.Controls.Add(lblBuscarNumeroItinerario);
            groupBox1.Location = new Point(12, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1395, 335);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // BusquedaItinerarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 909);
            Controls.Add(groupBox1);
            Controls.Add(grpDetallesPrereserva);
            Controls.Add(btnReservar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BusquedaItinerarioForm";
            Text = "Buscar Itinerario";
            Load += ListaPrereservas_Load;
            grpDetallesPrereserva.ResumeLayout(false);
            grpDetallesPrereserva.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Label lblBuscarNumeroItinerario;
        private TextBox txtBuscarItinerario;
        private Button BuscarItinerarioBtn;
        private Button btnReservar;
        private ColumnHeader fechaCreacionItinerarioHeader;
        private ColumnHeader PresupuestoHeader;
        private Button VerDetallesPreReservaBtn;
        private ListView listView2;
        private ListView listView3;
        private ListView listView4;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox grpDetallesPrereserva;
        private Label label4;
        private ListView listView5;
        private GroupBox groupBox1;
    }
}