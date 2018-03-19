using System;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace AttributeBugRepro
{
    public class Class1
    {
        [CsvHelper.Configuration.Attributes.Constant("")]
        public string fullyQualifiedProperty { get; set; }

        [CsvHelper.Configuration.Attributes.Constant("")]
        public string fullyQualifiedField;
    }
}
