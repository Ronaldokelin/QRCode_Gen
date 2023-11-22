namespace QRCode_Gen
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
            this.picQRCodeLeft = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.btnGerarQRCode = new System.Windows.Forms.Button();
            this.picQRCodeRight = new System.Windows.Forms.PictureBox();
            this.textInfo = new System.Windows.Forms.TextBox();
            this.labelDeveloper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeRight)).BeginInit();
            this.SuspendLayout();
            // 
            // picQRCodeLeft
            // 
            this.picQRCodeLeft.Location = new System.Drawing.Point(12, 12);
            this.picQRCodeLeft.Name = "picQRCodeLeft";
            this.picQRCodeLeft.Size = new System.Drawing.Size(200, 200);
            this.picQRCodeLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRCodeLeft.TabIndex = 0;
            this.picQRCodeLeft.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe o produto e estação. Exemplo: FOGODV01";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(12, 251);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(200, 20);
            this.txtTexto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Largura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(13, 291);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(66, 20);
            this.txtAltura.TabIndex = 5;
            this.txtAltura.Text = "400";
            // 
            // txtLargura
            // 
            this.txtLargura.Location = new System.Drawing.Point(95, 291);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(60, 20);
            this.txtLargura.TabIndex = 6;
            this.txtLargura.Text = "400";
            // 
            // btnGerarQRCode
            // 
            this.btnGerarQRCode.Location = new System.Drawing.Point(351, 274);
            this.btnGerarQRCode.Name = "btnGerarQRCode";
            this.btnGerarQRCode.Size = new System.Drawing.Size(95, 34);
            this.btnGerarQRCode.TabIndex = 7;
            this.btnGerarQRCode.Text = "QRCode Viwer";
            this.btnGerarQRCode.UseVisualStyleBackColor = true;
            this.btnGerarQRCode.Click += new System.EventHandler(this.btnGerarQRCode_Click);
            // 
            // picQRCodeRight
            // 
            this.picQRCodeRight.Location = new System.Drawing.Point(246, 12);
            this.picQRCodeRight.Name = "picQRCodeRight";
            this.picQRCodeRight.Size = new System.Drawing.Size(200, 200);
            this.picQRCodeRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRCodeRight.TabIndex = 8;
            this.picQRCodeRight.TabStop = false;
            // 
            // textInfo
            // 
            this.textInfo.Location = new System.Drawing.Point(17, 330);
            this.textInfo.Multiline = true;
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(428, 108);
            this.textInfo.TabIndex = 9;
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeveloper.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelDeveloper.Location = new System.Drawing.Point(2, 499);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(117, 12);
            this.labelDeveloper.TabIndex = 10;
            this.labelDeveloper.Text = "Developed by R. Kelin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 516);
            this.Controls.Add(this.labelDeveloper);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.picQRCodeRight);
            this.Controls.Add(this.btnGerarQRCode);
            this.Controls.Add(this.txtLargura);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picQRCodeLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "QRCode Gen";
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picQRCodeLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.Button btnGerarQRCode;
        private System.Windows.Forms.PictureBox picQRCodeRight;
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.Label labelDeveloper;
    }
}

