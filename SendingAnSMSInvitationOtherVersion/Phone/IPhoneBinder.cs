using System;
using System.Collections.Generic;
using System.Text;

namespace SendingAnSMSInvitationOtherVersion.Phone
{
    interface IPhoneBinder
    {
        Phone CreatePhone(string[] data);
    }
}
