using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod2
{
    public partial class DrawScreen : UserControl
    {
        public DrawScreen()
        {
            InitializeComponent();
        }

        int pointsNum, multiply, radius = 200, p2, anRnge, R, G, B, rotation;
        double cycle;
        Random rand = new Random();
        Point origin = new Point(300, 250);
        Point[] drawPoints;
        Graphics g, g2;
        Bitmap bm;
        Color drawColour, randColour;
        List<Button> colourButtons;

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            bm = new Bitmap(this.Width, this.Height);
            g2 = Graphics.FromImage(bm);
            drawColour = Color.Red;
            randCheckBox.Text = "Randomize colour\nduring animation";
            colourButtons = new List<Button>(new Button[] { redButton, greenButton, blueButton, customButton, randColourButton });
        }

        private void numberOfPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //only allows numbers to be typed
            {
                e.Handled = true;
            }
        }

        private void multiplyer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void animationRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numberOfPoints_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pointsNum = Convert.ToInt32(numberOfPoints.Value);
                rotationBar.Maximum = pointsNum - 1;
                multiply = Convert.ToInt32(multiplyer.Value);
                FindPoints();
                DrawMod();
            }
        }

        private void multiplyer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pointsNum = Convert.ToInt32(numberOfPoints.Value);
                multiply = Convert.ToInt32(multiplyer.Value);
                FindPoints();
                DrawMod();
            }
        }

        private void animationRange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pointsNum = Convert.ToInt32(numberOfPoints.Value);
                multiply = Convert.ToInt32(multiplyer.Value);
                anRnge = Convert.ToInt32(animationRange.Value) - pointsNum;
                for (int i = 0; i <= anRnge; i++)
                {
                    FindPoints();
                    DrawMod();
                    pointsNum++;
                }
                pointsNum--;//This resets the pointsNum value after the last animation
                randCheckBox.Checked = false;
                rotationBar.Maximum = pointsNum - 1;
            }
        }

        public void FindPoints()
        {
            drawPoints = new Point[pointsNum];

            for (int i = 0; i < pointsNum; i++)//Works in radians 
            {
                drawPoints[i] = new Point(Convert.ToInt32(origin.X + (Math.Cos((2 * Math.PI / pointsNum) * i)) * radius),
                     Convert.ToInt32(origin.Y - (Math.Sin((2 * Math.PI / pointsNum) * i)) * radius));
            }
        }

        public void DrawMod()
        {
            Pen drawPen = new Pen(drawColour);
            Pen randPen;
            g2.Clear(Color.WhiteSmoke);

            for (int i = 0; i < pointsNum; i++)
            {
                g2.DrawRectangle(drawPen, drawPoints[i].X, drawPoints[i].Y, 1, 1);
            }

            for (int i = 0; i < pointsNum; i++)
            {
                p2 = i * multiply;
                cycle = p2 / pointsNum;
                if (p2 > pointsNum - 1)
                {
                    p2 = p2 - Convert.ToInt32(Math.Floor(cycle) * pointsNum);
                }
                if (randCheckBox.Checked == true)
                {
                    RandomizeColour();
                    randPen = new Pen(randColour);
                    g2.DrawLine(randPen, drawPoints[i].X, drawPoints[i].Y, drawPoints[p2].X, drawPoints[p2].Y);
                }
                else { g2.DrawLine(drawPen, drawPoints[i].X, drawPoints[i].Y, drawPoints[p2].X, drawPoints[p2].Y); }
            }
            g.DrawImage(bm, 0, 0);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawImage(bm, 0, 0);
        }

        #region Colour Buttons
        private void redButton_Click(object sender, EventArgs e)
        {
            drawColour = Color.Red;
            redButton.BackColor = drawColour;
            FindPoints();
            DrawMod();
            for (int i = 0; i < colourButtons.Count(); i++)
            {
                if (i != colourButtons.IndexOf(redButton)) { colourButtons[i].BackColor = Color.Gainsboro; }
            }
        }
        private void greenButton_Click(object sender, EventArgs e)
        {
            drawColour = Color.Green;
            greenButton.BackColor = drawColour;
            FindPoints();
            DrawMod();
            for (int i = 0; i < colourButtons.Count(); i++)
            {
                if (i != colourButtons.IndexOf(greenButton)) { colourButtons[i].BackColor = Color.Gainsboro; }
            }
        }
        private void blueButton_Click(object sender, EventArgs e)
        {
            drawColour = Color.Blue;
            blueButton.BackColor = drawColour;
            FindPoints();
            DrawMod();
            for (int i = 0; i < colourButtons.Count(); i++)
            {
                if (i != colourButtons.IndexOf(blueButton)) { colourButtons[i].BackColor = Color.Gainsboro; }
            }
        }
        private void customButton_Click(object sender, EventArgs e)
        {
            customColDialog.ShowDialog();
            drawColour = customColDialog.Color;
            customButton.BackColor = drawColour;
            FindPoints();
            DrawMod();
            for (int i = 0; i < colourButtons.Count(); i++)
            {
                if (i != colourButtons.IndexOf(customButton)) { colourButtons[i].BackColor = Color.Gainsboro; }
            }
        }
        private void randColourButton_Click(object sender, EventArgs e)
        {
            RandomizeColour();
            randColourButton.BackColor = drawColour = Color.FromArgb(R,B,G);
            FindPoints();
            DrawMod();
            for (int i = 0; i < colourButtons.Count(); i++)
            {
                if (i != colourButtons.IndexOf(randColourButton)) { colourButtons[i].BackColor = Color.Gainsboro; }
            }
        }
        public void RandomizeColour()
        {
            R = rand.Next(1, 256);
            G = rand.Next(1, 256);
            B = rand.Next(1, 256);
            randColour = Color.FromArgb(R, G, B);
        }
        #endregion

        private void rotationBar_Scroll(object sender, EventArgs e)
        {
            FindPoints();
            rotation = rotationBar.Value;
            rotationValLabel.Text = "VALUE : " + rotation.ToString();
            Point[] rotPoints = new Point[pointsNum];
            int cycleCount = 0;

            for (int i = 0; i < pointsNum; i++)
            {
                if (i + rotation > pointsNum-1)
                {
                    rotPoints[i] = drawPoints[pointsNum - (i + rotation - cycleCount)];
                    cycleCount+=2;
                }
                else
                {
                    rotPoints[i] = drawPoints[i + rotation];
                }
            }
            drawPoints = rotPoints;
            DrawMod();
        }
    }
}
