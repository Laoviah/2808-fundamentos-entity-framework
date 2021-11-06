using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models{

    // [Id] INT NOT NULL IDENTITY(1, 1),
    // [Name] VARCHAR(80) NOT NULL,
    // [Slug] VARCHAR(80) NOT NULL,
    public class Tag{
        public int Id { get; set; }
        public string Slug { get; set; } = "";
        public string Name { get; set; } = "";

        public List<Post> Posts { get; set; }

    }
}