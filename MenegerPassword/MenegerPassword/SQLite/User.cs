using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MenegerPassword.SQLite
{
    [Table("User")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }
        public string Login { get; set; }
        public int Password { get; set; }
    }
}
