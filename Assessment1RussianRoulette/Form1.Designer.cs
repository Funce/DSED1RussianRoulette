namespace Assessment1RussianRoulette
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
            this.titleScreen1 = new Assessment1RussianRoulette.TitleScreen();
            this.mainScreen1 = new Assessment1RussianRoulette.MainScreen();
            this.SuspendLayout();
            // 
            // titleScreen1
            // 
            this.titleScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleScreen1.Location = new System.Drawing.Point(0, 0);
            this.titleScreen1.Name = "titleScreen1";
            this.titleScreen1.Size = new System.Drawing.Size(321, 288);
            this.titleScreen1.TabIndex = 0;
            // 
            // mainScreen1
            // 
            this.mainScreen1.credits = 200;
            this.mainScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainScreen1.Location = new System.Drawing.Point(0, 0);
            this.mainScreen1.losses = 0;
            this.mainScreen1.Name = "mainScreen1";
            this.mainScreen1.Size = new System.Drawing.Size(321, 288);
            this.mainScreen1.TabIndex = 1;
            this.mainScreen1.Visible = false;
            this.mainScreen1.wins = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 288);
            this.Controls.Add(this.mainScreen1);
            this.Controls.Add(this.titleScreen1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Russian Roulette";
            this.ResumeLayout(false);

        }

        #endregion

        public TitleScreen titleScreen1;
        public MainScreen mainScreen1;
    }
}

