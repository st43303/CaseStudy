using CaseStudy.API.Controllers;
using CaseStudy.Data.Repositories;
using CaseStudy.Domain.Models;
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

        [Fact]
        public async Task GetAllProducts()
        {
            var response = await _client.GetAsync("/api/v1/products");

            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GeProductByBadId()
        {
            var response = await _client.GetAsync("api/v1/products/00000000-0000-0000-0000-000000000000");

            Assert.Equal(System.Net.HttpStatusCode.NotFound, response.StatusCode);
        }

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
    }
}
