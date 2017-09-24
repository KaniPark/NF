using System;

namespace NF.Models
{
    public class Member
    {
        public Member()
        {
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string PhoneNumber
        {
            get;
            set;
        }

        public DateTime DateOfBirth
        {
            get;
            set;
        }

		public int Age
		{
			get;
			set;
		}
    }
}
