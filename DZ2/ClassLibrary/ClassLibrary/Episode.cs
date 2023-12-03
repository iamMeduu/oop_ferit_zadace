namespace ClassLibrary
{
    public class Episode
    {
        private int viewerCount;
        private double sumOfReviews;
        private double highestReview;
        private Description episodeInfo;

        public Episode(int viewerCount, double sumOfReviews, double highestReview, Description episodeInfo)
        {
            this.viewerCount = viewerCount;
            this.sumOfReviews = sumOfReviews;
            this.highestReview = highestReview;
            this.episodeInfo = episodeInfo;


        }
        public Episode()
        {
            this.viewerCount = 0;
            this.sumOfReviews = 0;
            this.highestReview = 0;
        }
        public int GetViewerCount()
        {
            return viewerCount;
        }
        public double GetMaxScore()
        {
            return highestReview;
        }
        public void AddView(double review)
        {
            sumOfReviews = sumOfReviews + review;
            if (review > highestReview)
            {
                highestReview = review;
            }
            viewerCount++;

        }
        public double GetAverageScore()
        {
            //fixed//
            if (viewerCount == 0)
            {
                return 0;
            }
            return sumOfReviews / viewerCount;
        }
        public static bool operator >(Episode lhs, Episode rhs)
        {
            if (lhs.GetAverageScore() > rhs.GetAverageScore())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Episode lhs, Episode rhs)
        {
            return rhs > lhs;

        }
        public override string ToString()
        {
            return $"View count: {viewerCount}., Sum of reviews: {sumOfReviews}, Max score: {highestReview}, Description: {episodeInfo}";
        }

    }
}