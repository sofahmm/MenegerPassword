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
        public string Password { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
    }
}
