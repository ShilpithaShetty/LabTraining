using System;
using System.Collections.Generic;

namespace DbFirstEF.Models
{
    public partial class ToMany1
    {
        public ToMany1()
        {
            Ones = new HashSet<One>();
        }

        public int Id { get; set; }

        public virtual ICollection<One> Ones { get; set; }
    }
}
