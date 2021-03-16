using System.Text;

namespace GenericsExercise.Console
{
    public class University : IEntity
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {

            return $"ID: {Id} Name: {Name} Adress:  {Address}"; 
        }
    }
}