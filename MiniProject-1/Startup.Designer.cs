namespace MiniProject_1
{
    partial class Startup
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(98, 37);
            label1.Name = "label1";
            label1.Size = new Size(713, 56);
            label1.TabIndex = 1;
            label1.Text = "Time Management Application";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(39, 217);
            button1.Name = "button1";
            button1.Size = new Size(250, 75);
            button1.TabIndex = 2;
            button1.Text = "New Entry";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(589, 217);
            button2.Name = "button2";
            button2.Size = new Size(250, 75);
            button2.TabIndex = 3;
            button2.Text = "Timer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(314, 217);
            button3.Name = "button3";
            button3.Size = new Size(250, 75);
            button3.TabIndex = 4;
            button3.Text = "Display";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Startup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(883, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Startup";
            Text = "Startup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}