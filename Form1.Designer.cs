namespace SampleApp
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 20);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Version 2.0.0.0";
            // 
            // button1
            // 
            button1.Location = new Point(105, 106);
            button1.Name = "button1";
            button1.Size = new Size(154, 102);
            button1.TabIndex = 1;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(359, 106);
            button2.Name = "button2";
            button2.Size = new Size(154, 102);
            button2.TabIndex = 2;
            button2.Text = "Update2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(576, 106);
            button3.Name = "button3";
            button3.Size = new Size(154, 102);
            button3.TabIndex = 3;
            button3.Text = "Update Git";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(105, 235);
            button4.Name = "button4";
            button4.Size = new Size(154, 102);
            button4.TabIndex = 4;
            button4.Text = "Update Git2";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(359, 235);
            button5.Name = "button5";
            button5.Size = new Size(154, 102);
            button5.TabIndex = 5;
            button5.Text = "Update Git3";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(576, 235);
            button6.Name = "button6";
            button6.Size = new Size(154, 102);
            button6.TabIndex = 6;
            button6.Text = "Update Git4";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(105, 373);
            button7.Name = "button7";
            button7.Size = new Size(154, 102);
            button7.TabIndex = 7;
            button7.Text = "Update Git5";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(359, 373);
            button8.Name = "button8";
            button8.Size = new Size(154, 102);
            button8.TabIndex = 8;
            button8.Text = "Update DekstopGit";
            button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 526);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sample App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}