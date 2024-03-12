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
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDepth = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textInfo = new System.Windows.Forms.TextBox();
            this.picQRCodeRight = new System.Windows.Forms.PictureBox();
            this.btnGerarQRCode = new System.Windows.Forms.Button();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picQRCodeLeft = new System.Windows.Forms.PictureBox();
            this.tabPageUCT = new System.Windows.Forms.TabPage();
            this.picQRCode3 = new System.Windows.Forms.PictureBox();
            this.picQRCode4 = new System.Windows.Forms.PictureBox();
            this.picQRCode2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textInfoUCT = new System.Windows.Forms.TextBox();
            this.btnGerarQRCodeUCT = new System.Windows.Forms.Button();
            this.txtLarguraUCT = new System.Windows.Forms.TextBox();
            this.txtAlturaUCT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTextoUCT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.picQRCode1 = new System.Windows.Forms.PictureBox();
            this.picQRCode5 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPageDepth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeLeft)).BeginInit();
            this.tabPageUCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode5)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeveloper.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelDeveloper.Location = new System.Drawing.Point(10, 569);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(117, 12);
            this.labelDeveloper.TabIndex = 10;
            this.labelDeveloper.Text = "Developed by R. Kelin";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageDepth);
            this.tabControl.Controls.Add(this.tabPageUCT);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(461, 554);
            this.tabControl.TabIndex = 26;
            // 
            // tabPageDepth
            // 
            this.tabPageDepth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageDepth.Controls.Add(this.label5);
            this.tabPageDepth.Controls.Add(this.label4);
            this.tabPageDepth.Controls.Add(this.textInfo);
            this.tabPageDepth.Controls.Add(this.picQRCodeRight);
            this.tabPageDepth.Controls.Add(this.btnGerarQRCode);
            this.tabPageDepth.Controls.Add(this.txtLargura);
            this.tabPageDepth.Controls.Add(this.txtAltura);
            this.tabPageDepth.Controls.Add(this.label3);
            this.tabPageDepth.Controls.Add(this.label2);
            this.tabPageDepth.Controls.Add(this.txtTexto);
            this.tabPageDepth.Controls.Add(this.label1);
            this.tabPageDepth.Controls.Add(this.picQRCodeLeft);
            this.tabPageDepth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageDepth.Location = new System.Drawing.Point(4, 22);
            this.tabPageDepth.Name = "tabPageDepth";
            this.tabPageDepth.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepth.Size = new System.Drawing.Size(453, 528);
            this.tabPageDepth.TabIndex = 0;
            this.tabPageDepth.Text = "Depth/Tele/TOF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Information for configuring the router/modem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Example: FOGO5G, DV and 01 \"FOGO5GDV01\"";
            // 
            // textInfo
            // 
            this.textInfo.Location = new System.Drawing.Point(10, 470);
            this.textInfo.Multiline = true;
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(420, 50);
            this.textInfo.TabIndex = 35;
            // 
            // picQRCodeRight
            // 
            this.picQRCodeRight.BackColor = System.Drawing.Color.Silver;
            this.picQRCodeRight.Location = new System.Drawing.Point(225, 35);
            this.picQRCodeRight.Name = "picQRCodeRight";
            this.picQRCodeRight.Size = new System.Drawing.Size(222, 213);
            this.picQRCodeRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRCodeRight.TabIndex = 34;
            this.picQRCodeRight.TabStop = false;
            // 
            // btnGerarQRCode
            // 
            this.btnGerarQRCode.Location = new System.Drawing.Point(311, 385);
            this.btnGerarQRCode.Name = "btnGerarQRCode";
            this.btnGerarQRCode.Size = new System.Drawing.Size(119, 65);
            this.btnGerarQRCode.TabIndex = 33;
            this.btnGerarQRCode.Text = "QRCode Viwer";
            this.btnGerarQRCode.UseVisualStyleBackColor = true;
            this.btnGerarQRCode.Click += new System.EventHandler(this.btnGerarQRCode_Click);
            // 
            // txtLargura
            // 
            this.txtLargura.Location = new System.Drawing.Point(95, 425);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(60, 20);
            this.txtLargura.TabIndex = 32;
            this.txtLargura.Text = "400";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(10, 425);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(66, 20);
            this.txtAltura.TabIndex = 31;
            this.txtAltura.Text = "400";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Height";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(10, 355);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(231, 20);
            this.txtTexto.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Enter the product, station and number of station.";
            // 
            // picQRCodeLeft
            // 
            this.picQRCodeLeft.BackColor = System.Drawing.Color.Silver;
            this.picQRCodeLeft.Location = new System.Drawing.Point(6, 35);
            this.picQRCodeLeft.Name = "picQRCodeLeft";
            this.picQRCodeLeft.Size = new System.Drawing.Size(213, 213);
            this.picQRCodeLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRCodeLeft.TabIndex = 26;
            this.picQRCodeLeft.TabStop = false;
            // 
            // tabPageUCT
            // 
            this.tabPageUCT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageUCT.Controls.Add(this.picQRCode3);
            this.tabPageUCT.Controls.Add(this.picQRCode4);
            this.tabPageUCT.Controls.Add(this.picQRCode2);
            this.tabPageUCT.Controls.Add(this.label6);
            this.tabPageUCT.Controls.Add(this.label7);
            this.tabPageUCT.Controls.Add(this.textInfoUCT);
            this.tabPageUCT.Controls.Add(this.btnGerarQRCodeUCT);
            this.tabPageUCT.Controls.Add(this.txtLarguraUCT);
            this.tabPageUCT.Controls.Add(this.txtAlturaUCT);
            this.tabPageUCT.Controls.Add(this.label8);
            this.tabPageUCT.Controls.Add(this.label9);
            this.tabPageUCT.Controls.Add(this.txtTextoUCT);
            this.tabPageUCT.Controls.Add(this.label10);
            this.tabPageUCT.Controls.Add(this.picQRCode1);
            this.tabPageUCT.Controls.Add(this.picQRCode5);
            this.tabPageUCT.Location = new System.Drawing.Point(4, 22);
            this.tabPageUCT.Name = "tabPageUCT";
            this.tabPageUCT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUCT.Size = new System.Drawing.Size(453, 528);
            this.tabPageUCT.TabIndex = 1;
            this.tabPageUCT.Text = "UCT";
            // 
            // picQRCode3
            // 
            this.picQRCode3.BackColor = System.Drawing.Color.Silver;
            this.picQRCode3.Location = new System.Drawing.Point(70, 163);
            this.picQRCode3.Name = "picQRCode3";
            this.picQRCode3.Size = new System.Drawing.Size(156, 148);
            this.picQRCode3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRCode3.TabIndex = 52;
            this.picQRCode3.TabStop = false;
            // 
            // picQRCode4
            // 
            this.picQRCode4.BackColor = System.Drawing.Color.Silver;
            this.picQRCode4.Location = new System.Drawing.Point(232, 163);
            this.picQRCode4.Name = "picQRCode4";
            this.picQRCode4.Size = new System.Drawing.Size(156, 148);
            this.picQRCode4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRCode4.TabIndex = 51;
            this.picQRCode4.TabStop = false;
            // 
            // picQRCode2
            // 
            this.picQRCode2.BackColor = System.Drawing.Color.Silver;
            this.picQRCode2.Location = new System.Drawing.Point(232, 9);
            this.picQRCode2.Name = "picQRCode2";
            this.picQRCode2.Size = new System.Drawing.Size(156, 148);
            this.picQRCode2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRCode2.TabIndex = 50;
            this.picQRCode2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Information for configuring the router/modem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Example: \"JAGWSGPS0020\"";
            // 
            // textInfoUCT
            // 
            this.textInfoUCT.Location = new System.Drawing.Point(10, 470);
            this.textInfoUCT.Multiline = true;
            this.textInfoUCT.Name = "textInfoUCT";
            this.textInfoUCT.Size = new System.Drawing.Size(420, 50);
            this.textInfoUCT.TabIndex = 47;
            // 
            // btnGerarQRCodeUCT
            // 
            this.btnGerarQRCodeUCT.Location = new System.Drawing.Point(311, 385);
            this.btnGerarQRCodeUCT.Name = "btnGerarQRCodeUCT";
            this.btnGerarQRCodeUCT.Size = new System.Drawing.Size(119, 65);
            this.btnGerarQRCodeUCT.TabIndex = 45;
            this.btnGerarQRCodeUCT.Text = "QRCode Viwer";
            this.btnGerarQRCodeUCT.UseVisualStyleBackColor = true;
            this.btnGerarQRCodeUCT.Click += new System.EventHandler(this.btnGerarQRCodeUCT_Click);
            // 
            // txtLarguraUCT
            // 
            this.txtLarguraUCT.Location = new System.Drawing.Point(95, 425);
            this.txtLarguraUCT.Name = "txtLarguraUCT";
            this.txtLarguraUCT.Size = new System.Drawing.Size(60, 20);
            this.txtLarguraUCT.TabIndex = 44;
            this.txtLarguraUCT.Text = "400";
            // 
            // txtAlturaUCT
            // 
            this.txtAlturaUCT.Location = new System.Drawing.Point(10, 425);
            this.txtAlturaUCT.Name = "txtAlturaUCT";
            this.txtAlturaUCT.Size = new System.Drawing.Size(66, 20);
            this.txtAlturaUCT.TabIndex = 43;
            this.txtAlturaUCT.Text = "400";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Width";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Height";
            // 
            // txtTextoUCT
            // 
            this.txtTextoUCT.Location = new System.Drawing.Point(10, 355);
            this.txtTextoUCT.Name = "txtTextoUCT";
            this.txtTextoUCT.Size = new System.Drawing.Size(231, 20);
            this.txtTextoUCT.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Enter the hostname.";
            // 
            // picQRCode1
            // 
            this.picQRCode1.BackColor = System.Drawing.Color.Silver;
            this.picQRCode1.Location = new System.Drawing.Point(70, 9);
            this.picQRCode1.Name = "picQRCode1";
            this.picQRCode1.Size = new System.Drawing.Size(156, 148);
            this.picQRCode1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRCode1.TabIndex = 38;
            this.picQRCode1.TabStop = false;
            // 
            // picQRCode5
            // 
            this.picQRCode5.Location = new System.Drawing.Point(145, 85);
            this.picQRCode5.Name = "picQRCode5";
            this.picQRCode5.Size = new System.Drawing.Size(68, 59);
            this.picQRCode5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRCode5.TabIndex = 53;
            this.picQRCode5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 594);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.labelDeveloper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "QRCode Gen v1.1";
            this.tabControl.ResumeLayout(false);
            this.tabPageDepth.ResumeLayout(false);
            this.tabPageDepth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeLeft)).EndInit();
            this.tabPageUCT.ResumeLayout(false);
            this.tabPageUCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDepth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.PictureBox picQRCodeRight;
        private System.Windows.Forms.Button btnGerarQRCode;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picQRCodeLeft;
        private System.Windows.Forms.TabPage tabPageUCT;
        private System.Windows.Forms.PictureBox picQRCode3;
        private System.Windows.Forms.PictureBox picQRCode4;
        private System.Windows.Forms.PictureBox picQRCode2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textInfoUCT;
        private System.Windows.Forms.Button btnGerarQRCodeUCT;
        private System.Windows.Forms.TextBox txtLarguraUCT;
        private System.Windows.Forms.TextBox txtAlturaUCT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTextoUCT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picQRCode1;
        private System.Windows.Forms.PictureBox picQRCode5;
    }
}

