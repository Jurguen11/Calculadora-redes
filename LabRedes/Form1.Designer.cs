namespace LabRedes
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_IP1 = new System.Windows.Forms.TextBox();
            this.textBox_IP2 = new System.Windows.Forms.TextBox();
            this.textBox_IP3 = new System.Windows.Forms.TextBox();
            this.textBox_IP4 = new System.Windows.Forms.TextBox();
            this.textBox_SubNet = new System.Windows.Forms.TextBox();
            this.textBox_Clase = new System.Windows.Forms.TextBox();
            this.textBox_Mascara = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.button_calcular = new System.Windows.Forms.Button();
            this.column_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subnet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Clase de Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Máscara por defecto";
            // 
            // textBox_IP1
            // 
            this.textBox_IP1.Location = new System.Drawing.Point(54, 10);
            this.textBox_IP1.Name = "textBox_IP1";
            this.textBox_IP1.Size = new System.Drawing.Size(51, 20);
            this.textBox_IP1.TabIndex = 5;
            // 
            // textBox_IP2
            // 
            this.textBox_IP2.Location = new System.Drawing.Point(127, 10);
            this.textBox_IP2.Name = "textBox_IP2";
            this.textBox_IP2.Size = new System.Drawing.Size(51, 20);
            this.textBox_IP2.TabIndex = 6;
            // 
            // textBox_IP3
            // 
            this.textBox_IP3.Location = new System.Drawing.Point(200, 10);
            this.textBox_IP3.Name = "textBox_IP3";
            this.textBox_IP3.Size = new System.Drawing.Size(53, 20);
            this.textBox_IP3.TabIndex = 7;
            // 
            // textBox_IP4
            // 
            this.textBox_IP4.Location = new System.Drawing.Point(275, 10);
            this.textBox_IP4.Name = "textBox_IP4";
            this.textBox_IP4.Size = new System.Drawing.Size(51, 20);
            this.textBox_IP4.TabIndex = 8;
            // 
            // textBox_SubNet
            // 
            this.textBox_SubNet.Location = new System.Drawing.Point(54, 42);
            this.textBox_SubNet.Name = "textBox_SubNet";
            this.textBox_SubNet.Size = new System.Drawing.Size(51, 20);
            this.textBox_SubNet.TabIndex = 9;
            // 
            // textBox_Clase
            // 
            this.textBox_Clase.Enabled = false;
            this.textBox_Clase.Location = new System.Drawing.Point(111, 329);
            this.textBox_Clase.Name = "textBox_Clase";
            this.textBox_Clase.Size = new System.Drawing.Size(51, 20);
            this.textBox_Clase.TabIndex = 10;
            // 
            // textBox_Mascara
            // 
            this.textBox_Mascara.Enabled = false;
            this.textBox_Mascara.Location = new System.Drawing.Point(111, 362);
            this.textBox_Mascara.Name = "textBox_Mascara";
            this.textBox_Mascara.Size = new System.Drawing.Size(151, 20);
            this.textBox_Mascara.TabIndex = 11;
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_1,
            this.column_2,
            this.column_3,
            this.column_4});
            this.grid.Location = new System.Drawing.Point(3, 68);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(461, 255);
            this.grid.TabIndex = 12;
            this.grid.TabStop = false;
            // 
            // button_calcular
            // 
            this.button_calcular.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_calcular.Image = global::LabRedes.Properties.Resources.play_button;
            this.button_calcular.Location = new System.Drawing.Point(424, 342);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(40, 40);
            this.button_calcular.TabIndex = 0;
            this.button_calcular.TabStop = false;
            this.button_calcular.UseVisualStyleBackColor = false;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // column_1
            // 
            this.column_1.HeaderText = "#";
            this.column_1.Name = "column_1";
            this.column_1.ReadOnly = true;
            // 
            // column_2
            // 
            this.column_2.HeaderText = "ID de la Red";
            this.column_2.Name = "column_2";
            this.column_2.ReadOnly = true;
            // 
            // column_3
            // 
            this.column_3.HeaderText = "Rango de IPs disponibles";
            this.column_3.Name = "column_3";
            this.column_3.ReadOnly = true;
            // 
            // column_4
            // 
            this.column_4.HeaderText = "Direcciones de difusión (Broadcast)";
            this.column_4.Name = "column_4";
            this.column_4.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = ":";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(468, 387);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.textBox_Mascara);
            this.Controls.Add(this.textBox_Clase);
            this.Controls.Add(this.textBox_SubNet);
            this.Controls.Add(this.textBox_IP4);
            this.Controls.Add(this.textBox_IP3);
            this.Controls.Add(this.textBox_IP2);
            this.Controls.Add(this.textBox_IP1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_calcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.Text = "Calculadora con IPv4";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_IP1;
        private System.Windows.Forms.TextBox textBox_IP2;
        private System.Windows.Forms.TextBox textBox_IP3;
        private System.Windows.Forms.TextBox textBox_IP4;
        private System.Windows.Forms.TextBox textBox_SubNet;
        private System.Windows.Forms.TextBox textBox_Clase;
        private System.Windows.Forms.TextBox textBox_Mascara;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

