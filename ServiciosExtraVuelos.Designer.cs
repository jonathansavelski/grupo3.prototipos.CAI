namespace grupo3.prototipos.CAI
{
    partial class ServiciosExtraVuelosForm
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
            lblServiciosExtra = new Label();
            ServiciosExtraListView = new ListView();
            CodigoServicioHeader = new ColumnHeader();
            DescripcionServicioHeader = new ColumnHeader();
            TarifaServicioHeader = new ColumnHeader();
            SuspendLayout();
            // 
            // AñadirServicioExtraButton
            // 
            AñadirServicioExtraButton.Location = new Point(12, 159);
            AñadirServicioExtraButton.Margin = new Padding(3, 4, 3, 4);
            AñadirServicioExtraButton.Name = "AñadirServicioExtraButton";
            AñadirServicioExtraButton.Size = new Size(155, 39);
            AñadirServicioExtraButton.TabIndex = 24;
            AñadirServicioExtraButton.Text = "Agregar servicio";
            AñadirServicioExtraButton.UseVisualStyleBackColor = true;
            // 
            // lblServiciosExtra
            // 
            lblServiciosExtra.AutoSize = true;
            lblServiciosExtra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblServiciosExtra.Location = new Point(12, 9);
            lblServiciosExtra.Name = "lblServiciosExtra";
            lblServiciosExtra.Size = new Size(194, 20);
            lblServiciosExtra.TabIndex = 23;
            lblServiciosExtra.Text = "Servicios extra disponibles";
            // 
            // ServiciosExtraListView
            // 
            ServiciosExtraListView.Columns.AddRange(new ColumnHeader[] { CodigoServicioHeader, DescripcionServicioHeader, TarifaServicioHeader });
            ServiciosExtraListView.FullRowSelect = true;
            ServiciosExtraListView.GridLines = true;
            ServiciosExtraListView.Location = new Point(12, 42);
            ServiciosExtraListView.Margin = new Padding(3, 4, 3, 4);
            ServiciosExtraListView.Name = "ServiciosExtraListView";
            ServiciosExtraListView.Size = new Size(567, 100);
            ServiciosExtraListView.TabIndex = 22;
            ServiciosExtraListView.UseCompatibleStateImageBehavior = false;
            ServiciosExtraListView.View = View.Details;
            // 
            // CodigoServicioHeader
            // 
            CodigoServicioHeader.Text = "Código de servicio";
            CodigoServicioHeader.Width = 150;
            // 
            // DescripcionServicioHeader
            // 
            DescripcionServicioHeader.Text = "Descripción servicio";
            DescripcionServicioHeader.TextAlign = HorizontalAlignment.Center;
            DescripcionServicioHeader.Width = 250;
            // 
            // TarifaServicioHeader
            // 
            TarifaServicioHeader.Text = "Tarifa servicio";
            TarifaServicioHeader.TextAlign = HorizontalAlignment.Center;
            TarifaServicioHeader.Width = 150;
            // 
            // ServiciosExtraVuelosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 211);
            Controls.Add(AñadirServicioExtraButton);
            Controls.Add(lblServiciosExtra);
            Controls.Add(ServiciosExtraListView);
            Name = "ServiciosExtraVuelosForm";
            Text = "Servicios Extra Vuelos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AñadirServicioExtraButton;
        private Label lblServiciosExtra;
        private ListView ServiciosExtraListView;
        private ColumnHeader CodigoServicioHeader;
        private ColumnHeader DescripcionServicioHeader;
        private ColumnHeader TarifaServicioHeader;
    }
}