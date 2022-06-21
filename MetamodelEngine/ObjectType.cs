using SQLite;

namespace MetamodelEngine
{
    public class ObjectType
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public string Conc_ID { get; set; }

        public string Cnst_ID { get; set; }

        public int ModelID { get; set; }

    }
}
