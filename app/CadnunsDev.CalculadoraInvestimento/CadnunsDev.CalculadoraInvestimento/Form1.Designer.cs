namespace CadnunsDev.CalculadoraInvestimento
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
            this.tboxTxAnual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxTxMensal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxVlrInicial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxPeriodo = new System.Windows.Forms.TextBox();
            this.tipoPeriodo = new System.Windows.Forms.GroupBox();
            this.rdbMensal = new System.Windows.Forms.RadioButton();
            this.rdbAnual = new System.Windows.Forms.RadioButton();
            this.lbValorFinal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbRendimentos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxAporteMensal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbVlrInvestido = new System.Windows.Forms.Label();
            this.tipoPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxTxAnual
            // 
            this.tboxTxAnual.Location = new System.Drawing.Point(112, 12);
            this.tboxTxAnual.Name = "tboxTxAnual";
            this.tboxTxAnual.Size = new System.Drawing.Size(123, 20);
            this.tboxTxAnual.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Taxa Anual(%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Taxa mensal(%)";
            // 
            // tboxTxMensal
            // 
            this.tboxTxMensal.Location = new System.Drawing.Point(112, 43);
            this.tboxTxMensal.Name = "tboxTxMensal";
            this.tboxTxMensal.Size = new System.Drawing.Size(123, 20);
            this.tboxTxMensal.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor inicial (R$) ";
            // 
            // tboxVlrInicial
            // 
            this.tboxVlrInicial.Location = new System.Drawing.Point(342, 12);
            this.tboxVlrInicial.Name = "tboxVlrInicial";
            this.tboxVlrInicial.Size = new System.Drawing.Size(123, 20);
            this.tboxVlrInicial.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Periodo";
            // 
            // tboxPeriodo
            // 
            this.tboxPeriodo.Location = new System.Drawing.Point(112, 78);
            this.tboxPeriodo.Name = "tboxPeriodo";
            this.tboxPeriodo.Size = new System.Drawing.Size(123, 20);
            this.tboxPeriodo.TabIndex = 6;
            // 
            // tipoPeriodo
            // 
            this.tipoPeriodo.Controls.Add(this.rdbMensal);
            this.tipoPeriodo.Controls.Add(this.rdbAnual);
            this.tipoPeriodo.Location = new System.Drawing.Point(28, 116);
            this.tipoPeriodo.Name = "tipoPeriodo";
            this.tipoPeriodo.Size = new System.Drawing.Size(207, 50);
            this.tipoPeriodo.TabIndex = 8;
            this.tipoPeriodo.TabStop = false;
            this.tipoPeriodo.Text = "Tipo Periodo";
            // 
            // rdbMensal
            // 
            this.rdbMensal.AutoSize = true;
            this.rdbMensal.Location = new System.Drawing.Point(106, 19);
            this.rdbMensal.Name = "rdbMensal";
            this.rdbMensal.Size = new System.Drawing.Size(59, 17);
            this.rdbMensal.TabIndex = 1;
            this.rdbMensal.Text = "Mensal";
            this.rdbMensal.UseVisualStyleBackColor = true;
            // 
            // rdbAnual
            // 
            this.rdbAnual.AutoSize = true;
            this.rdbAnual.Checked = true;
            this.rdbAnual.Location = new System.Drawing.Point(15, 19);
            this.rdbAnual.Name = "rdbAnual";
            this.rdbAnual.Size = new System.Drawing.Size(52, 17);
            this.rdbAnual.TabIndex = 0;
            this.rdbAnual.TabStop = true;
            this.rdbAnual.Text = "Anual";
            this.rdbAnual.UseVisualStyleBackColor = true;
            // 
            // lbValorFinal
            // 
            this.lbValorFinal.AutoSize = true;
            this.lbValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorFinal.Location = new System.Drawing.Point(379, 112);
            this.lbValorFinal.Name = "lbValorFinal";
            this.lbValorFinal.Size = new System.Drawing.Size(72, 20);
            this.lbValorFinal.TabIndex = 9;
            this.lbValorFinal.Text = "R$ 0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Montante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rendimentos";
            // 
            // lbRendimentos
            // 
            this.lbRendimentos.AutoSize = true;
            this.lbRendimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRendimentos.Location = new System.Drawing.Point(379, 143);
            this.lbRendimentos.Name = "lbRendimentos";
            this.lbRendimentos.Size = new System.Drawing.Size(72, 20);
            this.lbRendimentos.TabIndex = 11;
            this.lbRendimentos.Text = "R$ 0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Aporte Mensal(R$)";
            // 
            // tboxAporteMensal
            // 
            this.tboxAporteMensal.Location = new System.Drawing.Point(342, 40);
            this.tboxAporteMensal.Name = "tboxAporteMensal";
            this.tboxAporteMensal.Size = new System.Drawing.Size(123, 20);
            this.tboxAporteMensal.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(261, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Vlr. Investido";
            // 
            // lbVlrInvestido
            // 
            this.lbVlrInvestido.AutoSize = true;
            this.lbVlrInvestido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVlrInvestido.Location = new System.Drawing.Point(379, 81);
            this.lbVlrInvestido.Name = "lbVlrInvestido";
            this.lbVlrInvestido.Size = new System.Drawing.Size(72, 20);
            this.lbVlrInvestido.TabIndex = 15;
            this.lbVlrInvestido.Text = "R$ 0,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 178);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbVlrInvestido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tboxAporteMensal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbRendimentos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbValorFinal);
            this.Controls.Add(this.tipoPeriodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxPeriodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxVlrInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxTxMensal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxTxAnual);
            this.Name = "Form1";
            this.Text = "Calculadora de Investimentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tipoPeriodo.ResumeLayout(false);
            this.tipoPeriodo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxTxAnual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxTxMensal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxVlrInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxPeriodo;
        private System.Windows.Forms.GroupBox tipoPeriodo;
        private System.Windows.Forms.RadioButton rdbMensal;
        private System.Windows.Forms.RadioButton rdbAnual;
        private System.Windows.Forms.Label lbValorFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbRendimentos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxAporteMensal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbVlrInvestido;
    }
}

