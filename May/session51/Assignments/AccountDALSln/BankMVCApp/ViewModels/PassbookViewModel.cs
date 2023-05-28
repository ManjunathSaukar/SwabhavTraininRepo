using AccountDALLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankMVCApp.ViewModels
{
    public class PassbookViewModel
    {
        public Account Account { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}