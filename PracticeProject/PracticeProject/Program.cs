using Database;
using Microsoft.EntityFrameworkCore;

namespace PracticeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using DbManager dbManager = new();
            var categories = dbManager.Categories?.Include(x => x.Products);

        }
    }
}