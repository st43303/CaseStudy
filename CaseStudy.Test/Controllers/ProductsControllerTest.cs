using CaseStudy.API.Controllers;
using CaseStudy.Data.Repositories;
using CaseStudy.Domain.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CaseStudy.Test.Controllers
{
    public class ProductsControllerTest:IClassFixture<WebApplicationFactory<API.Startup>>
    {
        private readonly HttpClient _client;

        public ProductsControllerTest(WebApplicationFactory<API.Startup> fixture)
        {
            _client = fixture.CreateClient();
        }

        #region GetProducts

        /// <summary>
        /// Test if get method will return status code 200 OK
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GetAllProducts()
        {
            var response = await _client.GetAsync("/api/v1/products");

            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        }

        #endregion //GetProducts

        #region GetProductsForPage

        /// <summary>
        /// Test if get method will return status code 200 OK
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GetProductsForPage()
        {
            var response = await _client.GetAsync("/api/v2/products/page?pageNumber=1&pageSize=10");
            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test if get method will return status code 500 when the page number has a bad value
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GetProductsForBadNumberPage()
        {
            var response = await _client.GetAsync("/api/v2/products/page?pageNumber=-5&pageSize=10");
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        #endregion //GetProductsForPage

        #region GetProduct

        /// <summary>
        /// Test if get method will return status code 404 when there is no product with this ID
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GeProductByBadId()
        {
            var response = await _client.GetAsync("api/v1/products/00000000-0000-0000-0000-000000000000");

            Assert.Equal(System.Net.HttpStatusCode.NotFound, response.StatusCode);
        }

        #endregion // GetProductById

        #region CreateProduct

        /// <summary>
        /// Test if post method will return status code 201 Created
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task CreateProduct()
        {
            var product = new ProductModel
            {
                Description = "The description of test product",
                ImgUri = "image.png",
                Name = "Test product",
                Price = 100
            };

            var serializedData = JsonConvert.SerializeObject(product);
            var content = new StringContent(serializedData, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/v1/products", content);

            Assert.Equal(System.Net.HttpStatusCode.Created, response.StatusCode);
        }

        /// <summary>
        /// Test if post method will return status code 400 bad request when the product name is missing
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task CreateProductWithoutName()
        {
            var product = new ProductModel
            {
                Description = "The description of test product",
                ImgUri = "image.png",
                Price = 100
            };

            var serializedData = JsonConvert.SerializeObject(product);
            var content = new StringContent(serializedData, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/v1/products", content);

            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        /// <summary>
        /// Test if post method will return status code 400 bad request when the product price has a bad value
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task CreateProductWithBadPrice()
        {
            var product = new ProductModel
            {
                Description = "The description of test product II",
                ImgUri = "image2.png",
                Name = "Test product II",
                Price = -50
            };

            var serializedData = JsonConvert.SerializeObject(product);
            var content = new StringContent(serializedData, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/v1/products", content);

            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        #endregion // CreateProduct

        #region Patch
        /// <summary>
        /// Creating a new product and then updating by new value of description
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task UpdateDescriptionOfCreatedProduct()
        {
            var product = new ProductModel
            {
                Description = "The description of test product",
                ImgUri = "image.png",
                Name = "Test product",
                Price = 100
            };

            var serializedData = JsonConvert.SerializeObject(product);
            var content = new StringContent(serializedData, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/v1/products", content);

            var createdProduct = JsonConvert.DeserializeObject<ProductModel>(await response.Content.ReadAsStringAsync());
            var productId = createdProduct.Id;

            var document = new JsonPatchDocument<ProductModel>().Replace(i => i.Description, "The new description of test product");

            var serializedDocument = JsonConvert.SerializeObject(document);
            var patchContent = new StringContent(serializedDocument, Encoding.UTF8, "application/json-patch+json");
            var patchResponse = await _client.PatchAsync("api/v1/products/" + productId, patchContent);

            Assert.Equal(System.Net.HttpStatusCode.NoContent, patchResponse.StatusCode);

        }
        #endregion //Patch
    }
}
