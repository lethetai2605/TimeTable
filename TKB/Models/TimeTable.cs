namespace TKB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TimeTable")]
    public partial class TimeTable
    {
      
        public int ID { get; set; }
        [Required(ErrorMessage ="Thứ không được để trống")]
        [DisplayName("Thứ")]
        [Range(2,8,ErrorMessage ="Thứ phải từ 2 đến 8")]
        public int Day { get; set; }

        [StringLength(50)]
        [DisplayName("Thời gian")]
        public string Time { get; set; }

        [StringLength(50)]
        [DisplayName("Tuần")]
        public string Week { get; set; }

        [StringLength(50)]
        [DisplayName("Môn học")]
        public string Subject { get; set; }

        [StringLength(50)]
        [DisplayName("Phòng")]
        public string Place { get; set; }
    }
}
