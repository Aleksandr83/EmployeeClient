// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Data.Models.Reffers
{
    public class RefferModel
    {
        [Column("id")]
        public virtual int    Id   { get; set; }
        [Column("name")]
        public virtual string Name { get; set; }
    }
}
