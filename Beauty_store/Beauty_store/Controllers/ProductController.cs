using Beauty_store.Models;
using Microsoft.AspNetCore.Mvc;

namespace Beauty_store.Controllers
{
    public class ProductController: Controller
    {
       
            private readonly ProductDbContext _dbContext;
            public ProductController(ProductDbContext dbContext)
            {
                _dbContext = dbContext;
            }
            [HttpGet]
            public IActionResult Index()
            {
                return View("Index1", _dbContext.ProductItems.ToList());
            }
            [HttpGet]
            public IActionResult Create()
            {
                return View("Create1", new ProductItems());
            }
            [HttpPost]
            public IActionResult Create(ProductItems data)
            {
                if (ModelState.IsValid)
                {
                    _dbContext.ProductItems.Add(new ProductItems { Id = new Random().Next(), Name = data.Name, Count = data.Count, Price = data.Price, Image = data.Image });
                    _dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View("Create1", data);

            }
            

            [HttpGet]
            public IActionResult Init()
            {
                if (_dbContext.ProductItems.Any())
                    return Ok("Catalog is full");

                _dbContext.ProductItems.AddRange(new List<ProductItems>
            {
                new ProductItems { Id=1, Name="Lipstick", Count=25, Price=350, Image="https://patricialedo.liza.ua/images/tild6466-6334-4464-b839-386435616333__pomada_5.png"},
                new ProductItems { Id = 2, Name = "Rouge", Count = 15, Price = 400, Image="https://patricialedo.liza.ua/images/tild6436-3462-4934-a565-383734386534__rumana.png" },
                new ProductItems { Id = 3, Name = "Powder", Count = 20, Price = 365, Image="https://patricialedo.liza.ua/images/tild6438-3165-4336-a135-613034383462__pudra_2.png" }
            });
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }

