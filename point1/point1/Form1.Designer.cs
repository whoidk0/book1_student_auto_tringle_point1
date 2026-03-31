namespace point1
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
            showcoordinate = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // showcoordinate
            // 
            showcoordinate.BackColor = Color.HotPink;
            showcoordinate.Location = new System.Drawing.Point(83, 55);
            showcoordinate.Name = "showcoordinate";
            showcoordinate.Size = new Size(200, 29);
            showcoordinate.TabIndex = 0;
            showcoordinate.Text = "Получить координаты";
            showcoordinate.UseVisualStyleBackColor = false;
            showcoordinate.Click += showcoordinate_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(14, 117);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(338, 184);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(365, 317);
            Controls.Add(listBox1);
            Controls.Add(showcoordinate);
            Name = "Form1";
            Text = "Точка";
            ResumeLayout(false);
        }

        #endregion

        private Button showcoordinate;
        private ListBox listBox1;
    }
}
