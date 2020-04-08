namespace WokeUpInAUnfamiliarRoom
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
            this.blueButton = new System.Windows.Forms.PictureBox();
            this.redButton = new System.Windows.Forms.PictureBox();
            this.yellowButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.blueButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowButton)).BeginInit();
            this.SuspendLayout();
            // 
            // blueButton
            // 
            this.blueButton.Image = ((System.Drawing.Image)(resources.GetObject("blueButton.Image")));
            this.blueButton.Location = new System.Drawing.Point(12, 405);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(100, 55);
            this.blueButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueButton.TabIndex = 0;
            this.blueButton.TabStop = false;
            // 
            // redButton
            // 
            this.redButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("redButton.ErrorImage")));
            this.redButton.Image = ((System.Drawing.Image)(resources.GetObject("redButton.Image")));
            this.redButton.InitialImage = null;
            this.redButton.Location = new System.Drawing.Point(12, 466);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(100, 55);
            this.redButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redButton.TabIndex = 1;
            this.redButton.TabStop = false;
            // 
            // yellowButton
            // 
            this.yellowButton.Image = ((System.Drawing.Image)(resources.GetObject("yellowButton.Image")));
            this.yellowButton.Location = new System.Drawing.Point(12, 344);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(100, 55);
            this.yellowButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellowButton.TabIndex = 2;
            this.yellowButton.TabStop = false;
            this.yellowButton.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(51, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "M";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(53, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "B";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.xLabel.Location = new System.Drawing.Point(53, 361);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(20, 20);
            this.xLabel.TabIndex = 5;
            this.xLabel.Text = "X";
            this.xLabel.Visible = false;
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(118, 482);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(51, 20);
            this.redLabel.TabIndex = 7;
            this.redLabel.Text = "label4";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(118, 420);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(51, 20);
            this.blueLabel.TabIndex = 8;
            this.blueLabel.Text = "label5";
            // 
            // yellowLabel
            // 
            this.yellowLabel.AutoSize = true;
            this.yellowLabel.Location = new System.Drawing.Point(118, 361);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(51, 20);
            this.yellowLabel.TabIndex = 9;
            this.yellowLabel.Text = "label6";
            this.yellowLabel.Visible = false;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.MinimumSize = new System.Drawing.Size(590, 120);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(590, 120);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "You Woke Up In An Unfamiliar Room!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 533);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.blueButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Adventure Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.blueButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox blueButton;
        private System.Windows.Forms.PictureBox redButton;
        private System.Windows.Forms.PictureBox yellowButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label outputLabel;
    }
}

