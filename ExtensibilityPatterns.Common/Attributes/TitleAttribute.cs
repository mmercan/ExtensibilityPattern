using System;
using System.Linq.Expressions;

namespace ExtensibilityPatterns.Common.Attributes
{
    public class TitleAttribute : Attribute
    {
        public TitleAttribute()
        {

        }

        public TitleAttribute(Expression propertyExpression)
        {

        }

    }


}