using System.Data;

namespace Backend.Controllers
{
    public class Repository
    {
        public static List<PersonaDatos> persona = new List<PersonaDatos>()
        {
            new PersonaDatos()
            {
                Id = 1,
                age = new DateTime(1994,12,03),
                name = "LuisMi"

            },
            new PersonaDatos()
            {
                Id = 2,
                age = new DateTime(1999,08,02),
                name = "Messi"
            }

        };



    }
}

public class PersonaDatos
{
    public int Id { get; set; }
    public string name { get; set; }
    public DateTime age { get; set; }
    public string email { get; set; }
}
