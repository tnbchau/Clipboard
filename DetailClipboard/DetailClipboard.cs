using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetailClipboard
{
    public partial class DetailClipboard : Form
    {
        public DetailClipboard(string content)
        {
            InitializeComponent();
            textBox1.Text = content;
        }

        private void DetailClipboard_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
