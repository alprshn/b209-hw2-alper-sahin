namespace b209_hw2_alper_sahin
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
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            celciusText = new TextBox();
            fahrenheitText = new TextBox();
            kelvinText = new TextBox();
            converButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(121, 94);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(98, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Celcius (C)";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(121, 137);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(98, 23);
            textBox4.TabIndex = 2;
            textBox4.Text = "Fahrenheit";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(121, 181);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(98, 23);
            textBox5.TabIndex = 3;
            textBox5.Text = "Kelvin";
            // 
            // celciusText
            // 
            celciusText.Location = new Point(235, 94);
            celciusText.Margin = new Padding(3, 2, 3, 2);
            celciusText.Name = "celciusText";
            celciusText.Size = new Size(98, 23);
            celciusText.TabIndex = 5;
            // 
            // fahrenheitText
            // 
            fahrenheitText.Location = new Point(235, 137);
            fahrenheitText.Margin = new Padding(3, 2, 3, 2);
            fahrenheitText.Name = "fahrenheitText";
            fahrenheitText.Size = new Size(98, 23);
            fahrenheitText.TabIndex = 6;
            // 
            // kelvinText
            // 
            kelvinText.Location = new Point(235, 181);
            kelvinText.Margin = new Padding(3, 2, 3, 2);
            kelvinText.Name = "kelvinText";
            kelvinText.Size = new Size(98, 23);
            kelvinText.TabIndex = 7;
            // 
            // converButton
            // 
            converButton.Location = new Point(368, 136);
            converButton.Name = "converButton";
            converButton.Size = new Size(75, 23);
            converButton.TabIndex = 8;
            converButton.Text = "Convert";
            converButton.UseVisualStyleBackColor = true;
            converButton.Click += converButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 56);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 9;
            label1.Text = "Tempreture Converter";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label1);
            Controls.Add(converButton);
            Controls.Add(kelvinText);
            Controls.Add(fahrenheitText);
            Controls.Add(celciusText);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox celciusText;
        private TextBox fahrenheitText;
        private TextBox kelvinText;
        private Button converButton;
        private Label label1;
    }
}