using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiation
{
    public partial class ScreenSaver : Form
    {
        public ScreenSaver()
        {
            InitializeComponent();
            //axWindowsMediaPlayer1.
        }

        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            //SoundPlayer sp = new SoundPlayer(@"D:\Lm\Ld\What if We Nuke a City[music] (online-audio-converter.com).wav");
            //sp.Play();

            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = @"D:\Lm\Ld\What if We Nuke a City (audio-extractor.net) [music].mp3";
            wplayer.controls.play();

            //axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
