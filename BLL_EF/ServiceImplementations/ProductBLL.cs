using BLL.DTOModels.Request;
using BLL.DTOModels.Response;
using BLL.ServiceInterfaces;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_EF.ServiceImplementations
{
    public class ProductBLL : IProductsBLL
    {
        private DAL.WebshopContext context = new DAL.WebshopContext();

        public void activate(int id)
        {
            Product product = context.Products.Where(x => x.Id == id).First();
            if(!product.IsActive)
            {
                product.IsActive = true;
                context.Products.Update(product);
                context.SaveChanges();
            }
        }

        public void add(ProductRequestDTO productRequestDTO)
        {
            try
            {
                if (productRequestDTO.Price < 0)
                    throw new ArgumentException("Cena musi być większa od 0");
                Product product = new Product();
                product.Id = context.Products.ToList().Max(x => x.Id) + 1;
                product.Name = productRequestDTO.Name;
                product.Price = productRequestDTO.Price;
                product.IsActive = true;
                product.GroupId = productRequestDTO.GroupId;
                context.Products.Add(product);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(int id)
        {
            context.Products.Remove(context.Products.Where(x => x.Id == id).First());
        }

        public List<ProductResponseDTO> get(ProductSortingEntityDTO sortingEntityDTO = ProductSortingEntityDTO.NULL, SortingTypeDTO sortingType = SortingTypeDTO.ASC, ProductFilteringDTO productFilteringDTO = ProductFilteringDTO.NULL, string filterinfContent = null, bool activeOnly = true)
        {
            List<Product> products =  context.Products.ToList();
            List<ProductGroup> groups = context.ProductGroups.ToList();
            if (activeOnly)
                products = products.Where(x => x.IsActive).ToList();
            if(productFilteringDTO!= ProductFilteringDTO.NULL)
            {
                if(productFilteringDTO == ProductFilteringDTO.GROUP_NAME)
                {
                    int id = groups.Where(x => x.Name == filterinfContent).First().Id;
                    products = products.Where(x => x.GroupId == id).ToList();
                }
                else if(productFilteringDTO == ProductFilteringDTO.NAME)
                {
                    products = products.Where(x => x.Name == filterinfContent).ToList();
                }
                else if(productFilteringDTO == ProductFilteringDTO.GROUPID)
                {
                    products = products.Where(x => x.GroupId == Convert.ToInt32(filterinfContent)).ToList();
                }
            }
            List<ProductResponseDTO> response = new List<ProductResponseDTO>();
            foreach (Product product in products)
            {
                //ProductResponseDTO productResponseDTO = new ProductResponseDTO { Id = product.Id, Name = product.Name, GroupName = groups.Where(x => x.Id == product.GroupId).First().Name, Price = product.Price };
                int id = product.Id;
                string name = product.Name;
                string groupName = groups.Where(x => x.Id == product.GroupId).First().Name;
                double price = product.Price;

                ProductResponseDTO productResponseDTO = new ProductResponseDTO { Id =  product.Id, Name = product.Name,  GroupName = groups.Where(x=>x.Id == product.GroupId).First().Name, Price = product.Price};
                response.Add(productResponseDTO );
            }
            if(sortingType == SortingTypeDTO.ASC)
            {
                if (sortingEntityDTO == ProductSortingEntityDTO.NAME)
                    response = response.OrderBy(x => x.Name).ToList();
                else if(sortingEntityDTO == ProductSortingEntityDTO.GROUP_NAME)
                    response = response.OrderBy(x => x.GroupName).ToList();
                else if (sortingEntityDTO == ProductSortingEntityDTO.PRICE)
                    response = response.OrderBy(x => x.Price).ToList();
            }
            else
            {
                if (sortingEntityDTO == ProductSortingEntityDTO.NAME)
                    response = response.OrderByDescending(x => x.Name).ToList();
                else if (sortingEntityDTO == ProductSortingEntityDTO.GROUP_NAME)
                    response = response.OrderByDescending(x => x.GroupName).ToList();
                else if (sortingEntityDTO == ProductSortingEntityDTO.PRICE)
                    response = response.OrderByDescending(x => x.Price).ToList();
            }
            return response;
        }

        public void update(ProductRequestDTO productRequestDTO)
        {
            Product product = context.Products.Where(x => x.Id == productRequestDTO.Id).First();
            product.Name = productRequestDTO.Name;
            product.Price = productRequestDTO.Price;
            product.GroupId = productRequestDTO.GroupId;
            context.Products.Update(product);
            context.SaveChanges();
        }
    }
}
