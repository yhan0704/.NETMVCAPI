using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var Commands = new List<Command>()
            {
                new Command{ID = 0, HowTo = "egg", Line= "water",  Platform = "kettle"},
                new Command{ID = 1, HowTo = "cut", Line= "knife",  Platform = "chopping"},
                new Command{ID = 2, HowTo = "boil", Line= "banana",  Platform = "cut"}
            };
            
            return Commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{ID = 0, HowTo = "egg", Line= "water",  Platform = "kettle"};
        }
    }
}