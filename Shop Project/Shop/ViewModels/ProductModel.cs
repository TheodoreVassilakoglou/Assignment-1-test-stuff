using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Models;


namespace Shop.ViewModels
{
    public class ProductModel
    {
        public List<Product> _products { get; set; }
        public List<Product> findAll()
        {
            _products = new List<Product>
            {
                new Product()

                {
                    Id = "1",
                    Name = "Natsumi",
                    Photo = "thumb1.jpg",
                    Price = 200.80
                },
                new Product()

                {
                    Id = "2",
                    Name = "Natsuki",
                    Photo = "thumb2.jpg",
                    Price = 290.80
                },
                new Product()

                {
                    Id = "3",
                    Name = "Yui",
                    Photo = "thumb3.jpg",
                    Price = 223.80
                },
                new Product()

                {
                    Id = "4",
                    Name = "Kokoa",
                    Photo = "thumb4.jpg",
                    Price = 1000.80
                }



            };

            return _products;




        }
        public Product find(string id)
        {
            List<Product> products = findAll();
            var prod = products.Where(a => a.Id == id).FirstOrDefault();
            return prod;
        
        
        }
    }
}
