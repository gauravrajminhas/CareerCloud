using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    
    public class SecurityRoleLogic : BaseLogic<SecurityRolePoco>
    {
        private List<ValidationException> _exceptions = new List<ValidationException>();

        public SecurityRoleLogic(IDataRepository<SecurityRolePoco> repository) : base(repository)
        {

        }

        public override void Add(SecurityRolePoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(SecurityRolePoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }


        protected override void Verify(SecurityRolePoco[] pocos)
        {
            foreach (var poco in pocos)
            {
                // business Logic and validation 
                if (String.IsNullOrEmpty(poco.Role))
                {
                    _exceptions.Add(new ValidationException(800, "Cannot be empty"));
                }
            }

            if (_exceptions.Count > 0)
            {
                throw new AggregateException(_exceptions);
            }


        }

    }
}
