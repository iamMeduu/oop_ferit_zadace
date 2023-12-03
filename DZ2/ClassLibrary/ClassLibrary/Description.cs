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
        private TimeSpan episodeLenght;
        private string episodeName;

        public Description(int episodeNumber, TimeSpan episodeLenght, string episodeName)
        {
            this.episodeNumber = episodeNumber;
            this.episodeLenght = episodeLenght;
            this.episodeName = episodeName;
        }
        public Description()
        {
            episodeNumber = 0;
            episodeLenght = TimeSpan.Zero;
            episodeName = string.Empty;
        }
        public override string ToString()
        {
            return $"Episode number: {episodeLenght}., Episode Lenght: {episodeLenght}, Episode Name: {episodeName}";
        }
    }
}
