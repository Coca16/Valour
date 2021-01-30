
namespace Valour.Shared.Planets
{
    public class PlanetListItem
    {
        public ushort Position { get; set; }

        public ulong? Parent_Id { get; set;}

        public ulong Planet_Id { get; set; }

        public ulong Id { get; set; }

        public string Name { get; set; }
    }
}