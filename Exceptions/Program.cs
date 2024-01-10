using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            try
            {
                Find();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            HandleException(() => //Profesyonel kullanım
            {
                Find();
            });

            Console.ReadLine();
        }

        private static void HandleException(Action action) //Profesyonel kullanım (bir class haline getirip her yerde inherit edebilirsin.)
        {
            try
            {
                action.Invoke(); // 23.satırdaki HandleExceptionun içini çalıştır anlamına gelir. (Invoke)
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string>() { "Bora", "Bensu", "Zeynep" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found!"); // throw hatayı fırlat anlamındadır.
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try //kodu dene
            {
                string[] students = new string[3] { "Bora", "Bensu", "Zeynep" };
                students[3] = "Ercan";
            }
            catch (IndexOutOfRangeException exception) //eğer hata kodu parametre içinde yazılan gibiyse burası çalışır.
            {
                Console.WriteLine(exception);
            }
            catch (Exception exception) //hata çıkarsa burası çalışır ve hata kodunu gösterir.
            {
                Console.WriteLine(exception);
            }
        }
    }
}
