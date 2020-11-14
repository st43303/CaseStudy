using CaseStudy.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Data.Repositories
{
    public interface IProductRepository
    {
        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Product>> GetProducts();
        /// <summary>
        /// Get products on page
        /// </summary>
        /// <param name="pages"></param>
        /// <returns></returns>
        Task<IEnumerable<Product>> GetProducts(int pageNumber, int pageSize = 10);
        /// <summary>
        /// Get product specified by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Product> GetProductById(Guid id);
        /// <summary>
        /// Update product´s description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description"></param>
        Task<bool> UpdateProductDescription(Guid id, string description);
        /// <summary>
        /// Create a new product
        /// </summary>
        /// <param name="product"></param>
        Task<Guid> CreateProduct(Product product);
        /// <summary>
        /// Delete product from a database
        /// </summary>
        /// <param name="id"></param>
        Task<bool> DeleteProduct(Guid id);

    }

    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Guid> CreateProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return product.Id;
        }

        public async Task<bool> DeleteProduct(Guid id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(i => i.Id == id);
            if(product == null)
            {
                return false;
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Product> GetProductById(Guid id)
        {
            return await _context.Products.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProducts(int pageNumber, int pageSize = 10)
        {
            return await _context.Products.Skip(pageNumber * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<bool> UpdateProductDescription(Guid id, string description)
        {
            var product = await _context.Products.FirstOrDefaultAsync(i => i.Id == id);

            if (product == null)
            {
                return false;
            }

            product.Description = description;
            product.Modified = DateTime.Now;

            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
