using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DigitalXData;

namespace AuthService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class AuthService : IAuthService
    {
        DigitalXDBEntities db = new DigitalXDBEntities();
        public bool Login(string userName, string password)
        {
            Customer cust = db.Customers.Where(c => c.UserName == userName).FirstOrDefault();
            return true;
        }

        public int Register(RegisterDTO regData)
        {
            Customer newCust = new Customer
            {
                UserName = regData.UserName,
                FirstName = regData.FirstName,
                LastName = regData.LastName
            };
            db.Customers.Add(newCust);
            db.SaveChanges();
            return newCust.CustomerID;
        }
        public IList<Product> ProductGetAll()
        {
            DigitalXDBEntities DbContext = new DigitalXDBEntities();
            IList<Product> listProduct = DbContext.Products.ToList();
            return listProduct;
        }
        public Product ProductGetDetails(int? id)
        {
            DigitalXDBEntities DbContext = new DigitalXDBEntities();
            Product p = DbContext.Products.Find(id);
            return p;
        }
        public IList<Product> ProductGetTop(int count)
        {
            DigitalXDBEntities DbContext = new DigitalXDBEntities();
            var list = (from t in DbContext.Products
                        orderby t.Price
                        select t).Take(count);
            return list.ToList();

        }

        public bool create(string UserName)
        {
            throw new NotImplementedException();
        }
    }
}
