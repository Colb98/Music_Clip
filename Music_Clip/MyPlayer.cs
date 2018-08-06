using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Clip
{
    class MyPlayer
    {
        public System.Windows.Media.MediaPlayer player;
        public TimeSpan duration;
        bool play = false;

        public TimeSpan Position()
        {
            if (!play)
                return new TimeSpan(0);

            return player.Position;
        }

        public MyPlayer(string path)
        {
            player = new System.Windows.Media.MediaPlayer();
            player.Open(new Uri(path, UriKind.Absolute));
            player.Play();

            duration = GetVideoDuration(path);
        }

        public MyPlayer()
        {

        }

        public void Open(string path)
        {
            player = new System.Windows.Media.MediaPlayer();
            player.Open(new Uri(path, UriKind.Absolute));
            player.Play();

            duration = GetVideoDuration(path);
        }

        private static TimeSpan GetVideoDuration(string filePath)
        {
            using (var shell = Microsoft.WindowsAPICodePack.Shell.ShellObject.FromParsingName(filePath))
            {
                Microsoft.WindowsAPICodePack.Shell.PropertySystem.IShellProperty prop = shell.Properties.System.Media.Duration;
                var t = (ulong)prop.ValueAsObject;
                return TimeSpan.FromTicks((long)t);
            }
        }

    }
}
