using System;
using System.Collections.Generic;
using System.Text;

namespace SendingAnSMSInvitationOtherVersion.Phone
{
    class PhoneBinder : IPhoneBinder
    {
        public PhoneBinder()
        {

        }

        public Phone CreatePhone(string[] data)
        {
            if(data.Length != 0)
            {
                return new Phone { Numbers = data };
            }
            throw new Exception("Мало данных");


        }
    }
}
