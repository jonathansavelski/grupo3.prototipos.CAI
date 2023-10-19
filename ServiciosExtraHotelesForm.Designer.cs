namespace grupo3.prototipos.CAI
{
    partial class ServiciosExtraHotelesForm
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
            AñadirServicioExtraButton = new Button();
            label1 = new Label();
            listView1 = new ListView();
            CodigoHeader = new ColumnHeader();
            DescripcionHeader = new ColumnHeader();
            TarifaHeader = new ColumnHeader();
            PrecioPorPasajeroHeader = new ColumnHeader();
            SuspendLayout();
            // 
            // AñadirServicioExtraButton
            // 
            AñadirServicioExtraButton.Location = new Point(14, 158);
            AñadirServicioExtraButton.Margin = new Padding(3, 4, 3, 4);
            AñadirServicioExtraButton.Name = "AñadirServicioExtraButton";
            AñadirServicioExtraButton.Size = new Size(155, 39);
            AñadirServicioExtraButton.TabIndex = 28;
            AñadirServicioExtraButton.Text = "Agregar servicio";
            AñadirServicioExtraButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 27;
            label1.Text = "Servicios extra disponibles";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { CodigoHeader, DescripcionHeader, TarifaHeader, PrecioPorPasajeroHeader });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(16, 42);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(457, 104);
            listView1.TabIndex = 26;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // CodigoHeader
            // 
            CodigoHeader.Text = "Código";
            CodigoHeader.Width = 100;
            // 
            // DescripcionHeader
            // 
            DescripcionHeader.Text = "Descripción";
            DescripcionHeader.TextAlign = HorizontalAlignment.Center;
            DescripcionHeader.Width = 100;
            // 
            // TarifaHeader
            // 
            TarifaHeader.Text = "Tarifa";
            TarifaHeader.TextAlign = HorizontalAlignment.Center;
            TarifaHeader.Width = 100;
            // 
            // PrecioPorPasajeroHeader
            // 
            PrecioPorPasajeroHeader.Text = "Precio Por Pasajero";
            PrecioPorPasajeroHeader.TextAlign = HorizontalAlignment.Center;
            PrecioPorPasajeroHeader.Width = 150;
            // 
            // ServiciosExtraHotelesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 213);
            Controls.Add(AñadirServicioExtraButton);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "ServiciosExtraHotelesForm";
            Text = "Servicios Extra Hoteles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AñadirServicioExtraButton;
        private Label label1;
        private ListView listView1;
        private ColumnHeader CodigoHeader;
        private ColumnHeader DescripcionHeader;
        private ColumnHeader TarifaHeader;
        private ColumnHeader PrecioPorPasajeroHeader;
    }
}