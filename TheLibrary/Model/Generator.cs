using System;
using System.Text;

namespace TheLibrary.Model
{
    /// <summary>
    /// <c>Generator</c> contains methods for generating books.
    /// </summary>
    public static class Generator
    {
        /// <summary>
        /// Generate a random title for a book.
        /// </summary>
        /// <returns></returns>
        public static string GetRandomBookTitle()
        {
            Random random = new Random();
            string[] bookTitles = { "The Great Gatsby", "To Kill a Mockingbird", "1984", "Pride and Prejudice", "The Catcher in the Rye", "The Hobbit", "The Lord of the Rings", "Brave New World", "The Odyssey", "Moby-Dick", "War and Peace", "The Grapes of Wrath", "The Chronicles of Narnia", "Fahrenheit 451", "The Road", "The Da Vinci Code", "Harry Potter and the Sorcerer's Stone", "The Hunger Games", "Dune", "The Shining", "The Hitchhiker's Guide to the Galaxy", "The Alchemist", "The Kite Runner", "The Girl with the Dragon Tattoo", "The Name of the Wind", "The Stand", "Gone with the Wind", "The Great Expectations", "The Count of Monte Cristo", "The Silent Patient", "The Nightingale", "The Goldfinch", "The Handmaid's Tale", "The Little Prince", "The Secret Garden", "The Lord of the Flies", "The Jungle Book", "The Wind in the Willows", "The Adventures of Sherlock Holmes", "The Sun Also Rises", "The Road Less Traveled", "The Old Man and the Sea", "The Time Traveler's Wife", "The Color Purple", "The Art of War", "The Joy Luck Club", "The Giver", "The Book Thief", "The Fault in Our Stars", "The Girl on the Train", "The Help", "The Maze Runner", "The Life of Pi", "The Glass Castle", "The Immortal Life of Henrietta Lacks", "The Secret Life of Bees", "The Lovely Bones", "The Hunger Games", "The Green Mile", "The Curious Incident of the Dog in the Night-Time", "The Martian", "The Girl with All the Gifts", "The Handmaid's Tale", "The Road", "The Ocean at the End of the Lane", "The Night Circus", "The Goldfinch", "The Underground Railroad", "The Nightingale", "The Silent Patient", "The Giver", "The Book Thief", "The Night Stalker", "The Song of Achilles", "The Alice Network", "The Night Watchman", "The Dutch House", "The Immortal Life of Henrietta Lacks", "The Help", "The Girl on the Train", "The Lilac Girls", "The Guest List", "The Silent Wife", "The Night Before", "The Last House Guest", "The Vanishing Half", "The Tattooist of Auschwitz", "The Great Alone", "The Glass Hotel", "The Family Upstairs", "The Push", "The Invisible Life of Addie LaRue", "The Deep", "The Space Between Worlds", "The Memory Police", "The Only Good Indians", "The Once and Future Witches", "The Ten Thousand Doors of January" };
            return bookTitles[random.Next(bookTitles.Length - 1)];
        }

        /// <summary>
        /// Generate a random author name.
        /// </summary>
        /// <returns></returns>
        public static string GetRandomName()
        {
            Random random = new Random();
            string[] firstNames = { "John", "Jane", "Michael", "Emily", "William", "Olivia", "James", "Sophia", "Benjamin", "Emma", "Daniel", "Ava", "Matthew", "Isabella", "Joseph", "Mia", "David", "Charlotte", "Andrew", "Lucy", "Ethan", "Grace", "Christopher", "Lily", "Daniel", "Sophia", "Alexander", "Chloe", "Matthew", "Amelia", "Nicholas", "Abigail", "William", "Ella", "Samuel", "Madison", "Joseph", "Scarlett", "Nathan", "Avery", "Thomas", "Sofia", "Jacob", "Hannah", "Christopher", "Elizabeth", "Anthony", "Victoria", "Joshua", "Penelope", "Ryan", "Natalie", "Elijah", "Zoe", "Liam", "Audrey", "Tyler", "Layla", "William", "Aria", "Alexander", "Madeline", "Mason", "Hazel", "Luke", "Leah", "Evan", "Aubrey", "Christian", "Nora", "Isaac", "Aurora", "Dylan", "Brooklyn", "Carter", "Riley", "Gabriel", "Ellie", "Logan", "Savannah", "Jack", "Alice", "Jackson", "Stella", "Owen", "Maya", "Henry", "Julia", "Sebastian", "Evelyn", "Landon", "Claire", "Zachary", "Abigail", "Eli", "Harper", "Nathaniel", "Lillian", "Gavin", "Anna" };
            string[] lastNames = { "Smith", "Johnson", "Brown", "Davis", "Wilson", "Lee", "Anderson", "Harris", "Clark", "White", "Walker", "Hall", "Young", "Allen", "King", "Wright", "Turner", "Hill", "Carter", "Scott", "Adams", "Mitchell", "Robinson", "Garcia", "Martinez", "Miller", "Thomas", "Hernandez", "Moore", "Martin", "Jackson", "Thompson", "Lewis", "Lewis", "Allen", "Young", "Wright", "Turner", "Hill", "Carter", "Scott", "Adams", "Mitchell", "Robinson", "Garcia", "Martinez", "Miller", "Thomas", "Hernandez", "Moore", "Martin", "Jackson", "Thompson", "Lewis", "Allen", "Young", "Wright", "Turner", "Hill", "Carter", "Scott", "Adams", "Mitchell", "Robinson", "Garcia", "Martinez", "Miller", "Thomas", "Hernandez", "Moore", "Martin", "Jackson", "Thompson", "Lewis", "Walker", "Hall", "Young", "Allen", "King", "Wright" };
            return $"{firstNames[random.Next(firstNames.Length - 1)]} {lastNames[random.Next(lastNames.Length - 1)]}";
        }

        /// <summary>
        /// Generate a random barcode.
        /// </summary>
        /// <param name="length"></param>
        /// <returns>a barcode string</returns>
        public static string GenerateRandomBarcode(int length)
        {
            Random random = new Random();
            const string characters = "0123456789AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZzÆæØøÅå";
            StringBuilder barcode = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                barcode.Append(characters[random.Next(characters.Length - 1)]);
            }

            return barcode.ToString();
        }
    }
}
