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

namespace SaintSender
{
    class APIHandler
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/gmail-dotnet-quickstart.json
        static string[] Scopes = { GmailService.Scope.GmailReadonly };
        static string ApplicationName = "Gmail API .NET Quickstart";

        static GmailService service = CreateService(CreateCredentials());

        static UsersResource.MessagesResource.ListRequest MessageListRequest = service.Users.Messages.List("me");
        static UsersResource.LabelsResource.ListRequest LabelListRequest = service.Users.Labels.List("me");

        static IList<Message> MessageResponse = MessageListRequest.Execute().Messages;
        static IList<Label> LabelResponse = LabelListRequest.Execute().Labels;

        public IList<Message> GetMessages(string labelId)
        {
            IList<Message> Messages = new List<Message>();

            foreach (Message message in MessageResponse)
            {
                Message MessageObject = service.Users.Messages.Get("me", message.Id).Execute();
                if(MessageObject.LabelIds.Contains(labelId))
                {
                    Messages.Add(MessageObject);
                }
            }

            return Messages;
        }

        public string GetSubject(MessagePart messagePart)
        {
            IList<MessagePartHeader> headers = messagePart.Headers;
            string subject = "(No subject)";
            foreach(MessagePartHeader header in headers)
            {
                if(header.Name == "Subject")
                {
                    subject = header.Value;
                }
            }
            return subject;
        }

        private static UserCredential CreateCredentials()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/gmail-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
                return credential;
            }
        }

        private static GmailService CreateService(UserCredential credential)
        {
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            return service;
        }


    }
}
