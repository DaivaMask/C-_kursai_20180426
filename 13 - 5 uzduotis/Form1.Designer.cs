namespace _13___5_uzduotis
{
    partial class Biblioteka
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.knygosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atidarytiFailaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baigtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ivestinaujaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knygosToolStripMenuItem,
            this.ivestinaujaToolStripMenuItem,
            this.baigtiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // knygosToolStripMenuItem
            // 
            this.knygosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atidarytiFailaToolStripMenuItem});
            this.knygosToolStripMenuItem.Name = "knygosToolStripMenuItem";
            this.knygosToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.knygosToolStripMenuItem.Text = "Knygos";
            // 
            // atidarytiFailaToolStripMenuItem
            // 
            this.atidarytiFailaToolStripMenuItem.Name = "atidarytiFailaToolStripMenuItem";
            this.atidarytiFailaToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.atidarytiFailaToolStripMenuItem.Text = "Atidaryti";
            this.atidarytiFailaToolStripMenuItem.Click += new System.EventHandler(this.atidarytiFailaToolStripMenuItem_Click);
            // 
            // baigtiToolStripMenuItem
            // 
            this.baigtiToolStripMenuItem.Name = "baigtiToolStripMenuItem";
            this.baigtiToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.baigtiToolStripMenuItem.Text = "Baigti";
            this.baigtiToolStripMenuItem.Click += new System.EventHandler(this.baigtiToolStripMenuItem_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView3.Location = new System.Drawing.Point(0, 28);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(578, 423);
            this.dataGridView3.TabIndex = 1;
            // 
            // ivestinaujaToolStripMenuItem
            // 
            this.ivestinaujaToolStripMenuItem.Name = "ivestinaujaToolStripMenuItem";
            this.ivestinaujaToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.ivestinaujaToolStripMenuItem.Text = "Ivesti_nauja";
            this.ivestinaujaToolStripMenuItem.Click += new System.EventHandler(this.ivestinaujaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lentynos suma";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Biblioteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Biblioteka";
            this.Text = "Knygu lentyna";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem knygosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atidarytiFailaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baigtiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStripMenuItem ivestinaujaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

