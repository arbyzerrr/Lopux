﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lopus
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class LopyxEntities : DbContext
    {
        private static LopyxEntities _context;
        public LopyxEntities()
            : base("name=LopyxEntities")
        {
        }
        public static LopyxEntities GetContext()
        {
            if (_context == null) _context = new LopyxEntities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public virtual DbSet<authoriz> authorizs { get; set; }
        public virtual DbSet<Агент> Агент { get; set; }
        public virtual DbSet<Аналитик> Аналитик { get; set; }
        public virtual DbSet<График_смены> График_смены { get; set; }
        public virtual DbSet<Заявка> Заявка { get; set; }
        public virtual DbSet<Мастер_смены> Мастер_смены { get; set; }
        public virtual DbSet<Материал> Материал { get; set; }
        public virtual DbSet<Менеджер> Менеджер { get; set; }
        public virtual DbSet<Предложение> Предложение { get; set; }
        public virtual DbSet<Продукт> Продукт { get; set; }
        public virtual DbSet<Продукция> Продукция { get; set; }
        public virtual DbSet<Производство> Производство { get; set; }
        public virtual DbSet<Сотрудник> Сотрудник { get; set; }
        public virtual DbSet<ТипОрганизации> ТипОрганизации { get; set; }
        public virtual DbSet<Точка_продажи> Точка_продажи { get; set; }
        public virtual DbSet<Турникет> Турникет { get; set; }
        public virtual DbSet<Цех> Цех { get; set; }
    }
}
