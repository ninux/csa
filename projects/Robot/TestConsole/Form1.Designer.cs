using RobotView;

namespace TestConsole
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer();
            this.consoleView2 = new RobotView.ConsoleView();
            this.consoleView1 = new RobotView.ConsoleView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // consoleView2
            // 
            this.consoleView2.BackColor = System.Drawing.Color.Black;
            this.consoleView2.Location = new System.Drawing.Point(27, 116);
            this.consoleView2.Name = "consoleView2";
            this.consoleView2.RobotConsole = null;
            this.consoleView2.Size = new System.Drawing.Size(208, 46);
            this.consoleView2.TabIndex = 1;
            // 
            // consoleView1
            // 
            this.consoleView1.BackColor = System.Drawing.Color.Black;
            this.consoleView1.Location = new System.Drawing.Point(27, 22);
            this.consoleView1.Name = "consoleView1";
            this.consoleView1.RobotConsole = null;
            this.consoleView1.Size = new System.Drawing.Size(208, 46);
            this.consoleView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(363, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.consoleView2);
            this.Controls.Add(this.consoleView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        private ConsoleView consoleView1;
        #endregion

        private ConsoleView consoleView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer;
    }
}

