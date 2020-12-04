using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_3
{
    interface MusicPlayerInterface
    {
        void Switch(bool on);
        void play(bool on);
        void SetVolume(int loudness);
        void playNext();
        void playPrevious();
    }
}
