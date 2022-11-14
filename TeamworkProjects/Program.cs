using System;
using System.Text;

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
            Console.WriteLine($"Team {teamName} has been created by {creator}!");
        }
        //read input, until command = "end of assignment" :
        string command = String.Empty;
        while ((command = Console.ReadLine()) != "end of assignment")
        {

            //creating array of string input that holds info about teams and members:
            var info = command.Split("->").ToArray();
            string person = info[0]; //getting name of team member
            string teamName = info[1]; //getting name of team the person is looking to join

            //check if team name already exists:
            if (teams.Any(x => x.Name == teamName))
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                continue;
            }
            //check if team members' names contains person already joined a team, OR if creator has already created a team:
            if (teams.Any(x => x.peopleJoined.Contains(person) || teams.Any(x => x.Creator == person && x.Name == teamName)))
            {
                Console.WriteLine($"Members {person} cannot join team {teamName}!");
                continue;
            }

            //add the person to the list:
            int index = teams.FindIndex(x => x.Name == teamName);
            teams[index].peopleJoined.Add(person);
        }

        //create a list of teams that were created, by have no members joined:
        var teamsToBeDisbanded = teams.FindAll(x => x.peopleJoined.Count == 0)
            .OrderBy(x => x.Name)
            .ToList();

        //create a list of valid teams (1 or more members joined):
        var validTeams = teams
            .FindAll(x => x.peopleJoined.Count > 0)
            .OrderBy(x => x.Name)
            .ToList();

        //output for valid teams, sorted:
        Console.WriteLine(String.Join(Environment.NewLine, validTeams
            .OrderByDescending(x => x.peopleJoined.Count)
            .ThenBy(x => x.Name)));

        //output for disbanded teams:
        Console.WriteLine("Teams to disband:");
        foreach (var team in teamsToBeDisbanded)
        {
            Console.WriteLine(team.Name);
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

    //override of ToString() :
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(Name);
        sb.AppendLine("- " + Creator);


        foreach (var member in peopleJoined)
        {
            sb.AppendLine("-- " + member);
        }

        return sb.ToString().TrimEnd();
    }
}

