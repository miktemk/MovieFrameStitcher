namespace MovieFrameStitcher.GUI
{
    partial class FileDragPanel
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
            this.lblFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(42, 48);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(300, 32);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "Please drag file here...";
            // 
            // FileDragPanel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lblFile);
            this.Name = "FileDragPanel";
            this.Size = new System.Drawing.Size(694, 126);
            this.Load += new System.EventHandler(this.FileDragPanel_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileDragPanel_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileDragPanel_DragEnter);
            this.DragLeave += new System.EventHandler(this.FileDragPanel_DragLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFile;
    }
}
