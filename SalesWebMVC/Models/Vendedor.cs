using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Salario { get; set; }

        public Departamento Departamento { get; set; }
        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();

        public Vendedor() { }

        public Vendedor(int id, string name, string email, DateTime dataNascimento, double salario, Departamento departamento)
        {
            Id = id;
            Name = name;
            Email = email;
            DataNascimento = dataNascimento;
            Salario = salario;
            Departamento = departamento;
        }

        public void AddVenda(RegistroVendas rv)
        {
            //adciona venda
            Vendas.Add(rv);
        }
        public void RemoverVenda(RegistroVendas rv)
        {
            //remove venda
            Vendas.Remove(rv);
        }

        public double TotalVendas(DateTime inicial, DateTime final)        
        {
            //pega vendas do sr(Icollection Vendas) dentro do periodo inicial e final e faz a soma
            return Vendas.Where(sr => sr.Date >= inicial && sr.Date <= final).Sum(sr=>sr.Valor);
        
        }
    }
}
