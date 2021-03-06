﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SQLiteWithEF
{
    [Table(Name = "History")]
    public class History
    {
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int ID { get; set; }

        [Column(Name = "ID_USER", DbType = "INTEGER")]
        public string ID_USER { get; set; }

        [Column(Name = "ID_CA", DbType = "INTEGER")]
        public string ID_CA { get; set; }

        [Column(Name = "DATE", DbType = "VARCHAR")]
        public string DATE { get; set; }
    }
}
