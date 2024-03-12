namespace baikiemtrathu3
{
    partial class Form1
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
            MatKhau = new Label();
            txtMatKhau = new TextBox();
            SuspendLayout();
            // 
            // MatKhau
            // 
            MatKhau.AutoSize = true;
            MatKhau.Location = new Point(141, 125);
            MatKhau.Name = "MatKhau";
            MatKhau.Size = new Size(68, 20);
            MatKhau.TabIndex = 0;
            MatKhau.Text = "MatKhau";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(271, 130);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(125, 27);
            txtMatKhau.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMatKhau);
            Controls.Add(MatKhau);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MatKhau;
        private TextBox txtMatKhau;
    }
}
