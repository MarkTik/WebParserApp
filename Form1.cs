using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Drawing;


namespace WebParser
{
    public partial class Form1 : Form
    {
        
         
        public Form1()
        {   
            InitializeComponent();

           



        } 
        
        
        private void HTML_Edit_Button_Click(object sender, EventArgs e)
        { 

            Edit_Form.HTMLForm.ShowDialog();

        }

        private void CSS_Edit_Button_Click(object sender, EventArgs e)
        {
            Edit_Form.CSSForm.ShowDialog();
            
        }

        private void JS_Edit_Button_Click(object sender, EventArgs e)
        {
            Edit_Form.JSForm.ShowDialog();
        }
    }
}
