﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SendingAnSMSInvitationOtherVersion.Phone
{
    interface IPhoneValidator
    {
        bool IsValid(Phone phone);
    }
}
