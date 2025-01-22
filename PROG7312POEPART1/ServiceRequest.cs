using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312POEPART1
{
    internal class ServiceRequest : IComparable<ServiceRequest>
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public int CompareTo(ServiceRequest other)
        {
            return string.Compare(this.Name, other.Name, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
