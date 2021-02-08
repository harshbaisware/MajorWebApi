using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LoanDataAccess;

namespace MajorWebApi.Controllers
{
    public class HomeController : ApiController
    {
        public IEnumerable<Home> Get()
        {
            using (loandbEntities entities = new loandbEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                return entities.Homes.ToList();
            }
        }

        public HttpResponseMessage Get(int id)
        {
            using (loandbEntities entities = new loandbEntities())
            {
                entities.Configuration.ProxyCreationEnabled = false;
                var entity = entities.Homes.FirstOrDefault(e => e.P_ID == id);
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

        public HttpResponseMessage Post([FromBody] Home home)
        {
            try
            {
                using (loandbEntities entities = new loandbEntities())
                {
                    entities.Configuration.ProxyCreationEnabled = false;
                    entities.Homes.Add(home);
                    entities.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, home);
                    message.Headers.Location = new Uri(Request.RequestUri + home.ID.ToString());
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
                    var entity = entities.Homes.FirstOrDefault(e => e.P_ID == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Person with P_Id " + id.ToString() + " Not Found!");
                    }
                    else
                    {
                        entities.Homes.Remove(entity);
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


        public HttpResponseMessage Put(int id, [FromBody] Home home)
        {
            try
            {
                using (loandbEntities entities = new loandbEntities())
                {
                    var entity = entities.Homes.FirstOrDefault(e => e.P_ID == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Person with P_Id " + id.ToString() + " Not Found!");
                    }
                    else
                    {
                        entity.Prop_Type = home.Prop_Type;
                        entity.Prop_Trans_Type = home.Prop_Trans_Type;
                        entity.Prop_Builder_Name = home.Prop_Builder_Name;
                        entity.Prop_Project_Name = home.Prop_Project_Name;
                        entity.Prop_Building_Name = home.Prop_Building_Name;
                        entity.Prop_Land_Area = home.Prop_Land_Area;
                        entity.Prop_Cost = home.Prop_Cost;
                        entity.Prop_Addr = home.Prop_Addr;
                        entity.Prop_Landmark = home.Prop_Landmark;
                        entity.Prop_Pin = home.Prop_Pin;
                        entity.Prop_City = home.Prop_City;
                        entity.Prop_State = home.Prop_State;
                        entity.Prop_Country = home.Prop_Country;
                        entity.Prop_Ownership = home.Prop_Ownership;
                        entity.Prop_Seller_Name = home.Prop_Seller_Name;
                        entity.Prop_Seller_Addr = home.Prop_Seller_Addr;
                        entity.Prop_Const_Stage = home.Prop_Const_Stage;
                        entity.Prop_Pur_Con_Cost = home.Prop_Pur_Con_Cost;
                        entity.Prop_Reg_Cost = home.Prop_Reg_Cost;
                        entity.Prop_Total_Cost = home.Prop_Total_Cost;
                        entity.Prop_Stamp_Cost = home.Prop_Stamp_Cost;
                        entity.Prop_Other_Cost = home.Prop_Other_Cost;
                        entity.Prop_Own_Contrib = home.Prop_Own_Contrib;

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
