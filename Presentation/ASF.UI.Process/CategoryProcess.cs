using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using ASF.Entities;
using ASF.Services.Contracts;
using ASF.UI.Process;

namespace ASF.UI.Process
{
    public class CategoryProcess : ProcessComponent
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Category> SelectList()
        {
            var response = HttpGet<AllResponse>("rest/Category/All", new Dictionary<string, object>(), MediaType.Json);
            return response.Result;
        }

        public Category findCategory(int id)
        {
            var dic =new  Dictionary <string,object >();

            dic.Add("Id", id);
                var response = HttpGet<FindResponse>("rest/Category/Find", dic, MediaType.Json);
            return response.Result;

        }
        public void InsertCategory(Category category)
        {
            ProcessComponent.HttpPost<Category>("rest/Category/add", category, MediaType.Json);

        }
        public void EditCategory(Category category)
        {

            ProcessComponent.HttpPost<Category>("rest/Category/edit", category, MediaType.Json);

        }
        public void DeleteCategory(int id)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("Id", id);
            ProcessComponent.HttpGet<Category>("rest/Category/remove/{id}", dic, MediaType.Json);

        }
    }
}