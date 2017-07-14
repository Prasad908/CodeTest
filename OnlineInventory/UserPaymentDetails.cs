using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OnlineInventory
{
    public interface IUserDetails
    {
       bool ChargePayment(string creditCardNumber, decimal amount);
       bool ChargePayment(string Cvv, string FullName);
    }

    public class UserPaymentDetails : IUserDetails
    {
        public bool ChargePayment(string Cvv, string FullName)
        {
            if (!string.IsNullOrEmpty(Cvv) && !string.IsNullOrEmpty(FullName))
            {
                return true;

            }
            else
            {
                throw new Exception("Please Check your Cvv Number:");
            }
       

        }

        public bool ChargePayment(string creditCardNumber, decimal amount)
        {
            // checking the credit card  Details
            if (!string.IsNullOrEmpty(creditCardNumber) && amount>0)
            {
                return true;
            }
            else
            {
                throw new Exception("Please check you Credit Card Number ");   

            }

                //we should call some third party application.Here.

                //using Customer card details.

                //locking it to the uri address to resource.

             }

   
        }


    }


           

