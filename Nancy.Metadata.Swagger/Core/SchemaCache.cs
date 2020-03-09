using System.Collections.Generic;
using Newtonsoft.Json.Schema;

namespace Nancy.Metadata.Swagger.Core
{
    public static class SchemaCache
    {
         public static Dictionary<string, NJsonSchema.JsonSchema> Cache = new Dictionary<string, NJsonSchema.JsonSchema>();
    }
}