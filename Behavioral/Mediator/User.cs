using Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    //Colleague class
    public class User
    {
        private readonly IChatRoomMediator _chatRoom;
        public string Name { get; }

        public User(string name, IChatRoomMediator chatRoom)
        {
            this.Name = name;
            this._chatRoom = chatRoom;
        }

        public void Send(string message)
        {
            Console.WriteLine($"{Name} Sends : {message}");
            _chatRoom.SendMessage(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{Name} Receives : {message}");
        }
    }
}