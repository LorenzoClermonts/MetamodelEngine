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
    }
}
