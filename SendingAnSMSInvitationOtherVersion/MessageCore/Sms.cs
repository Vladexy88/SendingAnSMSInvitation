using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SendingAnSMSInvitationOtherVersion.MessageCore
{
    class Sms : IMessenger
    {
        private HttpClient _client;
        private HttpResponseMessage _response;
        public Sms()
        {
            _client = new HttpClient();
            _response = new HttpResponseMessage();
        }

        public async void SendAsync()
        {
            try
            {
                var url = "";
                var responseBody = "";
                _client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.142 Safari/537.36");
                try
                {
                    var request = new HttpRequestMessage(HttpMethod.Get, url);
                    _response = await _client.SendAsync(request);
                    responseBody = await _response.Content.ReadAsStringAsync();
                    System.Windows.MessageBox.Show("Responsed", "Done");
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show(ex.ToString());
                }
            }
            catch (HttpRequestException e)
            {
                System.Windows.MessageBox.Show("Exception Caught", $"Message:{e.Message}");
            }
            finally
            {
                _client.Dispose();
                _response.Dispose();
            }
        }
    }
}
