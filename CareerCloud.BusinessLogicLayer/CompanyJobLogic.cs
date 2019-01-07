﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyJobLogic :BaseLogic<CompanyJobPoco>
    {
        private List<ValidationException> _exceptions = new List<ValidationException>();

        public CompanyJobLogic(IDataRepository<CompanyJobPoco> repository) : base(repository)
        {

        }

        public override void Add(CompanyJobPoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(CompanyJobPoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }


        protected override void Verify(CompanyJobPoco[] pocos)
        {
            foreach (var poco in pocos)
            {
                // business Logic and validation 

            }

            if (_exceptions.Count > 0)
            {
                throw new AggregateException(_exceptions);
            }


        }

    }
}
