using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecast
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 0 - Sunny, 1 - Cloudy, 2 -Rainy
        /// </summary>
        private Bitmap MyImage;
        public Random rnd;
        int DayControll = 0;
        public float[,] Matrix_P =  { { 0.3f, 0.4f, 0.3f }, { 0.2f, 0.6f, 0.2f },{ 0.1f,0.4f,0.5f} };
        public List<int> Freq = new List<int>();
        public int CurrentState = 1;
        public int StateToChange;
        const string pathToRain = "Rain.jpg", pathToSunny = "Sunny.jpg", pathToCloudy = "Cloudy.jpg";
        const int xSize = 100, ySize = 100;
        public List<float> values = new List<float>();
        public Form1()
        {
            InitializeComponent();
            //timer1.Enabled = true;
            timer1.Interval = 1000;
            rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                Freq.Add(0);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (DayControll)
            {
                case 0:
                    DayPeriodLbl.Text = "Morning";
                    DayControll++;
                    break;
                case 1:
                    DayPeriodLbl.Text = "Day";
                    DayControll++;
                    break;
                case 2:
                    DayPeriodLbl.Text = "Evening";
                    int DayNumb = Int32.Parse(DayNumbLbl.Text);
                    DayNumb++;
                    DayNumbLbl.Text = DayNumb.ToString();
                    SunnyLbl.Text = ((float)Freq[0] / (float)DayNumb).ToString();
                    CloudyLbl.Text = ((float)Freq[1] / (float)DayNumb).ToString();
                    RainyLbl.Text = ((float)Freq[2] / (float)DayNumb).ToString();
                    DayControll = 0;
                    break;
                default:
                    break;
            }
            
            
            values.Clear();
            for (int i = 0; i < 3; i++)
            {
                values.Add(Matrix_P[CurrentState, i]);
                
            }
            StateToChange = filler();
            Freq[StateToChange]++;
            Console.WriteLine(StateToChange);
            switch (StateToChange)
            {
                case 0:
                    DisplayImage(pathToSunny);
                    break;
                case 1:
                    DisplayImage(pathToCloudy);
                    break;
                case 2:
                    DisplayImage(pathToRain);
                    break;
                default:
                    break;
            }

            


        }
        int filler()
        {
            double A = 0;
            int k = 0;
            A = rnd.NextDouble();

            k = 0;
            foreach (var value in values)
            {
                A -= value;
                if (A <= 0)
                {

                    break;
                }
                k++;
            }

            return k;
        }

        public void DisplayImage(String fileToDisplay)
        {
            // Sets up an image object to be displayed.
            if (MyImage != null)
            {
                MyImage.Dispose();
            }

            // Stretches the image to fit the pictureBox.
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            MyImage = new Bitmap(fileToDisplay);
            pictureBox1.ClientSize = new Size(xSize, ySize);
            pictureBox1.Image = (Image)MyImage;
        }
        public void StatCollector()
        {

        }
    }
}
