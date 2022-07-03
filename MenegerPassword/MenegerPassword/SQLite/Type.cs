using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MenegerPassword.SQLite
{
    [Table("Type")]
    public class Type
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
