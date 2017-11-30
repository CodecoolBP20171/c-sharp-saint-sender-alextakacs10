using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    class Populator
    {
        APIHandler gmailAPI = new APIHandler();
        
        public async Task<IList<string[]>> Populate(string labelId)
        {
            IList<Google.Apis.Gmail.v1.Data.Message> Messages = await gmailAPI.GetMessages(labelId);
            IList<string[]> result = new List<string[]>();
            foreach (Google.Apis.Gmail.v1.Data.Message message in Messages)
            {
                String[] newObject = new String[2];
                newObject[0] = gmailAPI.GetSubject(message.Payload);
                newObject[1] = message.Id;
                result.Add(newObject);
            }

            return result;
        }
    }
}
