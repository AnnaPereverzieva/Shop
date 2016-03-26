using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shop.Domain.Model;
using Shop.WebUI.Models;

namespace Shop.WebUI.ViewModels
{
    public class CustomersListViewModel
    {
        public IEnumerable<Customers> CustomersList { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}