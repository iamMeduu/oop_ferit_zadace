using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Season
    {
        private int seasonNumber;
        private Episode[] episodes;
        public int Length { get { return episodes.Length; } }

        public Season(int seasonNumber, Episode[] episodes)
        {
            this.seasonNumber = seasonNumber;
            this.episodes = episodes;
        }
       
        public int GetTotalViewerCount()
        {
            int sum = 0;
            foreach(Episode episode in episodes)
            {
                sum += episode.GetViewerCount();
            }
            return sum;
        }
        public TimeSpan GetDurationOfSeason()
        {
            TimeSpan duration = TimeSpan.Zero;
            foreach(Episode episode in episodes)
            {
                duration += episode.GetEpisodeLenght();
            }
            return duration;
        }
        public DateTime GetBingeEnd()
        {
            DateTime date = DateTime.Now;
            return date.Add(GetDurationOfSeason());
        }
        public Episode this[int index]
        {
            get { return (Episode)episodes[index]; }
            set { episodes[index] = value;}
        }
        public override string ToString()
        {
            string output = "";
            output += $"Season {seasonNumber}.\n";
            output += "=================================================\n";
            foreach(Episode episode in episodes)
            {
                output += episode.ToString()+"\n";
            }
            output += "=================================================\n";
            output += $"Total viewers: {GetTotalViewerCount()}\n";
            output += $"Total duration: {GetDurationOfSeason()}\n";
            output += "=================================================";
            return output;
        }
    }
}
