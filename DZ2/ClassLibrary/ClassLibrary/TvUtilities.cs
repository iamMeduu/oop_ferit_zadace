using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class TvUtilities
    {
        
        static double GenerateRandomScore()
        {
            Random random = new Random();
            return random.NextDouble() * (10.0 - 0.0) + 0.0;
        }
        public static Episode Parse(string episodeInfo)
        {
            string[] substring = episodeInfo.Split(',');
            int viewCount = int.Parse(substring[0]);
            double sumOfReviews = double.Parse(substring[1]);
            double highestReview = double.Parse(substring[2]);
            int episodeNumber = int.Parse(substring[3]);
            TimeSpan episodeLenght = TimeSpan.Parse(substring[4]);
            string episodeName = substring[5];
            Description description = new Description(episodeNumber, episodeLenght, episodeName);
            Episode episode = new Episode(viewCount, sumOfReviews, highestReview, description);
            return episode;
        }
        public static void Sort(Episode[] episodes)
        {
            for(int i = 0;i< episodes.Length-1; i++)
            {
                for (int j = i+1;j< episodes.Length; j++)
                {
                    if (episodes[j] > episodes[i])
                    {
                       Episode temp = episodes[i];
                        episodes[i] = episodes[j];
                        episodes[j] = temp;
                    }
                }
            }
        }

    }
}
