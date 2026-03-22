namespace WinFormsCourse
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            configuraciToolStripMenuItem = new ToolStripMenuItem();
            marcasToolStripMenuItem = new ToolStripMenuItem();
            cervezasToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            btnVenta = new Button();
            dgv = new DataGridView();
            menuStrip2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { configuraciToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // configuraciToolStripMenuItem
            // 
            configuraciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { marcasToolStripMenuItem, cervezasToolStripMenuItem });
            configuraciToolStripMenuItem.Name = "configuraciToolStripMenuItem";
            configuraciToolStripMenuItem.Size = new Size(116, 24);
            configuraciToolStripMenuItem.Text = "Configuración";
            // 
            // marcasToolStripMenuItem
            // 
            marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            marcasToolStripMenuItem.Size = new Size(150, 26);
            marcasToolStripMenuItem.Text = "Marcas";
            marcasToolStripMenuItem.Click += marcasToolStripMenuItem_Click;
            // 
            // cervezasToolStripMenuItem
            // 
            cervezasToolStripMenuItem.Name = "cervezasToolStripMenuItem";
            cervezasToolStripMenuItem.Size = new Size(150, 26);
            cervezasToolStripMenuItem.Text = "Cervezas";
            cervezasToolStripMenuItem.Click += cervezasToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVenta);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 89);
            panel1.TabIndex = 2;
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(37, 24);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(164, 42);
            btnVenta.TabIndex = 0;
            btnVenta.Text = "Nueva venta";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Dock = DockStyle.Fill;
            dgv.Location = new Point(0, 141);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(800, 309);
            dgv.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem configuraciToolStripMenuItem;
        private ToolStripMenuItem marcasToolStripMenuItem;
        private ToolStripMenuItem cervezasToolStripMenuItem;
        private Panel panel1;
        private Button btnVenta;
        private DataGridView dgv;
    }
}
