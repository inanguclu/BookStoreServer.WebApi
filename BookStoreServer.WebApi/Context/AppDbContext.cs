using BookStoreServer.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreServer.WebApi.Context;

public sealed class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=INANGUCLU\\SQLEXPRESS;Initial Catalog=YMYP_BookStoreDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookCategory> BooksCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookCategory>().HasKey(p => new { p.BookId, p.CategoryId });



        #region Seed Data

        #endregion
        List<Category> categories = new();
        for (int i = 0; i < 10; i++)
        {
            var category = new Category()
            {
                Id = i+1,
                Name = $"Category {i + 1}",
                IsActive = true ,
                IsDeleted = false
            };
            categories.Add(category);
        }
        //seed data
        modelBuilder.Entity<Category>().HasData(categories);


        List<Book> books = new();   
        for(int i = 0;i < 100; i++)
        {
            var book = new Book()
            {
                Id = i+1,
                Title = $"Book{i + 1}",
                Author = $"Author{i + 1}",
                ISBN = $"ISBN{i + 1}",
                IsActive = true,
                IsDeleted = false,
                Price = 10,
                Quantity = 10,
                Summary = $"Summary{i + 1}",
                CoverImageUrl = $"https://cdn03.ciceksepeti.com/cicek/kcm58372384-1/XL/domain-driven-design-eric-evans-kcm58372384-1-bf5eaf90649b467fad825d8d046b6d19.jpg",
                CreatedAt = DateTime.Now,


            };
            books.Add(book);
        }
        modelBuilder.Entity<Book>().HasData(books);

            List<BookCategory> booksCategories = new();
            foreach (var book in books)
            {
            var bookCategory = new BookCategory()
            {
                BookId = book.Id,
                CategoryId = categories[new Random().Next(0, 10)].Id
            };
            booksCategories.Add(bookCategory);
            }
            modelBuilder.Entity<BookCategory>().HasData(booksCategories);   

        
    }

}
