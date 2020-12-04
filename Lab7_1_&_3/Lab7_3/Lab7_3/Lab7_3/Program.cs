using System;

namespace Lab7_3
{
    class Program
    { 
           static void Main(string[] args)
           {
                RadioPlayerInterface radio = new Phone();
                radio.Switch(true);
                radio.retune(89.6);
                radio.SetVolume(70);
                radio.changeChannel();
                Console.WriteLine();



                MusicFile music1 = new MusicFile("Love me Two Times", "Karim", 2003, 5);
                MusicFile music2 = new MusicFile("Time is on my Side", "Ahsan", 2004, 6);
                MusicFile music3 = new MusicFile("Time of my Life", "Manna", 2005, 4);
                Phone phone = new Phone();
                phone.Switch(true);
                phone.play(true);
                Console.WriteLine("Adding Musics...");
                Console.WriteLine();
                phone.AddMusicFile(music1, music2, music3);
                phone.ShowAllMusicFile();
                Console.WriteLine();
                phone.SetVolume(90);

                Console.WriteLine(" ");
                



            }
    }
}
