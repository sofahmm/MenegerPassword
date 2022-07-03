using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MenegerPassword.SQLite
{
    [Table("Account")]
    public class Account
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }
        public string Login { get; set; }
        public int Password { get; set; }
        public Uri Url { get; set; }
        public Type IdType { get; set; }
    }
}
