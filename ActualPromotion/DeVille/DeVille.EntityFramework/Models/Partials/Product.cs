﻿using Deville.Models.MetaData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deville.EntityDataModel
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product : IEntity
    {
        public int ID
        {
            get { return this.Id; }
        }
    }
}
