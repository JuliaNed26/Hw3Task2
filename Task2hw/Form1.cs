using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void triangleReadybtn_Click(object sender, EventArgs e)
        {
            Triangle triangle;
            try
            {
                triangle = new Triangle(Convert.ToDouble(triangleSide1tb.Text),
                    Convert.ToDouble(triangleSide2tb.Text), Convert.ToDouble(triangleSide3tb.Text));
            }
            catch(FormatException)
            {
                MessageBox.Show("You should print only numbers");
                return;
            }
            catch(ArgumentException)
            {
                MessageBox.Show("Numbers should be > 0");
                return;
            }
            trianglePerimeterTb.Text = triangle.GetPerimeter().ToString();
            triangleSquareTb.Text = triangle.GetSquare().ToString();
                
        }

        private void rectangleReadybtn_Click(object sender, EventArgs e)
        {
            Rectangle rectangle;
            try
            {
                rectangle = new Rectangle(Convert.ToDouble(rectWidthtb.Text),
                    Convert.ToDouble(rectHeighttb.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("You should print only numbers");
                return;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Numbers should be > 0");
                return;
            }
            //if printed not a number, if sides < 0
            rectanglePerimeterTb.Text = rectangle.GetPerimeter().ToString();
            rectangleSquareTb.Text = rectangle.GetSquare().ToString();
        }

        private void rhombusReadybtn_Click(object sender, EventArgs e)
        {
            Rhombus rhombus;
            try
            {
                rhombus = new Rhombus(Convert.ToDouble(rhombusDiag1tb.Text),
                    Convert.ToDouble(rhombusDiag2tb.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("You should print only numbers");
                return;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Numbers should be > 0");
                return;
            }
            //if printed not a number, if sides < 0
            rhombusPerimeterTb.Text = rhombus.GetPerimeter().ToString();
            rhombusSquareTb.Text = rhombus.GetSquare().ToString();
        }

        private void circleReadybtn_Click(object sender, EventArgs e)
        {
            Circle circle;
            try
            {
                circle = new Circle(Convert.ToDouble(radiustb.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("You should print only numbers");
                return;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Numbers should be > 0");
                return;
            }
            //if printed not a number, if sides < 0
            circlePerimeterTb.Text = circle.GetPerimeter().ToString();
            circleSquareTb.Text = circle.GetSquare().ToString();
        }

        private void squareReadybtn_Click(object sender, EventArgs e)
        {
            Square square;
            try
            {
                square = new Square(Convert.ToDouble(squreSidetb.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("You should print only numbers");
                return;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Numbers should be > 0");
                return;
            }
            //if printed not a number, if sides < 0
            squarePerimeterTb.Text = square.GetPerimeter().ToString();
            squareSquareTb.Text = square.GetSquare().ToString();
        }
    }
}
