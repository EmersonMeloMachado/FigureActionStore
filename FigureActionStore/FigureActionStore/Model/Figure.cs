namespace FigureActionStore.Model
{
    public class Figure
    {
        public Figure()
        {
            this.figureDetail = new FigureDetail();
        }

        public int Id { get; set; }
        public string ImageFigure { get; set; }       
        public string name { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public string value { get; set; }
        public FigureDetail figureDetail { get; set; }
       
    }

    public class FigureDetail
    {
        public string ImageDetail { get; set; }
        public string detail { get; set; }
        public string detailDescription { get; set; }
        public double translationX { get; set; }
    }
}
