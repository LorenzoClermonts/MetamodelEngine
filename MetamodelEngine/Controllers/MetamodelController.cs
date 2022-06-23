using MetamodelAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetamodelEngine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetamodelController : ControllerBase
    {
        [HttpGet(Name = "GetModels")]
        public IEnumerable<tblModel> Get()
        {
            using (MetamodelEntities entities = new MetamodelEntities())
            {
                return entities.tblModel.ToList();
            }
        }

        /*[Route("~/api/AddModel")]
        [HttpPost]
        public tblModel AddModel([FromBody] tblModel model)
        {
            using(MetamodelEntities entities = new MetamodelEntities())
            {
                entities.tblModel.Add(model);
                entities.SaveChanges();
            }
            
            return model;
        }
        */

        [Route("~/api/AddModel")]
        [HttpPost]
        public void AddModel([FromBody] Metamodel metamodel)
        {
            using (MetamodelEntities entities = new MetamodelEntities())
            {
                entities.tblModel.Add(metamodel.model);
                entities.SaveChanges();

                foreach (var element in metamodel.classes)
                {
                    element.ModelID = metamodel.model.ID.ToString();
                    entities.tblObjectType.Add(element);

                    entities.SaveChanges();
                }
            }
        }
    }
}
