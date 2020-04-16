using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upravljac
{
    public partial class frmPlayer : Form
    {
        public frmPlayer()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Započeli ste muziku");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            
            MediaPlayer Stop = new MediaPlayer();

            Stop.setIsStopped(Stop.getIsStopped());
            Console.WriteLine($"Zaustavili ste medij");
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            MediaPlayer Fast = new MediaPlayer();

            Fast.setFastForward(Fast.getFastForward());
            Console.WriteLine($"Ubrzali ste medij");

        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            MediaPlayer Backwards = new MediaPlayer();

            Backwards.setFastReverse(Backwards.getFastReverse());
            Console.WriteLine($"Ubrzali ste medij");

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            MediaPlayer Pause = new MediaPlayer();

            Pause.setIsPaused(Pause.getIsPaused());
            Console.WriteLine($"Pauzirali ste medij");
        }
    }
}
