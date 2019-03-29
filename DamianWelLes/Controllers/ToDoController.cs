using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DamianWelLes.Models;
using static System.Net.Mime.MediaTypeNames;

namespace DamianWelLes.Controllers
{
    public class ToDoController : ApiController
    {
        // GET: api/ToDo
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ToDo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ToDo
        public Todo Post(int Id, string Title, string Description, DateTime Date )
        {
            Todo item = new Todo();
            item.Id = Id;
            item.Title = Title;
            item.Description = Description;
            item.Date = Date;
            
            //Creating of the file + Writing to it.
            WriteTextFile TodoList = new WriteTextFile();
            TodoList.Main(item);
            return item;
        }

        // PUT: api/ToDo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ToDo/5
        public void Delete(int id)
        {
        }

        public class WriteTextFile
        {
            public void Main(Todo item)
            {
                string pathString = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fileName = Path.Combine(pathString, "TodoItemsList.txt");

                // als dit hier boven niet werkt probeer dan dit:
                //string pathString = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName; // return the application.exe current folder
                //string fileName = Path.Combine(pathString, "TodoItemsList.txt"); // make the full path as folder/test.text

                if (!System.IO.File.Exists(pathString))
                {
                    using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(fileName))
                    {
                        for (int i = 0; i < 100; i++)
                        {
                            file.WriteLine(i);
                        }
                    }
                        
                }
                else
                {
                    Console.WriteLine("File \"{0}\" already exists.", fileName);
                    return;
                }
            }
        }
    }
}

