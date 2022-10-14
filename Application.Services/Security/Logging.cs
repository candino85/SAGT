using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace Application.Services.Security
{
    public class Logging
    {
        public void Info (string message)
        {
            Log.Information(message);
        }
        public void Error(string message, Exception e)
        {
            Log.Error(e, message);
        }
        public void Fatal(string message, Exception e)
        {
            Log.Fatal(e, message);
        }
    }
}
