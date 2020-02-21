using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HealthConnect.Api.Attributes
{

        public class AddRequiredHeaderParameter : IOperationFilter
        {

            public void Apply(Operation operation, OperationFilterContext context)
            {
            if (operation.Parameters == null)
                    operation.Parameters = new List<IParameter>();

//                operation.Parameters.Add(new Parameter
//                {
//                    name = "X-User-Token",
//                    @in = "header",
//                    type = "string",
//                    required = false
//                });
        }
        }
    
}
