
namespace target_app_for_ocr_test
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mydg = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydg)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::target_app_for_ocr_test.Properties.Resources.pic_time_utc;
            this.pictureBox2.Location = new System.Drawing.Point(29, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(328, 242);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // mydg
            // 
            this.mydg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mydg.Location = new System.Drawing.Point(393, 293);
            this.mydg.Name = "mydg";
            this.mydg.Size = new System.Drawing.Size(558, 242);
            this.mydg.TabIndex = 4;
            this.mydg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mydg_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(29, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 236);
            this.panel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panel1ToolStripMenuItem,
            this.panel2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1ToolStripMenuItem
            // 
            this.panel1ToolStripMenuItem.Name = "panel1ToolStripMenuItem";
            this.panel1ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.panel1ToolStripMenuItem.Text = "panel 1";
            this.panel1ToolStripMenuItem.Click += new System.EventHandler(this.panel1ToolStripMenuItem_Click);
            // 
            // panel2ToolStripMenuItem
            // 
            this.panel2ToolStripMenuItem.Name = "panel2ToolStripMenuItem";
            this.panel2ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.panel2ToolStripMenuItem.Text = "panel 2";
            this.panel2ToolStripMenuItem.Click += new System.EventHandler(this.panel2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mydg);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydg)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView mydg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem panel1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panel2ToolStripMenuItem;
    }
}

