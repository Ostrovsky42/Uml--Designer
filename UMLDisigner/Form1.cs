using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMLDisigner
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        List<Bitmap> BitmapList= new List<Bitmap>(); //шаг назад, но нужно передеать
        
        Graphics graphics;       
        Pen pen;
        SolidBrush brush;// заливка фигур
        Point mouseDownPosition;
        Point mouseUpPosition;
      
        string Output;
        public Form1()
        {
            InitializeComponent();
        }
                
        private void Form1_Load_1(object sender, EventArgs e)
        {
          bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            BitmapList.Add(new Bitmap(bitmap));
            pen = new Pen(Color.Black, 3);
            brush = new SolidBrush(Color.Black);
            graphics = Graphics.FromImage(bitmap);
           
            graphics.Clear(Color.White);


            BitmapList.Add(new Bitmap(bitmap));
            pictureBox1.Image = bitmap;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = bitmap;
        }             
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            mouseDownPosition = e.Location;
            if(BitmapList.Count>1)
            {
                button_StepBack.Enabled = true;
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpPosition = e.Location;
            switch (Output)
            {
                case "Rectangle":
                    Rectangle();
                    break;
                case "RectangleStack":
                    RectangleStack();
                    break;

                case "ArrowAssociation":
                    ArrowAssociation();
                    break;
                case "ArrowInheritance":
                    ArrowInheritance();
                    break;
                case "ArrowAddiction":
                    ArrowAddiction();
                    break;
                case "ArrowImplementation":
                    ArrowImplementation();
                    break;
                case "ArrowAggregation":
                    ArrowAggregation();
                    break;
                case "ArrowСomposition":
                    ArrowСomposition();
                    break;
                case "ArrowAggregationPlus":
                    ArrowAggregationPlus();
                    break;
                case "ArrowСompositionPlus":
                    ArrowСompositionPlus();
                    break;

            }
        }

       
        private void Rectangle()
        {
          
            Point[] P = new Point[] { new Point(mouseDownPosition.X, mouseDownPosition.Y),new Point(mouseDownPosition.X, mouseUpPosition.Y),
        new Point(mouseUpPosition.X, mouseUpPosition.Y),new Point(mouseUpPosition.X, mouseDownPosition.Y)}; //правильная последоватьльность точек)
            graphics.DrawPolygon(pen, P);
           
            pictureBox1.Image = bitmap;
            BitmapList.Add(new Bitmap(bitmap));//записываем битмап в лист(не важно)
        }// Прямоугольник 
        private void RectangleStack()
        {
            brush = new SolidBrush(Color.White);
            Point[] P;
            for (int i = 0; i < 5; i++)
            {
                int j = 0;
                P = new Point[] { new Point(mouseDownPosition.X, mouseDownPosition.Y),new Point(mouseDownPosition.X, mouseUpPosition.Y),
        new Point(mouseUpPosition.X, mouseUpPosition.Y),new Point(mouseUpPosition.X, mouseDownPosition.Y)}; //правильная последоватьльность точек)
                graphics.DrawPolygon(pen, P);
                graphics.FillPolygon(brush, P);
                pictureBox1.Image = bitmap;
                j += 10;
                mouseDownPosition.X += j;
                mouseUpPosition.X += j;
                mouseDownPosition.Y += j;
                mouseUpPosition.Y += j;


            }
            brush = new SolidBrush(Color.Black);
            BitmapList.Add(new Bitmap(bitmap));//записываем битмап в лист(не важно)
        }// Прямоугольник 
        private void ArrowAssociation() //Ассоциация
        { 
            
            Point[] ShouldersArrows = FindingPointsAndPerpendiculars();
            Point[] P = new Point[] { mouseUpPosition, ShouldersArrows[0], ShouldersArrows[1] };
            graphics.DrawLine(pen, mouseDownPosition, mouseUpPosition);
            graphics.DrawLine(pen, P[0], P[1]);
            graphics.DrawLine(pen, P[0], P[2]);
            pictureBox1.Image = bitmap;
            BitmapList.Add(new Bitmap(bitmap));
        } 
        private void ArrowAddiction() //зависимость 
        {

            Point[] ShouldersArrows = FindingPointsAndPerpendiculars();
            Point[] P = new Point[] { mouseUpPosition, ShouldersArrows[0], ShouldersArrows[1] };

            graphics.DrawLine(pen, P[0], P[1]);
            graphics.DrawLine(pen, P[0], P[2]);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            graphics.DrawLine(pen, mouseDownPosition, mouseUpPosition);
            pen = new Pen(Color.Black, 3);
            pictureBox1.Image = bitmap;
            BitmapList.Add(new Bitmap(bitmap));
        }
        private void ArrowInheritance()// Наследование
        {
            Point[] ShouldersArrows = FindingPointsAndPerpendiculars();      
            
            Point[] P = new Point[] { mouseUpPosition, ShouldersArrows[0], ShouldersArrows[1] };

            graphics.DrawPolygon(pen, P);
            graphics.DrawLine(pen, mouseDownPosition, ShouldersArrows[2]);
            pictureBox1.Image = bitmap;
            BitmapList.Add(new Bitmap(bitmap));
        }       
        private void ArrowImplementation() //Имплмементация
        {
            Point[] ShouldersArrows = FindingPointsAndPerpendiculars();
            Point[] P = new Point[] { mouseUpPosition, ShouldersArrows[0], ShouldersArrows[1] };
          

            graphics.DrawPolygon(pen, P);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            graphics.DrawLine(pen, mouseDownPosition, ShouldersArrows[2]);
            pen = new Pen(Color.Black, 3);
            pictureBox1.Image = bitmap;
            BitmapList.Add(new Bitmap(bitmap));
        }
        private void ArrowAggregation()//Агрегаця
        {
            BitmapList.Add(new Bitmap(bitmap));
            double d = Math.Sqrt(Math.Pow(this.mouseUpPosition.X - this.mouseDownPosition.X, 2) + Math.Pow(this.mouseUpPosition.Y - this.mouseDownPosition.Y, 2));
            Point[] ShouldersArrows = FindingPointsAndPerpendiculars();

            Point a = new Point((int)(mouseUpPosition.X - (ShouldersArrows[3].X / d) * 40),
                (int)(mouseUpPosition.Y - (ShouldersArrows[3].Y / d) * 40));
            Point[] P = new Point[] { mouseUpPosition, ShouldersArrows[0], a, ShouldersArrows[1] };

            graphics.DrawPolygon(pen, P);
            graphics.DrawLine(pen, mouseDownPosition, a);
            pictureBox1.Image = bitmap;
        }
        private void ArrowAggregationPlus()//Агрегаця
        {
            BitmapList.Add(new Bitmap(bitmap));
            double d = Math.Sqrt(Math.Pow(this.mouseUpPosition.X - this.mouseDownPosition.X, 2) + Math.Pow(this.mouseUpPosition.Y - this.mouseDownPosition.Y, 2));
            Point[] ShouldersArrows = FindingPointsAndPerpendiculars();
            Point[] ArrowAtFront = FindingPointsAndPerpendicularsAtFirst();
            Point a = new Point((int)(mouseUpPosition.X - (ShouldersArrows[3].X / d) * 40),
                (int)(mouseUpPosition.Y - (ShouldersArrows[3].Y / d) * 40));
            Point[] P = new Point[] { mouseUpPosition, ShouldersArrows[0], a, ShouldersArrows[1] };

            graphics.DrawPolygon(pen, P);
            graphics.DrawLine(pen, mouseDownPosition, a);
            graphics.DrawLine(pen, mouseDownPosition, ArrowAtFront[0]);
            graphics.DrawLine(pen, mouseDownPosition, ArrowAtFront[1]);
            pictureBox1.Image = bitmap;
        }
        private void ArrowСomposition()//Композиция
        {
            double d = Math.Sqrt(Math.Pow(this.mouseUpPosition.X - this.mouseDownPosition.X, 2) + Math.Pow(this.mouseUpPosition.Y - this.mouseDownPosition.Y, 2));


            Point[] ShouldersArrows = FindingPointsAndPerpendiculars();

            Point a = new Point((int)(mouseUpPosition.X - (ShouldersArrows[3].X / d) * 40),
                (int)(mouseUpPosition.Y - (ShouldersArrows[3].Y / d) * 40));
            Point[] P = new Point[] { mouseUpPosition, ShouldersArrows[0], a, ShouldersArrows[1] };

            BitmapList.Add(new Bitmap(bitmap));
            graphics.FillPolygon(brush, P);
            graphics.DrawPolygon(pen, P);
            graphics.DrawLine(pen, mouseDownPosition, a);
            pictureBox1.Image = bitmap;
        }
        private void ArrowСompositionPlus()//Композиция
        {
            double d = Math.Sqrt(Math.Pow(this.mouseUpPosition.X - this.mouseDownPosition.X, 2) + Math.Pow(this.mouseUpPosition.Y - this.mouseDownPosition.Y, 2));


            Point[] ShouldersArrows = FindingPointsAndPerpendiculars();
            Point[] ArrowAtFront = FindingPointsAndPerpendicularsAtFirst();
            Point a = new Point((int)(mouseUpPosition.X - (ShouldersArrows[3].X / d) * 40),
                (int)(mouseUpPosition.Y - (ShouldersArrows[3].Y / d) * 40));
            Point[] P = new Point[] { mouseUpPosition, ShouldersArrows[0], a, ShouldersArrows[1] };

            BitmapList.Add(new Bitmap(bitmap));
            graphics.FillPolygon(brush, P);
            graphics.DrawPolygon(pen, P);
            graphics.DrawLine(pen, mouseDownPosition, a);
            graphics.DrawLine(pen, mouseDownPosition, ArrowAtFront[0]);
            graphics.DrawLine(pen, mouseDownPosition, ArrowAtFront[1]);
            pictureBox1.Image = bitmap;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
        }
        private void button_Rectangle_Click(object sender, EventArgs e)
        {
            BottonText(sender);
        }
        private void button_RectangleStak_Click(object sender, EventArgs e)
        {
            BottonText(sender);
        }
        private void button_ArrowAssociation_Click(object sender, EventArgs e)
        {
            BottonText(sender);
        }
        private void button_ArrowInheritance_Click(object sender, EventArgs e)
        {
            BottonText(sender);

        }
        private void button_ArrowAggregation_Click(object sender, EventArgs e)
        {
            BottonText(sender);

        }
        private void button_ArrowСomposition_Click(object sender, EventArgs e)
        {
            BottonText(sender);
        }
        private void button_ArrowAddiction_Click(object sender, EventArgs e)
        {
            BottonText(sender);
        }
        private void button_ArrowImplementation_Click(object sender, EventArgs e)
        {
            BottonText(sender);
        }
        private void button_StepBack_Click(object sender, EventArgs e)          //нужно переделывать
        {
            bitmap=BitmapList[BitmapList.Count-1 ];
            BitmapList.RemoveAt(BitmapList.Count -1);
            if (BitmapList.Count == 1)
            {
                button_StepBack.Enabled = false;              
            }
          
           
            pictureBox1.Image = bitmap;
        }
        private void button1_button_ArrowAggregationPlus_Click(object sender, EventArgs e)
        {
            BottonText(sender);
        }
        private void button_ArrowСompositionPlus_Click(object sender, EventArgs e)
        {
            BottonText(sender);
        }


        private Point[] FindingPointsAndPerpendiculars()
        {
            // длина отрезка
            double d = Math.Sqrt(Math.Pow(this.mouseUpPosition.X - this.mouseDownPosition.X, 2) + Math.Pow(this.mouseUpPosition.Y - this.mouseDownPosition.Y, 2));

            // координаты вектора
            double X = this.mouseUpPosition.X - this.mouseDownPosition.X;
            double Y = this.mouseUpPosition.Y - this.mouseDownPosition.Y;

            // координаты точки, удалённой от конца  отрезка на 20px
            double X4 = mouseUpPosition.X - (X / d) * 20;
            double Y4 = mouseUpPosition.Y - (Y / d) * 20;

            // из уравнения прямой { (x - x1)/(x1 - x2) = (y - y1)/(y1 - y2) } получаем вектор перпендикуляра
            // (x - x1)/(x1 - x2) = (y - y1)/(y1 - y2) =>
            // (x - x1)*(y1 - y2) = (y - y1)*(x1 - x2) =>
            // (x - x1)*(y1 - y2) - (y - y1)*(x1 - x2) = 0 =>
            // полученные множители x и y => координаты вектора перпендикуляра
            double Xp = this.mouseUpPosition.Y - this.mouseDownPosition.Y;
            double Yp = this.mouseDownPosition.X - this.mouseUpPosition.X;

            // координаты перпендикуляров, удалённой от точки X4;Y4 на 5px в разные стороны
            double X5 = X4 + (Xp / d) * 15;
            double Y5 = Y4 + (Yp / d) * 15;
            double X6 = X4 - (Xp / d) * 15;
            double Y6 = Y4 - (Yp / d) * 15;
            Point[] ShouldersArrows = new Point[] { new Point((int)X5, (int)Y5), new Point((int)X6, (int)Y6), new Point((int)X4, (int)Y4), new Point((int)X, (int)Y) };
            return ShouldersArrows;
        }
        private Point[] FindingPointsAndPerpendicularsAtFirst()
        {
            // длина отрезка
            double d = Math.Sqrt(Math.Pow(this.mouseUpPosition.X - this.mouseDownPosition.X, 2) + Math.Pow(this.mouseUpPosition.Y - this.mouseDownPosition.Y, 2));

            // координаты вектора
            double X = this.mouseDownPosition.X - this.mouseUpPosition.X;//
            double Y = this.mouseDownPosition.Y - this.mouseUpPosition.Y;

            // координаты точки, удалённой от конца  отрезка на 20px
            double X4 = mouseDownPosition.X - (X / d) * 20;
            double Y4 = mouseDownPosition.Y - (Y / d) * 20;

            // из уравнения прямой { (x - x1)/(x1 - x2) = (y - y1)/(y1 - y2) } получаем вектор перпендикуляра
            // (x - x1)/(x1 - x2) = (y - y1)/(y1 - y2) =>
            // (x - x1)*(y1 - y2) = (y - y1)*(x1 - x2) =>
            // (x - x1)*(y1 - y2) - (y - y1)*(x1 - x2) = 0 =>
            // полученные множители x и y => координаты вектора перпендикуляра
            double Xp = mouseDownPosition.Y - mouseUpPosition.Y;
            double Yp = this.mouseUpPosition.X - this.mouseDownPosition.X;

            // координаты перпендикуляров, удалённой от точки X4;Y4 на 5px в разные стороны
            double X5 = X4 + (Xp / d) * 15;
            double Y5 = Y4 + (Yp / d) * 15;
            double X6 = X4 - (Xp / d) * 15;
            double Y6 = Y4 - (Yp / d) * 15;
            Point[] ArrowAtFront = new Point[] { new Point((int)X5, (int)Y5), new Point((int)X6, (int)Y6) };
            return ArrowAtFront;
        }
        private void BottonText(object sender)
        {
            Button button = (Button)sender;
            Output = button.Text;
        }
                

    }
}
