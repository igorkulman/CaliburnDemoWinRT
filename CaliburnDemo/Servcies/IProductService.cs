using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaliburnDemo.Data;

namespace CaliburnDemo.Servcies
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product Get(int id);
    }
}
