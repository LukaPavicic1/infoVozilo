namespace infoVozilo
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
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnObrada = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblGod = new System.Windows.Forms.Label();
            this.lblKotač = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGod = new System.Windows.Forms.TextBox();
            this.txtKotač = new System.Windows.Forms.TextBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(226, 13);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(147, 124);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            // 
            // btnObrada
            // 
            this.btnObrada.Location = new System.Drawing.Point(418, 13);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(147, 124);
            this.btnObrada.TabIndex = 1;
            this.btnObrada.Text = "Obrada";
            this.btnObrada.UseVisualStyleBackColor = true;
     
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(603, 13);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(147, 124);
            this.btnIspis.TabIndex = 2;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(9, 9);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 8;
            this.lblModel.Text = "Model:";
            // 
            // lblGod
            // 
            this.lblGod.AutoSize = true;
            this.lblGod.Location = new System.Drawing.Point(9, 55);
            this.lblGod.Name = "lblGod";
            this.lblGod.Size = new System.Drawing.Size(62, 13);
            this.lblGod.TabIndex = 9;
            this.lblGod.Text = "God.Proizv.";
            // 
            // lblKotač
            // 
            this.lblKotač.AutoSize = true;
            this.lblKotač.Location = new System.Drawing.Point(9, 101);
            this.lblKotač.Name = "lblKotač";
            this.lblKotač.Size = new System.Drawing.Size(64, 13);
            this.lblKotač.TabIndex = 10;
            this.lblKotač.Text = "Broj kotača:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(13, 26);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(181, 20);
            this.txtModel.TabIndex = 11;
            // 
            // txtGod
            // 
            this.txtGod.Location = new System.Drawing.Point(13, 71);
            this.txtGod.Name = "txtGod";
            this.txtGod.Size = new System.Drawing.Size(181, 20);
            this.txtGod.TabIndex = 12;
            // 
            // txtKotač
            // 
            this.txtKotač.Location = new System.Drawing.Point(12, 117);
            this.txtKotač.Name = "txtKotač";
            this.txtKotač.Size = new System.Drawing.Size(181, 20);
            this.txtKotač.TabIndex = 13;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(12, 157);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(738, 281);
            this.txtIspis.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.txtKotač);
            this.Controls.Add(this.txtGod);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblKotač);
            this.Controls.Add(this.lblGod);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnObrada);
            this.Controls.Add(this.btnUnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnObrada;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblGod;
        private System.Windows.Forms.Label lblKotač;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGod;
        private System.Windows.Forms.TextBox txtKotač;
        private System.Windows.Forms.TextBox txtIspis;
    }
}

