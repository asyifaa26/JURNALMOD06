using System.Diagnostics;
using System.Xml.Linq;

namespace modul6_1302223029
{

    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            id = random.Next(1000, 99999);

            Debug.Assert(title.Length <= 100 && title != null);
            this.title = title;
            this.playCount = 0;
        }

        public string getTitle() { return title; }

        public void IncreasePlayCount(int count)
        {
            this.playCount = count + 1;
        }

        public void PrintVideoDetails() 
        {
            Console.WriteLine($"Video ID    : {id}");
            Console.WriteLine($"Video Title : {title}");
            Console.WriteLine($"Play Count  : {playCount}");
        }
    }

    public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;
        
        public SayaTubeUser(string username) 
        {
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            return uploadedVideos.Count;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine($"User        : {username}");
            for (int i = 1; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i} judul : {uploadedVideos[i].getTitle()}");
            }
        }

        public static void Main (string[] args)
        {
            SayaTubeUser name = new SayaTubeUser("Sipa");
            

            SayaTubeVideo video = new SayaTubeVideo("Review Film Frozen Oleh Sipa");
            name.AddVideo(video);
            SayaTubeVideo video1 = new SayaTubeVideo("Review Film Enola Oleh Sipa");
            name.AddVideo(video1);
            SayaTubeVideo video2 = new SayaTubeVideo("Review Film Tangled Oleh Sipa");
            name.AddVideo(video2);
            SayaTubeVideo video3 = new SayaTubeVideo("Review Film Aladin Oleh Sipa");
            name.AddVideo(video3);
            SayaTubeVideo video4 = new SayaTubeVideo("Review Film How To Train Your Dragon Oleh Sipa");
            name.AddVideo(video4);
            SayaTubeVideo video5 = new SayaTubeVideo("Review Film Dumble Oleh Sipa");
            name.AddVideo(video5);
            SayaTubeVideo video6 = new SayaTubeVideo("Review Film Barbie And The Secreat Door Oleh Sipa");
            name.AddVideo(video6);
            SayaTubeVideo video7 = new SayaTubeVideo("Review Film Barbie Princess And The Pop Star Oleh Sipa");
            name.AddVideo(video7);
            SayaTubeVideo video8 = new SayaTubeVideo("Review Film Harry Potter Oleh Sipa");
            name.AddVideo(video8);
            SayaTubeVideo video9 = new SayaTubeVideo("Review Film Maleficent Oleh Sipa");
            name.AddVideo(video9);

            name.PrintAllVideoPlayCount();
            Console.WriteLine(" ");
            video.PrintVideoDetails();
           
        }
    }


}