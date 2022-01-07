using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace SouvenirApplication.Models
{
    public class SouvenirShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
    }
}
