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
            this.components = new System.ComponentModel.Container();
            this.gridPB = new System.Windows.Forms.PictureBox();
            this.menuToolStrip = new System.Windows.Forms.ToolStrip();
            this.fileToolStripButton = new System.Windows.Forms.ToolStripLabel();
            this.EditToolstripButton = new System.Windows.Forms.ToolStripLabel();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridPB)).BeginInit();
            this.menuToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPB
            // 
            this.gridPB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridPB.Location = new System.Drawing.Point(22, 12);
            this.gridPB.Name = "gridPB";
            this.gridPB.Size = new System.Drawing.Size(463, 336);
            this.gridPB.TabIndex = 0;
            this.gridPB.TabStop = false;
            this.gridPB.Paint += new System.Windows.Forms.PaintEventHandler(this.gridPB_Paint);
            // 
            // menuToolStrip
            // 
            this.menuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripButton,
            this.EditToolstripButton});
            this.menuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.menuToolStrip.Name = "menuToolStrip";
            this.menuToolStrip.Size = new System.Drawing.Size(713, 25);
            this.menuToolStrip.TabIndex = 1;
            this.menuToolStrip.Text = "toolStrip1";
            // 
            // fileToolStripButton
            // 
            this.fileToolStripButton.Name = "fileToolStripButton";
            this.fileToolStripButton.Size = new System.Drawing.Size(25, 22);
            this.fileToolStripButton.Text = "File";
            // 
            // EditToolstripButton
            // 
            this.EditToolstripButton.Name = "EditToolstripButton";
            this.EditToolstripButton.Size = new System.Drawing.Size(27, 22);
            this.EditToolstripButton.Text = "Edit";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(507, 42);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 360);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.menuToolStrip);
            this.Controls.Add(this.gridPB);
            this.Name = "GameWindow";
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridPB)).EndInit();
            this.menuToolStrip.ResumeLayout(false);
            this.menuToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox gridPB;
        private System.Windows.Forms.ToolStrip menuToolStrip;
        private System.Windows.Forms.ToolStripLabel fileToolStripButton;
        private System.Windows.Forms.ToolStripLabel EditToolstripButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

