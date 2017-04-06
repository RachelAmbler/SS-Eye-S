using Microsoft.SqlServer.Dts.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomThunks.API.SSiS
{
    public interface IContainer
    {
        iVariable AddVariable(string name, string description, string nameSpace, object value);
        iVariable AddVariable(string name, string description, object value);
        iVariable AddExpression(string name, string description, string expression);
        iVariable AddExpression(string name, string description, string nameSpace, string expression);

        T AddTask<T>(string name, string description) where T : iControlFlowTask, new();

        iControlFlowTask AddTask(string iComponentName, string name, string description);

        iVariable GetVariable(string name);

       iVariable GetVariable(string name, string nameSpace);
    }
}
