namespace ACM.BL
{
    class Customer
    {

        public int customerId { get; private set; }
        public string emailAddress { get; set; }
        public string FirstName { get; set; }

        private string _lastName;
        public string LastName
        {

            get { return _lastName; }

            set { _lastName = value; }

        }


        public string fullName
        {
            get  return LastName + "," + FirstName; }
        }

    }
}
