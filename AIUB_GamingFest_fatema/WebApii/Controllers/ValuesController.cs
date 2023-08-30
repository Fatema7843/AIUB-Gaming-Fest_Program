using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
namespace WebApii.Controllers
{

   
    public class ValuesController : ApiController
    {
      SqlConnection con =new SqlConnection(@"server = DESKTOP-HUCD54S\SQLEXPRESS; database= finalterm;Integrated Security = true");


        // GET api/values
        public string Get()
        {
            SqlDataAdapter st = new SqlDataAdapter("SELECT * FROM users", con)  ;
            DataTable tab = new DataTable();
          st.Fill(tab);
            if(tab.Rows.Count > 0)
            {
                return JsonConvert.SerializeObject(tab);
            }
            else
            {
                return "Sorry!!!!!There is No data to show";
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
