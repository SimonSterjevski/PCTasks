using CompanyApp.Logic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp.Logic
{
    public interface ISuplyImplementation
    {
        void CreateAndAddSuply(Demand demand);
    }
}
