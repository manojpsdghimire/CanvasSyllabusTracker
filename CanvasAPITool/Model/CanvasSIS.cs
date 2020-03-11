using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanvasAPITool.Model
{
    public class CanvasSIS
    {
        protected const string _access_token = "CANVAS ACCESS TOKE";
        protected const string _account_id = "ACCOUNT ID";
        protected const string _base_url = "https://domain/api/v1/";

        public string account_id { get; set; }
        public string access_token { get; set; }
        public string base_url { get; set; }

        public CanvasSIS()
        {
            this.access_token = _access_token;
            this.account_id = _account_id;
            this.base_url = _base_url;
        }
    }
}
