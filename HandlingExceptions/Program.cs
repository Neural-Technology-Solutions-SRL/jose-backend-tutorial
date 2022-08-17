// See https://aka.ms/new-console-template for more information
namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Lesson22\Exampl.txt");
                Console.WriteLine(content);
                Console.ReadLine();
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is named correctly: Exampl.txt");
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the directory C:\\Lesson22 exists");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //code to finalize
                //setting objects to null
                //Closing database connections
                Console.WriteLine("Closing application now...");
            }
            Console.ReadLine();
            
        }
    }
}
