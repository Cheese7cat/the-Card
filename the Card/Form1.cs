using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace the_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // Paige Chaisson
            //2019-09-23
            //Halloween themed card
            //front of card
            Graphics g = this.CreateGraphics();
            Font startFont = new Font("impact", 16);
            SoundPlayer portalsound = new SoundPlayer(Properties.Resources.portalsound);
            portalsound.Play();
            SolidBrush oneBrush = new SolidBrush(Color.Purple);
            SolidBrush twoBrush = new SolidBrush(Color.Orange);
            SolidBrush threeBrush = new SolidBrush(Color.Black);
            SolidBrush forBrush = new SolidBrush(Color.LightGray);
            SolidBrush fiveBrush = new SolidBrush(Color.MediumPurple);
           
            //colour changing code
            g.Clear(Color.Black);
            g.FillEllipse(forBrush, 300, 160, 200, 200);
            g.FillEllipse(fiveBrush, 200, 400, 200, 200);
            g.FillEllipse(forBrush, 0, 10, 200, 200);
            g.FillEllipse(forBrush, 680, 310, 200, 200);
            g.FillEllipse(fiveBrush, 600, 20, 200, 200);

            g.DrawString("Have a...", startFont, oneBrush, 400, 200);
            Thread.Sleep(700);
            g.DrawString("Have a...", startFont, twoBrush, 400, 200);
            Thread.Sleep(700);
            g.DrawString("Have a...", startFont, threeBrush, 400, 200);
            Thread.Sleep(700);
            g.DrawString("Have a...", startFont, oneBrush, 400, 200);
            Thread.Sleep(700);
            g.DrawString("Have a...", startFont, twoBrush, 400, 200);
            Thread.Sleep(700);
            g.DrawString("Have a...", startFont, threeBrush, 400, 200);
            Thread.Sleep(700);
            g.DrawString("Have a...", startFont, oneBrush, 400, 200);

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //card inners 
            Graphics g = this.CreateGraphics();
            Font startFont = new Font("comic sans", 16);
            SoundPlayer musicBoxsound = new SoundPlayer(Properties.Resources.MusicBox);
            musicBoxsound.Play();
            //brush colours
            SolidBrush purpleBrush = new SolidBrush(Color.Purple);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush pinkBrush = new SolidBrush(Color.LightPink);
            SolidBrush greenBrush = new SolidBrush(Color.LightGreen);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush lightyellowBrush = new SolidBrush(Color.LightYellow);
            //pen colours
            Pen whitePen = new Pen(Color.GhostWhite, 10);
            Pen blackPen = new Pen(Color.Black, 2);
            Pen thickTenblackPen = new Pen(Color.Black, 10);
            Pen thickblackPen = new Pen(Color.Black, 14);
            Pen purplePen = new Pen(Color.Purple, 50);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 1
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 500, 300);
            g.DrawLine(thickTenblackPen, 500, 310, 490, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(blackBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(blackBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(blackBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(blackBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);

            //frame 2
            g.Clear(Color.MediumPurple);
            g.Clear(Color.MediumPurple);
            g.DrawLine(purplePen, 0, 20, 10000, 1000);
            g.DrawLine(purplePen, 0, 500, 1000, 200);
            g.DrawLine(purplePen, 240, 500, 0, 200);
            g.FillRectangle(greenBrush, 300, 100, 230, 100);
            g.DrawRectangle(whitePen, 300, 100, 230, 100);
            g.DrawString("HAPPY HALLOWEEN", startFont, blackBrush, 307, 140);
            //cat
            g.FillEllipse(blackBrush, 400, 250, 72, 75);
            g.FillPie(blackBrush, 445, 215, 70, 60, 115, 50);
            g.FillPie(blackBrush, 374, 207, 63, 60, 45, 50);
            g.FillPie(pinkBrush, 385, 280, 100, 15, 50, 60);
            g.FillEllipse(greenBrush, 415, 266, 17, 10);
            g.FillEllipse(greenBrush, 443, 266, 17, 10);
            g.DrawLine(blackPen, 428, 270, 428, 276);
            g.DrawLine(blackPen, 450, 270, 450, 276);
            g.FillEllipse(blackBrush, 417, 300, 50, 100);
            g.FillEllipse(blackBrush, 425, 350, 50, 45);
            g.FillEllipse(blackBrush, 445, 385, 30, 20);
            //cat movements 
            g.DrawLine(thickblackPen, 490, 339, 460, 365);
            g.DrawLine(thickTenblackPen, 490, 340, 490, 300);
            g.DrawLine(thickTenblackPen, 495, 310, 475, 280);
            //pumpkin
            g.FillEllipse(orangeBrush, 340, 310, 50, 100);
            g.FillEllipse(orangeBrush, 360, 310, 50, 100);
            g.FillEllipse(orangeBrush, 380, 310, 50, 100);
            g.FillEllipse(orangeBrush, 400, 310, 50, 100);
            //pumpkin movements
            g.FillPie(yellowBrush, 300, 315, 200, 60, 80, 30);
            g.FillPie(yellowBrush, 280, 305, 200, 50, 80, 30);
            g.FillPie(yellowBrush, 320, 305, 200, 50, 80, 30);
            g.FillEllipse(yellowBrush, 390, 383, 20, 10);

            Thread.Sleep(2000);



        }
    }
}
