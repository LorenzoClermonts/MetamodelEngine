using SQLite;

namespace MetamodelEngine
{
    public class FactType
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Conc_ID { get; set; }

        public string Cnst_ID { get; set; }

        public string PredicatorSetType { get; set; }

    }
}
