using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchFlix_Frontend.Models
{
    public class ChatMessage
    {
        public ChatMessage(string _userName, string _content)
        {
            UserName = _userName;
            Content = _content;
        }
        public ChatMessage()
        {

        }
        public string UserName { get; set; }
        public string Content { get; set; }
        public List<string> UsersList { get; set; }
    }
}
