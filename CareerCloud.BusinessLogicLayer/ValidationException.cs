﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class ValidationException : Exception
    {
        public int Code { get; private set; }

        public ValidationException(int Code, String message ) : base(message)
        {
            this.Code = Code;
            //throw new ValidationException(12, "abc");
        }
    }
}
