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
            this.consoleView1 = new ConsoleView();
            this.SuspendLayout();
            // 
            // consoleView1
            // 
            this.consoleView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.consoleView1.Location = new System.Drawing.Point(102, 66);
            this.consoleView1.Name = "consoleView1";
            this.consoleView1.RobotConsole = null;
            this.consoleView1.Size = new System.Drawing.Size(105, 94);
            this.consoleView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(314, 219);
            this.Controls.Add(this.consoleView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        private RobotView.ConsoleView consoleView1;

        #endregion
    }
}

