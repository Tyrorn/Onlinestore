using System.ComponentModel.DataAnnotations;

namespace _17327291_Onlinestore.Models
{
        [MetadataType(typeof(ProductMetaData))]
        public partial class Product
        {
        }
        public class ProductMetaData
        {
            [Display(Name = "Product Name")]
            public string Name;
        }
}