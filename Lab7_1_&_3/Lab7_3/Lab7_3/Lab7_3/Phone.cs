using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_3
{
    class Phone : MusicFile, MusicPlayerInterface, RadioPlayerInterface
    {
        private MusicFile[] musicFiles;
        

        

        public void play(bool on)
        {
            if (on == true)
            {
                Console.WriteLine("Playing music on phone...");
            }
            else
            {          
                Console.WriteLine("Not playing music on phone...");
                    
            }

        }

        public void changeChannel()
        {
            Console.WriteLine("Channel is changing...");
        }


        public void retune(double frequency)
        {
            Console.WriteLine("Current frequency on Radio: " + frequency + " FM");
        }


        public void SetVolume(int loudness)
        {
            Console.WriteLine("Volume: " + loudness);
        }

        public void Switch(bool on)
        {
            if (on == true)
            {
                Console.WriteLine("On...");
            }
            else
            {                 
                 Console.WriteLine("Off...");
            }
        }
        private int musicCount;
        public int MusicCount
        {
            get { return musicCount; }
            set { musicCount = value; }
        }

        public Phone()
        {
            musicCount = 0;
            musicFiles = new MusicFile[500];

        }
        public Phone(string title, string artist, int yearOfRelease, int durationInSeconds) : base(title, artist, yearOfRelease, durationInSeconds)
        {
            musicCount = 0;
            musicFiles = new MusicFile[500];
        }

        public void AddMusicFile(params MusicFile[] musicFiles)
        {
            foreach (var music in musicFiles)
            {
                if (musicCount < 500)
                {
                    this.musicFiles[musicCount++] = music;
                }
                else
                {
                    Console.WriteLine("Storage full...");
                }
            }
        }

        public void ShowAllMusicFile()
        {
            for (int i = 0; i < musicCount; i++)
            {
                this.musicFiles[i].ShowInfo();

            }
        }


        public void playNext()
        {
            Console.WriteLine("|>> Music: ");
        }


        


        public void playPrevious()
        {
            Console.WriteLine("<<| Music: ");
        }
                

    }
}
