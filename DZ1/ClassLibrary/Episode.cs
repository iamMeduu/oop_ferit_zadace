namespace ClassLibrary
{
    public class Episode
    {
        private int viewerCount;
        private double sumOfReviews;
        private double highestReview;
        
        public Episode(int viewerCount, double sumOfReviews, double highestReview)
        {
            this.viewerCount = viewerCount;
            this.sumOfReviews = sumOfReviews;
            this.highestReview = highestReview;


        }
        public Episode()
        {
            this.viewerCount = 0;
            this.sumOfReviews = 0;
            this.highestReview= 0;
        }
        public int GetViewerCount() {
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
            return sumOfReviews / viewerCount;
        }
        
    }
}