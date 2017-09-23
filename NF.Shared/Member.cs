using System;
namespace NF.Shared
{
    /// <summary>
    /// Member.
    /// </summary>
    public class Member
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="T:NF.Shared.Member"/> class.
        /// </summary>
        public Member()
        {
        }
        #endregion

        #region Properties
        public int ID
        {
            get;
            set;
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

        public string MemberNumber
        {
            get;
            set;
        }

        public string Gender
        {
            get;
            set;
        }

        public string PhoneNumber
        {
            get;
            set;
        }
        #endregion
    }
}
