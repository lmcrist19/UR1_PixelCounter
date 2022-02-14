namespace PixelCounter
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
            this.rawView = new System.Windows.Forms.PictureBox();
            this.thresholdView = new System.Windows.Forms.PictureBox();
            this.thresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.slice1Label = new System.Windows.Forms.Label();
            this.slice2Label = new System.Windows.Forms.Label();
            this.slice3Label = new System.Windows.Forms.Label();
            this.slice4Label = new System.Windows.Forms.Label();
            this.slice5Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rawView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // rawView
            // 
            this.rawView.Location = new System.Drawing.Point(12, 12);
            this.rawView.Name = "rawView";
            this.rawView.Size = new System.Drawing.Size(351, 247);
            this.rawView.TabIndex = 0;
            this.rawView.TabStop = false;
            // 
            // thresholdView
            // 
            this.thresholdView.Location = new System.Drawing.Point(437, 12);
            this.thresholdView.Name = "thresholdView";
            this.thresholdView.Size = new System.Drawing.Size(351, 247);
            this.thresholdView.TabIndex = 1;
            this.thresholdView.TabStop = false;
            // 
            // thresholdTrackBar
            // 
            this.thresholdTrackBar.Location = new System.Drawing.Point(245, 341);
            this.thresholdTrackBar.Maximum = 255;
            this.thresholdTrackBar.Name = "thresholdTrackBar";
            this.thresholdTrackBar.Size = new System.Drawing.Size(533, 56);
            this.thresholdTrackBar.TabIndex = 2;
            this.thresholdTrackBar.TickFrequency = 10;
            this.thresholdTrackBar.Scroll += new System.EventHandler(this.thresholdTrackBar_Scroll_1);
            // 
            // slice1Label
            // 
            this.slice1Label.AutoSize = true;
            this.slice1Label.Location = new System.Drawing.Point(30, 309);
            this.slice1Label.Name = "slice1Label";
            this.slice1Label.Size = new System.Drawing.Size(50, 17);
            this.slice1Label.TabIndex = 3;
            this.slice1Label.Text = "Slice 1";
            // 
            // slice2Label
            // 
            this.slice2Label.AutoSize = true;
            this.slice2Label.Location = new System.Drawing.Point(30, 326);
            this.slice2Label.Name = "slice2Label";
            this.slice2Label.Size = new System.Drawing.Size(50, 17);
            this.slice2Label.TabIndex = 4;
            this.slice2Label.Text = "Slice 2";
            // 
            // slice3Label
            // 
            this.slice3Label.AutoSize = true;
            this.slice3Label.Location = new System.Drawing.Point(30, 343);
            this.slice3Label.Name = "slice3Label";
            this.slice3Label.Size = new System.Drawing.Size(50, 17);
            this.slice3Label.TabIndex = 5;
            this.slice3Label.Text = "Slice 3";
            // 
            // slice4Label
            // 
            this.slice4Label.AutoSize = true;
            this.slice4Label.Location = new System.Drawing.Point(30, 360);
            this.slice4Label.Name = "slice4Label";
            this.slice4Label.Size = new System.Drawing.Size(50, 17);
            this.slice4Label.TabIndex = 6;
            this.slice4Label.Text = "Slice 4";
            // 
            // slice5Label
            // 
            this.slice5Label.AutoSize = true;
            this.slice5Label.Location = new System.Drawing.Point(30, 377);
            this.slice5Label.Name = "slice5Label";
            this.slice5Label.Size = new System.Drawing.Size(50, 17);
            this.slice5Label.TabIndex = 7;
            this.slice5Label.Text = "Slice 5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.slice5Label);
            this.Controls.Add(this.slice4Label);
            this.Controls.Add(this.slice3Label);
            this.Controls.Add(this.slice2Label);
            this.Controls.Add(this.slice1Label);
            this.Controls.Add(this.thresholdTrackBar);
            this.Controls.Add(this.thresholdView);
            this.Controls.Add(this.rawView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rawView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rawView;
        private System.Windows.Forms.PictureBox thresholdView;
        private System.Windows.Forms.TrackBar thresholdTrackBar;
        private System.Windows.Forms.Label slice1Label;
        private System.Windows.Forms.Label slice2Label;
        private System.Windows.Forms.Label slice3Label;
        private System.Windows.Forms.Label slice4Label;
        private System.Windows.Forms.Label slice5Label;
    }
}

