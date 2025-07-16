using System.Diagnostics;

namespace FuzzyNinjectWarrior.ApiClients
{
    public class ApiGameLogger : IGameLogger
    {
        // Stub: Just write to debug output. Replace with real HTTP call if needed.
        public void LogEvent(string message)
        {
            Debug.WriteLine("Game Event: " + message);
        }
    }
}
