using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.WCF
{
    class Security :ISecurity
    {
        private SecurityLoginLogic _SecurityLoginLogic;
        private SecurityLoginsLogLogic _SecurityLoginsLogLogic;
        private SecurityLoginsRoleLogic _SecurityLoginsRoleLogic;
        private SecurityRoleLogic _SecurityRoleLogic;

        public Security()
        {
            _SecurityLoginLogic = new SecurityLoginLogic(new EFGenericRepository<SecurityLoginPoco>(false));
            _SecurityLoginsLogLogic = new SecurityLoginsLogLogic(new EFGenericRepository<SecurityLoginsLogPoco>(false));
            _SecurityLoginsRoleLogic = new SecurityLoginsRoleLogic(new EFGenericRepository<SecurityLoginsRolePoco>(false));
            _SecurityRoleLogic = new SecurityRoleLogic(new EFGenericRepository<SecurityRolePoco>(false));
        }

        public void AddSecurityRole(SecurityRolePoco[] pocos)
        {
            _SecurityRoleLogic.Add(pocos);
        }

        public List<SecurityRolePoco> GetAllSecurityRole()
        {
            return _SecurityRoleLogic.GetAll();
        }

        public SecurityRolePoco GetSingleSecurityRole(string id)
        {
            return _SecurityRoleLogic.Get(Guid.Parse(id));
        }

        public void RemoveSecurityRole(SecurityRolePoco[] pocos)
        {
            _SecurityRoleLogic.Delete(pocos);
        }


        public void UpdateSecurityRole(SecurityRolePoco[] pocos)
        {
            _SecurityRoleLogic.Update(pocos);
        }

        public void AddSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {
            _SecurityLoginsRoleLogic.Add(pocos);
        }

        public List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole()
        {
            return _SecurityLoginsRoleLogic.GetAll();
        }

        public SecurityLoginsRolePoco GetSingleSecurityLoginsRole(string id)
        {
            return _SecurityLoginsRoleLogic.Get(Guid.Parse(id));
        }

        public void RemoveSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {
            _SecurityLoginsRoleLogic.Delete(pocos);
        }


        public void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] pocos)
        {
            _SecurityLoginsRoleLogic.Update(pocos);
        }

        public void AddSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {
            _SecurityLoginsLogLogic.Add(pocos);
        }

        public List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog()
        {
            return _SecurityLoginsLogLogic.GetAll();
        }

        public SecurityLoginsLogPoco GetSingleSecurityLoginsLog(string id)
        {
            return _SecurityLoginsLogLogic.Get(Guid.Parse(id));
        }

        public void RemoveSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {
            _SecurityLoginsLogLogic.Delete(pocos);
        }


        public void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] pocos)
        {
            _SecurityLoginsLogLogic.Update(pocos);
        }

        public void AddSecurityLogin(SecurityLoginPoco[] pocos)
        {
            _SecurityLoginLogic.Add(pocos);
        }

        public List<SecurityLoginPoco> GetAllSecurityLogin()
        {
            return _SecurityLoginLogic.GetAll();
        }

        public SecurityLoginPoco GetSingleSecurityLogin(string id)
        {
            return _SecurityLoginLogic.Get(Guid.Parse(id));
        }

        public void RemoveSecurityLogin(SecurityLoginPoco[] pocos)
        {
            _SecurityLoginLogic.Delete(pocos);
        }


        public void UpdateSecurityLogin(SecurityLoginPoco[] pocos)
        {
            _SecurityLoginLogic.Update(pocos);
        }
    }
}
