using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SendingAnSMSInvitationOtherVersion.Phone
{
    class PhoneValidator : IPhoneValidator
    {
        public PhoneValidator()
        {

        }

        public bool IsValid(Phone phone)
        {
            if (phone.Numbers.Length == 0)
            {
                return false;
            }

            var isCorrectData = phone.Numbers.Any(s => s.Length == 11 && s.IndexOf("+") == -1 && s.IndexOf("(") == -1 && s.IndexOf(")") == -1 && s.IndexOf(" ") == -1);

            if (!isCorrectData)
            {
                System.Windows.MessageBox.Show("Error", " One or several phone numbers do not match with international format.");
            }
            return isCorrectData ? true : false;
        }
    }
}
