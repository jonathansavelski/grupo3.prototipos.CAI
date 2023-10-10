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
            grpHotel.SuspendLayout();
            SuspendLayout();
            // 
            // grpHotel
            // 
            grpHotel.Controls.Add(listViewHoteles);
            grpHotel.Location = new Point(15, 30);
            grpHotel.Name = "grpHotel";
            grpHotel.Size = new Size(786, 184);
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
            listViewHoteles.Size = new Size(768, 158);
            listViewHoteles.TabIndex = 0;
            listViewHoteles.UseCompatibleStateImageBehavior = false;
            listViewHoteles.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "CodigoHotel";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "NombreHotel";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "CodigoCiudad";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Direccion";
            columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Estrellas";
            columnHeader5.Width = 150;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(27, 343);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(255, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // HotelesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 548);
            Controls.Add(dateTimePicker2);
            Controls.Add(grpHotel);
            Name = "HotelesForm";
            Text = "HotelesForm";
            grpHotel.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}