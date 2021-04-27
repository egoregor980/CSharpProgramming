namespace Task6_ClassLibrary
{
    public interface IFurniture
    {
        string Name { get; set; }

        string SetUp();

        string Move();
    }
}
