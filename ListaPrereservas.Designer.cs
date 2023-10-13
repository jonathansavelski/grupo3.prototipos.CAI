namespace grupo3.prototipos.CAI
{
    partial class ListaPrereservas
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
            numeroItinerarioHeader = new ColumnHeader();
            fechaPresupuestoHeader = new ColumnHeader();
            duracionPresupuestoHeader = new ColumnHeader();
            PresupuestoHeader = new ColumnHeader();
            monedaHeader = new ColumnHeader();
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
            grpDetallesPrereserva.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { numeroItinerarioHeader, fechaPresupuestoHeader, duracionPresupuestoHeader, PresupuestoHeader, monedaHeader });
            listView1.Location = new Point(75, 62);
            listView1.Name = "listView1";
            listView1.Size = new Size(675, 90);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // numeroItinerarioHeader
            // 
            numeroItinerarioHeader.Text = "Número itinerario";
            numeroItinerarioHeader.Width = 120;
            // 
            // fechaPresupuestoHeader
            // 
            fechaPresupuestoHeader.Text = "Fecha presupuesto";
            fechaPresupuestoHeader.TextAlign = HorizontalAlignment.Center;
            fechaPresupuestoHeader.Width = 120;
            // 
            // duracionPresupuestoHeader
            // 
            duracionPresupuestoHeader.Text = "Duración presupuesto";
            duracionPresupuestoHeader.TextAlign = HorizontalAlignment.Center;
            duracionPresupuestoHeader.Width = 150;
            // 
            // PresupuestoHeader
            // 
            PresupuestoHeader.Text = "Presupuesto";
            PresupuestoHeader.TextAlign = HorizontalAlignment.Center;
            PresupuestoHeader.Width = 150;
            // 
            // monedaHeader
            // 
            monedaHeader.Text = "Moneda";
            monedaHeader.TextAlign = HorizontalAlignment.Center;
            // 
            // lblBuscarNumeroItinerario
            // 
            lblBuscarNumeroItinerario.AutoSize = true;
            lblBuscarNumeroItinerario.Location = new Point(75, 24);
            lblBuscarNumeroItinerario.Name = "lblBuscarNumeroItinerario";
            lblBuscarNumeroItinerario.Size = new Size(104, 15);
            lblBuscarNumeroItinerario.TabIndex = 1;
            lblBuscarNumeroItinerario.Text = "Número itinerario:";
            // 
            // txtBuscarItinerario
            // 
            txtBuscarItinerario.Location = new Point(185, 21);
            txtBuscarItinerario.Name = "txtBuscarItinerario";
            txtBuscarItinerario.Size = new Size(100, 23);
            txtBuscarItinerario.TabIndex = 2;
            // 
            // BuscarItinerarioBtn
            // 
            BuscarItinerarioBtn.Location = new Point(291, 21);
            BuscarItinerarioBtn.Name = "BuscarItinerarioBtn";
            BuscarItinerarioBtn.Size = new Size(100, 23);
            BuscarItinerarioBtn.TabIndex = 3;
            BuscarItinerarioBtn.Text = "Buscar";
            BuscarItinerarioBtn.UseVisualStyleBackColor = true;
            // 
            // btnReservar
            // 
            btnReservar.Location = new Point(73, 620);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(75, 23);
            btnReservar.TabIndex = 4;
            btnReservar.Text = "RESERVAR";
            btnReservar.UseVisualStyleBackColor = true;
            // 
            // VerDetallesPreReservaBtn
            // 
            VerDetallesPreReservaBtn.Location = new Point(73, 158);
            VerDetallesPreReservaBtn.Name = "VerDetallesPreReservaBtn";
            VerDetallesPreReservaBtn.Size = new Size(129, 33);
            VerDetallesPreReservaBtn.TabIndex = 5;
            VerDetallesPreReservaBtn.Text = "Ver detalles";
            VerDetallesPreReservaBtn.UseVisualStyleBackColor = true;
            VerDetallesPreReservaBtn.Click += VerDetallesPreReservaBtn_Click;
            // 
            // listView2
            // 
            listView2.Location = new Point(6, 65);
            listView2.Name = "listView2";
            listView2.Size = new Size(378, 60);
            listView2.TabIndex = 6;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            listView3.Location = new Point(6, 147);
            listView3.Name = "listView3";
            listView3.Size = new Size(378, 60);
            listView3.TabIndex = 7;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView4
            // 
            listView4.Location = new Point(7, 231);
            listView4.Name = "listView4";
            listView4.Size = new Size(378, 60);
            listView4.TabIndex = 8;
            listView4.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 42);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 9;
            label1.Text = "Lista vuelos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 128);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 10;
            label2.Text = "Lista hoteles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 210);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
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
            grpDetallesPrereserva.Location = new Point(75, 214);
            grpDetallesPrereserva.Name = "grpDetallesPrereserva";
            grpDetallesPrereserva.Size = new Size(514, 387);
            grpDetallesPrereserva.TabIndex = 12;
            grpDetallesPrereserva.TabStop = false;
            grpDetallesPrereserva.Text = "Detalles";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 294);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 14;
            label4.Text = "Lista personas";
            // 
            // listView5
            // 
            listView5.Location = new Point(7, 315);
            listView5.Name = "listView5";
            listView5.Size = new Size(378, 60);
            listView5.TabIndex = 13;
            listView5.UseCompatibleStateImageBehavior = false;
            // 
            // ListaPrereservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 682);
            Controls.Add(grpDetallesPrereserva);
            Controls.Add(VerDetallesPreReservaBtn);
            Controls.Add(btnReservar);
            Controls.Add(BuscarItinerarioBtn);
            Controls.Add(txtBuscarItinerario);
            Controls.Add(lblBuscarNumeroItinerario);
            Controls.Add(listView1);
            Name = "ListaPrereservas";
            Text = "PreReservas";
            Load += ListaPrereservas_Load;
            grpDetallesPrereserva.ResumeLayout(false);
            grpDetallesPrereserva.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label lblBuscarNumeroItinerario;
        private TextBox txtBuscarItinerario;
        private Button BuscarItinerarioBtn;
        private Button btnReservar;
        private ColumnHeader numeroItinerarioHeader;
        private ColumnHeader fechaPresupuestoHeader;
        private ColumnHeader duracionPresupuestoHeader;
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
        private ColumnHeader monedaHeader;
    }
}