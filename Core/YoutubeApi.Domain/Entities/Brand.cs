namespace YoutubeApi.Domain.Entities
{
    public class Brand
    {
        public Brand()
        {

        }
        public Brand(string name)
        {
            Name = name;
        }
        public required string Name { get; set; }
    }
}
