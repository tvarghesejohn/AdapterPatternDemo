using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternDemo.Adapter
{
    public interface ITarget
    {
        void ProcessCompanySalary(string[,] employeesArray);
    }
}
