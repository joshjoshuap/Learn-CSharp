namespace CSharp_OOP_Constructor_Overload
{
    class Movie
    {
        public string title { get; set; }
        public string description { get; set; }
        public int rating { get; set; }
        public int price { get; set; }

        public Movie(string title, string description, int rating, int price)
        {
            this.title = title;
            this.description = description;
            this.rating = rating;
            this.price = price;
        }

        // movie without price value or incomplete value but still setting the value
        public Movie(string title, string description, int rating)
        {
            this.title = title;
            this.description = description;
            this.rating = rating;
        }
    }
}