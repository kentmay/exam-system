﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExaminationSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ExaminationSystemDbEntities : DbContext
    {
        public ExaminationSystemDbEntities()
            : base("name=ExaminationSystemDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ES_ExamPaper> ES_ExamPaper { get; set; }
        public virtual DbSet<ES_ExamPaper_Exercise> ES_ExamPaper_Exercise { get; set; }
        public virtual DbSet<ES_ExamPart> ES_ExamPart { get; set; }
        public virtual DbSet<ES_Exercise> ES_Exercise { get; set; }
        public virtual DbSet<ES_FillAnswer> ES_FillAnswer { get; set; }
        public virtual DbSet<ES_FillQuestion> ES_FillQuestion { get; set; }
        public virtual DbSet<ES_JudgeQuestion> ES_JudgeQuestion { get; set; }
        public virtual DbSet<ES_MultipleAnswer> ES_MultipleAnswer { get; set; }
        public virtual DbSet<ES_MultipleQuestion> ES_MultipleQuestion { get; set; }
        public virtual DbSet<ES_Paper_Tag> ES_Paper_Tag { get; set; }
        public virtual DbSet<ES_Permission> ES_Permission { get; set; }
        public virtual DbSet<ES_Role> ES_Role { get; set; }
        public virtual DbSet<ES_Role_Permission> ES_Role_Permission { get; set; }
        public virtual DbSet<ES_SelectQuestion> ES_SelectQuestion { get; set; }
        public virtual DbSet<ES_Tag> ES_Tag { get; set; }
        public virtual DbSet<ES_Tag_Exercise> ES_Tag_Exercise { get; set; }
        public virtual DbSet<ES_User> ES_User { get; set; }
        public virtual DbSet<ES_User_ExamPaper> ES_User_ExamPaper { get; set; }
        public virtual DbSet<ES_User_ExamPart> ES_User_ExamPart { get; set; }
        public virtual DbSet<User_ExamPart_ExamPaper_v> User_ExamPart_ExamPaper_v { get; set; }
        public virtual DbSet<ES_Image> ES_Image { get; set; }
        public virtual DbSet<ES_ExamLog> ES_ExamLog { get; set; }
    }
}
