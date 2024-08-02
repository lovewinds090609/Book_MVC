using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="名稱不能為空白")]
        [MaxLength(30,ErrorMessage ="名稱長度不能大於30個字元")]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "編號不能為空白")]
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="範圍必須在1到100之間")]
        public int DisplayOrder { get; set; }
    }
}
