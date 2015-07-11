namespace QualTipoMime
{
    partial class frmPrincipal
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
            this.btnSelecionaArquivo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSobre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblTamanho2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelecionaArquivo
            // 
            this.btnSelecionaArquivo.Location = new System.Drawing.Point(36, 166);
            this.btnSelecionaArquivo.Name = "btnSelecionaArquivo";
            this.btnSelecionaArquivo.Size = new System.Drawing.Size(146, 23);
            this.btnSelecionaArquivo.TabIndex = 0;
            this.btnSelecionaArquivo.Text = "Selecionar arquivo";
            this.btnSelecionaArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionaArquivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo mime";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(36, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(224, 13);
            this.textBox1.TabIndex = 2;
            // 
            // btnSobre
            // 
            this.btnSobre.Location = new System.Drawing.Point(204, 166);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(56, 23);
            this.btnSobre.TabIndex = 3;
            this.btnSobre.Text = "Sobre...";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tamanho";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(53, 88);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(0, 13);
            this.lblTamanho.TabIndex = 5;
            // 
            // lblTamanho2
            // 
            this.lblTamanho2.AutoSize = true;
            this.lblTamanho2.Location = new System.Drawing.Point(53, 107);
            this.lblTamanho2.Name = "lblTamanho2";
            this.lblTamanho2.Size = new System.Drawing.Size(0, 13);
            this.lblTamanho2.TabIndex = 6;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 201);
            this.Controls.Add(this.lblTamanho2);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelecionaArquivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QualTipoMime";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionaArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblTamanho2;
    }
}

