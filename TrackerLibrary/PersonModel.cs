using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// The first name of the person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The person's email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The person's phone number.
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
