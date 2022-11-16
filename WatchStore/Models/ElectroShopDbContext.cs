namespace WatchStore.Models
{
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
    public class WatchStoreDbContext : DbContext
    {
        // DbContext là lớp chính chịu trách nhiệm tương tác với database ( query, theo dõi thay đổi, ánh xạ đối tượng
        public WatchStoreDbContext() : base("name=StrC")
        { }
        // DbSet đại diện cho một tập thực thể có thể thực hiện các thao tác CRUD 

        //Lớp WatchStoreDbContext implement từ lớp DbContext phải có các thuộc tính kiểu DbSet cho các thực thể
        //ánh xạ tới các table và view trong cơ sở dữ liệu
        public virtual DbSet<MProduct> Products { get; set; }
        public virtual DbSet<MCategory> Categorys { get; set; }
        public virtual DbSet<MContact> Contacts { get; set; }
        public virtual DbSet<MMenu> Menus { get; set; }
        public virtual DbSet<MOrder> Orders { get; set; }
        public virtual DbSet<MOrderdetail> Orderdetails { get; set; }
        public virtual DbSet<MPost> Posts { get; set; }
        public virtual DbSet<MSlider> Sliders { get; set; }
        public virtual DbSet<MTopic> Topics { get; set; }
        public virtual DbSet<MUser> Users { get; set; }
        public virtual DbSet<MLink> Links { get; set; }
        public virtual DbSet<MRate> Rates { get; set; }

    }
}