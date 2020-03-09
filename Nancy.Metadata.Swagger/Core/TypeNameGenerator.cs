using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NJsonSchema;
using NJsonSchema.Generation;

namespace Nancy.Metadata.Swagger.Core
{
    public class TypeNameGenerator : ITypeNameGenerator, ISchemaNameGenerator
    {
        public string Generate(Type type)
        {
            return type.FullName;
        }

        public string Generate(NJsonSchema.JsonSchema schema, string typeNameHint)
        {
            return typeNameHint;
        }

        public string Generate(JsonSchema schema, string typeNameHint, IEnumerable<string> reservedTypeNames)
        {
            return typeNameHint;
        }
    }
}
