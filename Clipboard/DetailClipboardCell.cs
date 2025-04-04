using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipboard
{
    public partial class DetailClipboardCell : Form
    {
        private static DetailClipboardCell _instance; // Thể hiện duy nhất của form

        public static DetailClipboardCell Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new DetailClipboardCell();
                }
                return _instance;
            }
        }

        private DetailClipboardCell() 
        {
            InitializeComponent();
        }
        public void SetClipboardText(string text)
        {
            textBox1.Text = text;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
