using System;
using System.Collections.Generic;
using System.Text;

namespace SendingAnSMSInvitationOtherVersion.MessageCore
{
    class Notification
    {
        private IMessenger _messenger;
        public Notification(IMessenger mes)
        {
            _messenger = mes;
        }

        public void DoNotify()
        {
            _messenger.SendAsync();  
        }
    }
}
