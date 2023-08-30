using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApii.Controllers
{

    [Authorize]

    public class managers : ApiController
    {

        SqlConnection con = new SqlConnection(@"server = DESKTOP-HUCD54S\SQLEXPRESS; database= finalterm;Integrated Security = true");

        // GET api/<controller>
        public string Get()
        {
            SqlDataAdapter st = new SqlDataAdapter("SELECT * FROM volunteers", con);
            DataTable tab = new DataTable();
            st.Fill(tab);
            if (tab.Rows.Count > 0)
            {
                return JsonConvert.SerializeObject(tab);
            }
            else
            {
                return "Sorry!!!!!There is No data to show";
            }
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}