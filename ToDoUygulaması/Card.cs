using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoUygulaması
{
    public class Card
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Member Member { get; set; }
        public Size Size { get; set; }
        public Board Colon { get; set; }

        public Card(string title, string content, Member member, Size size, Board colon)
        {
            Title = title;
            Content = content;
            Member = member;
            Size = size;
            Colon = colon;
        }
    }
}
