using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract1
{
    public partial class Form1 : Form
    {
        private byte lightState;
        private bool state; // true - up false - down
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.State.Visible = false;
            this.GreenLight.BackColor = Color.Gray;
            this.YellowLight.BackColor = Color.Gray;
            this.RedLight.BackColor = Color.Gray;
            this.StopButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        
            switch (lightState)
            {
                case 1:
                    PaintGrey();
                    this.State.Text = "Stop!";
                    this.RedLight.BackColor = Color.Red;
                    
                    if (state)
                    {
                        ++lightState;
                        state = false;
                    }
                    else
                    {
                        ++lightState;
                    }

                    break;
                case 2:
                    PaintGrey();
                    this.YellowLight.BackColor = Color.Yellow;
                    this.State.Text = "Get Ready!";
                    
                    if (state)
                    {
                        --lightState;
                    }
                    else
                    {
                        ++lightState;
                    }
                    break;
                case 3:
                    PaintGrey();
                    this.GreenLight.BackColor = Color.Green;
                    this.State.Text = "Go!";
                    if (state)
                    {
                        ++lightState;
                        
                    }
                    else
                    {
                        --lightState;
                        state = true;
                    }
                    break;
                default:
                    break;
            }

        }
        public void PaintGrey()
        {
            this.GreenLight.BackColor = Color.Gray;
            this.YellowLight.BackColor = Color.Gray;
            this.RedLight.BackColor = Color.Gray;
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
            var obj = sender as Button;
            this.timer1.Start();
            this.State.Visible = true;
            this.lightState = 1;
            this.State.Text = "Stop!";
            this.RedLight.BackColor = Color.Red;
            obj.Enabled = false;
            this.StopButton.Enabled = true;
            state = false;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.StopButton.Enabled = false;
            this.StartButton.Enabled = true;
            PaintGrey();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

               
                this.timer1.Enabled = false;
                this.StopButton.Enabled = false;
                this.StartButton.Enabled = true;
                PaintGrey();
                this.timer2.Enabled = false;
                MessageBox.Show("Pause");
                

        }
    }
}
