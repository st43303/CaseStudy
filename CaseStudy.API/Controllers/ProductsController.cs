using AutoMapper;
using CaseStudy.Data.Entities;
using CaseStudy.Data.Repositories;
using CaseStudy.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudy.API.Controllers
{
    /// <summary>
    /// Managing products
    /// </summary>
    [Route("api/v{v:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public ProductsController(IProductRepository productRepository, IMapper mapper, ILogger<ProductsController> logger)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _logger = logger;
        }

        /// <summary>
        /// Create a new product
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(ProductModel), 201)]
        [ProducesResponseType(typeof(IDictionary<string, string[]>), 400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]

        public async Task<IActionResult> CreateProduct([FromBody] ProductModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var productId = Guid.NewGuid();
                var product = new Product
                {
                    Id = productId,
                    Name = model.Name,
                    ImgUri = model.ImgUri,
                    Description = model.Description,
                    Price = model.Price,
                    Created = DateTime.Now,
                    Modified = null
                };

                await _productRepository.CreateProduct(product);

                return CreatedAtAction(nameof(GetProduct), new { id = productId }, _mapper.Map<ProductModel>(product));
            }catch(Exception ex)
            {
                _logger.LogError(ex, "CreateProduct");
                return StatusCode(500);
            }
        }

        /// <summary>
        /// Get product by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProductModel), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string[]>), 400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProduct([FromRoute]Guid id)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var product = await _productRepository.GetProductById(id);

                if (product == null)
                {
                    return NotFound();
                }

                return Ok(_mapper.Map<ProductModel>(product));
            }catch(Exception ex)
            {
                _logger.LogError(ex, "GetProduct");
                return StatusCode(500);
            }
        }

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IList<ProductModel>), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string[]>), 400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var products = await _productRepository.GetProducts();

                return Ok(_mapper.Map<IList<ProductModel>>(products));
            }catch(Exception ex)
            {
                _logger.LogError(ex, "GetProducts");
                return StatusCode(500);
            }
        }

        /// <summary>
        /// Get products for specified page
        /// </summary>
        /// <param name="pageNumber">The number of the required page. The first page number is 0</param>
        /// <param name="pageSize">The number of products per page</param>
        /// <returns></returns>
        [HttpGet("search")]
        [ApiVersion("2.0")]
        [ProducesResponseType(typeof(IList<ProductModel>), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string[]>), 400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProductsForPage([FromQuery]int pageNumber, [FromQuery] int pageSize = 10)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var products = await _productRepository.GetProducts(pageNumber, pageSize);

                return Ok(_mapper.Map<IList<ProductModel>>(products));
            }catch(Exception ex)
            {
                _logger.LogError(ex, "GetProductsForPage");
                return StatusCode(500);
            }
        }

        /// <summary>
        /// Delete product by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(typeof(IDictionary<string, string[]>), 400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> DeleteProduct([FromRoute]Guid id)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var product = await _productRepository.GetProductById(id);
                if (product == null)
                {
                    return NotFound();
                }

                var result = await _productRepository.DeleteProduct(id);
                if (!result)
                {
                    return NotFound();
                }

                return NoContent();
            }catch(Exception ex)
            {
                _logger.LogError(ex, "DeleteProduct");
                return StatusCode(500);
            }
        }

        /// <summary>
        /// Update the description of product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(typeof(IDictionary<string, string[]>),400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateDescription([FromRoute] Guid id, [FromQuery] string description)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var product = await _productRepository.GetProductById(id);
                if (product == null)
                {
                    return NotFound();
                }

                product.Description = description;

                var result = await _productRepository.UpdateProductDescription(id, product.Description);
                if (!result)
                {
                    return NotFound();
                }

                return NoContent();
            }catch(Exception ex)
            {
                _logger.LogError(ex, "UpdateDescription");
                return StatusCode(500);
            }
        }
    }
}
