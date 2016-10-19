namespace ObjectTracker
{
    partial class ObjectTracking
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
            this.components = new System.ComponentModel.Container();
            this.captureImageBox = new Emgu.CV.UI.ImageBox();
            this.btnPauseOrResume = new System.Windows.Forms.Button();
            this.txtXYRadius = new System.Windows.Forms.TextBox();
            this.processedImageBox = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // captureImageBox
            // 
            this.captureImageBox.Location = new System.Drawing.Point(8, 15);
            this.captureImageBox.Name = "captureImageBox";
            this.captureImageBox.Size = new System.Drawing.Size(640, 480);
            this.captureImageBox.TabIndex = 2;
            this.captureImageBox.TabStop = false;
            // 
            // btnPauseOrResume
            // 
            this.btnPauseOrResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPauseOrResume.Location = new System.Drawing.Point(80, 544);
            this.btnPauseOrResume.Name = "btnPauseOrResume";
            this.btnPauseOrResume.Size = new System.Drawing.Size(191, 66);
            this.btnPauseOrResume.TabIndex = 3;
            this.btnPauseOrResume.Text = "Pause";
            this.btnPauseOrResume.UseVisualStyleBackColor = true;
            this.btnPauseOrResume.Click += new System.EventHandler(this.btnPauseOrResume_Click);
            // 
            // txtXYRadius
            // 
            this.txtXYRadius.BackColor = System.Drawing.SystemColors.Window;
            this.txtXYRadius.Location = new System.Drawing.Point(654, 501);
            this.txtXYRadius.Multiline = true;
            this.txtXYRadius.Name = "txtXYRadius";
            this.txtXYRadius.ReadOnly = true;
            this.txtXYRadius.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXYRadius.Size = new System.Drawing.Size(640, 118);
            this.txtXYRadius.TabIndex = 4;
            // 
            // processedImageBox
            // 
            this.processedImageBox.Location = new System.Drawing.Point(655, 16);
            this.processedImageBox.Name = "processedImageBox";
            this.processedImageBox.Size = new System.Drawing.Size(640, 480);
            this.processedImageBox.TabIndex = 5;
            this.processedImageBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 803);
            this.Controls.Add(this.txtXYRadius);
            this.Controls.Add(this.processedImageBox);
            this.Controls.Add(this.btnPauseOrResume);
            this.Controls.Add(this.captureImageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox captureImageBox;
        private System.Windows.Forms.Button btnPauseOrResume;
        private System.Windows.Forms.TextBox txtXYRadius;
        private Emgu.CV.UI.ImageBox processedImageBox;
    }
}

