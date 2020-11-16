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

        [Fact]
        public async Task GetAllProducts()
        {
            var response = await _client.GetAsync("/api/v1/products");

            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        }

        #endregion //GetProducts

        #region GetProductsForPage
        
        [Fact]
        public async Task GetProductsForPage()
        {
            var response = await _client.GetAsync("/api/v2/products/page?pageNumber=1&pageSize=10");
            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GetProductsForBadNumberPage()
        {
            var response = await _client.GetAsync("/api/v2/products/page?pageNumber=-5&pageSize=10");
            Assert.Equal(System.Net.HttpStatusCode.InternalServerError, response.StatusCode);
        }

        #endregion //GetProductsForPage

        #region GetProduct

        [Fact]
        public async Task GeProductByBadId()
        {
            var response = await _client.GetAsync("api/v1/products/00000000-0000-0000-0000-000000000000");

            Assert.Equal(System.Net.HttpStatusCode.NotFound, response.StatusCode);
        }

        #endregion // GetProductById

        #region CreateProduct

        [Fact]
        public async Task CreateProduct()
        {
            var product = new ProductModel
            {
                Description = "Popis k testovacímu produktu",
                ImgUri = "image.png",
                Name = "Testovací produkt",
                Price = 100
            };

            var serializedData = JsonConvert.SerializeObject(product);
            var content = new StringContent(serializedData, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/v1/products", content);

            Assert.Equal(System.Net.HttpStatusCode.Created, response.StatusCode);
        }

        [Fact]
        public async Task CreateProductWithoutName()
        {
            var product = new ProductModel
            {
                Description = "Popis k testovacímu produktu",
                ImgUri = "image.png",
                Price = 100
            };

            var serializedData = JsonConvert.SerializeObject(product);
            var content = new StringContent(serializedData, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/v1/products", content);

            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task CreateProductWithBadPrice()
        {
            var product = new ProductModel
            {
                Description = "Popis k testovacímu produktu II",
                ImgUri = "image2.png",
                Name = "Testovací produkt II",
                Price = -50
            };

            var serializedData = JsonConvert.SerializeObject(product);
            var content = new StringContent(serializedData, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/v1/products", content);

            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }

        #endregion // CreateProduct

        #region Patch
        [Fact]
        public async Task UpdateDescriptionOfCreatedProduct()
        {
            var product = new ProductModel
            {
                Description = "Popis k testovacímu produktu",
                ImgUri = "image.png",
                Name = "Testovací produkt",
                Price = 100
            };

            var serializedData = JsonConvert.SerializeObject(product);
            var content = new StringContent(serializedData, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/v1/products", content);

            var createdProduct = JsonConvert.DeserializeObject<ProductModel>(await response.Content.ReadAsStringAsync());
            var productId = createdProduct.Id;

            var document = new JsonPatchDocument<ProductModel>().Replace(i => i.Description, "Nový testovací popis");

            var serializedDocument = JsonConvert.SerializeObject(document);
            var patchContent = new StringContent(serializedDocument, Encoding.UTF8, "application/json-patch+json");
            var patchResponse = await _client.PatchAsync("api/v1/products/" + productId, patchContent);

            Assert.Equal(System.Net.HttpStatusCode.NoContent, patchResponse.StatusCode);

        }
        #endregion //Patch
    }
}
