namespace ATM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btn09 = new System.Windows.Forms.Button();
            this.btn08 = new System.Windows.Forms.Button();
            this.btn07 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btn06 = new System.Windows.Forms.Button();
            this.btn05 = new System.Windows.Forms.Button();
            this.btn04 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btn03 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.lblEmprestimo = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.lblSaque = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaque);
            this.groupBox1.Controls.Add(this.btnSaldo);
            this.groupBox1.Location = new System.Drawing.Point(45, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSaque
            // 
            this.btnSaque.Image = ((System.Drawing.Image)(resources.GetObject("btnSaque.Image")));
            this.btnSaque.Location = new System.Drawing.Point(6, 86);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(101, 77);
            this.btnSaque.TabIndex = 11;
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnSaldo
            // 
            this.btnSaldo.Image = ((System.Drawing.Image)(resources.GetObject("btnSaldo.Image")));
            this.btnSaldo.Location = new System.Drawing.Point(6, 9);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(101, 77);
            this.btnSaldo.TabIndex = 10;
            this.btnSaldo.UseVisualStyleBackColor = true;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.lblSaque);
            this.groupBox2.Controls.Add(this.lblDeposito);
            this.groupBox2.Controls.Add(this.lblDisplay);
            this.groupBox2.Controls.Add(this.lblSaldo);
            this.groupBox2.Controls.Add(this.lblEmprestimo);
            this.groupBox2.Location = new System.Drawing.Point(158, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeposito);
            this.groupBox3.Controls.Add(this.btnEmprestimo);
            this.groupBox3.Location = new System.Drawing.Point(358, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 154);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btnDeposito
            // 
            this.btnDeposito.Image = ((System.Drawing.Image)(resources.GetObject("btnDeposito.Image")));
            this.btnDeposito.Location = new System.Drawing.Point(5, 77);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(101, 77);
            this.btnDeposito.TabIndex = 9;
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.Image = ((System.Drawing.Image)(resources.GetObject("btnEmprestimo.Image")));
            this.btnEmprestimo.Location = new System.Drawing.Point(5, 0);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(101, 77);
            this.btnEmprestimo.TabIndex = 8;
            this.btnEmprestimo.UseVisualStyleBackColor = true;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnMais);
            this.groupBox4.Controls.Add(this.btnBranco);
            this.groupBox4.Controls.Add(this.btn00);
            this.groupBox4.Controls.Add(this.btnMenos);
            this.groupBox4.Controls.Add(this.btnEntrar);
            this.groupBox4.Controls.Add(this.btn09);
            this.groupBox4.Controls.Add(this.btn08);
            this.groupBox4.Controls.Add(this.btn07);
            this.groupBox4.Controls.Add(this.btnLimpar);
            this.groupBox4.Controls.Add(this.btn06);
            this.groupBox4.Controls.Add(this.btn05);
            this.groupBox4.Controls.Add(this.btn04);
            this.groupBox4.Controls.Add(this.btnCancelar);
            this.groupBox4.Controls.Add(this.btn03);
            this.groupBox4.Controls.Add(this.btn02);
            this.groupBox4.Controls.Add(this.btn01);
            this.groupBox4.Location = new System.Drawing.Point(45, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(419, 358);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // btnMais
            // 
            this.btnMais.Image = ((System.Drawing.Image)(resources.GetObject("btnMais.Image")));
            this.btnMais.Location = new System.Drawing.Point(302, 260);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(117, 73);
            this.btnMais.TabIndex = 20;
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Image = ((System.Drawing.Image)(resources.GetObject("btnBranco.Image")));
            this.btnBranco.Location = new System.Drawing.Point(205, 260);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(91, 73);
            this.btnBranco.TabIndex = 19;
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btn00
            // 
            this.btn00.Image = ((System.Drawing.Image)(resources.GetObject("btn00.Image")));
            this.btn00.Location = new System.Drawing.Point(107, 260);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(92, 73);
            this.btn00.TabIndex = 18;
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.btn00_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Image = ((System.Drawing.Image)(resources.GetObject("btnMenos.Image")));
            this.btnMenos.Location = new System.Drawing.Point(6, 262);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(95, 73);
            this.btnMenos.TabIndex = 17;
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrar.Image")));
            this.btnEntrar.Location = new System.Drawing.Point(302, 181);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(117, 73);
            this.btnEntrar.TabIndex = 16;
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btn09
            // 
            this.btn09.Image = ((System.Drawing.Image)(resources.GetObject("btn09.Image")));
            this.btn09.Location = new System.Drawing.Point(205, 183);
            this.btn09.Name = "btn09";
            this.btn09.Size = new System.Drawing.Size(91, 73);
            this.btn09.TabIndex = 15;
            this.btn09.UseVisualStyleBackColor = true;
            this.btn09.Click += new System.EventHandler(this.btn09_Click);
            // 
            // btn08
            // 
            this.btn08.Image = ((System.Drawing.Image)(resources.GetObject("btn08.Image")));
            this.btn08.Location = new System.Drawing.Point(107, 181);
            this.btn08.Name = "btn08";
            this.btn08.Size = new System.Drawing.Size(92, 73);
            this.btn08.TabIndex = 14;
            this.btn08.UseVisualStyleBackColor = true;
            this.btn08.Click += new System.EventHandler(this.btn08_Click);
            // 
            // btn07
            // 
            this.btn07.Image = ((System.Drawing.Image)(resources.GetObject("btn07.Image")));
            this.btn07.Location = new System.Drawing.Point(6, 183);
            this.btn07.Name = "btn07";
            this.btn07.Size = new System.Drawing.Size(95, 73);
            this.btn07.TabIndex = 13;
            this.btn07.UseVisualStyleBackColor = true;
            this.btn07.Click += new System.EventHandler(this.btn07_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(302, 104);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 73);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btn06
            // 
            this.btn06.Image = ((System.Drawing.Image)(resources.GetObject("btn06.Image")));
            this.btn06.Location = new System.Drawing.Point(205, 104);
            this.btn06.Name = "btn06";
            this.btn06.Size = new System.Drawing.Size(91, 73);
            this.btn06.TabIndex = 11;
            this.btn06.UseVisualStyleBackColor = true;
            this.btn06.Click += new System.EventHandler(this.btn06_Click);
            // 
            // btn05
            // 
            this.btn05.Image = ((System.Drawing.Image)(resources.GetObject("btn05.Image")));
            this.btn05.Location = new System.Drawing.Point(107, 104);
            this.btn05.Name = "btn05";
            this.btn05.Size = new System.Drawing.Size(92, 73);
            this.btn05.TabIndex = 10;
            this.btn05.UseVisualStyleBackColor = true;
            this.btn05.Click += new System.EventHandler(this.btn05_Click);
            // 
            // btn04
            // 
            this.btn04.Image = ((System.Drawing.Image)(resources.GetObject("btn04.Image")));
            this.btn04.Location = new System.Drawing.Point(6, 104);
            this.btn04.Name = "btn04";
            this.btn04.Size = new System.Drawing.Size(95, 73);
            this.btn04.TabIndex = 9;
            this.btn04.UseVisualStyleBackColor = true;
            this.btn04.Click += new System.EventHandler(this.btn04_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(302, 25);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 73);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btn03
            // 
            this.btn03.Image = ((System.Drawing.Image)(resources.GetObject("btn03.Image")));
            this.btn03.Location = new System.Drawing.Point(205, 25);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(91, 73);
            this.btn03.TabIndex = 7;
            this.btn03.UseVisualStyleBackColor = true;
            this.btn03.Click += new System.EventHandler(this.btn03_Click);
            // 
            // btn02
            // 
            this.btn02.Image = ((System.Drawing.Image)(resources.GetObject("btn02.Image")));
            this.btn02.Location = new System.Drawing.Point(107, 25);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(92, 73);
            this.btn02.TabIndex = 6;
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.btn02_Click);
            // 
            // btn01
            // 
            this.btn01.Image = ((System.Drawing.Image)(resources.GetObject("btn01.Image")));
            this.btn01.Location = new System.Drawing.Point(6, 25);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(95, 73);
            this.btn01.TabIndex = 5;
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btn01_Click);
            // 
            // lblEmprestimo
            // 
            this.lblEmprestimo.AutoSize = true;
            this.lblEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmprestimo.Location = new System.Drawing.Point(90, 32);
            this.lblEmprestimo.Name = "lblEmprestimo";
            this.lblEmprestimo.Size = new System.Drawing.Size(104, 20);
            this.lblEmprestimo.TabIndex = 0;
            this.lblEmprestimo.Text = "Empréstimo";
            this.lblEmprestimo.Click += new System.EventHandler(this.lblEmprestimo_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(6, 32);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(55, 20);
            this.lblSaldo.TabIndex = 21;
            this.lblSaldo.Text = "Saldo";
            this.lblSaldo.Click += new System.EventHandler(this.lblSaldo_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(6, 60);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(188, 50);
            this.lblDisplay.TabIndex = 22;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.Location = new System.Drawing.Point(90, 110);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(81, 20);
            this.lblDeposito.TabIndex = 23;
            this.lblDeposito.Text = "Depósito";
            this.lblDeposito.Click += new System.EventHandler(this.lblDeposito_Click);
            // 
            // lblSaque
            // 
            this.lblSaque.AutoSize = true;
            this.lblSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaque.Location = new System.Drawing.Point(6, 109);
            this.lblSaque.Name = "lblSaque";
            this.lblSaque.Size = new System.Drawing.Size(61, 20);
            this.lblSaque.TabIndex = 24;
            this.lblSaque.Text = "Saque";
            this.lblSaque.Click += new System.EventHandler(this.lblSaque_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 655);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btn09;
        private System.Windows.Forms.Button btn08;
        private System.Windows.Forms.Button btn07;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btn06;
        private System.Windows.Forms.Button btn05;
        private System.Windows.Forms.Button btn04;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btn03;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btnEmprestimo;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Label lblSaque;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblEmprestimo;
    }
}

