using System;
using System.Media;
using System.Threading;
using System.Xml.Linq;
using System.Windows;
using NAudio.Wave;

class program
{

    static void Main()
    {
        Displaylogo();
        PlayAudio();
        string name = AskUsername();
        WelcomeMessage(name);
        chatbot();

    }

   static void PlayAudio()
    {


       try {
          using (var audioFile = new AudioFileReader("C:\\Users\\Student\\source\\repos\\Chatbox\\Chatbox\\bin\\Debug\\net10.0\\welcome.wav"))
                using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(100);
                }
            }
        }
        
         catch{   Console.WriteLine("Error playing audio: " ); }
        
        
            
          
   }
    

    
    //LOGO
    static void Displaylogo()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
       
        Console.WriteLine("========================================================");
        Console.WriteLine("|\t\t Cybersecurity awareness chatbox                  |");
        Console.WriteLine("|******************************************************|");
        Console.WriteLine("|             ~~~                 ~~~                  |");
        Console.WriteLine("|       (      0                   0   )               |");
        Console.WriteLine("|      (                                 )             |");
        Console.WriteLine("|       (              _____            )              |");
        Console.WriteLine("|                                                      |");
        Console.WriteLine("|                 (*_*)(^_^)(+~_~+)                    |");
        Console.WriteLine("|                                                      |");
        Console.WriteLine("|  #$@@$%*^%$#@#$%^&*(*^%$#@$%^*(*^%$#$%^*()(*&^%$##$  |");
        Console.WriteLine("|******************************************************|");
        Console.WriteLine("|\t\t BE SECURED                                       |");
        Console.WriteLine("========================================================");
        Console.ResetColor();

    }
    //USER INPUT
    static string AskUsername()
    {
        Console.Write("\n Please enter your name:");
        string name = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(name))


        {
            Console.Write("Name cannnot be blank, please enter your name to continue");
            name = Console.ReadLine();
        }
        return name;
    }
    //WELCOME MESSAGE
    static void WelcomeMessage(string name)
    {
        Console.WriteLine($"\n Welcome {name} to the cybersecurity awareness chatbox.");
        Console.ResetColor();
        Console.WriteLine("\nYour are given access to ask about the following context:");
        Console.WriteLine("1. Phishing");
        Console.WriteLine("2. Safe browsing");
        Console.WriteLine("3. Password safety");
        Console.WriteLine("4. What can i ask you");
        Console.WriteLine("5. Purpose");
        Console.WriteLine("6. Exit");
        Console.WriteLine("\n");



    }
    //BOT
    static void chatbot()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ResetColor();

            Console.WriteLine("type:");
            string input = Console.ReadLine();
            

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Bot: Please type something.");
                continue;
            }
            input = input.ToLower();
            Console.ForegroundColor = ConsoleColor.Cyan;
            if  (input.Contains("purpose"))
            {
                Console.WriteLine("Bot: My purpose is to educate people about cybersecurity.");
            }
            else if (input.Contains("password safety"))
            {
                Console.WriteLine("Bot: Always use strong password with numbers,sysbols, upper and lowercase letters.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Bot: Phishing is when scammers try to trick you into giving personal information.");
            }
            else if (input.Contains("safe browsing"))
            {
                Console.WriteLine("Bot:Always check that websites use HTTPS and avoid suspicious links.");
            }
            else if (input.Contains("what can i ask you"))
            {
                Console.WriteLine("Bot: You can ask me about phishing, safe browsing, password safety, and my purpose.");
            }
            else if (input.Contains("exit"))
            {
                Console.WriteLine("Bot: Goodbye! Stay safe online.");
                Console.Beep();
                break;
            }
            else
            {
                Console.WriteLine("Bot: I didn't quite understand that. Could you rephrase?");
            }
            Console.ResetColor();
        }
    }

    static void TypeText(string text, int delay = 50)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }
}

