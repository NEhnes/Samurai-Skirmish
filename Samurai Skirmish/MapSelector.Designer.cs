namespace Samurai_Skirmish
{
    partial class MapSelector
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
            this.map2PictureBox = new System.Windows.Forms.PictureBox();
            this.map1PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.map2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // map2PictureBox
            // 
            this.map2PictureBox.Location = new System.Drawing.Point(687, 195);
            this.map2PictureBox.Name = "map2PictureBox";
            this.map2PictureBox.Size = new System.Drawing.Size(228, 211);
            this.map2PictureBox.TabIndex = 16;
            this.map2PictureBox.TabStop = false;
            // 
            // map1PictureBox
            // 
            this.map1PictureBox.Location = new System.Drawing.Point(46, 195);
            this.map1PictureBox.Name = "map1PictureBox";
            this.map1PictureBox.Size = new System.Drawing.Size(228, 211);
            this.map1PictureBox.TabIndex = 15;
            this.map1PictureBox.TabStop = false;
            // 
            // MapSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.map2PictureBox);
            this.Controls.Add(this.map1PictureBox);
            this.Name = "MapSelector";
            this.Size = new System.Drawing.Size(960, 600);
            ((System.ComponentModel.ISupportInitialize)(this.map2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map1PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox map2PictureBox;
        private System.Windows.Forms.PictureBox map1PictureBox;
    }
}
