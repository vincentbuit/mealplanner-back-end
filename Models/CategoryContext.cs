using Microsoft.EntityFrameworkCore;

namespace CategoryApi.Models;

public class CategoryContext : DbContext
{
    public DbSet<Category> Categories { get; set; } = null!;
    public string DbPath { get; }

    public CategoryContext(DbContextOptions<CategoryContext> options)
        : base(options)
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "mealprep.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
