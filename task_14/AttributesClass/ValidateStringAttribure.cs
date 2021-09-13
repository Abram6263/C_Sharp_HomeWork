using System;

namespace AttributesClass
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ValidateStringAttribure : System.Attribute
    {
        public string Pattern { get; set; }
        
        public ValidateStringAttribure(string pattern)
        {
            Pattern = pattern;
        }
    }
}
