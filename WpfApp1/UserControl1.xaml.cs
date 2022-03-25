using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private DispatcherTimer dt = new DispatcherTimer();
        private bool ExitDt = false;
        private int tbycount = 0;
        private double y = 0;
        private int xinitoffset = 0;
        public UserControl1()
        {
            InitializeComponent();            
            this.SizeChanged += UserControl1_ScaleChanged;
        }
        private void UserControl1_ScaleChanged(object sender, SizeChangedEventArgs e)
        {
            tbycount = (int)this.ActualHeight / 50;
            yGrid.Children.Clear();
            for (int i = 0; i < tbycount; i++)
            {
                TextBlock tb = new TextBlock();
                tb.HorizontalAlignment = HorizontalAlignment.Center;
                tb.Text = (yScaleInterval * (tbycount - i - 1) - yScaleStart).ToString();
                tb.Margin = new Thickness(0, i * 50, 0, 0);
                yGrid.Children.Add(tb);
            }
            //X Axis Display changes to display system time
            //xCanvas.Children.Clear();
            //for (int i = 0; i < tbxcount; i++)
            //{
            //    TextBlock tb = new TextBlock();
            //    tb.Text = (i * xScaleInterval + xScaleStart).ToString();
            //    tb.Margin = new Thickness(i * 50, 0, 0, 0);
            //    xCanvas.Children.Add(tb);
            //}
        }

        #region axis scale start move or stop
        public void CollectionStart()
        {
            if (ExitDt)
            {
                dt.IsEnabled = true;
            }
            else
            {
                dt.Interval = TimeSpan.FromMilliseconds(ReFreshInterval);
                dt.Tick += Dt_Tick;
                dt.IsEnabled = true;
                ExitDt = true;
            }
        }
        private void Dt_Tick(object sender, EventArgs e)
        {

            myPolyLine.Points.Add(new Point((double)-xinitoffset+ LetfBlankSpace, yValue));
            y += 0.01;            
            if (xinitoffset % DisplayxLabelInterval == 0)
            {
                TextBlock tb = new TextBlock();
                tb.Text = DateTime.Now.ToString("T");
                tb.Margin = new Thickness(-xinitoffset + LetfBlankSpace - 25, 0, 0, 0);
                this.xCanvas.Children.Add(tb);
            }
            if (xinitoffset <=-DisplayLineWidth)
            {
                this.myCanvas.Margin = new Thickness(xinitoffset+ DisplayLineWidth, 0, 0, 0);
                this.xCanvas.Margin = new Thickness(xinitoffset+ DisplayLineWidth, 0, 0, 0);
                myPolyLine.Points.RemoveAt(0);
                if (xinitoffset % DisplayxLabelInterval == 0)
                {
                    this.xCanvas.Children.RemoveAt(0);
                }              
            }
            xinitoffset = xinitoffset - 1;
            //this.myCanvas.Margin = new Thickness(xinitoffset, 0, 0, 0);
            //this.xCanvas.Margin = new Thickness(xinitoffset, 0, 0, 0);
        }
        public void CollectionStop()
        {
            dt.IsEnabled = false;
        }
        #endregion


        public int yScaleStart
        {
            get { return (int)GetValue(yScaleStartProperty); }
            set { SetValue(yScaleStartProperty, value); }
        }

        // Using a DependencyProperty as the backing store for yScaleStart.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty yScaleStartProperty =
            DependencyProperty.Register("yScaleStart", typeof(int), typeof(UserControl1), new PropertyMetadata(0));



        public int yScaleInterval
        {
            get { return (int)GetValue(yScaleIntervalProperty); }
            set { SetValue(yScaleIntervalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for yScaleInterval.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty yScaleIntervalProperty =
            DependencyProperty.Register("yScaleInterval", typeof(int), typeof(UserControl1), new PropertyMetadata(50));



        public int DisplayLineWidth
        {
            get { return (int)GetValue(DisplayLineWidthProperty); }
            set { SetValue(DisplayLineWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisplayLineWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisplayLineWidthProperty =
            DependencyProperty.Register("DisplayLineWidth", typeof(int), typeof(UserControl1), new PropertyMetadata(100));



        public int DisplayxLabelInterval
        {
            get { return (int)GetValue(DisplayxLabelIntervalProperty); }
            set { SetValue(DisplayxLabelIntervalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisplayxLabelInterval.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisplayxLabelIntervalProperty =
            DependencyProperty.Register("DisplayxLabelInterval", typeof(int), typeof(UserControl1), new PropertyMetadata(50));



        public double yValue
        {
            get { return (double)GetValue(yValueProperty); }
            set { SetValue(yValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for yValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty yValueProperty =
            DependencyProperty.Register("yValue", typeof(double), typeof(UserControl1), new PropertyMetadata(0.0));




        public int ReFreshInterval
        {
            get { return (int)GetValue(ReFreshIntervalProperty); }
            set { SetValue(ReFreshIntervalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ReFreshInterval.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ReFreshIntervalProperty =
            DependencyProperty.Register("ReFreshInterval", typeof(int), typeof(UserControl1), new PropertyMetadata(50));




        public int LetfBlankSpace
        {
            get { return (int)GetValue(LetfBlankSpaceProperty); }
            set { SetValue(LetfBlankSpaceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LetfBlankSpace.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LetfBlankSpaceProperty =
            DependencyProperty.Register("LetfBlankSpace", typeof(int), typeof(UserControl1), new PropertyMetadata(100));





    }
}
