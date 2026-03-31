namespace student
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
            showstudent = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // showstudent
            // 
            showstudent.BackColor = Color.HotPink;
            showstudent.Location = new Point(84, 43);
            showstudent.Name = "showstudent";
            showstudent.Size = new Size(165, 29);
            showstudent.TabIndex = 0;
            showstudent.Text = "Показать студентов";
            showstudent.UseVisualStyleBackColor = false;
            showstudent.Click += showstudent_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(11, 108);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(315, 164);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(338, 283);
            Controls.Add(listBox1);
            Controls.Add(showstudent);
            Name = "Form1";
            Text = "Студент";
            ResumeLayout(false);
        }

        #endregion

        private Button showstudent;
        private ListBox listBox1;
    }
}
