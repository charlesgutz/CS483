namespace WindowsFormsApp
{
    partial class TelaCadastroPessoas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textCPFCNPJ = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textIdade = new System.Windows.Forms.TextBox();
            this.checkFisica = new System.Windows.Forms.CheckBox();
            this.checkJuridica = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF/CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME";
            // 
            // textCPFCNPJ
            // 
            this.textCPFCNPJ.Location = new System.Drawing.Point(120, 103);
            this.textCPFCNPJ.Name = "textCPFCNPJ";
            this.textCPFCNPJ.Size = new System.Drawing.Size(269, 20);
            this.textCPFCNPJ.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.Color.Yellow;
            this.txtNome.Location = new System.Drawing.Point(120, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(269, 20);
            this.txtNome.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "LISTAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "HOME";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "IDADE";
            // 
            // textIdade
            // 
            this.textIdade.Location = new System.Drawing.Point(120, 149);
            this.textIdade.Name = "textIdade";
            this.textIdade.Size = new System.Drawing.Size(269, 20);
            this.textIdade.TabIndex = 8;
            // 
            // checkFisica
            // 
            this.checkFisica.AutoSize = true;
            this.checkFisica.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkFisica.Location = new System.Drawing.Point(164, 202);
            this.checkFisica.Name = "checkFisica";
            this.checkFisica.Size = new System.Drawing.Size(59, 17);
            this.checkFisica.TabIndex = 9;
            this.checkFisica.Text = "FISICA";
            this.checkFisica.UseVisualStyleBackColor = true;
            // 
            // checkJuridica
            // 
            this.checkJuridica.AutoSize = true;
            this.checkJuridica.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkJuridica.Location = new System.Drawing.Point(263, 202);
            this.checkJuridica.Name = "checkJuridica";
            this.checkJuridica.Size = new System.Drawing.Size(75, 17);
            this.checkJuridica.TabIndex = 10;
            this.checkJuridica.Text = "JURIDICA";
            this.checkJuridica.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 309);
            this.Controls.Add(this.checkJuridica);
            this.Controls.Add(this.checkFisica);
            this.Controls.Add(this.textIdade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.textCPFCNPJ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastroPessoas";
            this.Text = "TelaCadastroPessoas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCPFCNPJ;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textIdade;
        private System.Windows.Forms.CheckBox checkFisica;
        private System.Windows.Forms.CheckBox checkJuridica;
    }
}