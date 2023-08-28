using BlogWebSite.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.Core.BaseEntities
{
    public class BaseEntity
    {
       public int Id { get; set; }

       public State State { get; set; }
    }
}
