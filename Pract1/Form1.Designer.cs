
namespace Pract1
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
            this.components = new System.ComponentModel.Container();
            this.State = new System.Windows.Forms.Label();
            this.RedLight = new System.Windows.Forms.Button();
            this.YellowLight = new System.Windows.Forms.Button();
            this.GreenLight = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StopButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(369, 79);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(33, 15);
            this.State.TabIndex = 0;
            this.State.Text = "State";
            // 
            // RedLight
            // 
            this.RedLight.Location = new System.Drawing.Point(360, 118);
            this.RedLight.Name = "RedLight";
            this.RedLight.Size = new System.Drawing.Size(62, 65);
            this.RedLight.TabIndex = 1;
            this.RedLight.UseVisualStyleBackColor = true;
            // 
            // YellowLight
            // 
            this.YellowLight.Location = new System.Drawing.Point(360, 189);
            this.YellowLight.Name = "YellowLight";
            this.YellowLight.Size = new System.Drawing.Size(62, 65);
            this.YellowLight.TabIndex = 2;
            this.YellowLight.UseVisualStyleBackColor = true;
            // 
            // GreenLight
            // 
            this.GreenLight.Location = new System.Drawing.Point(360, 260);
            this.GreenLight.Name = "GreenLight";
            this.GreenLight.Size = new System.Drawing.Size(62, 65);
            this.GreenLight.TabIndex = 3;
            this.GreenLight.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(519, 189);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 46);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(631, 189);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 46);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.GreenLight);
            this.Controls.Add(this.YellowLight);
            this.Controls.Add(this.RedLight);
            this.Controls.Add(this.State);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Button RedLight;
        private System.Windows.Forms.Button YellowLight;
        private System.Windows.Forms.Button GreenLight;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Timer timer2;
    }
}

