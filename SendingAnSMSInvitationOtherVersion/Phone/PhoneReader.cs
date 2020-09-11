using System;
using System.Collections.Generic;
using System.Text;

namespace SendingAnSMSInvitationOtherVersion.Phone
{
    class PhoneReader : IPhoneReader
    {
        public PhoneReader()
        {

        }
        public string[] GetInputData()
        {
            return new string[] { "79123456789", "79423256789", "79573456789", "79993456789" };
        }
    }
}
