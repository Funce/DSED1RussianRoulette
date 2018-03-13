namespace Assessment1RussianRoulette
{
    partial class MainScreen
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
            this.btnPull = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.lbxLog = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPull
            // 
            this.btnPull.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPull.Location = new System.Drawing.Point(165, 207);
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(70, 41);
            this.btnPull.TabIndex = 0;
            this.btnPull.Text = "Pull";
            this.btnPull.UseVisualStyleBackColor = true;
            // 
            // btnPass
            // 
            this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.Location = new System.Drawing.Point(241, 207);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(70, 41);
            this.btnPass.TabIndex = 1;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = true;
            // 
            // lbxLog
            // 
            this.lbxLog.FormattingEnabled = true;
            this.lbxLog.Location = new System.Drawing.Point(11, 10);
            this.lbxLog.Name = "lbxLog";
            this.lbxLog.Size = new System.Drawing.Size(127, 238);
            this.lbxLog.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(241, 254);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Losses:";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(246, 142);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(13, 13);
            this.lblWins.TabIndex = 6;
            this.lblWins.Text = "0";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Location = new System.Drawing.Point(246, 159);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(13, 13);
            this.lblLosses.TabIndex = 7;
            this.lblLosses.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Credits:";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(281, 10);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(25, 13);
            this.lblCredits.TabIndex = 9;
            this.lblCredits.Text = "200";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbxLog);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnPull);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(321, 288);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPull;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.ListBox lbxLog;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCredits;
    }
}
