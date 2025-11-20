namespace practice01
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
            Rock = new Button();
            Scissors = new Button();
            Paper = new Button();
            SuspendLayout();
            // 
            // Rock
            // 
            Rock.Location = new Point(30, 26);
            Rock.Name = "Rock";
            Rock.Size = new Size(112, 34);
            Rock.TabIndex = 0;
            Rock.Text = "グー";
            Rock.UseVisualStyleBackColor = true;
            Rock.Click += rock_click;
            // 
            // Scissors
            // 
            Scissors.Location = new Point(148, 26);
            Scissors.Name = "Scissors";
            Scissors.Size = new Size(112, 34);
            Scissors.TabIndex = 1;
            Scissors.Text = "チョキ";
            Scissors.UseVisualStyleBackColor = true;
            Scissors.Click += scissors_click;
            // 
            // Paper
            // 
            Paper.Location = new Point(266, 26);
            Paper.Name = "Paper";
            Paper.Size = new Size(112, 34);
            Paper.TabIndex = 2;
            Paper.Text = "パー";
            Paper.UseVisualStyleBackColor = true;
            Paper.Click += paper_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Paper);
            Controls.Add(Scissors);
            Controls.Add(Rock);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Rock;
        private Button Scissors;
        private Button Paper;
    }
}
