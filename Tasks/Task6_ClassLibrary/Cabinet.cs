namespace Task6_ClassLibrary
{
    public abstract class Cabinet : IFurniture
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Capacity { get; set; }

        public abstract string SetUp();

        public abstract string Move();

        public string Turn()
        {
            return "Turning...";
        }
    }
}
