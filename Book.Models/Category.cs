using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Book.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="名稱不能為空白")]
        [MaxLength(30,ErrorMessage ="名稱長度不能大於30個字元")]
        [DisplayName("類別名稱")]
        public string Name { get; set; }
        [Required(ErrorMessage = "顯示順序不能為空白")]
        [DisplayName("顯示順序")]
        [Range(1,100,ErrorMessage ="範圍必須在1到100之間")]
        public int DisplayOrder { get; set; }
    }
}
