using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppp;

namespace ToDoAppp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> Todo = new List<Card>();
            List<Card> InProgress = new List<Card>();
            List<Card> Done = new List<Card>();

                    Dictionary<int, string> Member = new Dictionary<int, string>()
                {
                    { 1,"Ali"},
                    { 2,"Güven"},
                    { 3,"Aylin"},
                    { 4,"Salih"},
                    { 5,"Veli"},
                    { 6,"Ayşe"},
                };

            Card card = new Card();

            Card card1 = new Card();
            card1.Title = "BackEnd";
            card1.Content = "Csharp";
            card1.MemberId = Member[1];
            card1.Size = Size.L;

            Card card2 = new Card();
            card2.Title = "FrontEnd";
            card2.Content = "Html";
            card2.MemberId = Member[2];
            card2.Size = Size.M;

            Card card3 = new Card();
            card3.Title = "Apllication";
            card3.Content = "Kotlin";
            card3.MemberId = Member[3];
            card3.Size = Size.S;

            Card card4 = new Card();
            card3.Title = "BackEnd";
            card3.Content = "Java";
            card3.MemberId = Member[4];
            card3.Size = Size.Xs;

            Card card5 = new Card();
            card3.Title = "FrontEnd";
            card3.Content = "Css";
            card3.MemberId = Member[5];
            card3.Size = Size.Xs;

            Card card6 = new Card();
            card3.Title = "Apilication";
            card3.Content = "Swift";
            card3.MemberId = Member[5];
            card3.Size = Size.M;

            Todo.Add(card1);
            Todo.Add(card2);
            InProgress.Add(card3);
            InProgress.Add(card4);
            Done.Add(card5);
            Done.Add(card6);


            MainMenu();

            void MainMenu()
            {
                Console.WriteLine("Please select the action you want to do :");
                Console.WriteLine("******************************************");
                Console.WriteLine("(1) List the board");
                Console.WriteLine("(2) Add a card in board");
                Console.WriteLine("(3) Remove the card from board");
                Console.WriteLine("(4) Move the card to an another board");

                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        ListBoard();
                        break;
                    case 2:
                        AddCard();
                        break;
                    case 3:
                        RemoveCard();
                        break;
                    case 4:
                        MoveCard();
                        break;
                }
            }
            void ListBoard()
            {
                Console.WriteLine("TODO Line");
                Console.WriteLine("**************");
                foreach (var item in Todo)
                {
                    Console.WriteLine("Title : " + item.Title);
                    Console.WriteLine("Content : " + item.Content);
                    Console.WriteLine("Person : " + item.MemberId);
                    Console.WriteLine("Size : " + item.Size);
                    Console.WriteLine("---------------");
                }

            }
            void AddCard()
            {
                Console.WriteLine("Enter title :");
                card.Title = Console.ReadLine();
                Console.WriteLine("Enter content :");
                card.Content = Console.ReadLine();
                Console.WriteLine("Select size -> Xs(1),S(2),M(3),L(4),Xl(5) :");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        card.Size = Size.Xs;
                        break;
                    case 2:
                        card.Size = Size.S;
                        break;
                    case 3:
                        card.Size = Size.M;
                        break;
                    case 4:
                        card.Size = Size.L;
                        break;
                    case 5:
                        card.Size = Size.Xl;
                        break;
                }
                Console.WriteLine("Select a person :");
                int b = int.Parse(Console.ReadLine());
                if (!Member.ContainsKey(b))
                {
                    Console.WriteLine("Incorrect entry has done! Try again");
                    AddCard();
                }
                else
                {
                    card.MemberId = Member[b];
                }
                Console.WriteLine("Select the board type you want to add the card :");
                Console.WriteLine("(1)TODO, (2)INPROGRESS, (3)DONE");
                int c = int.Parse(Console.ReadLine());
                if (c == 1)
                {
                    Todo.Add(card);
                    foreach (var item in Todo)
                    {
                        Console.WriteLine("Title : " + item.Title);
                        Console.WriteLine("Content : " + item.Content);
                        Console.WriteLine("Person : " + item.MemberId);
                        Console.WriteLine("Size : " + item.Size);
                        Console.WriteLine("---------------");
                    }
                }
                else if (c == 2)
                {
                    InProgress.Add(card);
                    foreach (var item in InProgress)
                    {
                        Console.WriteLine("Title : " + item.Title);
                        Console.WriteLine("Content : " + item.Content);
                        Console.WriteLine("Person : " + item.MemberId);
                        Console.WriteLine("Size : " + item.Size);
                        Console.WriteLine("---------------");
                    }
                }
                else if (c == 3)
                {
                    Done.Add(card);
                    foreach (var item in Done)
                    {
                        Console.WriteLine("Title : " + item.Title);
                        Console.WriteLine("Content : " + item.Content);
                        Console.WriteLine("Person : " + item.MemberId);
                        Console.WriteLine("Size : " + item.Size);
                        Console.WriteLine("---------------");
                    }
                }
                MainMenu();
            }
            void RemoveCard()
            {
                Console.WriteLine("First you should select the card you want to delete.");
                Console.WriteLine("Enter the card's name :");
                String name = Console.ReadLine();

                Todo.RemoveAll(i => i.Title.ToLower() == name.ToLower());
                InProgress.RemoveAll(i => i.Title.ToLower() == name.ToLower());
                Done.RemoveAll(i => i.Title.ToLower() == name.ToLower());

                foreach (var item in Todo)
                {
                    Console.WriteLine("Title : " + item.Title);
                    Console.WriteLine("Content : " + item.Content);
                    Console.WriteLine("Person : " + item.MemberId);
                    Console.WriteLine("Size : " + item.Size);
                    Console.WriteLine("---------------\n");
                }
                bool a = Todo.Any(i => i.Title.ToLower() != name.ToLower());
                if (a)
                {
                    Console.WriteLine("The card matching your search criteria was not found in the board. Please make a selection :");
                    Console.WriteLine("For ending removing (1)");
                    Console.WriteLine("For try again (2)");
                    int n = int.Parse(Console.ReadLine());
                    if (n == 2)
                    {
                        RemoveCard();
                    }
                }
            }
            void MoveCard()
            {
                Console.WriteLine("First you should select the card you want to delete.");
                Console.WriteLine("Enter the card's name :");
                String cardTitle = Console.ReadLine();

                var titlesTodo = Todo.Where(i => i.Title.ToLower() == cardTitle.ToLower()).ToList();
                var titlesInprogress = InProgress.Where(i => i.Title.ToLower() == cardTitle.ToLower()).ToList();
                var titlesDone = Done.Where(i => i.Title.ToLower() == cardTitle.ToLower()).ToList();

                foreach (var item in titlesTodo)
                {
                    Console.WriteLine("Card Informations :");
                    Console.WriteLine("********************");
                    Console.WriteLine("Title : " + item.Title);
                    Console.WriteLine("Content : " + item.Content);
                    Console.WriteLine("Person : " + item.MemberId);
                    Console.WriteLine("Size : " + item.Size);
                    Console.WriteLine("---------------");
                }

                foreach (var item in titlesInprogress)
                {
                    Console.WriteLine("Card Informations :");
                    Console.WriteLine("********************");
                    Console.WriteLine("Title : " + item.Title);
                    Console.WriteLine("Content : " + item.Content);
                    Console.WriteLine("Person : " + item.MemberId);
                    Console.WriteLine("Size : " + item.Size);
                    Console.WriteLine("---------------");
                }

                foreach (var item in titlesDone)
                {
                    Console.WriteLine("Card Informations :");
                    Console.WriteLine("********************");
                    Console.WriteLine("Title : " + item.Title);
                    Console.WriteLine("Content : " + item.Content);
                    Console.WriteLine("Person : " + item.MemberId);
                    Console.WriteLine("Size : " + item.Size);
                    Console.WriteLine("---------------");
                }

                Console.WriteLine("Please select the board you want to move :");
                Console.WriteLine("(1)TODO (2)INPROGRESS (3)DONE");
                int n = int.Parse(Console.ReadLine());

                if (n == 1)
                {
                    titlesInprogress.ForEach(i => InProgress.Remove(i));
                    titlesDone.ForEach(i => Done.Remove(i));
                    titlesDone.ForEach(i => Todo.Add(i));
                    titlesInprogress.ForEach(i => Todo.Add(i));
                }
                else if (n == 2)
                {
                    titlesTodo.ForEach(i => Todo.Remove(i));
                    titlesDone.ForEach(i => Done.Remove(i));
                    titlesDone.ForEach(i => InProgress.Add(i));
                    titlesTodo.ForEach(i => InProgress.Add(i));
                    foreach (var item in InProgress)
                    {
                        Console.WriteLine("Title : " + item.Title);
                        Console.WriteLine("Content : " + item.Content);
                        Console.WriteLine("Person : " + item.MemberId);
                        Console.WriteLine("Size : " + item.Size);
                        Console.WriteLine("---------------");
                    }
                }
                else if (n == 3)
                {
                    titlesInprogress.ForEach(i => InProgress.Remove(i));
                    titlesTodo.ForEach(i => Todo.Remove(i));
                    titlesInprogress.ForEach(i => Done.Add(i));
                    titlesTodo.ForEach(i => Done.Add(i));
                }
                bool a = Todo.Any(i => i.Title.ToLower() != cardTitle.ToLower());
                if (a)
                {
                    Console.WriteLine("The card matching your search criteria was not found in the board. Please make a selection :");
                    Console.WriteLine("For ending removing (1)");
                    Console.WriteLine("For try again (2)");
                    int b = int.Parse(Console.ReadLine());
                    if (b == 2)
                    {
                        MoveCard();
                    }
                }
            }

        }


    }
}
