using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBaseet.Core.Entities;

public class RealEstate
{
    public int Id { get; set; }
    public string Address { get; set; }
    public Type Type { get; set; }
    public string Description { get; set; }
    [Column(TypeName = "decimal(6, 2)")]
    public decimal Price { get; set; }
    public Status RentOrSell { get; set; }
    public Customer Customer { get; set; }
    public Document Document { get; set; }

}

public enum Status
{
    Rent,
    Sell
}
public enum Type
{
    Apartment,
    House,
    Store,
}