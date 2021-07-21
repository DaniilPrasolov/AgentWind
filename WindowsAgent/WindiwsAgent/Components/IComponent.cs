using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WindowsAgent.Components
{
    public interface IComponent
    {
        public void CollectInfo();
        public string Parce(Regex regex, string output);
    }
}
