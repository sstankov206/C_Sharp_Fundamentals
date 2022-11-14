using System;

class Program
{
    static void Main()
    {
        //List of all teams created:
        List<Team> teams = new List<Team>();

        //reading number of teams to create, via input:
        int numOfTeams = int.Parse(Console.ReadLine());


        for (int i = 0; i < numOfTeams; i++)
        {
            var info = Console.ReadLine().Split("-").ToArray();
            string creator = info[0]; //getting name of team leader (creator)
            string teamName = info[1]; //getting name of team that's being created

            //Create a team:

            if (teams.Any(x => x.Name == teamName)) //check if team name already created
            {
                Console.WriteLine($"Team {teamName} was already created!");
                continue;
            }
            if (teams.Any(x => x.Creator == creator)) //check if creator has previously created a team
            {
                Console.WriteLine($"{creator} cannot create another team!");
                continue;
            }

            Team team = new Team(teamName, creator);
            teams.Add(team);//add the team to the list of team names
        }
        //read input, until command = "end of assignment" :
        string command = String.Empty;
        while ((command = Console.ReadLine()) != "end of assignment")
        {

            //creating array of string input that holds info about teams and members:
            var info = command.Split("->").ToArray();
            string person = info[0]; //getting name of team member
            string team = info[1]; //getting name of team the person is looking to join
        }
    }

}


//creating 'Team' class:
public class Team
{
    //properties:
    public string Creator { get; set; } //creator

    public string Name { get; set; } //member

    public List<string> peopleJoined;


    //constructor:
    public Team(string name, string creator)
    {
        this.Name = name;
        this.Creator = creator;

        peopleJoined = new List<string>(); //used when new team members is added
    }
}

