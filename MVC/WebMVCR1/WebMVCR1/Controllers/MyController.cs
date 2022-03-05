using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers
{
    public class MyController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index(string hel)
        {
            string Greeting = ModelClass.ModelHello() + ", " + hel;
            //return Greeting; 

            //string res = ExeEnum();
            string res = ExeStruct(); 
            return res;
        }

        public string ExeEnum()
        {
            AccountType goldAccount;
            AccountType platinumAccount;
            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            string res1 = String.Format("Тип банковского счета {0}", goldAccount);
            string res2 = String.Format("Тип банковского счета {0}", platinumAccount);
            string res = res1 + "<p>" + res2;
            return res;
        }
        public string ExeStruct()
        {
            BankAccount goldBankAccount;
            goldBankAccount.accType = AccountType.Checking; 
            goldBankAccount.accBal = (decimal)3200.00; 
            goldBankAccount.accNo = 123;

            string res = String.Format("Номер счета {0}, баланс {1}, тип {2}", 
                goldBankAccount.accNo, goldBankAccount.accBal, goldBankAccount.accType); 
            return res;
        }
    }
}