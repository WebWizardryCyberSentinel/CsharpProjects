using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoops
{
    public partial class timetostartcoding : Form
    {
        public timetostartcoding()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Code voor Buttonclick  Quick Mafs!:)
            string name = "Martin";
            int x = 3; //int x met waarde van 3
            x = x * 17; // verander waarde van x in 3x17
            double d = Math.PI / 2;  //int met decimale , PI delen door 2
            MessageBox.Show("Name is " + name //Toont messagebox met naam, plus waardes van variabele x en D.
                + "\nX is " + x
                + "\nD is " + d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5; //variabele int X met waarde 5
            if (x == 10) // als conditie, als x gelijk is aan tien
            {
                MessageBox.Show("x is  10"); //Toon messagebox x is 10
            }
            else // else conditie, als x niet gelijk is aan 10
            {
                MessageBox.Show("x isn't 10"); // toon messagebox x is niet gelijk aan tien
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Somevalue = 4; //variabalen int SomeValue met waarde 4
            string name = "Bobo Jr."; //string name met waarde BoBo Jr.
            if ((Somevalue == 3) && (name == "Joe")) // if statement met expressions als Somevalue gelijk is aan 3 en name gelijk aan Joe
            {
                MessageBox.Show("SomeValue is 3 and name is Joe");// toon message box SomeValue is 3 and name is Joe
            }
            MessageBox.Show("This line runs because SomeValue isn't 3 and name isn't Joe.");//anders  toon messagebox this line runs because SomeValue isn't 3 and name isn't Joe.
        }
      

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0; // int count met waarde 0
            while(count < 10) ; //while loop, als count kleiner is als 10
            {
                count = count + 1; //verander count en voeg 1 toe
            }
            for int(i = 0; i < 5; i++) // for loop int i is gelijk aan nul. als i kleiner is als vijf increment i met 1
            {
                count = count -1 //als i < 5 - 1 op count
            }

            MessageBox.Show("The answer is " + count) // toont messagebox met antwoord is int count.
        }


    }
}
