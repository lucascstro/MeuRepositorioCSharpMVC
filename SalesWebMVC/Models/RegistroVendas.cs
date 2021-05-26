using SalesWebMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Valor { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }


        public  RegistroVendas(){}

        public RegistroVendas(int id, DateTime date, double valor, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            Date = date;
            Valor = valor;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
