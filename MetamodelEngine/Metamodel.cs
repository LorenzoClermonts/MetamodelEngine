using MetamodelAccess;

namespace MetamodelEngine
{
    public class Metamodel
    {
        public tblModel model { get; set; }

        public List<tblObjectType> classes { get; set; }

        public List<tblFactType> relations { get; set; }
    }
}
