using MetamodelAccess;

namespace MetamodelEngine
{
    public interface IMetamodel
    {
        public tblModel model { get; set; }

        public List<tblObjectType> classes { get; set; }

        public List<Attribute> attributes { get; set; }

        public List<tblFactType> relations { get; set; }

        public List<tblPredicator> predicators { get; set; }
    }
}
