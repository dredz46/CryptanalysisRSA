namespace CryptanalysisRSAProject
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
            this.TxtPrim1 = new System.Windows.Forms.TextBox();
            this.TxtPrim2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGenKey = new System.Windows.Forms.Button();
            this.TxtPublicKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrivateKey = new System.Windows.Forms.TextBox();
            this.TxtModulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtPrim1
            // 
            this.TxtPrim1.Location = new System.Drawing.Point(79, 12);
            this.TxtPrim1.Name = "TxtPrim1";
            this.TxtPrim1.Size = new System.Drawing.Size(270, 22);
            this.TxtPrim1.TabIndex = 0;
            // 
            // TxtPrim2
            // 
            this.TxtPrim2.Location = new System.Drawing.Point(79, 40);
            this.TxtPrim2.Name = "TxtPrim2";
            this.TxtPrim2.Size = new System.Drawing.Size(270, 22);
            this.TxtPrim2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prim 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prim 2:";
            // 
            // BtnGenKey
            // 
            this.BtnGenKey.Location = new System.Drawing.Point(12, 68);
            this.BtnGenKey.Name = "BtnGenKey";
            this.BtnGenKey.Size = new System.Drawing.Size(336, 26);
            this.BtnGenKey.TabIndex = 4;
            this.BtnGenKey.Text = "Generate Public/Private key";
            this.BtnGenKey.UseVisualStyleBackColor = true;
            // 
            // TxtPublicKey
            // 
            this.TxtPublicKey.Location = new System.Drawing.Point(107, 101);
            this.TxtPublicKey.Name = "TxtPublicKey";
            this.TxtPublicKey.Size = new System.Drawing.Size(241, 22);
            this.TxtPublicKey.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Public Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Private Key";
            // 
            // TxtPrivateKey
            // 
            this.TxtPrivateKey.Location = new System.Drawing.Point(108, 129);
            this.TxtPrivateKey.Name = "TxtPrivateKey";
            this.TxtPrivateKey.Size = new System.Drawing.Size(241, 22);
            this.TxtPrivateKey.TabIndex = 8;
            // 
            // TxtModulo
            // 
            this.TxtModulo.Location = new System.Drawing.Point(107, 157);
            this.TxtModulo.Name = "TxtModulo";
            this.TxtModulo.Size = new System.Drawing.Size(241, 22);
            this.TxtModulo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Modulo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 190);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtModulo);
            this.Controls.Add(this.TxtPrivateKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPublicKey);
            this.Controls.Add(this.BtnGenKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPrim2);
            this.Controls.Add(this.TxtPrim1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPrim1;
        private System.Windows.Forms.TextBox TxtPrim2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGenKey;
        private System.Windows.Forms.TextBox TxtPublicKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrivateKey;
        private System.Windows.Forms.TextBox TxtModulo;
        private System.Windows.Forms.Label label5;
    }
}

