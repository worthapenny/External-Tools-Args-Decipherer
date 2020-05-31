using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExternalToolsArgsDecipherer
{
    public partial class Form1 : Form
    {
        public Form1(string[] args)
        {
            InitializeComponent();

            Text = "OpenFlows External Tools Arguments Viewer";
            Icon = IconExtractor.Extract("shell32.dll", 209, false);
            Args = args;
        }

        protected override void OnLoad(EventArgs e)
        {
            if (Args.Length <= 0)
                return;
                        
            Args = Args[0].Split('|');

            for (int i = 0; i < Args.Length; i++)
            {
                var message = $"{i}: {Args[i]} {Environment.NewLine}";

                textBox.AppendText( message);
                Console.WriteLine(message);
            }


            base.OnLoad(e);
        }


        private string[] Args { get; set; }
    }
}
