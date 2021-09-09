using InlineEditingJobTask.Context;
using InlineEditingJobTask.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlineEditingJobTask.Services
{
    public class ProductService
    {
        private readonly CustomDbContext _customDb;

        public ProductService(CustomDbContext customDb)
        {
            _customDb = customDb;
        }

        public IEnumerable<Product> Read()
        {
            return GetAll();
        }

        public IList<Product> GetAll()
        {
            return _customDb.Products.ToList();
        }

        public void Create(Product product)
        {
            _customDb.Products.Add(product);
            _customDb.SaveChanges();
        }

        public void Update(Product product)
        {
            _customDb.Products.Attach(product);
            _customDb.Entry(product).State = EntityState.Modified;
            _customDb.SaveChanges();
        }

        public void Destroy(Product product)
        {
            _customDb.Products.Remove(product);
            _customDb.SaveChanges();
        }
    }
}
