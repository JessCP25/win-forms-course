namespace WinFormsCourse
{
    partial class FormNewSale
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
            label1 = new Label();
            cboBeer = new ComboBox();
            label2 = new Label();
            txtQuantity = new NumericUpDown();
            btnAdd = new Button();
            dgv = new DataGridView();
            btnSale = new Button();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 30);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Cerveza:";
            // 
            // cboBeer
            // 
            cboBeer.FormattingEnabled = true;
            cboBeer.Location = new Point(113, 27);
            cboBeer.Name = "cboBeer";
            cboBeer.Size = new Size(161, 28);
            cboBeer.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 32);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Cantidad:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(409, 28);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 27);
            txtQuantity.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(603, 27);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(34, 80);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(663, 221);
            dgv.TabIndex = 5;
            // 
            // btnSale
            // 
            btnSale.Location = new Point(496, 326);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(201, 42);
            btnSale.TabIndex = 6;
            btnSale.Text = "Agregar Venta";
            btnSale.UseVisualStyleBackColor = true;
            // 
            // FormNewSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 392);
            Controls.Add(btnSale);
            Controls.Add(dgv);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(label2);
            Controls.Add(cboBeer);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNewSale";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva venta";
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboBeer;
        private Label label2;
        private NumericUpDown txtQuantity;
        private Button btnAdd;
        private DataGridView dgv;
        private Button btnSale;
    }
}