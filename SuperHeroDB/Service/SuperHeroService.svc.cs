using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace SuperHeroDB.Service
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class SuperHeroService
    {
        [OperationContract, WebGet(ResponseFormat = WebMessageFormat.Json)]
        public string DoWork()
        {
            return "This is the SuperHeroDB service!";
        }

        [OperationContract, WebGet(ResponseFormat = WebMessageFormat.Json)]
        public List<SuperHero> GetAllHeroes()
        {
            return Data.SuperHeroes;
        }

        [OperationContract, WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetHero/{id}") ]
        public SuperHero GetHero(string id)
        {
            return Data.SuperHeroes.Find(hero => hero.Id == int.Parse(id));
        }
    }
}
