using BLL.DTOModels.Request;
using BLL.DTOModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IProductsBLL
    {
        public List<ProductResponseDTO> get(
            ProductSortingEntityDTO sortingEntityDTO = ProductSortingEntityDTO.NULL, 
            SortingTypeDTO sortingType = SortingTypeDTO.ASC, 
            ProductFilteringDTO productFilteringDTO = ProductFilteringDTO.NULL, 
            string filterinfContent = null, 
            bool activeOnly = true);

        public void add(ProductRequestDTO productRequestDTO);
        public void delete(int id);
        public void update(ProductRequestDTO productRequestDTO);
        public void activate(int id);

    }
}
