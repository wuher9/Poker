namespace PokerGame
{
    partial class PlayerNameEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerNameEntry));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(390, 630);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 20);
            this.textBox1.TabIndex = 0;
            // 
            // enterButton
            // 
            this.enterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enterButton.BackgroundImage")));
            this.enterButton.Location = new System.Drawing.Point(320, 684);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(107, 35);
            this.enterButton.TabIndex = 1;
            this.enterButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.Location = new System.Drawing.Point(629, 684);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(107, 35);
            this.backButton.TabIndex = 2;
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // PlayerNameEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1047, 761);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.textBox1);
            this.Name = "PlayerNameEntry";
            this.Text = "PlayerNameEntry";
            this.Load += new System.EventHandler(this.PlayerNameEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button backButton;
    }
}