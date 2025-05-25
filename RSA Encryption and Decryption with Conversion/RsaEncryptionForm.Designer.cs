namespace RSA_Encryption_and_Decryption_with_Conversion
{
    partial class RsaEncryptionForm
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
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnToBinary = new System.Windows.Forms.Button();
            this.btnToHex = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtConvertedOutput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtConversionInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCipherInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCipherText = new System.Windows.Forms.TextBox();
            this.Heading = new System.Windows.Forms.Label();
            this.lblPlainText = new System.Windows.Forms.Label();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.lblQ = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblP = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.BackgroundImage = global::RSA_Encryption_and_Decryption_with_Conversion.Properties.Resources._9AZKH1;
            this.btnGenerateKeys.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateKeys.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerateKeys.Location = new System.Drawing.Point(75, 163);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(492, 40);
            this.btnGenerateKeys.TabIndex = 64;
            this.btnGenerateKeys.Text = "Generate Keys";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackgroundImage = global::RSA_Encryption_and_Decryption_with_Conversion.Properties.Resources._9AZKH1;
            this.btnDecrypt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDecrypt.Location = new System.Drawing.Point(75, 507);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(492, 40);
            this.btnDecrypt.TabIndex = 63;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnToBinary
            // 
            this.btnToBinary.BackgroundImage = global::RSA_Encryption_and_Decryption_with_Conversion.Properties.Resources._9AZKH1;
            this.btnToBinary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToBinary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnToBinary.Location = new System.Drawing.Point(611, 222);
            this.btnToBinary.Name = "btnToBinary";
            this.btnToBinary.Size = new System.Drawing.Size(359, 147);
            this.btnToBinary.TabIndex = 62;
            this.btnToBinary.Text = "To Binary";
            this.btnToBinary.UseVisualStyleBackColor = true;
            this.btnToBinary.Click += new System.EventHandler(this.btnToBinary_Click);
            // 
            // btnToHex
            // 
            this.btnToHex.BackgroundImage = global::RSA_Encryption_and_Decryption_with_Conversion.Properties.Resources._9AZKH1;
            this.btnToHex.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToHex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnToHex.Location = new System.Drawing.Point(611, 397);
            this.btnToHex.Name = "btnToHex";
            this.btnToHex.Size = new System.Drawing.Size(359, 150);
            this.btnToHex.TabIndex = 60;
            this.btnToHex.Text = "To Hex";
            this.btnToHex.UseVisualStyleBackColor = true;
            this.btnToHex.Click += new System.EventHandler(this.btnToHex_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(616, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 23);
            this.label14.TabIndex = 59;
            this.label14.Text = "Output :";
            // 
            // txtConvertedOutput
            // 
            this.txtConvertedOutput.Location = new System.Drawing.Point(722, 134);
            this.txtConvertedOutput.Name = "txtConvertedOutput";
            this.txtConvertedOutput.Size = new System.Drawing.Size(248, 26);
            this.txtConvertedOutput.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(613, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(260, 42);
            this.label12.TabIndex = 57;
            this.label12.Text = "Conversions :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(616, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 23);
            this.label13.TabIndex = 56;
            this.label13.Text = "Input :";
            // 
            // txtConversionInput
            // 
            this.txtConversionInput.Location = new System.Drawing.Point(722, 92);
            this.txtConversionInput.Name = "txtConversionInput";
            this.txtConversionInput.Size = new System.Drawing.Size(248, 26);
            this.txtConversionInput.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(71, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 23);
            this.label9.TabIndex = 54;
            this.label9.Text = "Cihoer Text :";
            // 
            // txtCipherInput
            // 
            this.txtCipherInput.Location = new System.Drawing.Point(309, 432);
            this.txtCipherInput.Name = "txtCipherInput";
            this.txtCipherInput.Size = new System.Drawing.Size(248, 26);
            this.txtCipherInput.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(70, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 28);
            this.label10.TabIndex = 52;
            this.label10.Text = "Decryption :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(71, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 23);
            this.label8.TabIndex = 51;
            this.label8.Text = "Cipher Text Output :";
            // 
            // txtCipherText
            // 
            this.txtCipherText.Location = new System.Drawing.Point(309, 309);
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.Size = new System.Drawing.Size(248, 26);
            this.txtCipherText.TabIndex = 50;
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.BackColor = System.Drawing.Color.Transparent;
            this.Heading.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Heading.Location = new System.Drawing.Point(70, 222);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(152, 28);
            this.Heading.TabIndex = 49;
            this.Heading.Text = "Encryption :";
            // 
            // lblPlainText
            // 
            this.lblPlainText.AutoSize = true;
            this.lblPlainText.BackColor = System.Drawing.Color.Transparent;
            this.lblPlainText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlainText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlainText.Location = new System.Drawing.Point(71, 265);
            this.lblPlainText.Name = "lblPlainText";
            this.lblPlainText.Size = new System.Drawing.Size(115, 23);
            this.lblPlainText.TabIndex = 48;
            this.lblPlainText.Text = "Plain Text :";
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(269, 131);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(102, 26);
            this.txtQ.TabIndex = 46;
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.BackColor = System.Drawing.Color.Transparent;
            this.lblQ.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQ.Location = new System.Drawing.Point(71, 134);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(197, 23);
            this.lblQ.TabIndex = 45;
            this.lblQ.Text = "Prime Number (Q) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(70, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 28);
            this.label3.TabIndex = 44;
            this.label3.Text = "Key Encryption :";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackgroundImage = global::RSA_Encryption_and_Decryption_with_Conversion.Properties.Resources._9AZKH1;
            this.btnEncrypt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEncrypt.Location = new System.Drawing.Point(75, 342);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(492, 40);
            this.btnEncrypt.TabIndex = 42;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.BackColor = System.Drawing.Color.Transparent;
            this.lblP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblP.Location = new System.Drawing.Point(71, 92);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(194, 23);
            this.lblP.TabIndex = 41;
            this.lblP.Text = "Prime Number (P) :";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(309, 262);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(248, 26);
            this.txtPlainText.TabIndex = 40;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(269, 89);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(102, 26);
            this.txtP.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(71, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 66;
            this.label1.Text = "Plain Text Output :";
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(309, 472);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new System.Drawing.Size(248, 26);
            this.txtDecrypted.TabIndex = 65;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(405, 124);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(152, 26);
            this.txtN.TabIndex = 67;
            this.txtN.Text = "N (Modulus)";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(405, 92);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(152, 26);
            this.txtE.TabIndex = 68;
            this.txtE.Text = "E (Public Key)";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(405, 57);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(152, 26);
            this.txtD.TabIndex = 69;
            this.txtD.Text = "D (Private Key)";
            // 
            // RsaEncryptionForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RSA_Encryption_and_Decryption_with_Conversion.Properties.Resources._9AZKH1;
            this.ClientSize = new System.Drawing.Size(1041, 572);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.btnGenerateKeys);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnToBinary);
            this.Controls.Add(this.btnToHex);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtConvertedOutput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtConversionInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCipherInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCipherText);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.lblPlainText);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.txtP);
            this.Name = "RsaEncryptionForm";
            this.Text = "RsaEncryptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnToBinary;
        private System.Windows.Forms.Button btnToHex;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtConvertedOutput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtConversionInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCipherInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCipherText;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label lblPlainText;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.TextBox txtD;
    }
}