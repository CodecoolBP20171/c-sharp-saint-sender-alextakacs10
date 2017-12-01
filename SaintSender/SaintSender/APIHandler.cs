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
                
        private async Task<IList<Message>> GetAllMessages()
        {
            IList<Message> Messages = new List<Message>();

            foreach (Message message in MessageResponse)
            {
                var request = service.Users.Messages.Get("me", message.Id);
                request.Format = UsersResource.MessagesResource.GetRequest.FormatEnum.Metadata;
                Message response = await request.ExecuteAsync();
                Messages.Add(response);
            }
            return Messages;
        }

        public async Task<IList<Message>> GetMessages(string labelId)
        {
            IList<Message> allMessages = await GetAllMessages();
            IList<Message> labeledMessages = new List<Message>();
            foreach (Message message in allMessages)
            {
                if (message.LabelIds.Contains(labelId))
                {
                    labeledMessages.Add(message);
                }
            }
            return labeledMessages;
        }

        public string GetSubject(MessagePart messagePart)
        {
            IList<MessagePartHeader> headers = messagePart.Headers;
            string subject = "(No subject)";
            foreach(MessagePartHeader header in headers)
            {
                if(header.Name == "Subject")
                {
                    if(header.Value != "")
                    {
                        subject = header.Value;
                    } else
                    {
                        subject = "(No subject)";
                    }

                }
            }
            return subject;
        }

        public string GetSender(MessagePart messagePart)
        {
            IList<MessagePartHeader> headers = messagePart.Headers;
            string sender = "Unknown user";
            foreach (MessagePartHeader header in headers)
            {
                if (header.Name == "From")
                {
                    sender = header.Value;
                }
            }
            return sender;
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
