using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace ArtWebApp.Models
{
    public class Message
    {
        public int MessageId {get;set;}

        public int UserId {get;set;}

        public int receiver {get;set;} //also a userId

        public string message {get;set;}        
    }
}