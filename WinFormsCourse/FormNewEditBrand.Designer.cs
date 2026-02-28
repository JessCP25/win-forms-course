namespace WinFormsCourse
{
    partial class FormNewEditBrand
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
            txtBrand = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 32);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre de marca";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(197, 29);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(195, 27);
            txtBrand.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(140, 90);
            button1.Name = "button1";
            button1.Size = new Size(158, 37);
            button1.TabIndex = 2;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormNewEditBrand
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 153);
            Controls.Add(button1);
            Controls.Add(txtBrand);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormNewEditBrand";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Marca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBrand;
        private Button button1;
    }
}