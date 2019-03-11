using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.WCF
{
    [ServiceContract]

    interface ISystem
    {

        [OperationContract]
        void AddSystemLanguageCode(SystemLanguageCodePoco[] poco);

        [OperationContract]
        List<SystemLanguageCodePoco> GetAllSystemLanguageCode();

        [OperationContract]
        SystemLanguageCodePoco GetSingleSystemLanguageCode(string CountryCode);

        [OperationContract]
        void RemoveSystemLanguageCode(SystemLanguageCodePoco[] pocos);

        [OperationContract]
        void UpdateSystemLanguageCode(SystemLanguageCodePoco[] pocos);

        [OperationContract]
        void AddSystemCountryCode(SystemCountryCodePoco[] poco);

        [OperationContract]
        List<SystemCountryCodePoco> GetAllSystemCountryCode();

        [OperationContract]
        SystemCountryCodePoco GetSingleSystemCountryCode(string CountryCode);

        [OperationContract]
        void RemoveSystemCountryCode(SystemCountryCodePoco[] pocos);

        [OperationContract]
        void UpdateSystemCountryCode(SystemCountryCodePoco[] pocos);

    }
}
