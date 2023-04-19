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

        public Response ChangeTittle(string Tittle)
        {
            return new Response("not emplemented yet");
        }
    }
}
