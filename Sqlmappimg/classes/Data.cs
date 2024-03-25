namespace Sqlmappimg.classes
{
    public class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Data()
        {

        }
        public Data(int id, string name, string description, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }

    }

}
