namespace ViolinSuzukiLeila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStripContainer1 = new ToolStripContainer();
            toolStrip1 = new ToolStrip();
            btnCargar = new ToolStripDropDownButton();
            cargarPersonaToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(800, 425);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(800, 450);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCargar });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(98, 25);
            toolStrip1.TabIndex = 0;
            // 
            // btnCargar
            // 
            btnCargar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCargar.DropDownItems.AddRange(new ToolStripItem[] { cargarPersonaToolStripMenuItem });
            btnCargar.Image = (Image)resources.GetObject("btnCargar.Image");
            btnCargar.ImageTransparentColor = Color.Magenta;
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(55, 22);
            btnCargar.Text = "Cargar";
            // 
            // cargarPersonaToolStripMenuItem
            // 
            cargarPersonaToolStripMenuItem.Name = "cargarPersonaToolStripMenuItem";
            cargarPersonaToolStripMenuItem.Size = new Size(180, 22);
            cargarPersonaToolStripMenuItem.Text = "Cargar persona";
            cargarPersonaToolStripMenuItem.Click += cargarPersonaToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripContainer1);
            Name = "MainForm";
            Text = "MainForm";
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton btnCargar;
        private ToolStripMenuItem cargarPersonaToolStripMenuItem;
    }
}