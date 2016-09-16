using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethodPattern
{
    public partial class Form1 : Form
    {
        string fileName;
        ConcreteFactory factory = new ConcreteFactory();
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnCreateTextFile_Click(object sender, EventArgs e)
        {
            fileName = tbFileName.Text;
            string text = tbUserText.Text;
            factory.createFile("Text File", fileName, text);
        }

        private void btnCSVFile_Click(object sender, EventArgs e)
        {
            fileName = tbFileName.Text;
            string text = tbUserText.Text;
            factory.createFile("CSV File", fileName, text);
        }
    }
}
