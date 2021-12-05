// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Data.Models
{
    internal class Employee
    {
        [Key]
        public virtual int    Id            { get; set; }        
        public virtual String FIO           { get; set; }
        public virtual String Status        { get; set; }
        public virtual String Departament   { get; set; }
        public virtual String Post          { get; set; }
        public virtual String DateEmploy    { get; set; }
        public virtual String DateUneploy   { get; set; }
    }
}
