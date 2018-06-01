using WebApplication1.Models;

namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DogDBContext : DbContext
    {
        // Контекст настроен для использования строки подключения "DogDBContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "WebApplication1.DogDBContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "DogDBContext" 
        // в файле конфигурации приложения.
        public DogDBContext()
            : base("name=DogDBContext")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Dog> Dogs { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}