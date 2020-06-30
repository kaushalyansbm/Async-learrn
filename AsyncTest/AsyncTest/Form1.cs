using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int StringCounter() {
            int count = 0;
           

               
                using (StreamReader SM = new StreamReader("C:\\Users\\Kaushalya.h\\source\\repos\\AsyncTest\\AsyncTest\\x.txt"))
                {

                    
                    string counter = SM.ReadToEnd();
                    count = counter.Length;
                    Thread.Sleep(7000);




                }
           
            return count;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
          Task<int> x = new Task<int>(StringCounter);
            x.Start();
            label1.Text = "still processing";
            int count =await x;
            label1.Text = count.ToString() + "numberof characters";

        }
    }
}
