namespace PokerGame
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
            this.startButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startButton.BackgroundImage")));
            this.startButton.Location = new System.Drawing.Point(221, 673);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(107, 35);
            this.startButton.TabIndex = 0;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadButton.BackgroundImage")));
            this.loadButton.Location = new System.Drawing.Point(707, 673);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(107, 35);
            this.loadButton.TabIndex = 1;
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.BackgroundImageChanged += new System.EventHandler(this.loadButton_Click);
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1047, 761);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "TitleScreen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button loadButton;
    }
}

