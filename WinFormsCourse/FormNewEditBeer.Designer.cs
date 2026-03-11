namespace WinFormsCourse
{
    partial class FormNewEditBeer
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
            label2 = new Label();
            label3 = new Label();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            txtAlcohol = new TextBox();
            cboMarca = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 43);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 91);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 139);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Alcohol:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(105, 193);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 43);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(155, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(154, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtAlcohol
            // 
            txtAlcohol.Location = new Point(155, 136);
            txtAlcohol.Name = "txtAlcohol";
            txtAlcohol.Size = new Size(154, 27);
            txtAlcohol.TabIndex = 5;
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(155, 93);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(151, 28);
            cboMarca.TabIndex = 6;
            // 
            // FormNewEditBeer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 264);
            Controls.Add(cboMarca);
            Controls.Add(txtAlcohol);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNewEditBeer";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva cerveza";
            Load += FormNewEditBeer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGuardar;
        private TextBox txtNombre;
        private TextBox txtAlcohol;
        private ComboBox cboMarca;
    }
}