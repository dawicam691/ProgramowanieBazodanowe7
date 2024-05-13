using BLL.DTOModels.Response;
using DAL;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DB
{
    public class ProductBLL_DB
    {
        private DAL.WebshopContext context = new WebshopContext();

        public List<ProductResponseDTO> get(ProductSortingEntityDTO sortingEntityDTO = ProductSortingEntityDTO.NULL, SortingTypeDTO sortingType = SortingTypeDTO.ASC, ProductFilteringDTO productFilteringDTO = ProductFilteringDTO.NULL, string filterinfContent = null, bool activeOnly = true)
        {
            //string select = "SELECT Products.Id as Id, Products.Name as Name, Products.Price as Price, ProductGroups.Name as ProductGroupName from Products join ProductGroups on Product.GroupId = ProductGroup.Id ";
            string select = "SELECT * FROM Products";
            string where = "WHERE ";
            if (productFilteringDTO != ProductFilteringDTO.NULL)
            {
                if (productFilteringDTO == ProductFilteringDTO.NAME)
                    where += $"Name ='{filterinfContent}' ";
                else if (productFilteringDTO == ProductFilteringDTO.GROUP_NAME)
                    where += $"ProductGroupName = '{filterinfContent}' ";
                else where += $"ProductGroups.Id = '{filterinfContent}' ";
            }
            else
                where = "";
            if (activeOnly)
            {
                if (where == "")
                    where = " WHERE Product.IsActive = true";
                else
                    where += " AND Product.IsActive = true";
            }
            string sortingOrder = "ORDER BY ";
            string sortlingType = "";
            if (sortingType == SortingTypeDTO.ASC)
                sortlingType = "ASC";
            else
                sortlingType = "DESC";
            if (sortingEntityDTO == ProductSortingEntityDTO.NULL)
                sortingOrder = "";
            else if (sortingEntityDTO == ProductSortingEntityDTO.NAME)
                sortingOrder += "Name " + sortlingType;
            else if (sortingEntityDTO == ProductSortingEntityDTO.PRICE)
                sortingOrder += "Price" + sortlingType;
            else
                sortingOrder += "GroupName" + sortlingType;

            select += where + sortingOrder;
            select = "SELECT * FROM Products";
            using (SqlConnection connection = new SqlConnection(context.Database.GetConnectionString()))
            {
                SqlCommand command = new SqlCommand(
                    select, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}, {1}",
                            reader[0], reader[1]));
                    }
                }
            }
            return new List<ProductResponseDTO>();
        }
    }
}