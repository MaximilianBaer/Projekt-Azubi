using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Survey : Entity
    {
        public string name { get; set; }
        public DateTime crationTime { get; protected set; }
        public bool isDeletet { get; set; }
        public List<Question> Questions { get; set; }

    }
}
