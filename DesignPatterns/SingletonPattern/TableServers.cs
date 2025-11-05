namespace SingletonPattern
{
    public class TableServers
    {
        private static readonly TableServers _instance = new TableServers();
        private List<string> _servers = new List<string>();
        private int nextServerIndex = 0;

        public TableServers()
        {
            _servers.Add("Tim");
            _servers.Add("Sue");
            _servers.Add("Mary");
            _servers.Add("Bob");
        }

        public static TableServers GetTableServersInstance()
        {
            return _instance;
        }

        public string GetNextServer()
        {
            var server = _servers[nextServerIndex];

            nextServerIndex += 1;
            nextServerIndex = (nextServerIndex >= _servers.Count) ? 0 : nextServerIndex;

            return server;
        }
    }
}
