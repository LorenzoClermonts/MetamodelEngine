using SQLite;

namespace MetamodelEngine
{
    public class Attribute
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Datatype { get; set; }

        public string Classname { get; set; }
    }
}
