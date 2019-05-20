using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FileValidation.Filters
{
    public class ValidationTxtAttribute : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
 
            return base.IsValid(value);
        }
    }
}