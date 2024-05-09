namespace Singleton;
public class LoadBalancer
{
    static LoadBalancer? instance;
    readonly List<string> servers = new();

    private static readonly object locker = new();

    protected LoadBalancer()
    {
        servers.Add("ServerI");
        servers.Add("ServerII");
        servers.Add("ServerIII");
        servers.Add("ServerIV");
        servers.Add("ServerV");
    }

    public static LoadBalancer GetLoadBalancer()
    {
        if (instance == null)
        {
            lock (locker)
            {
                instance ??= new LoadBalancer();
            }
        }
        return instance;
    }

    public string Server
    {
        get
        {
            Random random = new();
            int r = random.Next(servers.Count);
            return servers[r].ToString();
        }
    }
}