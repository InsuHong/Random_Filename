namespace Random_Filename
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button_make = new Button();
            textBox_filename = new TextBox();
            label1 = new Label();
            button_copy = new Button();
            comboBox_ext = new ComboBox();
            SuspendLayout();
            // 
            // button_make
            // 
            button_make.Location = new Point(12, 67);
            button_make.Name = "button_make";
            button_make.Size = new Size(129, 64);
            button_make.TabIndex = 0;
            button_make.Text = "생성";
            button_make.UseVisualStyleBackColor = true;
            button_make.Click += button_make_Click;
            // 
            // textBox_filename
            // 
            textBox_filename.Location = new Point(76, 24);
            textBox_filename.Name = "textBox_filename";
            textBox_filename.Size = new Size(147, 23);
            textBox_filename.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "파일명";
            // 
            // button_copy
            // 
            button_copy.Location = new Point(160, 65);
            button_copy.Name = "button_copy";
            button_copy.Size = new Size(127, 64);
            button_copy.TabIndex = 3;
            button_copy.Text = "복사(Ctrl+C)";
            button_copy.UseVisualStyleBackColor = true;
            button_copy.Click += button_copy_Click;
            // 
            // comboBox_ext
            // 
            comboBox_ext.FormattingEnabled = true;
            comboBox_ext.Items.AddRange(new object[] { "png", "jpg", "gif", "zip", "bmp", "psd" });
            comboBox_ext.Location = new Point(229, 24);
            comboBox_ext.Name = "comboBox_ext";
            comboBox_ext.Size = new Size(58, 23);
            comboBox_ext.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 141);
            Controls.Add(comboBox_ext);
            Controls.Add(button_copy);
            Controls.Add(label1);
            Controls.Add(textBox_filename);
            Controls.Add(button_make);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Random Filename";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_make;
        private TextBox textBox_filename;
        private Label label1;
        private Button button_copy;
        private ComboBox comboBox_ext;
    }
}
