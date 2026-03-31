namespace tringle
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
            showtringle = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // showtringle
            // 
            showtringle.BackColor = Color.HotPink;
            showtringle.Location = new Point(79, 55);
            showtringle.Name = "showtringle";
            showtringle.Size = new Size(225, 29);
            showtringle.TabIndex = 0;
            showtringle.Text = "Показать треугольники";
            showtringle.UseVisualStyleBackColor = false;
            showtringle.Click += showtringle_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(15, 115);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(354, 204);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(381, 326);
            Controls.Add(listBox1);
            Controls.Add(showtringle);
            Name = "Form1";
            Text = "Треугольник";
            ResumeLayout(false);
        }

        #endregion

        private Button showtringle;
        private ListBox listBox1;
    }
}
