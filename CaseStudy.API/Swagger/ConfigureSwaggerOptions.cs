using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudy.API.Swagger
{
    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly ILogger _logger;
        readonly IApiVersionDescriptionProvider _provider;

        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider, ILogger<ConfigureSwaggerOptions> logger)
        {
            _provider = provider;
            _logger = logger;
        }
        public void Configure(SwaggerGenOptions options)
        {
            foreach(var description in _provider.ApiVersionDescriptions)
            {
                try
                {
                    options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
                }catch(Exception ex)
                {
                    _logger.LogError(ex, "ConfigureSwaggerOptions");
                }
            }
        }

        static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
        {
            var contact = new OpenApiContact()
            {
                Name = "Miloslav Moravec",
                Email = "mila.moravec@email.cz",
                Url = new Uri("https://www.alza.cz")
            };

            var license = new OpenApiLicense()
            {
                Name = "My License",
                Url = new Uri("https://www.alza.cz")
            };

            var info = new OpenApiInfo()
            {
                Version = description.ApiVersion.ToString(),
                Title = "Swagger Demo API",
                Description = "Swagger API for Alza products",
                Contact = contact,
                License = license
            };

            if (description.IsDeprecated)
            {
                info.Description += "This API version has been deprecated";
            }

            return info;
        }
    }
}
