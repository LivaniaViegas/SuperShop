using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SuperShop.Data.Entities;
using SuperShop.Helpers;

namespace SuperShop.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        private Random _random;

        public SeedDb(DataContext context,IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
            _userHelper=  userHelper;
            _random = new Random();
        }
        public async Task SeedAsync()
        {
            //verificar se a base 
            await _context.Database.EnsureCreatedAsync(); // Cria a base de dados caso ainda nao estiver criada

            //tratar dos utilizadores
            var user = await _userHelper.GetUserByEmailAsync("livaniagarreth@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Livânia",
                    LastName = "Viegas",
                    Email = "livaniagarreth@gmail.com",
                    UserName = "livaniagarreth@gmail.com",
                    PhoneNumber = "926670207"
                };

                var result=await _userHelper.AddUserAsync(user, "123456");
                if(result!=IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }     

            if (!_context.Products.Any())
            {
                AddProduct("Iphone X", user);
                AddProduct("Magic Mouse", user);
                AddProduct("iWatch Series 4", user);
                AddProduct("iPad Mini", user);
                await _context.SaveChangesAsync();
            }

        }
        private void AddProduct(string name, User user)
        {
            _context.Products.Add(new Product
            {
                Name = name,
                Price = _random.Next(1000),
                IsAvailable = true,
                Stock = _random.Next(100),
                User=user
            });
        }
    }
}
