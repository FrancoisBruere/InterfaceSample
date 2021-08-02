using System;

namespace Interface
{


    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("E:\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
