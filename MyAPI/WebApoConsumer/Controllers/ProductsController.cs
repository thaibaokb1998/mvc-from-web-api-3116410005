using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using APIMessages;

namespace WebApoConsumer.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var products = GetProductsFromAPI();

            return View(products);
        }

        private List<ProductEntity> GetProductsFromAPI()
        {
            try
            {
                var resultList = new List<ProductEntity>();
                var client = new HttpClient();
                var getDataTask = client.GetAsync("https://localhost:44380/api/Products").ContinueWith(response =>
                {
                    var result = response.Result;
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var readResult = result.Content.ReadAsAsync<List<ProductEntity>>();
                        readResult.Wait();
                        resultList = readResult.Result;
                    }
                });
                getDataTask.Wait();
                return resultList;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}