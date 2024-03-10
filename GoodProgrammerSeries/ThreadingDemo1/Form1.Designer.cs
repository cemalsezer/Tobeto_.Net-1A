namespace ThreadingDemo1
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
            btnProccess1 = new Button();
            btnProccess2 = new Button();
            SuspendLayout();
            // 
            // btnProccess1
            // 
            btnProccess1.Location = new Point(172, 90);
            btnProccess1.Name = "btnProccess1";
            btnProccess1.Size = new Size(125, 90);
            btnProccess1.TabIndex = 0;
            btnProccess1.Text = "İşlem 1";
            btnProccess1.UseVisualStyleBackColor = true;
            btnProccess1.Click += button1_Click;
            // 
            // btnProccess2
            // 
            btnProccess2.Location = new Point(444, 90);
            btnProccess2.Name = "btnProccess2";
            btnProccess2.Size = new Size(125, 90);
            btnProccess2.TabIndex = 1;
            btnProccess2.Text = "İşlem 2";
            btnProccess2.UseVisualStyleBackColor = true;
            btnProccess2.Click += btnProccess2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProccess2);
            Controls.Add(btnProccess1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnProccess1;
        private Button btnProccess2;
    }
}