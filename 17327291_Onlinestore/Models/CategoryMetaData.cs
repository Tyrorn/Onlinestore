using System.ComponentModel.DataAnnotations;

namespace _17327291_Onlinestore.Models
{
    public class CategorytMetaData
    {
        [MetadataType(typeof(CategorytMetaData))]
        public partial class Product
        {
        }
        public class CategoryMetaData
        {
            [Display(Name = "Category Name")]
            public string Name;
        }
    }
}