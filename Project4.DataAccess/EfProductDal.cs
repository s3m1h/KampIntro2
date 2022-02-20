using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class EfProductDal : IProductDal
    {

        public void Add(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Remove(context.Products.SingleOrDefault(p=>p.ProductID == entity.ProductID));
                context.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }

        public Product GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(p=>p.ProductID == id);
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var productToUpdate = context.Products.SingleOrDefault(p => p.ProductID == entity.ProductID);
                productToUpdate.ProductID = entity.ProductID;
                productToUpdate.ProductName = entity.ProductName;
                productToUpdate.CategoryID = entity.CategoryID;
                productToUpdate.UnitPrice = entity.UnitPrice;
                productToUpdate.UnitsInStock = entity.UnitsInStock;
                context.SaveChanges();
                
            }
        }
    }
}
