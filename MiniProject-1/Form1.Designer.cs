namespace MiniProject_1
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
            tmrStr = new Button();
            tmrStp = new Button();
            label2 = new Label();
            EntData = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(264, 112);
            label1.Name = "label1";
            label1.Size = new Size(257, 46);
            label1.TabIndex = 0;
            label1.Text = "00:00:00.000";
            // 
            // tmrStr
            // 
            tmrStr.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            tmrStr.Location = new Point(74, 284);
            tmrStr.Name = "tmrStr";
            tmrStr.Size = new Size(188, 74);
            tmrStr.TabIndex = 1;
            tmrStr.Text = "Start";
            tmrStr.UseVisualStyleBackColor = true;
            tmrStr.Click += tmrStr_Click;
            // 
            // tmrStp
            // 
            tmrStp.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            tmrStp.Location = new Point(74, 284);
            tmrStp.Name = "tmrStp";
            tmrStp.Size = new Size(188, 74);
            tmrStp.TabIndex = 2;
            tmrStp.Text = "Stop";
            tmrStp.UseVisualStyleBackColor = true;
            tmrStp.Visible = false;
            tmrStp.Click += tmrStp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(318, 9);
            label2.Name = "label2";
            label2.Size = new Size(155, 56);
            label2.TabIndex = 3;
            label2.Text = "Timer";
            // 
            // EntData
            // 
            EntData.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            EntData.Location = new Point(524, 284);
            EntData.Name = "EntData";
            EntData.Size = new Size(188, 74);
            EntData.TabIndex = 4;
            EntData.Text = "Enter data";
            EntData.UseVisualStyleBackColor = true;
            EntData.Click += EntData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(EntData);
            Controls.Add(label2);
            Controls.Add(tmrStp);
            Controls.Add(tmrStr);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Timer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button tmrStr;
        private Button tmrStp;
        private Label label2;
        private Button EntData;
    }
}