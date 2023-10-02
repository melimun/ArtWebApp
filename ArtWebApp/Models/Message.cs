using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebApp.Models
{
    public class Message
    {
        public int messageId {get;}

        public User sender {get;set;}

        public User receiver {get;set;}

        public string message {get;private set;}        
    }
}