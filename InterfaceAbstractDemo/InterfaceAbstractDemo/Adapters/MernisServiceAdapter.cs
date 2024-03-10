using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(customer.NationalityId, customer.FirstName, customer.LastName, customer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
           
        }
    }
}
