namespace KontaktbuchVersuch1000_oder_so
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
            Btnsave = new Button();
            txtBoxName = new TextBox();
            txtBoxTel = new TextBox();
            txtBoxEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // Btnsave
            // 
            Btnsave.Location = new Point(127, 233);
            Btnsave.Name = "Btnsave";
            Btnsave.Size = new Size(134, 36);
            Btnsave.TabIndex = 0;
            Btnsave.Text = "Speichern";
            Btnsave.UseVisualStyleBackColor = true;
            Btnsave.Click += Btnsave_Click;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(76, 22);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(248, 27);
            txtBoxName.TabIndex = 1;
            // 
            // txtBoxTel
            // 
            txtBoxTel.Location = new Point(76, 94);
            txtBoxTel.Name = "txtBoxTel";
            txtBoxTel.Size = new Size(248, 27);
            txtBoxTel.TabIndex = 2;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(76, 170);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(248, 27);
            txtBoxEmail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 5;
            label2.Text = "Tel:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 177);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 6;
            label3.Text = "Email:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(351, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(332, 284);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 327);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxEmail);
            Controls.Add(txtBoxTel);
            Controls.Add(txtBoxName);
            Controls.Add(Btnsave);
            Name = "Form1";
            Text = "Kontaktbuch";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btnsave;
        private TextBox txtBoxName;
        private TextBox txtBoxTel;
        private TextBox txtBoxEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
    }
}
