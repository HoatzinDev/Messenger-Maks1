using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger_Maks
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChatForm chat = new ChatForm("User1");
            chat.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChatForm chat = new ChatForm("User2");
            chat.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChatForm chat = new ChatForm("User3");
            chat.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChatForm chat = new ChatForm("Admin");
            chat.Show();
        }
    }
}
