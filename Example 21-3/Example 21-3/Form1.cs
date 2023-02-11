using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//--------new------------------
//Add Reference System.Speech
using System.Speech;
using System.Speech.Synthesis;
//-----------------------------
namespace Example_21_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------------
        SpeechSynthesizer newSpeech = new SpeechSynthesizer();
        //----------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            newSpeech.Rate = 0;
            newSpeech.Volume = trackBarVolume.Value = 50;//mid
        }
        //----------------------------------------------------------------
        private void btnSpeech_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtWord.Text == "")
                    MessageBox.Show("Enter Word!!!");
                else
                    newSpeech.SpeakAsync(txtWord.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtWord.Focus();
        }
        //----------------------------------------------------------------
        private void trackBarRate_ValueChanged(object sender, EventArgs e)
        {
            newSpeech.Rate = trackBarRate.Value;
        }
        //----------------------------------------------------------------
        private void trackBarVolume_ValueChanged(object sender, EventArgs e)
        {
            newSpeech.Volume = trackBarVolume.Value;
        }        
    }
}
