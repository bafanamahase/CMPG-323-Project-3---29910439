using Data;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;
using System.Collections;


namespace EcoPower_Logistics.Repository
{
    public class ProductRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        public IEnumerable<Product> GetAll()
        {
            return _context.Product.ToList();

        }
    }
}
