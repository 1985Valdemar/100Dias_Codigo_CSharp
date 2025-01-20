namespace teste
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.checkMultinacional = new System.Windows.Forms.CheckBox();
            this.checkNacional = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioHospitalar = new System.Windows.Forms.RadioButton();
            this.radioMontadora = new System.Windows.Forms.RadioButton();
            this.radioMetalurgica = new System.Windows.Forms.RadioButton();
            this.lista = new System.Windows.Forms.ListBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Nascimento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(231, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(528, 34);
            this.txtNome.TabIndex = 4;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(231, 55);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(528, 34);
            this.txtData.TabIndex = 5;
            // 
            // comboEstado
            // 
            this.comboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(231, 95);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(528, 37);
            this.comboEstado.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(231, 141);
            this.txtTelefone.Mask = "(00) 00000 - 0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(528, 34);
            this.txtTelefone.TabIndex = 7;
            this.txtTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefone_MaskInputRejected);
            // 
            // checkMultinacional
            // 
            this.checkMultinacional.AutoSize = true;
            this.checkMultinacional.Location = new System.Drawing.Point(231, 197);
            this.checkMultinacional.Name = "checkMultinacional";
            this.checkMultinacional.Size = new System.Drawing.Size(107, 20);
            this.checkMultinacional.TabIndex = 8;
            this.checkMultinacional.Text = "Multinacional";
            this.checkMultinacional.UseVisualStyleBackColor = true;
            // 
            // checkNacional
            // 
            this.checkNacional.AutoSize = true;
            this.checkNacional.Location = new System.Drawing.Point(344, 197);
            this.checkNacional.Name = "checkNacional";
            this.checkNacional.Size = new System.Drawing.Size(83, 20);
            this.checkNacional.TabIndex = 9;
            this.checkNacional.Text = "Nacional";
            this.checkNacional.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioHospitalar);
            this.groupBox1.Controls.Add(this.radioMontadora);
            this.groupBox1.Controls.Add(this.radioMetalurgica);
            this.groupBox1.Location = new System.Drawing.Point(231, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 76);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Segmento";
            // 
            // radioHospitalar
            // 
            this.radioHospitalar.AutoSize = true;
            this.radioHospitalar.Location = new System.Drawing.Point(140, 31);
            this.radioHospitalar.Name = "radioHospitalar";
            this.radioHospitalar.Size = new System.Drawing.Size(90, 20);
            this.radioHospitalar.TabIndex = 2;
            this.radioHospitalar.Text = "Hospitalar";
            this.radioHospitalar.UseVisualStyleBackColor = true;
            // 
            // radioMontadora
            // 
            this.radioMontadora.AutoSize = true;
            this.radioMontadora.Location = new System.Drawing.Point(278, 31);
            this.radioMontadora.Name = "radioMontadora";
            this.radioMontadora.Size = new System.Drawing.Size(93, 20);
            this.radioMontadora.TabIndex = 1;
            this.radioMontadora.Text = "Montadora";
            this.radioMontadora.UseVisualStyleBackColor = true;
            // 
            // radioMetalurgica
            // 
            this.radioMetalurgica.AutoSize = true;
            this.radioMetalurgica.Checked = true;
            this.radioMetalurgica.Location = new System.Drawing.Point(7, 31);
            this.radioMetalurgica.Name = "radioMetalurgica";
            this.radioMetalurgica.Size = new System.Drawing.Size(98, 20);
            this.radioMetalurgica.TabIndex = 0;
            this.radioMetalurgica.TabStop = true;
            this.radioMetalurgica.Text = "Metalurgica";
            this.radioMetalurgica.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 29;
            this.lista.Location = new System.Drawing.Point(26, 391);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(716, 91);
            this.lista.TabIndex = 11;
            this.lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lista_MouseDoubleClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(26, 320);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(191, 65);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar / Alterar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(288, 320);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(191, 65);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(550, 320);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(191, 65);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 494);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkNacional);
            this.Controls.Add(this.checkMultinacional);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(300, 150);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.CheckBox checkMultinacional;
        private System.Windows.Forms.CheckBox checkNacional;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioHospitalar;
        private System.Windows.Forms.RadioButton radioMontadora;
        private System.Windows.Forms.RadioButton radioMetalurgica;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
    }
}

