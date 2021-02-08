using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LoanDataAccess;

namespace MajorWebApi.Controllers
{
    public class PropertyController : ApiController
    {
        public IEnumerable<Property> Get()
        {
            using (loandbEntities entities = new loandbEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Properties.ToList();
            }
        }

        public HttpResponseMessage Get(int id)
        {
            using (loandbEntities entities = new loandbEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                var entity = entities.Properties.FirstOrDefault(e => e.P_ID == id);
                if (entity != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, message: "Person with P_Id " + id.ToString() + " Not Found!");
                }
            }
        }

        public HttpResponseMessage Post([FromBody] Property property)
        {
            try
            {
                using (loandbEntities entities = new loandbEntities())
                {
                    entities.Configuration.ProxyCreationEnabled = false;
                    entities.Properties.Add(property);
                    entities.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, property);
                    message.Headers.Location = new Uri(Request.RequestUri + property.ID.ToString());
                    return message;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (loandbEntities entities = new loandbEntities())
                {
                    var entity = entities.Properties.FirstOrDefault(e => e.P_ID == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Person with P_Id " + id.ToString() + " Not Found!");
                    }
                    else
                    {
                        entities.Properties.Remove(entity);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }

                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        public HttpResponseMessage Put(int id, [FromBody] Property property)
        {
            try
            {
                using (loandbEntities entities = new loandbEntities())
                {
                    var entity = entities.Properties.FirstOrDefault(e => e.P_ID == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Person with P_Id " + id.ToString() + " Not Found!");
                    }
                    else
                    {
                        entity.Ag_Prop_Type = property.Ag_Prop_Type;
                        entity.Ag_Prop_Classif = property.Ag_Prop_Classif;
                        entity.Ag_Building_Age = property.Ag_Building_Age;
                        entity.Ag_Market_Value = property.Ag_Market_Value;
                        entity.Ag_Regis_Value = property.Ag_Regis_Value;
                        entity.Ag_Prop_Land_Area = property.Ag_Prop_Land_Area;
                        entity.Ag_Buildup_Area = property.Ag_Buildup_Area;
                        entity.Ag_Prop_Addr = property.Ag_Prop_Addr;
                        entity.Ag_Landmark = property.Ag_Landmark;
                        entity.Ag_Pin = property.Ag_Pin;
                        entity.Ag_City = property.Ag_City;
                        entity.Ag_State = property.Ag_State;
                        entity.Ag_Country = property.Ag_Country;
                        entity.Ag_Rev_Mortage = property.Ag_Rev_Mortage;
                        entity.Ag_Lumpsum_Amount = property.Ag_Lumpsum_Amount;
                        entity.Ag_Annuity_Periodicity = property.Ag_Annuity_Periodicity;

                        entities.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
