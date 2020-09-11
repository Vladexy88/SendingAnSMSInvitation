using SendingAnSMSInvitationOtherVersion.MessageCore;
using SendingAnSMSInvitationOtherVersion.Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SendingAnSMSInvitationOtherVersion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IMessenger _messenger;
        private readonly Notification _notification;
        private readonly PhoneInvitation _phoneInvitation;
        public MainWindow()
        {
            InitializeComponent();
            _messenger = new Sms();
            _notification = new Notification(_messenger);
            _phoneInvitation = new PhoneInvitation(new PhoneBinder(), new PhoneReader(), new PhoneValidator());
        }

        private void StartWork(object sender, RoutedEventArgs e)
        {
            _phoneInvitation.GetPhoneInvitation();
            _notification.DoNotify();
        }
    }
}
