using System.Collections.Generic;

namespace BindingStatement.Model
{
    public class Products
    {
        public List<Product> ProductList { get; private set; } = new List<Product>();
        public Product Product { get; set; } 
        public Products()
        {
            InitilizeProductList();
            Product = new Product()
            {
                Id = 10,
                ProductName = "Some Name"
            };
        }

        private void InitilizeProductList()
        {
            for (int i = 0; i < 10; i++)
                ProductList.Add(new Product()
                {
                    Id = Faker.RandomNumber.Next(10, 100),
                    ProductName = Faker.Company.Name()
                });

        }
    }
}