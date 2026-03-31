namespace book1
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
            showbookbutton = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // showbookbutton
            // 
            showbookbutton.BackColor = Color.HotPink;
            showbookbutton.Location = new Point(75, 53);
            showbookbutton.Name = "showbookbutton";
            showbookbutton.Size = new Size(161, 29);
            showbookbutton.TabIndex = 0;
            showbookbutton.Text = "Показать книги";
            showbookbutton.UseVisualStyleBackColor = false;
            showbookbutton.Click += showbookbutton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(13, 101);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(297, 184);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(320, 293);
            Controls.Add(listBox1);
            Controls.Add(showbookbutton);
            Name = "Form1";
            Text = "Книга";
            ResumeLayout(false);
        }

        #endregion

        private Button showbookbutton;
        private ListBox listBox1;
    }
}
