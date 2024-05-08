namespace MiniProject_1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(263, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 56);
            label1.TabIndex = 0;
            label1.Text = "Data Entry";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(435, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(110, 276);
            label2.Name = "label2";
            label2.Size = new Size(229, 37);
            label2.TabIndex = 2;
            label2.Text = "Activity Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(110, 137);
            label3.Name = "label3";
            label3.Size = new Size(175, 37);
            label3.TabIndex = 3;
            label3.Text = "Start Time";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(435, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 31);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(110, 204);
            label4.Name = "label4";
            label4.Size = new Size(160, 37);
            label4.TabIndex = 5;
            label4.Text = "End Time";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(435, 282);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(233, 31);
            textBox3.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(263, 366);
            button1.Name = "button1";
            button1.Size = new Size(243, 60);
            button1.TabIndex = 8;
            button1.Text = "Enter Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(824, 459);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = Color.Cyan;
            Name = "Form2";
            Text = "Data Entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button button1;
    }
}