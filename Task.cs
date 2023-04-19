using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KanBanProj.ServiceLayer
{
    internal class Task
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

