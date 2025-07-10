Dictionary<string, HashSet<string>> vFollowers = new Dictionary<string, HashSet<string>>();
Dictionary<string, HashSet<string>> vFollowing = new Dictionary<string, HashSet<string>>();

while (true)
{
    bool flowControl = ProcessInput(vFollowers, vFollowing);

    if (!flowControl)
    {
        break;
    }
}

vFollowers = vFollowers
    .OrderByDescending(kvp => kvp.Value.Count)
    .ThenBy(kvp => vFollowing[kvp.Key].Count)
    .ToDictionary(a => a.Key, b => b.Value);

int counter = 1;

Console.WriteLine($"The V-Logger has a total of {vFollowers.Count} vloggers in its logs.");

KeyValuePair<string, HashSet<string>> mostFamousVlogger = vFollowers.First();
string mostFamousVloggerName = mostFamousVlogger.Key;
HashSet<string> mostFamousVloggerFollowers = mostFamousVlogger.Value
    .OrderBy(n => n)
    .ToHashSet();

Console.WriteLine($"{counter++}. {mostFamousVloggerName} : {mostFamousVloggerFollowers.Count} followers, {vFollowing[mostFamousVloggerName].Count} following");

foreach (var follower in mostFamousVloggerFollowers)
{
    Console.WriteLine($"*  {follower}");
}

foreach (var vloggerFollowersPair in vFollowers.Skip(1))
{
    string name = vloggerFollowersPair.Key;
    HashSet<string> followers = vloggerFollowersPair.Value;
    Console.WriteLine($"{counter++}. {name} : {followers.Count} followers, {vFollowing[name].Count} following");
}

static void JoinVlogger(Dictionary<string, HashSet<string>> vFollowers, Dictionary<string, HashSet<string>> vFollowing, string[] input)
{
    string vloggerName = input[0];
    if (!vFollowers.ContainsKey(vloggerName))
    {
        vFollowers.Add(input[0], new HashSet<string>());
        vFollowing.Add(input[0], new HashSet<string>());
    }
}

static void Follow(Dictionary<string, HashSet<string>> vFollowers, Dictionary<string, HashSet<string>> vFollowing, string[] input)
{
    string follower = input[0];
    string followed = input[2];
    if (vFollowers.ContainsKey(follower))
    {
        if (follower != followed)
        {
            if (vFollowing.ContainsKey(follower) &&
                vFollowers.ContainsKey(followed))
            {
                vFollowers[followed].Add(follower);
                vFollowing[follower].Add(followed);
            }
        }
    }
}

static bool ProcessInput(Dictionary<string, HashSet<string>> vFollowers, Dictionary<string, HashSet<string>> vFollowing)
{
    string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (input.Contains("joined"))
    {
        JoinVlogger(vFollowers, vFollowing, input);
    }

    if (input.Contains("followed"))
    {
        Follow(vFollowers, vFollowing, input);
    }
    if (input.Contains("Statistics"))
    {
        return false;
    }

    return true;
}