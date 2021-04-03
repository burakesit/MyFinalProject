using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

       

        public List<Product> GetAll()
        {
            //iş kodları
            //Yetkisi var mı?

            return _productDal.GetAll();
        }
    }
}
