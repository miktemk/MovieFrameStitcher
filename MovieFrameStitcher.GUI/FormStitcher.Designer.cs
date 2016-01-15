namespace MovieFrameStitcher.GUI
{
    partial class FormStitcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStitcher));
            this.btnExtract = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.pictureWHDepArrow = new System.Windows.Forms.PictureBox();
            this.lblVideoData = new System.Windows.Forms.Label();
            this.btnDeleteOld = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileDragPanel = new MovieFrameStitcher.GUI.FileDragPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWHDepArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExtract
            // 
            this.btnExtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExtract.Location = new System.Drawing.Point(1127, 171);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(314, 102);
            this.btnExtract.TabIndex = 1;
            this.btnExtract.Text = "Extract thumbs";
            this.btnExtract.UseVisualStyleBackColor = false;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interval (s)";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(195, 194);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(244, 38);
            this.txtWidth.TabIndex = 4;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(195, 309);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(244, 38);
            this.txtInterval.TabIndex = 5;
            this.txtInterval.TextChanged += new System.EventHandler(this.txtInterval_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Height";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(195, 252);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(244, 38);
            this.txtHeight.TabIndex = 7;
            // 
            // pictureWHDepArrow
            // 
            this.pictureWHDepArrow.Image = global::MovieFrameStitcher.GUI.Properties.Resources.arrowDown1;
            this.pictureWHDepArrow.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureWHDepArrow.InitialImage")));
            this.pictureWHDepArrow.Location = new System.Drawing.Point(445, 214);
            this.pictureWHDepArrow.Name = "pictureWHDepArrow";
            this.pictureWHDepArrow.Size = new System.Drawing.Size(58, 59);
            this.pictureWHDepArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureWHDepArrow.TabIndex = 8;
            this.pictureWHDepArrow.TabStop = false;
            // 
            // lblVideoData
            // 
            this.lblVideoData.AutoSize = true;
            this.lblVideoData.Location = new System.Drawing.Point(567, 197);
            this.lblVideoData.Name = "lblVideoData";
            this.lblVideoData.Size = new System.Drawing.Size(245, 32);
            this.lblVideoData.TabIndex = 9;
            this.lblVideoData.Text = "No video loaded...";
            // 
            // btnDeleteOld
            // 
            this.btnDeleteOld.Location = new System.Drawing.Point(1127, 294);
            this.btnDeleteOld.Name = "btnDeleteOld";
            this.btnDeleteOld.Size = new System.Drawing.Size(314, 53);
            this.btnDeleteOld.TabIndex = 1;
            this.btnDeleteOld.Text = "Delete old thumbs";
            this.btnDeleteOld.UseVisualStyleBackColor = true;
            this.btnDeleteOld.Click += new System.EventHandler(this.btnDeleteOld_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(42, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1377, 10);
            this.panel1.TabIndex = 10;
            // 
            // fileDragPanel
            // 
            this.fileDragPanel.AllowDrop = true;
            this.fileDragPanel.BackColor = System.Drawing.Color.LightGray;
            this.fileDragPanel.ExtensionsAllowed = null;
            this.fileDragPanel.Location = new System.Drawing.Point(30, 29);
            this.fileDragPanel.Name = "fileDragPanel";
            this.fileDragPanel.Size = new System.Drawing.Size(1411, 126);
            this.fileDragPanel.TabIndex = 0;
            this.fileDragPanel.Load += new System.EventHandler(this.fileDragPanel_Load);
            // 
            // FormStitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 1062);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblVideoData);
            this.Controls.Add(this.pictureWHDepArrow);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteOld);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.fileDragPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStitcher";
            this.Text = "Movie Thumbnail Stitcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureWHDepArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FileDragPanel fileDragPanel;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.PictureBox pictureWHDepArrow;
        private System.Windows.Forms.Label lblVideoData;
        private System.Windows.Forms.Button btnDeleteOld;
        private System.Windows.Forms.Panel panel1;
    }
}

