using System.Globalization;
using System.Net;
using System.Threading;
/// <summary>
/// San Andreas Multiplayer server announcer namespace
/// </summary>
namespace SAMPServerAnnouncer
{
    /// <summary>
    /// Program class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main entry point
        /// </summary>
        /// <param name="args">Command line arguments</param>
        internal static void Main(string[] args)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            if (args.Length >= 1)
            {
                ushort default_port;
                if (ushort.TryParse(args[0], out default_port))
                {
                    Announcer.Create("announce.json", default_port)?.AnnounceAsync().GetAwaiter().GetResult();
                }
            }
        }
    }
}
