namespace LINQSample.ConsoleApp.LINQ_Sample;

public class LINQSample
{
    private class Blog
    {
        public string BlogTitle { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Blog(string blogTitle, decimal price, int quantity)
        {
            BlogTitle = blogTitle;
            Price = price;
            Quantity = quantity;
        }
    }

    public void Run()
    {
        LINQLoop();
    }

    private void LINQLoop()
    {
        var blogs = new List<Blog>()
        {
            new Blog("Battle with Justice", 1000, 4),
            new Blog("Battle with Justice", 1000, 4),
            new Blog("Battle with Justice", 1000, 4),
            new Blog("Battle with Justice", 1000, 4)
        };

        decimal total = 0m;

        blogs.ForEach(blog =>
        {
            decimal lineTotal = blog.Price * blog.Quantity;
            Console.WriteLine($"{blog.BlogTitle} x {blog.Quantity}: {lineTotal:C}");
            total += lineTotal;
        });

        Console.WriteLine($"Total: {total:C}");
    }
}