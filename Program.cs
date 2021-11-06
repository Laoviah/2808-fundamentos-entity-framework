using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog{

    class Program{

        static void Main(string[] args){

            using(var context = new BlogDataContext()){

                // var tag = new Tag{Name="NET", Slug = "ASP.NET"};
                // context.Tags.Add(tag);
                // context.SaveChanges();

                // var tag = context.Tags.FirstOrDefault(x => x.Id ==1);
                // tag.Name = ".NET";
                // tag.Slug = "dotnet";

                // context.Update(tag);
                // context.SaveChanges();

                // var tag = context.Tags.FirstOrDefault(x => x.Id ==1);
                // context.Remove(tag);
                // context.SaveChanges();

                // var tags = context.Tags.
                //                     AsNoTracking().
                //                     ToList();

                // foreach(var tag in tags){
                //     Console.WriteLine(tag.Name);
                // }
            }
        }
    }
}