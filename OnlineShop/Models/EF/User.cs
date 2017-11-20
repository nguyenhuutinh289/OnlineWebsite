﻿namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public long ID { get; set; }
      
        [StringLength(50)]
        [Display(Name = "Tài Khoản")]
        public string UserName { get; set; }
       
        [StringLength(32)]
        [Display(Name = "Mật Khẩu")]
        public string Password { get; set; }
      
        [StringLength(20)]
        [Display(Name = "Nhóm")]
        public string GroupID { get; set; }
       
        [StringLength(50)]
        [Display(Name = "Họ Tên")]
        public string Name { get; set; }
       
        [StringLength(50)]
        [Display(Name = "Địa Chỉ")]
        public string Address { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
       
        [StringLength(50)]
        [Display(Name = "Số Điện Thoại")]
        public string Phone { get; set; }

        public int? ProvinceID { get; set; }

        public int? DistrictID { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public bool Status { get; set; }

        public User()
        {

        }
        public User(string userName, string passWord)
        {
            this.UserName = userName;
            this.Password = passWord;
        }
        public User(string userName, string passWord, string groupID, bool status)
        {
            this.UserName = userName;
            this.Password = passWord;
            this.GroupID = groupID;
            this.Status = status;
        }
    }
}
