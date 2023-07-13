//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using SuperShop.Data.Entities;

//namespace SuperShop.Data
//{
//    public class Repository : IRepository
//    {
//        private readonly DataContext _context;

//        public Repository(DataContext context)
//        {
//            _context = context;
//        }
//        //vai receber todos os produtos
//        public IEnumerable<Product> GetProducts()
//        {
//            return _context.Products.OrderBy(p => p.Name);
//        }
//        //receber um produto
//        public Product GetProduct(int id)
//        {
//            return _context.Products.Find(id);
//        }

//        public void AddProduct(Product product)
//        {
//            _context.Products.Add(product);
//        }

//        public void UpdateProduct(Product product)
//        {
//            _context.Products.Update(product);
//        }
//        public void RemoveProduct(Product product)
//        {
//            _context.Products.Remove(product);
//        }

//        public async Task<bool> SaveAllAsync()
//        {
//            return await _context.SaveChangesAsync() > 0; //grava tudo sem ir pegar a base de dados
//        }
//        public bool ProductExists(int id)
//        {
//            return _context.Products.Any(p => p.Id == id);
//        }
//    }
//}
