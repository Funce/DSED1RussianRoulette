namespace Assessment1RussianRoulette
{
    partial class TitleScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblCredits = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChambers = new System.Windows.Forms.TextBox();
            this.txtBullets = new System.Windows.Forms.TextBox();
            this.btnResetCredits = new System.Windows.Forms.Button();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(50, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Russian Roulette";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(120, 249);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(281, 10);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(25, 13);
            this.lblCredits.TabIndex = 11;
            this.lblCredits.Text = "200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Credits:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chambers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bullets:";
            // 
            // txtChambers
            // 
            this.txtChambers.Location = new System.Drawing.Point(172, 139);
            this.txtChambers.Name = "txtChambers";
            this.txtChambers.Size = new System.Drawing.Size(37, 20);
            this.txtChambers.TabIndex = 14;
            this.txtChambers.Text = "6";
            this.txtChambers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBullets
            // 
            this.txtBullets.Location = new System.Drawing.Point(172, 166);
            this.txtBullets.Name = "txtBullets";
            this.txtBullets.Size = new System.Drawing.Size(37, 20);
            this.txtBullets.TabIndex = 15;
            this.txtBullets.Text = "1";
            this.txtBullets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnResetCredits
            // 
            this.btnResetCredits.Location = new System.Drawing.Point(157, 5);
            this.btnResetCredits.Name = "btnResetCredits";
            this.btnResetCredits.Size = new System.Drawing.Size(79, 23);
            this.btnResetCredits.TabIndex = 16;
            this.btnResetCredits.Text = "Reset Credits";
            this.btnResetCredits.UseVisualStyleBackColor = true;
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(172, 194);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(37, 20);
            this.txtBet.TabIndex = 18;
            this.txtBet.Text = "10";
            this.txtBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bet:";
            // 
            // TitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnResetCredits);
            this.Controls.Add(this.txtBullets);
            this.Controls.Add(this.txtChambers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblTitle);
            this.Name = "TitleScreen";
            this.Size = new System.Drawing.Size(321, 288);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChambers;
        private System.Windows.Forms.TextBox txtBullets;
        private System.Windows.Forms.Button btnResetCredits;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Label label4;
    }
}
