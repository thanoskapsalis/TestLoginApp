using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestLoginApp.Models
{
    //Ta Models genika xrhsimevoun gia na stelnoyme dedomena apo tous controller sta views kai to aditheto 
    //Xrhsimopoioudai toso apo ta ajax request gia na xtisoun ta json oso kai san omi c# mesa sta views gia na organwsoyme ta dedomena mas
    public class UserModel
    {
        public string username { get; set; } //idia morfi me to json
        public string password { get; set; } //idia morfi me to json
    }
}