namespace Ucu.Poo.Defense
{
    public class Residue
    {
        public bool IsOrganic
        {
            get
            {
                return this.Type.IsOrganic;
            }
        }
        public string Name { get; set; }

        public ResidueType Type { get; set; }

        public Residue(string name, ResidueType type)
        {
            this.Name = name;
            this.Type = type;
        }
    }
}