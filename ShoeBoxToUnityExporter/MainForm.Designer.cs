namespace ShoeBoxToUnityExporter
{
    partial class MainForm
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.spritesTab = new System.Windows.Forms.TabPage();
            this.fontPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fontPicture = new System.Windows.Forms.PictureBox();
            this.dropFontLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabs.SuspendLayout();
            this.fontPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.spritesTab);
            this.tabs.Controls.Add(this.fontPage);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(665, 486);
            this.tabs.TabIndex = 0;
            // 
            // spritesTab
            // 
            this.spritesTab.Location = new System.Drawing.Point(4, 22);
            this.spritesTab.Name = "spritesTab";
            this.spritesTab.Padding = new System.Windows.Forms.Padding(3);
            this.spritesTab.Size = new System.Drawing.Size(708, 446);
            this.spritesTab.TabIndex = 0;
            this.spritesTab.Text = "Sprites";
            this.spritesTab.UseVisualStyleBackColor = true;
            // 
            // fontPage
            // 
            this.fontPage.Controls.Add(this.toolStrip1);
            this.fontPage.Controls.Add(this.splitContainer1);
            this.fontPage.Location = new System.Drawing.Point(4, 22);
            this.fontPage.Name = "fontPage";
            this.fontPage.Padding = new System.Windows.Forms.Padding(3);
            this.fontPage.Size = new System.Drawing.Size(657, 460);
            this.fontPage.TabIndex = 1;
            this.fontPage.Text = "Font";
            this.fontPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dropFontLabel);
            this.splitContainer1.Panel1.Controls.Add(this.fontPicture);
            this.splitContainer1.Size = new System.Drawing.Size(655, 428);
            this.splitContainer1.SplitterDistance = 467;
            this.splitContainer1.TabIndex = 0;
            // 
            // fontPicture
            // 
            this.fontPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontPicture.Location = new System.Drawing.Point(0, 0);
            this.fontPicture.Name = "fontPicture";
            this.fontPicture.Size = new System.Drawing.Size(465, 426);
            this.fontPicture.TabIndex = 0;
            this.fontPicture.TabStop = false;
            this.fontPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.fontPicture_Paint);
            // 
            // dropFontLabel
            // 
            this.dropFontLabel.AllowDrop = true;
            this.dropFontLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropFontLabel.Location = new System.Drawing.Point(0, 0);
            this.dropFontLabel.Name = "dropFontLabel";
            this.dropFontLabel.Size = new System.Drawing.Size(465, 426);
            this.dropFontLabel.TabIndex = 1;
            this.dropFontLabel.Text = "Drop font picture and txt here";
            this.dropFontLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dropFontLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropFontLabel_DragDrop);
            this.dropFontLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropFontLabel_DragEnter);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(651, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 486);
            this.Controls.Add(this.tabs);
            this.Name = "MainForm";
            this.Text = "ShoeBox to Unity3D Exporter";
            this.tabs.ResumeLayout(false);
            this.fontPage.ResumeLayout(false);
            this.fontPage.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fontPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage spritesTab;
        private System.Windows.Forms.TabPage fontPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox fontPicture;
        private System.Windows.Forms.Label dropFontLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

