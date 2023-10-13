namespace grupo3.prototipos.CAI
{
    partial class BuscaroCrearItForm
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
            NuevoItinerarioBtn = new Button();
            BuscarItinerarioBtn = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // NuevoItinerarioBtn
            // 
            NuevoItinerarioBtn.Location = new Point(125, 45);
            NuevoItinerarioBtn.Name = "NuevoItinerarioBtn";
            NuevoItinerarioBtn.Size = new Size(127, 50);
            NuevoItinerarioBtn.TabIndex = 0;
            NuevoItinerarioBtn.Text = "Crear itinerario";
            NuevoItinerarioBtn.UseVisualStyleBackColor = true;
            NuevoItinerarioBtn.Click += NuevoItinerarioBtn_Click;
            // 
            // BuscarItinerarioBtn
            // 
            BuscarItinerarioBtn.Location = new Point(125, 120);
            BuscarItinerarioBtn.Name = "BuscarItinerarioBtn";
            BuscarItinerarioBtn.Size = new Size(127, 50);
            BuscarItinerarioBtn.TabIndex = 1;
            BuscarItinerarioBtn.Text = "Buscar itinerario";
            BuscarItinerarioBtn.UseVisualStyleBackColor = true;
            BuscarItinerarioBtn.Click += BuscarItinerarioBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NuevoItinerarioBtn);
            groupBox1.Controls.Add(BuscarItinerarioBtn);
            groupBox1.Location = new Point(180, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 214);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione una opción:";
            // 
            // BuscaroCrearItForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "BuscaroCrearItForm";
            Text = "Pantalla principal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button NuevoItinerarioBtn;
        private Button BuscarItinerarioBtn;
        private GroupBox groupBox1;
    }
}