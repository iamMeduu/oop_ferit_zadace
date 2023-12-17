using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Description
    {
        private int episodeNumber;
        public TimeSpan EpisodeLenght { get; set; }
        private string episodeName;

        public Description(int episodeNumber, TimeSpan episodeLenght, string episodeName)
        {
            this.episodeNumber = episodeNumber;
            this.EpisodeLenght = episodeLenght;
            this.episodeName = episodeName;
        }
        public Description()
        {
            episodeNumber = 0;
            EpisodeLenght = TimeSpan.Zero;
            episodeName = string.Empty;
        }
        public override string ToString()
        {
            return $"Episode number: {episodeNumber}., Episode Lenght: {EpisodeLenght}, Episode Name: {episodeName}";
        }
    }
}
