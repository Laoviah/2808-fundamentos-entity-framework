namespace Blog.Models{

    // [Id] INT NOT NULL IDENTITY(1, 1),
    // [Name] VARCHAR(80) NOT NULL,
    // [Slug] VARCHAR(80) NOT NULL,
    public class Role{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}