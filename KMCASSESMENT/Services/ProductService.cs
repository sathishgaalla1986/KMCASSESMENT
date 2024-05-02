using KMCASSESMENT.Infrastruture;
using KMCASSESMENT.Models;

namespace KMCASSESMENT.Services
{
    public class ProductService: IProductService
    {
        private List<Product> _products;

        public ProductService()
        {
            _products = new List<Product>
            {
                new Product
                {
                    Id = 1, 
                    Name = "Harvest Vase",
                    Description = "Harvest Vases are a reinterpretation of peeled fruits and vegetables as functional objects. The surfaces appear to be sliced and pulled aside, allowing room for growth. ",
                    Price = 10,
                    ImageURL = "http://bit.ly/2tMBBTd",
                    ProductTag = "by studio and friends"
                },
                new Product
                {
                    Id = 2, 
                    Name = "Nurton",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Vero voluptatem nam pariatur voluptate perferendis, asperiores aspernatur! Porro similique consequatur, nobis soluta minima, quasi laboriosam hic cupiditate perferendis esse numquam magni. ",
                    Price = 120,
                    ImageURL = "https://images-na.ssl-images-amazon.com/images/I/613A7vcgJ4L._SL1500_.jpg",
                    ProductTag = "OFFICE CHAIR"
                },
                new Product
                {
                    Id = 3, 
                    Name = "Afro",
                    Description = "Shadow your real allegiance to New York's Pirate radio with this cool cap featuring the Graphic Know Wave logo. ",
                    Price = 120,
                    ImageURL = "https://bit.ly/2kOzUTm",
                    ProductTag = "baseball hair"
                },
                new Product
                {
                    Id = 4, 
                    Name = "CLASSIC PEACE LILY",
                    Description = "Classic Peace Lily is a spathiphyllum floor plant arranged in a bamboo planter with a blue & red ribbom and butterfly pick.",
                    Price = 100,
                    ImageURL = "https://s-media-cache-ak0.pinimg.com/236x/3b/36/ca/3b36ca3afe0fa0fd4984b9eee2e154bb.jpg",
                    ProductTag = "POPULAR HOUSE PLANT"
                },
                new Product
                {
                    Id = 5, 
                    Name = "Women Bag",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Vero, possimus nostrum!",
                    Price = 100,
                    ImageURL = "https://i.imgur.com/xdbHo4E.png",
                    ProductTag = "Women Leather Bag"
                },
                new Product
                {
                    Id = 6, 
                    Name = "Biru Putaran",
                    Description = "Especially good for container gardening, the Angelonia will keep blooming all summer even if old flowers are removed. Once tall enough to cut, bring them inside and you'll notice a light scent that some say is reminiscent of apples.",
                    Price = 49,
                    ImageURL = "https://s-media-cache-ak0.pinimg.com/736x/49/80/6f/49806f3f1c7483093855ebca1b8ae2c4.jpg",
                    ProductTag = "Biru Putaran"
                }
            };
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> SearchProducts(string searchTerm)
        {
            return _products
                .Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) || p.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
