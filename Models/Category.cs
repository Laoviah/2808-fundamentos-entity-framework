namespace Blog.Models{

    // [Id] INT NOT NULL IDENTITY(1, 1),
    // [Name] VARCHAR(80) NOT NULL,
    // [Slug] VARCHAR(80) NOT NULL,
    public class Category{
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Slug { get; set; } ="";
    }
}