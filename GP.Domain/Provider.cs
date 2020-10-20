using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Provider:Concept
    {

        //public string ConfirmPassword { get { return confirmpassword; }
        //    set { if (string.Compare(Password, ConfirmPassword) != 0)
        //            System.Console.WriteLine("Erreur");
        //        else confirmpassword = value;
        //    } }

        private string confirmpassword;
        private string password;
        public string ConfirmPassword { get; set; }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public  int Id { get; set; }
        public bool IsApproved { get; set; }
        
        public string Password { get { return password; }  set {
                if (value.Length >= 5 && value.Length <= 20)
                    password = value;
                else
                    System.Console.WriteLine("le password doit être une chaîne " +
                        "de caractères dont la taille est dans "+
                        "intervalle[5, 20]");
            } }
        public string UserName { get; set; }
        public List<Product> Products { get; set; }

        public override void GetDetails()
        {
            System.Console.WriteLine("Id:" + Id +
               " UserName: " + UserName+" Email:"+Email);
            if (Products != null)
            {
                foreach (Product p in Products ) { p.GetDetails(); }
            }
        }

        public void GetProducts(string filterType, string filterValue)
        {
            if (Products != null)
            {
                switch (filterType)
                {
                    case "Name" : foreach (Product p in Products){

                            if (string.Equals(p.Name, filterValue)){
                                p.GetDetails();
                            }

                        }
                        break;
                    case "DateProd":
                        foreach (Product p in Products)
                        {

                            if (DateTime.Equals(p.DateProd,
                                DateTime.Parse(filterValue)))
                            {
                                p.GetDetails();
                            }

                        }
                        break;
                    case "Price":
                        foreach (Product p in Products)
                        {

                            if (p.Price == double.Parse(filterValue))
                            {
                                p.GetDetails();
                            }

                        }
                        break;
                    case "ProductId":
                        foreach (Product p in Products)
                        {

                            if (p.ProductId == int.Parse(filterValue))
                            {
                                p.GetDetails();
                            }

                        }
                        break;
                    case "Quantity":
                        foreach (Product p in Products)
                        {

                            if (p.Quantity == int.Parse(filterValue))
                            {
                                p.GetDetails();
                            }

                        }
                        break;
                    case "Description":
                        foreach (Product p in Products)
                        {

                            if (string.Equals(p.Description, filterValue))
                            {
                                p.GetDetails();
                            }

                        }
                        break;

                }
            }

        }

        public bool Login(string username , string password ) {
            return string.Compare(UserName, username) == 0 
                && string.Compare(password, Password) == 0;
        }

        //public bool Login(string username, string password , string email)
        //{
        //    return string.Compare(UserName, username) == 0
        //        && string.Compare(password, Password) == 0 
        //        && string.Compare(email,Email)==0 ;
        //}

        public bool Login(string username, string password, string email)
        {

            //if (email == null) {
            //    return string.Compare(UserName, username) == 0 
            //    && string.Compare(password, Password) == 0; }
            //else

            //    return string.Compare(UserName, username) == 0
            //    && string.Compare(password, Password) == 0 
            //    && string.Compare(email, Email) == 0;

            return string.Compare(UserName, username) == 0
                && string.Compare(password, Password) == 0
                && email != null ? string.Compare(Email, email) == 0:true;
                
        }

        public static void SetIsApproved(Provider P)
        {
            P.IsApproved = string.Compare(P.Password, P.ConfirmPassword)
                == 0;
        }

        public static void SetIsApproved(string password , 
            string confirmpassword ,bool isApproved)
        {
            isApproved = string.Compare(password, confirmpassword) == 0;
        }

        public Provider()
        {
                
        }

        public Provider(string confirmPassword, DateTime dateCreated,
            string email, int id, bool isApproved, string password,
            string userName)
        {
            ConfirmPassword = confirmPassword;
            DateCreated = dateCreated;
            Email = email;
            Id = id;
            IsApproved = isApproved;
            Password = password;
            UserName = userName;
        }


    }
}
