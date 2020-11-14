using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy.Data.Entities
{
    public abstract class BaseAuditing
    {
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
