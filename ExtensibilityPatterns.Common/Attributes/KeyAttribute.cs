using System;
using System.Linq.Expressions;

namespace ExtensibilityPatterns.Common.Attributes
{
    public class KeyAttribute :Attribute
    {
        public KeyAttribute()
        {

        }

        public KeyAttribute(Expression propertyExpression)
        {

        }
    }
}