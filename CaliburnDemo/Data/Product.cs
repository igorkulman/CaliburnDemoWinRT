using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using PropertyChanged;

namespace CaliburnDemo.Data
{
    [ImplementPropertyChanged]
    public class Product : PropertyChangedBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
