using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExercise.Console
{

    class DisplayToConsoleService
    {
        public async static void DisplayToConsole<TEntity>(Persistence persistence) where TEntity : IEntity
        {
            try
            {

                var items = await persistence.GetAllAsync<TEntity>();
                foreach (var item in items)
                {
                    System.Console.WriteLine(item.ToString());

                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex); 

            }
        }
    }
}
