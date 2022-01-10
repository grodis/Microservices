using System.Collections.Generic;
using CommandsService.Models;

namespace CommandsService.Data
{
    public interface ICommandRepo
    {
        bool SaveChanges();

        // Platforms
        IEnumerable<Platform> GetAllPlatforms();
        bool PlatformExists(int platformId);
        void CreatePlatform(Platform platform);
        bool ExternalPlatformExists(int externalPlatformId);

        // Commands
        IEnumerable<Command> GetCommandsForPlatform(int platformId);
        Command GetCommand(int platformId, int commandId);
        void CreateCommand(int platformId, Command command);
    }
}