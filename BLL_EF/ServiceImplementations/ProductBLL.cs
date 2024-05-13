using BLL.DTOModels.Request;
using BLL.DTOModels.Response;
using BLL.ServiceInterfaces;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                //product.Id = context.Products.ToList().Max(x => x.Id) + 1;
                product.Name = productRequestDTO.Name;
                product.Price = productRequestDTO.Price;
                product.Image = "brak";
                product.IsActive = true;
                //product.GroupId = null;
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
            int countOfProductUse = context.OrderPositions.Where(x=>x.ProductId == id).Count();
            List<OrderPosition> listOfOrderPositionsUsingProduct = context.OrderPositions.Where(x=>x.ProductId == id).ToList();
            int unpaidCounter = 0;
            foreach(OrderPosition orderPosition in listOfOrderPositionsUsingProduct)
            {
                Order order = context.Orders.Where(x=>x.Id == orderPosition.OrderId).FirstOrDefault();
                if (order.isPaid == false)
                {
                    unpaidCounter++;
                    break;
                }
            }
            if (countOfProductUse == 0)
            {
                Product prosductToDelete = context.Products.Where(x=>x.Id == id).FirstOrDefault();
                context.Products.Remove(prosductToDelete);
                context.SaveChanges();
            }
            else if(unpaidCounter==0)
            {
                Product product = context.Products.Where(x=>x.Id == id).FirstOrDefault();
                product.IsActive = false;
                context.Products.Update(product);
                context.SaveChanges();
            }
            //context.Products.Remove(context.Products.Where(x => x.Id == id).First());
        }
        private string getGroupName(int id)
        {
            string result = "";
            ProductGroup productGroup = context.ProductGroups.Where(x => x.Id == id).FirstOrDefault();
            result = productGroup.Name;
            if (productGroup.ParentId != null)
                result = getGroupName((int)productGroup.ParentId) + "/" + productGroup.Name;
            return result;
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
                string groupName = "";
                if(product.GroupId!=null)
                    groupName = getGroupName((int)product.GroupId);
                double price = product.Price;
                ProductResponseDTO productResponseDTO = new ProductResponseDTO { Id =  product.Id, Name = product.Name,  GroupName = groupName, Price = product.Price};
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
