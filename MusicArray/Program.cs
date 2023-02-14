
using System;
namespace music
{
    class Program
    {
        enum Genre
        {
            Pop,
            Rock,
            HipHop,
            Classical,
            Jazz
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            /*public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }*/
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength:" + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Please enter the song title?");
                    collection[i].setTitle(Console.ReadLine());
                    Console.WriteLine("Please enter the song artist?");
                    collection[i].setArtist(Console.ReadLine());
                    Console.WriteLine("What is the album?");
                    collection[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("What is the song length?");
                    collection[i].setLength(Console.ReadLine());
                    Console.WriteLine("What is the music genre?");
                    Console.WriteLine("P - Pop\nR - Rock\nH - HipHop\nC - Classical\nJ - Jazz");
                    Genre tempGenre = Genre.Pop;
                    char g = char.Parse(Console.ReadLine());
                    switch (g)
                    {
                        case 'P':
                            tempGenre = Genre.Pop;
                            break;
                        case 'R':
                            tempGenre = Genre.Rock;
                            break;
                        case 'H':
                            tempGenre = Genre.HipHop;
                            break;
                        case 'C':
                            tempGenre = Genre.Classical;
                            break;
                        case 'J':
                            tempGenre = Genre.Jazz;
                            break;
                    }
                    collection[i].setGenre(tempGenre);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"{collection[i].Display()}");
                }
            }

            /*Console.WriteLine("Please enter the song title?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What is the album?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("What is the song length?");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What is the music genre?");
            Console.WriteLine("P - Pop\nR - Rock\nH - HipHop\nC - Classical\nJ - Jazz");
            Genre tempGenre = Genre.Pop;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'P':
                    tempGenre = Genre.Pop;
                    break;
                case 'R':
                    tempGenre = Genre.Rock;
                    break;
                case 'H':
                    tempGenre = Genre.HipHop;
                    break;
                case 'C':
                    tempGenre = Genre.Classical;
                    break;
                case 'J':
                    tempGenre = Genre.Jazz;
                    break;
            }
            */
            //Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            //Music moreMusic = music;
            //Console.WriteLine("What is the next song on the album");
            //moreMusic.setTitle(Console.ReadLine());
            //Console.WriteLine("What is the length of the song");
            //moreMusic.setLength(Console.ReadLine());
            //Console.WriteLine($"{music.Display()}");
            //Console.WriteLine($"{moreMusic.Display()}");
        }
    }
}