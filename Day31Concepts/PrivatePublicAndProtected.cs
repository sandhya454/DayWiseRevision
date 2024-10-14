using System;

namespace Day31Concepts.PrivatePublicAndProtected
{
    public class Customer
    {
        private int _id;
        protected string name;
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }

    public class CorporateCustomer : Customer
    {
        public void PrintName()
        {
            CorporateCustomer corporateCustomer = new CorporateCustomer();
            corporateCustomer.name = "Savar";
            Console.WriteLine(corporateCustomer.name);
        }
    }

    public class GovernmentCustomer
    {
        public void PrintId()
        {
            Customer customer = new Customer();
            customer.ID = 100;
            Console.WriteLine(customer.ID);

            //throws an error because _id set to private filed
            //Console.WriteLine(cutsomer._id);
        }
    }
}


