namespace RSA_Encryption_and_Decryption_with_Conversion
{
    partial class MenuForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnRsa = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(112, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 42);
            this.label3.TabIndex = 13;
            this.label3.Text = "SELECT ANY OPTION";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnRsa
            // 
            this.btnRsa.BackgroundImage = global::RSA_Encryption_and_Decryption_with_Conversion.Properties.Resources.istockphoto_1447055225_612x612;
            this.btnRsa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRsa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRsa.Location = new System.Drawing.Point(99, 272);
            this.btnRsa.Name = "btnRsa";
            this.btnRsa.Size = new System.Drawing.Size(206, 148);
            this.btnRsa.TabIndex = 11;
            this.btnRsa.Text = "Encryption\r\nDecryption";
            this.btnRsa.UseVisualStyleBackColor = true;
            this.btnRsa.Click += new System.EventHandler(this.btnRsa_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::RSA_Encryption_and_Decryption_with_Conversion.Properties.Resources.istockphoto_1447055225_612x612;
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(313, 272);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(198, 148);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RSA_Encryption_and_Decryption_with_Conversion.Properties.Resources.istockphoto_1447055225_612x6121;
            this.ClientSize = new System.Drawing.Size(615, 572);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRsa);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRsa;
        private System.Windows.Forms.Button btnLogout;
    }
}