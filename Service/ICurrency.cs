using AWS_Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWS_Service.Service
{
    public interface ICurrency
    {
      public Task<Root> GetConveryValue();
    }
}
