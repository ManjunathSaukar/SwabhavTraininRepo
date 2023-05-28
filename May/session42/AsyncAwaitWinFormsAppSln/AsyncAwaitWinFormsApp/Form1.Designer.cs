namespace AsyncAwaitWinFormsApp
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
            button1 = new Button();
            btnPrintSync = new Button();
            butTask1 = new Button();
            btnPrintAsync1 = new Button();
            btnPrintAsync2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Location = new Point(174, 119);
            button1.Name = "button1";
            button1.Size = new Size(92, 40);
            button1.TabIndex = 0;
            button1.Text = "Hello";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnPrintSync
            // 
            btnPrintSync.BackColor = Color.Gray;
            btnPrintSync.Location = new Point(284, 119);
            btnPrintSync.Name = "btnPrintSync";
            btnPrintSync.Size = new Size(92, 40);
            btnPrintSync.TabIndex = 1;
            btnPrintSync.Text = "PrintSync";
            btnPrintSync.UseVisualStyleBackColor = false;
            btnPrintSync.Click += btnPrintSync_Click;
            // 
            // butTask1
            // 
            butTask1.BackColor = Color.Gray;
            butTask1.Location = new Point(403, 119);
            butTask1.Name = "butTask1";
            butTask1.Size = new Size(92, 40);
            butTask1.TabIndex = 2;
            butTask1.Text = "Task1";
            butTask1.UseVisualStyleBackColor = false;
            butTask1.Click += butTask1_Click;
            // 
            // btnPrintAsync1
            // 
            btnPrintAsync1.BackColor = Color.Gray;
            btnPrintAsync1.Location = new Point(174, 214);
            btnPrintAsync1.Name = "btnPrintAsync1";
            btnPrintAsync1.Size = new Size(92, 40);
            btnPrintAsync1.TabIndex = 3;
            btnPrintAsync1.Text = "PrintAsync1";
            btnPrintAsync1.UseVisualStyleBackColor = false;
            btnPrintAsync1.Click += btnPrintAsync1_Click;
            // 
            // btnPrintAsync2
            // 
            btnPrintAsync2.BackColor = Color.Gray;
            btnPrintAsync2.Location = new Point(284, 214);
            btnPrintAsync2.Name = "btnPrintAsync2";
            btnPrintAsync2.Size = new Size(92, 40);
            btnPrintAsync2.TabIndex = 4;
            btnPrintAsync2.Text = "PrintAsync2";
            btnPrintAsync2.UseVisualStyleBackColor = false;
            btnPrintAsync2.Click += btnPrintAsync2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrintAsync2);
            Controls.Add(btnPrintAsync1);
            Controls.Add(butTask1);
            Controls.Add(btnPrintSync);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnPrintSync;
        private Button butTask1;
        private Button btnPrintAsync1;
        private Button btnPrintAsync2;
    }
}