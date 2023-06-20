namespace DepartmentDetailsWinFormApp
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
            btnDisplay = new Button();
            label1 = new Label();
            textBoxDno = new TextBox();
            textBoxDname = new TextBox();
            textBox2 = new TextBox();
            btnAdd = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = SystemColors.Highlight;
            btnDisplay.Location = new Point(481, 192);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(85, 36);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // textBoxDno
            // 
            textBoxDno.Location = new Point(382, 45);
            textBoxDno.Name = "textBoxDno";
            textBoxDno.Size = new Size(184, 23);
            textBoxDno.TabIndex = 1;
            textBoxDno.TextChanged += textBoxDno_TextChanged;
            // 
            // textBoxDname
            // 
            textBoxDname.Location = new Point(382, 91);
            textBoxDname.Name = "textBoxDname";
            textBoxDname.Size = new Size(184, 23);
            textBoxDname.TabIndex = 2;
            textBoxDname.TextChanged += textBoxDname_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(382, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HotTrack;
            btnAdd.Location = new Point(382, 193);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(84, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(319, 48);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "DeptNo : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(303, 94);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 6;
            label3.Text = "DeptName : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(311, 142);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 7;
            label4.Text = "Location  : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(textBoxDname);
            Controls.Add(textBoxDno);
            Controls.Add(label1);
            Controls.Add(btnDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDisplay;
        private Label label1;
        private TextBox textBoxDno;
        private TextBox textBoxDname;
        private TextBox textBox2;
        private Button btnAdd;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}