using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FileValidation.Filters;
using System.ComponentModel.DataAnnotations;

namespace FileValidation.ViewModels
{
    public class NewsViewModel
    {
        [ValidationImg(ErrorMessage = "Please select a image small than 10MB")]
        public HttpPostedFileBase File { get; set; }

        [ValidationTxt(ErrorMessage = "Please enter news content")]
        public string Content { get; set; }
    }
}