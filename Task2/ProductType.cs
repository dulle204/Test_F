using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2;
public class ProductType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ProductCategory ProductCategory { get; set; }
}
