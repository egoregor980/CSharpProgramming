namespace Task6_ClassLibrary
{
    public class BookCabinet : Cabinet
    {
        public string BooksType { get; set; }
        public string BooksCount { get; set; }

        public override string SetUp()
        {
            return "setting up...";
        }

        public override string Move()
        {
            return "Moving...";
        }

        public string AccessBook()
        {
            return "Accessing...";
        }
    }
}
