using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyProfileLogic : BaseLogic<CompanyProfilePoco>
    {
        private List<ValidationException> _exceptions = new List<ValidationException>();

        public CompanyProfileLogic(IDataRepository<CompanyProfilePoco> repository) : base(repository)
        {

        }

        public override void Add(CompanyProfilePoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(CompanyProfilePoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }


        protected override void Verify(CompanyProfilePoco[] pocos)
        {
            foreach (var poco in pocos)
            {
                // business Logic and validation 
                if (String.IsNullOrEmpty(poco.CompanyWebsite))
                {
                    _exceptions.Add(new ValidationException(600, $"Valid website must exist"));
                }
                else
                {
                    string[] webSiteArraySplit = poco.CompanyWebsite.Split('.');
                    if (webSiteArraySplit.Length > 2)
                    {
                        _exceptions.Add(new ValidationException(600, $"Valid website must exist"));
                    }
                    else
                    {
                        if (webSiteArraySplit[1].Equals("com") || webSiteArraySplit[1].Equals("ca") || webSiteArraySplit[1].Equals("biz"))
                        {
                            //doubt :- Havent use RegEx here to check ! will this work 
                            break;
                        }
                        else
                        {
                            _exceptions.Add(new ValidationException(600, $"Valid website must exist"));
                        }
                    }
                }
           

                if (string.IsNullOrEmpty(poco.ContactPhone))
                {
                    _exceptions.Add(new ValidationException(601, $"Contact Phone is required"));
                }
                else
                {
                    string[] phoneComponents = poco.ContactPhone.Split('-');
                    if (phoneComponents.Length < 3)
                    {
                        _exceptions.Add(new ValidationException(601, $"Contact Phone is not in the required format."));
                    }
                    else
                    {
                        if (phoneComponents[0].Length < 3)
                        {
                            _exceptions.Add(new ValidationException(601, $"Contact Phone is not in the required format."));
                        }
                        else if (phoneComponents[1].Length < 3)
                        {
                            _exceptions.Add(new ValidationException(601, $"Contact Phone is not in the required format."));
                        }
                        else if (phoneComponents[2].Length < 4)
                        {
                            _exceptions.Add(new ValidationException(601, $"Contact Phone is not in the required format."));
                        }
                    }
                }



            }

            if (_exceptions.Count > 0)
            {
                throw new AggregateException(_exceptions);
            }


        }

    }
}
