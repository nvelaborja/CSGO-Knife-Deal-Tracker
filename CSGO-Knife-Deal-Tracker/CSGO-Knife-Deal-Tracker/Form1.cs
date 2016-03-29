using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace CSGO_Knife_Deal_Tracker
{
    public partial class mainForm : Form
    {
        private List<Knife> knives;
        private string baseURL;
        private bool execute;
        private SoundPlayer sound;

        public mainForm()
        {
            InitializeComponent();

            knives = new List<Knife>();

            InitializeKnives();

            textBoxURLBase.Text = baseURL;

            timer.Interval = (int)RefreshInterval.Value * 1000;

            execute = false;

            knifeGrid.DefaultCellStyle.ForeColor = Color.Black;

            sound = new SoundPlayer(Application.StartupPath + "\\..\\..\\air-horn-club-sample_1.wav");
        }

        private void InitializeKnives()
        {
            StreamReader reader = new StreamReader(Application.StartupPath + "\\..\\..\\URLs.txt");
            List<string> linePieces = new List<string>();
            string line;

            while(!reader.EndOfStream)
            {
                line = reader.ReadLine();

                linePieces = line.Split(',').ToList();

                if (linePieces[0] == "BaseURL")
                {
                    baseURL = linePieces[1];
                }
                else if (linePieces[0] == "KnifeURL")
                {
                    Knife newKnife = new Knife(baseURL, linePieces[1], (int)percentage.Value);
                    knives.Add(newKnife);
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            execute = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            execute = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (execute)
            {
                knifeGrid.Rows.Clear();

                foreach (Knife knife in knives)
                {
                    knife.Update();
                    knifeGrid.Rows.Add();
                    knifeGrid.Rows[knifeGrid.Rows.Count - 1].Cells[0].Value = knife.Name;
                    knifeGrid.Rows[knifeGrid.Rows.Count - 1].Cells[1].Value = knife.KnifeURL;
                    knifeGrid.Rows[knifeGrid.Rows.Count - 1].Cells[2].Value = knife.MedPrice;
                    knifeGrid.Rows[knifeGrid.Rows.Count - 1].Cells[3].Value = knife.LowPrice;
                    knifeGrid.Rows[knifeGrid.Rows.Count - 1].Cells[4].Value = knife.DesiredPrice;
                    
                    if (knife.LowPrice <= knife.DesiredPrice)
                    {
                        messageBoard.ForeColor = Color.Pink;
                        messageBoard.Items.Add(knife.Name);
                        messageBoard.ForeColor = Color.White;
                        sound.Play();
                    }
                    else if (knife.LowPrice != knife.PrevLow)
                    {
                        messageBoard.Items.Add(knife.Name + " Has changed price.");
                        SystemSounds.Beep.Play();
                    }
                }
            }
        }

        private void RefreshInterval_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = (int)RefreshInterval.Value * 1000;
        }

        private void percentage_ValueChanged(object sender, EventArgs e)
        {
            foreach (Knife knife in knives)
            {
                knife.Percentage = (int)percentage.Value;
            }
        }

        private void buttonDismissMessage_Click(object sender, EventArgs e)
        {
            messageBoard.Items.Clear();
        }
    }
}
