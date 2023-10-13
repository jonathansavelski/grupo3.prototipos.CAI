namespace grupo3.prototipos.CAI
{
    partial class CrearItinerario
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
            grpMenu = new GroupBox();
            button8 = new Button();
            AgregarPersonaBtn = new Button();
            listView4 = new ListView();
            nombreHeader = new ColumnHeader();
            apellidoHeader = new ColumnHeader();
            TipoPasajero = new ColumnHeader();
            button5 = new Button();
            textBox7 = new TextBox();
            label10 = new Label();
            textBox6 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            listView3 = new ListView();
            label7 = new Label();
            listView2 = new ListView();
            label6 = new Label();
            listView1 = new ListView();
            textBox5 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblNumeroItinerario = new Label();
            ConsultaDisponibilidadHotelesBtn = new Button();
            ConsultaDisponibilidadVuelosBtn = new Button();
            txtNumeroItinerario = new TextBox();
            ConsultaDisponibilidadPaquetesBtn = new Button();
            grpMenu.SuspendLayout();
            SuspendLayout();
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(button8);
            grpMenu.Controls.Add(AgregarPersonaBtn);
            grpMenu.Controls.Add(listView4);
            grpMenu.Controls.Add(button5);
            grpMenu.Controls.Add(textBox7);
            grpMenu.Controls.Add(label10);
            grpMenu.Controls.Add(textBox6);
            grpMenu.Controls.Add(button3);
            grpMenu.Controls.Add(button4);
            grpMenu.Controls.Add(button2);
            grpMenu.Controls.Add(button1);
            grpMenu.Controls.Add(label8);
            grpMenu.Controls.Add(listView3);
            grpMenu.Controls.Add(label7);
            grpMenu.Controls.Add(listView2);
            grpMenu.Controls.Add(label6);
            grpMenu.Controls.Add(listView1);
            grpMenu.Controls.Add(textBox5);
            grpMenu.Controls.Add(label5);
            grpMenu.Controls.Add(label4);
            grpMenu.Controls.Add(textBox4);
            grpMenu.Controls.Add(label3);
            grpMenu.Controls.Add(label2);
            grpMenu.Controls.Add(label1);
            grpMenu.Controls.Add(textBox3);
            grpMenu.Controls.Add(textBox2);
            grpMenu.Controls.Add(textBox1);
            grpMenu.Controls.Add(lblNumeroItinerario);
            grpMenu.Controls.Add(ConsultaDisponibilidadHotelesBtn);
            grpMenu.Controls.Add(ConsultaDisponibilidadVuelosBtn);
            grpMenu.Controls.Add(txtNumeroItinerario);
            grpMenu.Controls.Add(ConsultaDisponibilidadPaquetesBtn);
            grpMenu.Location = new Point(33, 2);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(815, 761);
            grpMenu.TabIndex = 0;
            grpMenu.TabStop = false;
            // 
            // button8
            // 
            button8.Location = new Point(655, 599);
            button8.Name = "button8";
            button8.Size = new Size(138, 31);
            button8.TabIndex = 38;
            button8.Text = "Eliminar";
            button8.UseVisualStyleBackColor = true;
            // 
            // AgregarPersonaBtn
            // 
            AgregarPersonaBtn.Location = new Point(655, 562);
            AgregarPersonaBtn.Name = "AgregarPersonaBtn";
            AgregarPersonaBtn.Size = new Size(138, 31);
            AgregarPersonaBtn.TabIndex = 37;
            AgregarPersonaBtn.Text = "Agregar";
            AgregarPersonaBtn.UseVisualStyleBackColor = true;
            AgregarPersonaBtn.Click += AgregarPersonaBtn_Click;
            // 
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { nombreHeader, apellidoHeader, TipoPasajero });
            listView4.Location = new Point(3, 562);
            listView4.Name = "listView4";
            listView4.Size = new Size(646, 97);
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
            apellidoHeader.Width = 80;
            // 
            // TipoPasajero
            // 
            TipoPasajero.Text = "Tipo pasajero ";
            TipoPasajero.Width = 100;
            // 
            // button5
            // 
            button5.Location = new Point(0, 675);
            button5.Name = "button5";
            button5.Size = new Size(144, 34);
            button5.TabIndex = 35;
            button5.Text = "PRERESERVA";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(588, 64);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(528, 64);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 33;
            label10.Text = "Moneda:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(108, 516);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 31;
            // 
            // button3
            // 
            button3.Location = new Point(0, 508);
            button3.Name = "button3";
            button3.Size = new Size(98, 37);
            button3.TabIndex = 30;
            button3.Text = "Cotizar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(660, 295);
            button4.Name = "button4";
            button4.Size = new Size(138, 31);
            button4.TabIndex = 29;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(660, 441);
            button2.Name = "button2";
            button2.Size = new Size(138, 31);
            button2.TabIndex = 27;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(660, 144);
            button1.Name = "button1";
            button1.Size = new Size(138, 31);
            button1.TabIndex = 25;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 377);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 24;
            label8.Text = "Paquetes:";
            // 
            // listView3
            // 
            listView3.Location = new Point(3, 395);
            listView3.Name = "listView3";
            listView3.Size = new Size(641, 97);
            listView3.TabIndex = 23;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 230);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 22;
            label7.Text = "Hoteles:";
            // 
            // listView2
            // 
            listView2.Location = new Point(3, 248);
            listView2.Name = "listView2";
            listView2.Size = new Size(641, 97);
            listView2.TabIndex = 21;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 89);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 20;
            label6.Text = "Vuelos:";
            // 
            // listView1
            // 
            listView1.Location = new Point(3, 107);
            listView1.Name = "listView1";
            listView1.Size = new Size(641, 97);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(418, 64);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(267, 64);
            label5.Name = "label5";
            label5.Size = new Size(145, 15);
            label5.TabIndex = 17;
            label5.Text = "Duración del presupuesto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 64);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 16;
            label4.Text = "Fecha de presupuesto:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(134, 64);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 38);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 14;
            label3.Text = "Cantidad infantes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(443, 41);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 13;
            label2.Text = "Cantidad menores:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 38);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 12;
            label1.Text = "Cantidad adultos:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(547, 35);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(328, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            // 
            // lblNumeroItinerario
            // 
            lblNumeroItinerario.AutoSize = true;
            lblNumeroItinerario.Location = new Point(6, 13);
            lblNumeroItinerario.Name = "lblNumeroItinerario";
            lblNumeroItinerario.Size = new Size(102, 15);
            lblNumeroItinerario.TabIndex = 8;
            lblNumeroItinerario.Text = "Itinerario número:";
            // 
            // ConsultaDisponibilidadHotelesBtn
            // 
            ConsultaDisponibilidadHotelesBtn.Location = new Point(660, 261);
            ConsultaDisponibilidadHotelesBtn.Name = "ConsultaDisponibilidadHotelesBtn";
            ConsultaDisponibilidadHotelesBtn.Size = new Size(138, 28);
            ConsultaDisponibilidadHotelesBtn.TabIndex = 3;
            ConsultaDisponibilidadHotelesBtn.Text = "Agregar";
            ConsultaDisponibilidadHotelesBtn.UseVisualStyleBackColor = true;
            ConsultaDisponibilidadHotelesBtn.Click += ConsultaDisponibilidadHotelesBtn_Click;
            // 
            // ConsultaDisponibilidadVuelosBtn
            // 
            ConsultaDisponibilidadVuelosBtn.Location = new Point(660, 107);
            ConsultaDisponibilidadVuelosBtn.Name = "ConsultaDisponibilidadVuelosBtn";
            ConsultaDisponibilidadVuelosBtn.Size = new Size(138, 29);
            ConsultaDisponibilidadVuelosBtn.TabIndex = 1;
            ConsultaDisponibilidadVuelosBtn.Text = "Agregar";
            ConsultaDisponibilidadVuelosBtn.UseVisualStyleBackColor = true;
            ConsultaDisponibilidadVuelosBtn.Click += ConsultaDisponibilidadVuelosBtn_Click;
            // 
            // txtNumeroItinerario
            // 
            txtNumeroItinerario.Location = new Point(114, 10);
            txtNumeroItinerario.Name = "txtNumeroItinerario";
            txtNumeroItinerario.Size = new Size(255, 23);
            txtNumeroItinerario.TabIndex = 7;
            // 
            // ConsultaDisponibilidadPaquetesBtn
            // 
            ConsultaDisponibilidadPaquetesBtn.Location = new Point(660, 404);
            ConsultaDisponibilidadPaquetesBtn.Name = "ConsultaDisponibilidadPaquetesBtn";
            ConsultaDisponibilidadPaquetesBtn.Size = new Size(138, 31);
            ConsultaDisponibilidadPaquetesBtn.TabIndex = 2;
            ConsultaDisponibilidadPaquetesBtn.Text = "Agregar";
            ConsultaDisponibilidadPaquetesBtn.UseVisualStyleBackColor = true;
            ConsultaDisponibilidadPaquetesBtn.Click += ConsultaDisponibilidadPaquetesBtn_Click;
            // 
            // CrearItinerario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 822);
            Controls.Add(grpMenu);
            Name = "CrearItinerario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear itinerario";
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMenu;
        private Button ConsultaDisponibilidadHotelesBtn;
        private Button ConsultaDisponibilidadPaquetesBtn;
        private Button ConsultaDisponibilidadVuelosBtn;
        private Label lblNumeroItinerario;
        private TextBox txtNumeroItinerario;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox5;
        private Label label5;
        private Label label4;
        private TextBox textBox4;
        private ListView listView1;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label8;
        private ListView listView3;
        private Label label7;
        private ListView listView2;
        private Label label6;
        private Button button5;
        private TextBox textBox7;
        private Label label10;
        private TextBox textBox6;
        private Button button3;
        private Button button8;
        private Button AgregarPersonaBtn;
        private ListView listView4;
        private ColumnHeader nombreHeader;
        private ColumnHeader apellidoHeader;
        private ColumnHeader TipoPasajero;
    }
}