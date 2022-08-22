using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace WebParser
{
    public partial class Edit_Form : Form
    {
        public static Edit_Form CSSForm { get; } = new Edit_Form() { Text = "CSS" };
        public static Edit_Form HTMLForm { get; } = new Edit_Form() { Text = "HTML" };
        public static Edit_Form JSForm { get; } = new Edit_Form() { Text = "JS" };

        private int c = 0;
        private static int widthOffset = 20;
        private static int topOffset = 10;
        private static int textBoxheight = 23;

        private static readonly string _applicationPath = @"C:\Users\Administrator\source\repos\WebParser\WebParser";
        private static readonly string _configsPath = _applicationPath + @"\configs";
        

        private bool _activated = false;
        private Edit_Form()
        {
            InitializeComponent();
            Activated += async (s, e) =>
            {
                if (!_activated)
                {
                    using StreamReader reader = new StreamReader(_configsPath + $@"\{Text}.txt");
                    string line = await reader.ReadLineAsync();
                    while (!(line is null))
                    {
                        panel.Controls.Add(BuildTextBox(line));
                        line = await reader.ReadLineAsync();
                    }
                    _activated = true;
                }
            };
            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Tab)
                    panel.Controls.Add(BuildTextBox(""));
            };

        }
        
       
        
        private void newButton_Click(object sender, EventArgs e)
        {
            panel.Controls.Add(BuildTextBox(""));
        }
        private TextBox BuildTextBox(string text)
        {
            return new TextBox()
            {
                Size = new Size(panel.Width - 2 * widthOffset, textBoxheight),
                Location = new Point(widthOffset, topOffset + c++ * textBoxheight),
                Text = text
            };
        }
        private async void applyButton_Click(object sender, EventArgs e)
        {
            using StreamWriter writer = new StreamWriter(_configsPath + $@"\{Text}.txt");
            writer.Flush();
            foreach (var _control in panel.Controls)
            {
                var text = (_control as TextBox).Text;
                if (text != "")
                    await writer.WriteLineAsync(text);
            }           
            Close();
        }
        
        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
