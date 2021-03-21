namespace TKB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {

        [Key]
        public int ID { get; set; }
     
        [StringLength(50)]
        [Required(ErrorMessage = "Mời nhập tài khoản.")]
        public string UserName { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Mời nhập nhập khẩu.")]
        public string PassWord { get; set; }

    }

}
