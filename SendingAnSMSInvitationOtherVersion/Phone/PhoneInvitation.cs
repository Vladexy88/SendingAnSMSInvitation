using SendingAnSMSInvitationOtherVersion.MessageCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SendingAnSMSInvitationOtherVersion.Phone
{
    class PhoneInvitation
    {
        public IPhoneReader Reader { get; set; }
        public IPhoneBinder Binder { get; set; }
        public IPhoneValidator Validator { get; set; }
       
        public PhoneInvitation(IPhoneBinder phoneBinder, IPhoneReader phoneReader, IPhoneValidator phoneValidator)
        {
            this.Binder = phoneBinder;
            this.Reader = phoneReader;
            this.Validator = phoneValidator;
        }
      

        public void GetPhoneInvitation()
        {
            string[] data = Reader.GetInputData();
            Phone phone = Binder.CreatePhone(data);
            if (Validator.IsValid(phone))
            {
                System.Windows.MessageBox.Show("Done", "Validate");
            }
        }
    }
}
