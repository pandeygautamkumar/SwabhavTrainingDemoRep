namespace AsyncAwaitWinFormApp
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
            btnHello = new Button();
            btnTask1 = new Button();
            btnPrintAsync1 = new Button();
            btnPrintAsync2 = new Button();
            btnPrintSync = new Button();
            SuspendLayout();
            // 
            // btnHello
            // 
            btnHello.BackColor = SystemColors.ControlDarkDark;
            btnHello.Location = new Point(41, 113);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(97, 44);
            btnHello.TabIndex = 0;
            btnHello.Text = "Hello";
            btnHello.UseVisualStyleBackColor = false;
            btnHello.Click += btnHelloCode_Click;
            // 
            // btnTask1
            // 
            btnTask1.BackColor = SystemColors.ControlDarkDark;
            btnTask1.Location = new Point(463, 113);
            btnTask1.Name = "btnTask1";
            btnTask1.Size = new Size(97, 44);
            btnTask1.TabIndex = 1;
            btnTask1.Text = "Task1";
            btnTask1.UseVisualStyleBackColor = false;
            btnTask1.Click += btnTask1_Click;
            // 
            // btnPrintAsync1
            // 
            btnPrintAsync1.BackColor = SystemColors.ControlDarkDark;
            btnPrintAsync1.Location = new Point(41, 245);
            btnPrintAsync1.Name = "btnPrintAsync1";
            btnPrintAsync1.Size = new Size(97, 44);
            btnPrintAsync1.TabIndex = 2;
            btnPrintAsync1.Text = "PrintAsync1";
            btnPrintAsync1.UseVisualStyleBackColor = false;
            btnPrintAsync1.Click += btnPrintAsync1_Click;
            // 
            // btnPrintAsync2
            // 
            btnPrintAsync2.BackColor = SystemColors.ControlDarkDark;
            btnPrintAsync2.Location = new Point(278, 245);
            btnPrintAsync2.Name = "btnPrintAsync2";
            btnPrintAsync2.Size = new Size(97, 44);
            btnPrintAsync2.TabIndex = 3;
            btnPrintAsync2.Text = "PrintAsync2";
            btnPrintAsync2.UseVisualStyleBackColor = false;
            btnPrintAsync2.Click += btnPrintAsync2_Click;
            // 
            // btnPrintSync
            // 
            btnPrintSync.BackColor = SystemColors.ControlDarkDark;
            btnPrintSync.Location = new Point(244, 113);
            btnPrintSync.Name = "btnPrintSync";
            btnPrintSync.Size = new Size(97, 44);
            btnPrintSync.TabIndex = 4;
            btnPrintSync.Text = "PrintSync";
            btnPrintSync.UseVisualStyleBackColor = false;
            btnPrintSync.Click += btnPrintSync_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrintSync);
            Controls.Add(btnPrintAsync2);
            Controls.Add(btnPrintAsync1);
            Controls.Add(btnTask1);
            Controls.Add(btnHello);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHello;
        private Button btnTask1;
        private Button btnPrintAsync1;
        private Button btnPrintAsync2;
        private Button btnPrintSync;
    }
}