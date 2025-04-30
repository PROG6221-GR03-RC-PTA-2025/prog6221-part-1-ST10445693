using System;


namespace Chatbot
{
    class Program
    {
       

        static void Main(string[] args)
        {
            GreetUser();
            string userName = GetUserInput("What is your name? ");
            string userPurpose = GetUserInput($"Hello, {userName}! What can I help you with today? ");

            RespondToUser(userPurpose);
            GetFeedback();
        }

        static void GreetUser()
        {
  
        }

        static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static void RespondToUser(string userPurpose)
        {
            
            string response;
            if (string.IsNullOrWhiteSpace(userPurpose))
            {
                response = "I’m sorry, I didn’t quite catch that. Could you please rephrase?";
            }
            else
            {
                response = "You asked about: {userPurpose}. Let me see how I can assist you with that.";
            }
            Console.WriteLine(response);

          
        }

        static void GetFeedback()
        {
            
            Console.WriteLine("On a scale of 1 to 5, how would you rate my response?");
            string feedback = Console.ReadLine();


            if (int.TryParse(feedback, out int rating) && rating >= 1 && rating <= 5)
            {
                Console.WriteLine($"Thank you for your feedback: {rating}. I hope to improve!");
                
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
               
            }
           
        }

        
    }
}
