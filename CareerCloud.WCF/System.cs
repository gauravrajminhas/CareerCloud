using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.WCF
{
    class System : ISystem
    {
        private SystemCountryCodeLogic _SystemCountryCodeLogic;
        private SystemLanguageCodeLogic _SystemLanguageCodeLogic;

        public System()
        {
            _SystemCountryCodeLogic = new SystemCountryCodeLogic(new EFGenericRepository<SystemCountryCodePoco>(false));
            _SystemLanguageCodeLogic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>(false));

        }


        public void AddSystemLanguageCode(SystemLanguageCodePoco[] pocos)
        {
            _SystemLanguageCodeLogic.Add(pocos);
        }

        public List<SystemLanguageCodePoco> GetAllSystemLanguageCode()
        {
            return _SystemLanguageCodeLogic.GetAll();
        }

        public SystemLanguageCodePoco GetSingleSystemLanguageCode(string LanguageID)
        {
            return _SystemLanguageCodeLogic.Get(LanguageID);
        }

        public void RemoveSystemLanguageCode(SystemLanguageCodePoco[] pocos)
        {
            _SystemLanguageCodeLogic.Delete(pocos);
        }


        public void UpdateSystemLanguageCode(SystemLanguageCodePoco[] pocos)
        {
            _SystemLanguageCodeLogic.Update(pocos);
        }



        public void AddSystemCountryCode(SystemCountryCodePoco[] pocos)
        {
            _SystemCountryCodeLogic.Add(pocos);
        }

        public List<SystemCountryCodePoco> GetAllSystemCountryCode()
        {
            return _SystemCountryCodeLogic.GetAll();
        }

        public SystemCountryCodePoco GetSingleSystemCountryCode(string countryCode)
        {
            return _SystemCountryCodeLogic.Get(countryCode);
        }

        public void RemoveSystemCountryCode(SystemCountryCodePoco[] pocos)
        {
            _SystemCountryCodeLogic.Delete(pocos);
        }


        public void UpdateSystemCountryCode(SystemCountryCodePoco[] pocos)
        {
            _SystemCountryCodeLogic.Update(pocos);
        }






    }
}
