namespace lec5
{
    using lec5.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class GameModel : DbContext
    {
        // Контекст настроен для использования строки подключения "GameModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "lec5.GameModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "GameModel" 
        // в файле конфигурации приложения.
        public GameModel()
            : base("name=GameModel")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<GameEntity> Games { get; set; }
    }

}