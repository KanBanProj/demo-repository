using System.Text.Json;
using System;
namespace IntroSE.KanBan.Backend.ServiceLayer
{
	public class Task
	{
        private int currColumn;
        private int id;
        private string Tittle;
        private string Descreption;
        private string dueDate;
        private string CreationTime;
        private int loc;

        public string ChangeTittle(string Tittle)
        {
            return JsonSerializer.Serialize(new Response("not emplemented yet"));
        }

        public string ChangeDescreptioon(string Descreption)
        {
            
            return JsonSerializer.Serialize(new Response("not emplemented yet"));
            
        }
        public string ChangeCol()
        {
            return JsonSerializer.Serialize(new Response("not emplemented yet"));
        }

        public string ChangeDueDate(string Date)
        {
            return JsonSerializer.Serialize(new Response("not emplemented yet"));
        }
    }
}
