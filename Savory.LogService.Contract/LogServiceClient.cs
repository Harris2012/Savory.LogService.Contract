using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Savory.LogService.Contract.WriteLog;
using System.ServiceModel.Description;
using System.ServiceModel;
using System.Diagnostics;

namespace Savory.LogService.Contract
{
    [DebuggerStepThrough]
    public class LogServiceClient : ClientBase<ILogService>, ILogService
    {

        public LogServiceClient() :
            base(new ServiceEndpoint(ContractDescription.GetContract(typeof(ILogService)), new BasicHttpBinding(), new EndpointAddress("http://localhost:8877/")))
        {
        }

        #region ILogService Members
        public WriteLogResponse WriteLog(WriteLogRequest writeLogRequest)
        {
            return base.Channel.WriteLog(writeLogRequest);
        }
        #endregion
    }
}
