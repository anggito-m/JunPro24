using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatchUP
{
    public class Chatbot
    {
        // Deklarasi variabel
        public int ChatID { get; set; }
        public string Prompt { get; set; }
        public DateTime Time { get; set; }

        // Constructor
        public void Chatbot(int chatID, string prompt, DateTime time)
        {
            ChatID = chatID;
            Time = time;
            Console.WriteLine("Halo! Apakah ada yang bisa saya bantu?");
        }

        // Method untuk menjawab prompt
        public string AnswerPrompt()
        {
            Prompt = Console.ReadLine();
            return "Terima kasih atas pertanyaannya. Anda bertanya: " + Prompt;
        }
    }
}