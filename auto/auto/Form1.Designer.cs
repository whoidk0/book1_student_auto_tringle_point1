namespace auto
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
            showauto = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // showauto
            // 
            showauto.BackColor = Color.HotPink;
            showauto.Location = new Point(80, 62);
            showauto.Name = "showauto";
            showauto.Size = new Size(217, 29);
            showauto.TabIndex = 0;
            showauto.Text = "Показать автомобили";
            showauto.UseVisualStyleBackColor = false;
            showauto.Click += showauto_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(8, 116);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(352, 184);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(372, 310);
            Controls.Add(listBox1);
            Controls.Add(showauto);
            Name = "Form1";
            Text = "Автомобиль";
            ResumeLayout(false);
        }

        #endregion

        private Button showauto;
        private ListBox listBox1;
    }
}
