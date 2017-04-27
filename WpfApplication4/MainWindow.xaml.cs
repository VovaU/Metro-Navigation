using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ellipse[] Green = new Ellipse[16];//Array for all graphics objects
        Ellipse[] Blue = new Ellipse[15];
        Ellipse[] Red = new Ellipse[18];
        TextBlock[] GreenBlock = new TextBlock[16];
        TextBlock[] BlueBlock = new TextBlock[15];
        TextBlock[] RedBlock = new TextBlock[18];
        Line[] GreenLine = new Line[15];
        Line[] BlueLine = new Line[14];
        Line[] RedLine = new Line[17];
        private int count = 0;//Count how many station is choosen
        private int first;//Station that was click first
        private int second;//Station that was click second
        private Brush firstBrushes = null;//Color of first station
        private Brush secondBrushes = null;//Color of second station
        public MainWindow()
        {
            InitializeComponent();
#region   From Window to code
            Green[0] = Green0;
            Green[1] = Green1;
            Green[2] = Green2;
            Green[3] = Green3;
            Green[4] = Green4;
            Green[5] = Green5;
            Green[6] = Green6;
            Green[7] = Green7;
            Green[8] = Green8;
            Green[9] = Green9;
            Green[10] = Green10;
            Green[11] = Green11;
            Green[12] = Green12;
            Green[13] = Green13;
            Green[14] = Green14;
            Green[15] = Green15;
            Blue[0] = Blue0;
            Blue[1] = Blue1;
            Blue[2] = Blue2;
            Blue[3] = Blue3;
            Blue[4] = Blue4;
            Blue[5] = Blue5;
            Blue[6] = Blue6;
            Blue[7] = Blue7;
            Blue[8] = Blue8;
            Blue[9] = Blue9;
            Blue[10] = Blue10;
            Blue[11] = Blue11;
            Blue[12] = Blue12;
            Blue[13] = Blue13;
            Blue[14] = Blue14;
            Red[0] = Red0;
            Red[1] = Red1;
            Red[2] = Red2;
            Red[3] = Red3;
            Red[4] = Red4;
            Red[5] = Red5;
            Red[6] = Red6;
            Red[7] = Red7;
            Red[8] = Red8;
            Red[9] = Red9;
            Red[10] = Red10;
            Red[11] = Red11;
            Red[12] = Red12;
            Red[13] = Red13;
            Red[14] = Red14;
            Red[15] = Red15;
            Red[16] = Red16;
            Red[17] = Red17;
            GreenLine[0] = Green00;
            GreenLine[1] = Green01;
            GreenLine[2] = Green02;
            GreenLine[3] = Green03;
            GreenLine[4] = Green04;
            GreenLine[5] = Green05;
            GreenLine[6] = Green06;
            GreenLine[7] = Green07;
            GreenLine[8] = Green08;
            GreenLine[9] = Green09;
            GreenLine[10] = Green010;
            GreenLine[11] = Green011;
            GreenLine[12] = Green012;
            GreenLine[13] = Green013;
            GreenLine[14] = Green014;
            BlueLine[0] = Blue00;
            BlueLine[1] = Blue01;
            BlueLine[2] = Blue02;
            BlueLine[3] = Blue03;
            BlueLine[4] = Blue04;
            BlueLine[5] = Blue05;
            BlueLine[6] = Blue06;
            BlueLine[7] = Blue07;
            BlueLine[8] = Blue08;
            BlueLine[9] = Blue09;
            BlueLine[10] = Blue010;
            BlueLine[11] = Blue011;
            BlueLine[12] = Blue012;
            BlueLine[13] = Blue013;
            RedLine[0] = Red00;
            RedLine[1] = Red01;
            RedLine[2] = Red02;
            RedLine[3] = Red03;
            RedLine[4] = Red04;
            RedLine[5] = Red05;
            RedLine[6] = Red06;
            RedLine[7] = Red07;
            RedLine[8] = Red08;
            RedLine[9] = Red09;
            RedLine[10] = Red010;
            RedLine[11] = Red011;
            RedLine[12] = Red012;
            RedLine[13] = Red013;
            RedLine[14] = Red014;
            RedLine[15] = Red015;
            RedLine[16] = Red016;
            GreenBlock[0] = _0Green;
            GreenBlock[1] = _1Green;
            GreenBlock[2] = _2Green;
            GreenBlock[3] = _3Green;
            GreenBlock[4] = _4Green;
            GreenBlock[5] = _5Green;
            GreenBlock[6] = _6Green;
            GreenBlock[7] = _7Green;
            GreenBlock[8] = _8Green;
            GreenBlock[9] = _9Green;
            GreenBlock[10] = _10Green;
            GreenBlock[11] = _11Green;
            GreenBlock[12] = _12Green;
            GreenBlock[13] = _13Green;
            GreenBlock[14] = _14Green;
            GreenBlock[15] = _15Green;
            BlueBlock[0] = _0Blue;
            BlueBlock[1] = _1Blue;
            BlueBlock[2] = _2Blue;
            BlueBlock[3] = _3Blue;
            BlueBlock[4] = _4Blue;
            BlueBlock[5] = _5Blue;
            BlueBlock[6] = _6Blue;
            BlueBlock[7] = _7Blue;
            BlueBlock[8] = _8Blue;
            BlueBlock[9] = _9Blue;
            BlueBlock[10] = _10Blue;
            BlueBlock[11] = _11Blue;
            BlueBlock[12] = _12Blue;
            BlueBlock[13] = _13Blue;
            BlueBlock[14] = _14Blue;
            RedBlock[0] = _0Red;
            RedBlock[1] = _1Red;
            RedBlock[2] = _2Red;
            RedBlock[3] = _3Red;
            RedBlock[4] = _4Red;
            RedBlock[5] = _5Red;
            RedBlock[6] = _6Red;
            RedBlock[7] = _7Red;
            RedBlock[8] = _8Red;
            RedBlock[9] = _9Red;
            RedBlock[10] = _10Red;
            RedBlock[11] = _11Red;
            RedBlock[12] = _12Red;
            RedBlock[13] = _13Red;
            RedBlock[14] = _14Red;
            RedBlock[15] = _15Red;
            RedBlock[16] = _16Red;
            RedBlock[17] = _17Red;
            #endregion
            Canvas.SetZIndex(Red[9], 1);
            Canvas.SetZIndex(Green[4], 1);
            Canvas.SetZIndex(Red[10], 1);
           
        }


        private void Grid_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)//Wait for click
        {
            if (e.LeftButton == e.ButtonState)//Looking for left button
            {
                var windowPosition = Mouse.GetPosition(this);//Take position of mouse from window
                //Finding what station was choosen
                for (int i = 0; i < Green.Length; i++)
                {
                    Ellipse VARIABLE = Green[i];
                    if (windowPosition.X < Canvas.GetLeft(VARIABLE) ||
                        (windowPosition.X > Canvas.GetLeft(VARIABLE) + 30) ||
                        (windowPosition.Y < Canvas.GetTop(VARIABLE)) ||
                        (windowPosition.Y > Canvas.GetTop(VARIABLE) + 30))
                    {

                    }

                    else
                    {
                        if (VARIABLE.Fill != Brushes.MediumVioletRed && count < 2)
                        {
                            if (count == 0)
                            {
                                first = i;
                                firstBrushes = VARIABLE.Fill;
                            }
                            if (count == 1)
                            {
                                second = i;
                                secondBrushes = VARIABLE.Fill;
                            }

                            count++;
                            VARIABLE.Fill = Brushes.MediumVioletRed;
                            GreenBlock[i].Background = new SolidColorBrush(Colors.Black);
                            GreenBlock[i].Foreground = new SolidColorBrush(Colors.White);
                        }
                        else
                        {
                            if (VARIABLE.Fill == Brushes.MediumVioletRed && count < 3)
                            {
                                VARIABLE.Fill = Brushes.Green;
                                 GreenBlock[i].Background = null;
                                GreenBlock[i].Foreground = new SolidColorBrush(Colors.Black);
                                count--;
                                if (Brushes.Green == firstBrushes && first == i)
                                {
                                    firstBrushes = null;
                                    first = -1;
                                }
                                if (Brushes.Green == secondBrushes && second == i)
                                {
                                    secondBrushes = null;
                                    second = -1;
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < Blue.Length; i++)
                {
                    Ellipse VARIABLE = Blue[i];
                    if (windowPosition.X < Canvas.GetLeft(VARIABLE) ||
                        (windowPosition.X > Canvas.GetLeft(VARIABLE) + 30) ||
                        (windowPosition.Y < Canvas.GetTop(VARIABLE)) ||
                        (windowPosition.Y > Canvas.GetTop(VARIABLE) + 30))
                    {

                    }

                    else
                    {
                        if (VARIABLE.Fill != Brushes.MediumVioletRed && count < 2)
                        {
                            if (count == 0)
                            {
                                first = i;
                                firstBrushes = VARIABLE.Fill;
                            }
                            if (count == 1)
                            {
                                second = i;
                                secondBrushes = VARIABLE.Fill;
                            }

                            count++;
                            BlueBlock[i].Background = new SolidColorBrush(Colors.Black);
                            BlueBlock[i].Foreground = new SolidColorBrush(Colors.White);
                            VARIABLE.Fill = Brushes.MediumVioletRed;
                        }
                        else
                        {
                            if (VARIABLE.Fill == Brushes.MediumVioletRed && count < 3)
                            {
                               BlueBlock[i].Background = null;
                                BlueBlock[i].Foreground = new SolidColorBrush(Colors.Black);
                                VARIABLE.Fill = Brushes.Blue;
                                count--;
                                if (Brushes.Blue == firstBrushes && first == i)
                                {
                                    firstBrushes = null;
                                    first = -1;
                                }
                                if (Brushes.Blue == secondBrushes && second == i)
                                {
                                    secondBrushes = null;
                                    second = -1;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < Red.Length; i++)
                {
                    Ellipse VARIABLE = Red[i];
                    if (windowPosition.X < Canvas.GetLeft(VARIABLE) ||
                        (windowPosition.X > Canvas.GetLeft(VARIABLE) + 30) ||
                        (windowPosition.Y < Canvas.GetTop(VARIABLE)) ||
                        (windowPosition.Y > Canvas.GetTop(VARIABLE) + 30))
                    {

                    }

                    else
                    {
                        if (VARIABLE.Fill != Brushes.MediumVioletRed && count < 2)
                        {
                            if (count == 0)
                            {
                                first = i;
                                firstBrushes = VARIABLE.Fill;
                            }
                            if (count == 1)
                            {
                                second = i;
                                secondBrushes = VARIABLE.Fill;
                            }

                            count++;
                            VARIABLE.Fill = Brushes.MediumVioletRed;
                            RedBlock[i].Background = new SolidColorBrush(Colors.Black);
                            RedBlock[i].Foreground = new SolidColorBrush(Colors.White);
                        }
                        else
                        {
                            if (VARIABLE.Fill == Brushes.MediumVioletRed && count < 3)
                            {
                                RedBlock[i].Background = null;
                                RedBlock[i].Foreground = new SolidColorBrush(Colors.Black);
                                VARIABLE.Fill = Brushes.Red;
                                count--;
                                if (Brushes.Red == firstBrushes && first == i)
                                {
                                    firstBrushes = null;
                                    first = -1;
                                }
                                if (Brushes.Red == secondBrushes && second == i)
                                {
                                    secondBrushes = null;
                                    second = -1;
                                }
                            }
                        }
                    }
                }
                //Try build our road from first station to second if it is possible
                if (count == 2 && first != -1 && second != -1 && firstBrushes != null && secondBrushes != null)
                {
                    if (firstBrushes == secondBrushes)//color of stations is same
                    {
                        if (first - second > 0)
                        { 

                            if (firstBrushes == Brushes.Green)
                            {
                                for (int i = second; i < first ; i++)
                                {
                                    GreenLine[i].Stroke = Brushes.Lime;
                                }
                                if ((first > 3 && second <= 3)|| (first <3 && second >= 3))
                                {
                                    Gr1.Stroke = Brushes.Lime;
                                    Canvas.SetZIndex(Red[9], 0);
                                    Canvas.SetZIndex(Gr1,1);
                                    Gr1.Opacity = 1;
                                    Red[9].Opacity = 0.25;
                                }
                            }
                            if (firstBrushes == Brushes.Blue)
                            {
                                for (int i = second; i < first ; i++)
                                {
                                    BlueLine[i].Stroke = Brushes.Lime;
                                }
                                    if ((first >= 8 && second <= 8) || (first < 8 && second >= 8))
                                    {
                                        Bl1.Stroke = Brushes.Lime;
                                        Canvas.SetZIndex(Green[4], 0);
                                        Canvas.SetZIndex(Bl1, 1);
                                        Bl1.Opacity = 1;
                                        Green[4].Opacity = 0.25;
                                    }
                                if ((first > 7 && second <= 7) || (first < 7 && second >= 7))
                                {
                                    Rd1.Stroke = Brushes.Lime;
                                    Canvas.SetZIndex(Red[10], 0);
                                    Canvas.SetZIndex(Rd1, 1);
                                    Rd1.Opacity = 1;
                                    Red[10].Opacity = 0.25;
                                }
                            }

                            if (firstBrushes == Brushes.Red)
                            {
                                for (int i = second; i < first; i++)
                                {
                                    RedLine[i].Stroke = Brushes.Lime;
                                }

                            }
                        }

                        if (first - second < 0)
                        {

                            if (firstBrushes == Brushes.Green)
                            {
                                for (int i = first; i < second; i++)
                                {
                                    GreenLine[i].Stroke = Brushes.Lime;
                                }
                                if ((first >= 3 && second < 3) || (first <= 3 && second > 3))
                                {
                                    Gr1.Stroke = Brushes.Lime;
                                    Canvas.SetZIndex(Red[9], 0);
                                    Canvas.SetZIndex(Gr1, 1);
                                    Gr1.Opacity = 1;
                                    Red[9].Opacity = 0.25;
                                }
                            }
                            if (firstBrushes == Brushes.Blue)
                            {
                                for (int i = first; i < second ; i++)
                                {
                                    BlueLine[i].Stroke = Brushes.Lime;
                                }

                                    if ((first >= 8 && second < 8) || (first <8 && second >= 8))
                                    {

                                        Bl1.Stroke = Brushes.Lime;
                                        Canvas.SetZIndex(Green[4], 0);
                                        Canvas.SetZIndex(Bl1, 1);
                                        Bl1.Opacity = 1;
                                        Green[4].Opacity = 0.25;
                                    }
                                if ((first >= 7 && second < 7) || (first <= 7 && second > 7))
                                {
                                    Rd1.Stroke = Brushes.Lime;
                                    Canvas.SetZIndex(Red[10], 0);
                                    Canvas.SetZIndex(Rd1, 1);
                                    Rd1.Opacity = 1;
                                    Red[10].Opacity = 0.25;
                                }
                            }

                            if (firstBrushes == Brushes.Red)
                            {
                                for (int i = first; i < second; i++)
                                {
                                    RedLine[i].Stroke = Brushes.Lime;
                                }
                            }


                        }
                    }

                    if (firstBrushes != secondBrushes)//color of stations is not same
                    {
                        if (firstBrushes == Brushes.Red && secondBrushes == Brushes.Green)
                        {
                            GreenRed.Fill = Brushes.Lime;
                            Canvas.SetZIndex(Green[3], 1);
                            Canvas.SetZIndex(Red[9], 1);
                            if (first <= 9)
                            {
                                for (int i = first; i < 9; i++)
                                {
                                    RedLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (first > 9)
                            {
                                for (int i = 9; i < first; i++)
                                {
                                    RedLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (second <= 3)
                            {
                                for (int i = second; i < 3; i++)
                                {
                                    GreenLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (second > 3)
                            {
                                for (int i = 3; i < second ; i++)
                                {
                                    GreenLine[i].Stroke = Brushes.Lime;
                                }
                            }

                        }
                        if (firstBrushes == Brushes.Green && secondBrushes == Brushes.Red)
                        {
                            GreenRed.Fill = Brushes.Lime;
                            Canvas.SetZIndex(Green[3], 1);
                            Canvas.SetZIndex(Red[9], 1);
                            if (second <= 9)
                            {
                                for (int i = second; i < 9; i++)
                                {
                                    RedLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (second > 9)
                            {
                                for (int i = 9; i < second; i++)
                                {
                                    RedLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (first < 3)
                            {
                                for (int i = first; i < 3; i++)
                                {
                                    GreenLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (first > 3)
                            {
                                for (int i = 3; i < first ; i++)
                                {
                                    GreenLine[i].Stroke = Brushes.Lime;
                                }
                            }

                        }
                        if (firstBrushes == Brushes.Red && secondBrushes == Brushes.Blue)
                        {
                            BlueRed.Fill = Brushes.Lime;
                            Canvas.SetZIndex(Red[10], 1);
                            Canvas.SetZIndex(Blue[7], 1);
                            if (first <= 10)
                            {
                                for (int i = first; i < 10; i++)
                                {
                                    RedLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (first > 10)
                            {
                                for (int i = 10; i < first; i++)
                                {
                                    RedLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (second <= 7)
                            {
                                for (int i = second; i < 7; i++)
                                {
                                    BlueLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (second > 7)
                            {
                                for (int i = 7; i < second ; i++)
                                {
                                    BlueLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (second > 7)
                            {
                                Bl1.Stroke = Brushes.Lime;
                                Canvas.SetZIndex(Green[4], 0);
                                Canvas.SetZIndex(Bl1, 1);
                                Bl1.Opacity = 1;
                                Green[4].Opacity = 0.25;
                            }
                        }
                        if (secondBrushes == Brushes.Red && firstBrushes == Brushes.Blue)
                        {
                            BlueRed.Fill = Brushes.Lime;
                            Canvas.SetZIndex(Red[10], 1);
                            Canvas.SetZIndex(Blue[7], 1);
                            if (second <= 10)
                            {
                                for (int i = second; i < 10; i++)
                                {
                                    RedLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (second > 10)
                            {
                                for (int i = 10; i < second; i++)
                                {
                                    RedLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (first <= 7)
                            {
                                for (int i = first; i < 7; i++)
                                {
                                    BlueLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (first > 7)
                            {
                                for (int i = 7; i < first; i++)
                                {
                                    BlueLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (first>7)
                            {
                                Bl1.Stroke = Brushes.Lime;
                                Canvas.SetZIndex(Green[4], 0);
                                Canvas.SetZIndex(Bl1, 1);
                                Bl1.Opacity = 1;
                                Green[4].Opacity = 0.25;
                            }
                        }
                        if (firstBrushes == Brushes.Blue && secondBrushes == Brushes.Green)
                        {
                            BlueGreen.Fill = Brushes.Lime;
                            Canvas.SetZIndex(Green[4], 1);
                            Canvas.SetZIndex(Blue[8], 1);
                            if (second <= 4)
                            {
                                for (int i = second; i < 4; i++)
                                {
                                    GreenLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (second > 4)
                            {
                                for (int i = 4; i < second; i++)
                                {
                                    GreenLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (first <= 8)
                            {
                                for (int i = first; i < 8; i++)
                                {
                                    BlueLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (first > 8)
                            {
                                for (int i = 8; i < first; i++)
                                {
                                    BlueLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            //TODO:
                            if (first < 8)
                            {
                                Rd1.Stroke = Brushes.Lime;
                                Canvas.SetZIndex(Red[10], 0);
                                Canvas.SetZIndex(Rd1, 1);
                                Rd1.Opacity = 1;
                                Red[10].Opacity = 0.25;
                            }
                            if (second < 4)
                            {
                                Gr1.Stroke = Brushes.Lime;
                                Canvas.SetZIndex(Red[9], 0);
                                Canvas.SetZIndex(Gr1, 1);
                                Gr1.Opacity = 1;
                                Red[9].Opacity = 0.25;
                            }
                        }
                        if (firstBrushes == Brushes.Green && secondBrushes == Brushes.Blue)
                        {
                            BlueGreen.Fill = Brushes.Lime;
                            Canvas.SetZIndex(Green[4], 1);
                            Canvas.SetZIndex(Blue[8], 1);
                            if (first <= 4)
                            {
                                for (int i = first; i < 4; i++)
                                {
                                    GreenLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (first > 4)
                            {
                                for (int i = 4; i < first - 1; i++)
                                {
                                    GreenLine[i].Stroke = Brushes.Lime;
                                }

                            }
                            if (second <= 8)
                            {
                                for (int i = second; i < 8; i++)
                                {
                                    BlueLine[i].Stroke = Brushes.Lime;
                                }
                            }
                            if (second > 8)
                            {
                                for (int i = 8; i < second ; i++)
                                {
                                    BlueLine[i].Stroke = Brushes.Lime;
                                }

                            }
                            if (second< 8)
                            {
                                Rd1.Stroke = Brushes.Lime;
                                Canvas.SetZIndex(Red[10], 0);
                                Canvas.SetZIndex(Rd1, 1);
                                Rd1.Opacity = 1;
                                Red[10].Opacity = 0.25;
                            }
                            if (first < 4)
                            {
                                Gr1.Stroke = Brushes.Lime;
                                Canvas.SetZIndex(Red[9], 0);
                                Canvas.SetZIndex(Gr1, 1);
                                Gr1.Opacity = 1;
                                Red[9].Opacity = 0.25;
                            }
                        }
                    }
                }

                if (count < 2)//Clear all road that was bult
                {
                    foreach (var VARIABLE in GreenLine)
                    {
                        VARIABLE.Stroke = Brushes.Green;
                    }
                    foreach (var VARIABLE in BlueLine)
                    {
                        VARIABLE.Stroke = Brushes.Blue;
                    }
                    foreach (var VARIABLE in RedLine)
                    {
                        VARIABLE.Stroke = Brushes.Red;
                    }
                    GreenRed.Fill = null;
                    BlueGreen.Fill = null;
                    BlueRed.Fill = null;
                     Gr1.Stroke = Brushes.Green;
                        Canvas.SetZIndex(Red[9], 1);
                        Canvas.SetZIndex(Gr1, 0);
                        Gr1.Opacity = 0.25;
                        Red[9].Opacity = 1;
                        Canvas.SetZIndex(Green[4], 1);
                        Canvas.SetZIndex(Bl1, 0);
                        Bl1.Opacity = 0.25;
                    Green[4].Opacity = 1;
                    Rd1.Stroke = Brushes.Blue;
                    Canvas.SetZIndex(Red[10], 1);
                    Canvas.SetZIndex(Rd1, 0);
                    Rd1.Opacity = 0.25;
                    Red[10].Opacity = 1;
                    Bl1.Stroke = Brushes.Blue;

 
                }
            }
        }

    }
}
                   
            
            

        
   

