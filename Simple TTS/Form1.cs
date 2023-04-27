using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Simple_TTS
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer speech;
        public Form1()
        {
            InitializeComponent();
            speech = new SpeechSynthesizer();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                speech.SpeakAsync(textBox1.Text);
            }
        }
    }
}
