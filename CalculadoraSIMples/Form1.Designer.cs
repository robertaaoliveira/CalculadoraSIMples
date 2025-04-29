namespace CalculadoraSIMples
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
            this.btlCalcular = new System.Windows.Forms.Button();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.numeric1 = new System.Windows.Forms.NumericUpDown();
            this.numeric2 = new System.Windows.Forms.NumericUpDown();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.rbSoma = new System.Windows.Forms.RadioButton();
            this.rbSub = new System.Windows.Forms.RadioButton();
            this.rbMult = new System.Windows.Forms.RadioButton();
            this.rbDiv = new System.Windows.Forms.RadioButton();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2)).BeginInit();
            this.SuspendLayout();
            // 
            // btlCalcular
            // 
            this.btlCalcular.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btlCalcular.Location = new System.Drawing.Point(148, 418);
            this.btlCalcular.Name = "btlCalcular";
            this.btlCalcular.Size = new System.Drawing.Size(115, 47);
            this.btlCalcular.TabIndex = 0;
            this.btlCalcular.Text = "Calcular";
            this.btlCalcular.UseVisualStyleBackColor = false;
            this.btlCalcular.Click += new System.EventHandler(this.btlCalcular_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(98, 105);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(56, 13);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "Número 1:";
            // 
            // numeric1
            // 
            this.numeric1.Location = new System.Drawing.Point(160, 103);
            this.numeric1.Name = "numeric1";
            this.numeric1.Size = new System.Drawing.Size(120, 20);
            this.numeric1.TabIndex = 2;
            // 
            // numeric2
            // 
            this.numeric2.Location = new System.Drawing.Point(160, 161);
            this.numeric2.Name = "numeric2";
            this.numeric2.Size = new System.Drawing.Size(120, 20);
            this.numeric2.TabIndex = 3;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(98, 163);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(56, 13);
            this.lblNum2.TabIndex = 4;
            this.lblNum2.Text = "Número 2:";
            this.lblNum2.Click += new System.EventHandler(this.lblNum2_Click);
            // 
            // rbSoma
            // 
            this.rbSoma.AutoSize = true;
            this.rbSoma.Location = new System.Drawing.Point(160, 241);
            this.rbSoma.Name = "rbSoma";
            this.rbSoma.Size = new System.Drawing.Size(52, 17);
            this.rbSoma.TabIndex = 5;
            this.rbSoma.TabStop = true;
            this.rbSoma.Text = "Soma";
            this.rbSoma.UseVisualStyleBackColor = true;
            // 
            // rbSub
            // 
            this.rbSub.AutoSize = true;
            this.rbSub.Location = new System.Drawing.Point(160, 279);
            this.rbSub.Name = "rbSub";
            this.rbSub.Size = new System.Drawing.Size(74, 17);
            this.rbSub.TabIndex = 6;
            this.rbSub.TabStop = true;
            this.rbSub.Text = "Subtração";
            this.rbSub.UseVisualStyleBackColor = true;
            // 
            // rbMult
            // 
            this.rbMult.AutoSize = true;
            this.rbMult.Location = new System.Drawing.Point(160, 317);
            this.rbMult.Name = "rbMult";
            this.rbMult.Size = new System.Drawing.Size(87, 17);
            this.rbMult.TabIndex = 7;
            this.rbMult.TabStop = true;
            this.rbMult.Text = "Multiplicação";
            this.rbMult.UseVisualStyleBackColor = true;
            // 
            // rbDiv
            // 
            this.rbDiv.AutoSize = true;
            this.rbDiv.Location = new System.Drawing.Point(160, 351);
            this.rbDiv.Name = "rbDiv";
            this.rbDiv.Size = new System.Drawing.Size(60, 17);
            this.rbDiv.TabIndex = 8;
            this.rbDiv.TabStop = true;
            this.rbDiv.Text = "Divisão";
            this.rbDiv.UseVisualStyleBackColor = true;
            this.rbDiv.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // txbResultado
            // 
            this.txbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResultado.Location = new System.Drawing.Point(56, 488);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(294, 38);
            this.txbResultado.TabIndex = 9;
            this.txbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.IndianRed;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnLimpar.FlatAppearance.BorderSize = 5;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(56, 532);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(294, 37);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 573);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.rbDiv);
            this.Controls.Add(this.rbMult);
            this.Controls.Add(this.rbSub);
            this.Controls.Add(this.rbSoma);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.numeric2);
            this.Controls.Add(this.numeric1);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.btlCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "::Calculadora::";
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btlCalcular;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.NumericUpDown numeric1;
        private System.Windows.Forms.NumericUpDown numeric2;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.RadioButton rbSoma;
        private System.Windows.Forms.RadioButton rbSub;
        private System.Windows.Forms.RadioButton rbMult;
        private System.Windows.Forms.RadioButton rbDiv;
        private System.Windows.Forms.TextBox txbResultado;
        private System.Windows.Forms.Button btnLimpar;
    }
}

