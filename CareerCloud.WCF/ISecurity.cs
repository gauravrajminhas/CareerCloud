using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    [ServiceContract]
    interface ISecurity
    {

        [OperationContract]
        void AddSecurityRole(SecurityRolePoco[] poco);

        [OperationContract]
        List<SecurityRolePoco> GetAllSecurityRole();

        [OperationContract]
        SecurityRolePoco GetSingleSecurityRole(string id);

        [OperationContract]
        void RemoveSecurityRole(SecurityRolePoco[] pocos);

        [OperationContract]
        void UpdateSecurityRole(SecurityRolePoco[] pocos);

        [OperationContract]
        void AddSecurityLoginsRole(SecurityLoginsRolePoco[] poco);

        [OperationContract]
        List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole();

        [OperationContract]
        SecurityLoginsRolePoco GetSingleSecurityLoginsRole(string id);

        [OperationContract]
        void RemoveSecurityLoginsRole(SecurityLoginsRolePoco[] pocos);

        [OperationContract]
        void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] pocos);

        //
        [OperationContract]
        void AddSecurityLoginsLog(SecurityLoginsLogPoco[] poco);

        [OperationContract]
        List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog();

        [OperationContract]
        SecurityLoginsLogPoco GetSingleSecurityLoginsLog(string id);

        [OperationContract]
        void RemoveSecurityLoginsLog(SecurityLoginsLogPoco[] pocos);

        [OperationContract]
        void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] pocos);



        [OperationContract]
        void AddSecurityLogin(SecurityLoginPoco[] poco);

        [OperationContract]
        List<SecurityLoginPoco> GetAllSecurityLogin();

        [OperationContract]
        SecurityLoginPoco GetSingleSecurityLogin(string id);

        [OperationContract]
        void RemoveSecurityLogin(SecurityLoginPoco[] pocos);

        [OperationContract]
        void UpdateSecurityLogin(SecurityLoginPoco[] pocos);


    }
}
