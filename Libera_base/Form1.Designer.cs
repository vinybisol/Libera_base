namespace Libera_base
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.checkAbastecidas = new System.Windows.Forms.CheckBox();
            this.checkCupom = new System.Windows.Forms.CheckBox();
            this.checkHistorico = new System.Windows.Forms.CheckBox();
            this.checkNotaeletronica = new System.Windows.Forms.CheckBox();
            this.checkNotaemitida = new System.Windows.Forms.CheckBox();
            this.checkNotavinculada = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 215);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "localhost";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 279);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "postgres";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(57, 305);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "181271";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(57, 331);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "dbapanhador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Database";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(57, 357);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "5432";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Porta";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(390, 253);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Data";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(206, 383);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(112, 55);
            this.btnVerificar.TabIndex = 14;
            this.btnVerificar.Text = "Verificar CheckedListBox";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // checkAbastecidas
            // 
            this.checkAbastecidas.AutoSize = true;
            this.checkAbastecidas.Location = new System.Drawing.Point(196, 245);
            this.checkAbastecidas.Name = "checkAbastecidas";
            this.checkAbastecidas.Size = new System.Drawing.Size(83, 17);
            this.checkAbastecidas.TabIndex = 15;
            this.checkAbastecidas.Text = "abastecidas";
            this.checkAbastecidas.UseVisualStyleBackColor = true;
            // 
            // checkCupom
            // 
            this.checkCupom.AutoSize = true;
            this.checkCupom.Location = new System.Drawing.Point(196, 268);
            this.checkCupom.Name = "checkCupom";
            this.checkCupom.Size = new System.Drawing.Size(128, 17);
            this.checkCupom.TabIndex = 16;
            this.checkCupom.Text = "cupomfiscaleletronico";
            this.checkCupom.UseVisualStyleBackColor = true;
            // 
            // checkHistorico
            // 
            this.checkHistorico.AutoSize = true;
            this.checkHistorico.Location = new System.Drawing.Point(196, 291);
            this.checkHistorico.Name = "checkHistorico";
            this.checkHistorico.Size = new System.Drawing.Size(124, 17);
            this.checkHistorico.TabIndex = 17;
            this.checkHistorico.Text = "historicotransacaotef";
            this.checkHistorico.UseVisualStyleBackColor = true;
            // 
            // checkNotaeletronica
            // 
            this.checkNotaeletronica.AutoSize = true;
            this.checkNotaeletronica.Location = new System.Drawing.Point(196, 314);
            this.checkNotaeletronica.Name = "checkNotaeletronica";
            this.checkNotaeletronica.Size = new System.Drawing.Size(117, 17);
            this.checkNotaeletronica.TabIndex = 18;
            this.checkNotaeletronica.Text = "notafiscaleletronica";
            this.checkNotaeletronica.UseVisualStyleBackColor = true;
            // 
            // checkNotaemitida
            // 
            this.checkNotaemitida.AutoSize = true;
            this.checkNotaemitida.Location = new System.Drawing.Point(196, 337);
            this.checkNotaemitida.Name = "checkNotaemitida";
            this.checkNotaemitida.Size = new System.Drawing.Size(104, 17);
            this.checkNotaemitida.TabIndex = 19;
            this.checkNotaemitida.Text = "notafiscalemitida";
            this.checkNotaemitida.UseVisualStyleBackColor = true;
            // 
            // checkNotavinculada
            // 
            this.checkNotavinculada.AutoSize = true;
            this.checkNotavinculada.Location = new System.Drawing.Point(196, 360);
            this.checkNotavinculada.Name = "checkNotavinculada";
            this.checkNotavinculada.Size = new System.Drawing.Size(132, 17);
            this.checkNotavinculada.TabIndex = 20;
            this.checkNotavinculada.Text = "notasfiscaisvinculadas";
            this.checkNotavinculada.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(698, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 21;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkNotavinculada);
            this.Controls.Add(this.checkNotaemitida);
            this.Controls.Add(this.checkNotaeletronica);
            this.Controls.Add(this.checkHistorico);
            this.Controls.Add(this.checkCupom);
            this.Controls.Add(this.checkAbastecidas);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.CheckBox checkAbastecidas;
        private System.Windows.Forms.CheckBox checkCupom;
        private System.Windows.Forms.CheckBox checkHistorico;
        private System.Windows.Forms.CheckBox checkNotaeletronica;
        private System.Windows.Forms.CheckBox checkNotaemitida;
        private System.Windows.Forms.CheckBox checkNotavinculada;
        private System.Windows.Forms.Button button2;
    }
}

