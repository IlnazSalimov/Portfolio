﻿using Deville.Models.MetaData;
using System.ComponentModel.DataAnnotations;

namespace Deville.Models.Showcases
{
    [MetadataType(typeof(ServiceSubcategoryMetaData))]
    public class AddServiceSubcategory
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public int Status { get; set; }
    }
}
