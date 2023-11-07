using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

ProductManager productMaganer = new ProductManager(new EfProductDal());
foreach(var product in productMaganer.GetByUnitPrice(50,100))
{
    Console.WriteLine(product.ProductName);
}
