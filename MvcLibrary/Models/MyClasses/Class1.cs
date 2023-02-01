using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcLibrary.Models.Entity;

namespace MvcLibrary.Models.MyClasses
{
    public class Class1
    {
        public IEnumerable<tblBooks> Value1 { get; set; }
        public IEnumerable<tblAbouts> Value2 { get; set; }
    }
}