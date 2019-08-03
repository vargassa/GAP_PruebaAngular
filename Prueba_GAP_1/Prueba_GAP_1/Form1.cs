using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_GAP_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void ClicMerge(object sender, EventArgs e)
        {
            txtMerge.Text = MergeText();            
        }
        
        private String MergeText()
        {
            int maxCount = 0;
            String resume = "";
            char[] FirstText = txtTexto1.Text.ToString().ToCharArray();
            char[] SecondText = txtTexto2.Text.ToString().ToCharArray();

            if (FindTextMostBigger(FirstText, SecondText) == 1)
                maxCount = FirstText.Length;
            else
                maxCount = SecondText.Length;

            int initialCount = 0;
            while (initialCount <= maxCount)
            {
               if (initialCount < FirstText.Length)
                    resume += FirstText[initialCount];

               if (initialCount < SecondText.Length)
                    resume += SecondText[initialCount];

               initialCount++;
            }

            return resume;
        }

        private int FindTextMostBigger(char[] pCount1, char[] pCount2)
        {
            if (pCount1.Length > pCount2.Length)
                return 1;
            else  
                return 2;            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMerge.Text = "";
            txtTexto1.Text = "";
            txtTexto2.Text = "";
        }
    }
}
