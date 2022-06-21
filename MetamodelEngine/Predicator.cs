using SQLite;

namespace MetamodelEngine
{
    public class Predicator
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public int FactTypeId { get; set; }

        public int ObjectTypeId { get; set; }

        public string Multiplicity { get; set; }

        public string Verb { get; set; }
    }
}
