namespace snakeBuild1
{
    partial class GameWindow
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
            this.gridPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPB)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPB
            // 
            this.gridPB.Location = new System.Drawing.Point(22, 12);
            this.gridPB.Name = "gridPB";
            this.gridPB.Size = new System.Drawing.Size(463, 336);
            this.gridPB.TabIndex = 0;
            this.gridPB.TabStop = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 360);
            this.Controls.Add(this.gridPB);
            this.Name = "GameWindow";
            this.Text = "Snake Game";
            ((System.ComponentModel.ISupportInitialize)(this.gridPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gridPB;
    }
}

