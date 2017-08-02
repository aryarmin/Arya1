using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public string[] domains;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

      
            Class1 cs = new Class1();
          
            cs.search4();
             listBox3.Items.Add(cs.key1.ToString());


            }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 cs = new Class1();

            cs.search1();
            listBox3.Items.Add(cs.s.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 cs = new Class1();

            cs.search2();
            listBox3.Items.Add(cs.key.ToString());


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1 cs = new Class1();

            cs.seach3();
            listBox3.Items.Add(cs.p.ToString());
        }

       
    }

       

        
    }

