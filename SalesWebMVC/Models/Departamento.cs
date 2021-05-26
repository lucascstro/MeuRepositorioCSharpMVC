using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Vendedor> vendedores { get; set; } = new List<Vendedor>();

        public Departamento() { }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddVendedor(Vendedor vendedor) 
        {
            vendedores.Add(vendedor);
        }

        public double TotalVendas(DateTime inicial, DateTime Final)        
        {
            return vendedores.Sum(vendedor => vendedor.TotalVendas(inicial, Final));
        }
    }
}
