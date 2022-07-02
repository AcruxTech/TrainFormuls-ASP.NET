using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainFormuls.Shared.Exceptions
{
    public class UnknownError : Exception
    {
        public UnknownError() : base("Unexpected server error! Please, notify the administrator")
        {

        }
    }
}
