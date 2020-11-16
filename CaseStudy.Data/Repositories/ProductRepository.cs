using CaseStudy.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
        /// Get products by specified page
        /// </summary>
        /// <param name="pageNumber">The number of the required page. The first page number is 0</param>
        /// <param name="pageSize">The number of products per page</param>
        /// <returns></returns>
        Task<IEnumerable<Product>> GetProductsByPage(int pageNumber, int pageSize = 10);
        /// <summary>
        /// Get product specified by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Product> GetProductById(Guid id);
        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description"></param>
        Task<bool> UpdateProduct(Guid id, Product product);
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
        private readonly ILogger _logger;

        public ProductRepository(ApplicationDbContext context, ILogger<ProductRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<Guid> CreateProduct(Product product)
        {
            try
            {
                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();

                return product.Id;
            }catch(Exception ex)
            {
                _logger.LogError(ex, "CreateProduct");
                throw ex;
            }
        }

        public async Task<bool> DeleteProduct(Guid id)
        {
            try
            {
                var product = await _context.Products.FirstOrDefaultAsync(i => i.Id == id);
                if (product == null)
                {
                    return false;
                }

                _context.Products.Remove(product);
                await _context.SaveChangesAsync();

                return true;
            }catch(Exception ex)
            {
                _logger.LogError(ex, "DeleteProduct");
                throw ex;
            }
        }

        public async Task<Product> GetProductById(Guid id)
        {
            try
            {
                return await _context.Products.FirstOrDefaultAsync(i => i.Id == id);
            }catch(Exception ex)
            {
                _logger.LogError(ex, "GetProductById");
                throw ex;
            }
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            try
            {
                return await _context.Products.ToListAsync();
            }catch(Exception ex)
            {
                _logger.LogError(ex, "GetProducts");
                throw ex;
            }
        }

        public async Task<IEnumerable<Product>> GetProductsByPage(int pageNumber, int pageSize = 10)
        {
            try
            {
                return await _context.Products.OrderBy(o => o.Name).Skip(pageNumber * pageSize).Take(pageSize).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetProductsByPage");
                throw ex;
            }
        }

        public async Task<bool> UpdateProduct(Guid id, Product product)
        {
            try
            {
                var oldProduct = await _context.Products.FirstOrDefaultAsync(i => i.Id == id);

                if (oldProduct == null || oldProduct.Id != product.Id)
                {
                    return false;
                }

                oldProduct.Description = product.Description;
                oldProduct.ImgUri = product.ImgUri;
                oldProduct.Name = product.Name;
                oldProduct.Price = product.Price;
                oldProduct.Modified = DateTime.Now;

                _context.Entry(oldProduct).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return true;
            }catch(Exception ex)
            {
                _logger.LogError(ex, "UpdateProductDescription");
                throw ex;
            }
        }
    }
}
