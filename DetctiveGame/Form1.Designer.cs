namespace DetctiveGame
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
            this.blueLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.outputLable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // blueLabel
            // 
            this.blueLabel.BackColor = System.Drawing.Color.Black;
            this.blueLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.blueLabel.Location = new System.Drawing.Point(31, 659);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(2256, 98);
            this.blueLabel.TabIndex = 0;
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.redLabel.Location = new System.Drawing.Point(33, 567);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(2231, 73);
            this.redLabel.TabIndex = 1;
            // 
            // yellowLabel
            // 
            this.yellowLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLabel.ForeColor = System.Drawing.Color.Gold;
            this.yellowLabel.Location = new System.Drawing.Point(12, 796);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(2199, 153);
            this.yellowLabel.TabIndex = 2;
            // 
            // outputLable
            // 
            this.outputLable.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLable.ForeColor = System.Drawing.Color.Green;
            this.outputLable.Location = new System.Drawing.Point(12, 348);
            this.outputLable.Name = "outputLable";
            this.outputLable.Size = new System.Drawing.Size(2275, 209);
            this.outputLable.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(18, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2238, 318);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(2268, 979);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outputLable);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.blueLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label outputLable;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

