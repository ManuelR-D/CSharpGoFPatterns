using CSharpGoFPatterns.Observer.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Observer.implementations
{
    internal class FlagObserver : interfaces.IObserver
    {
        public void Update(ISubject subject)
        {
            try
            {
                Flag f = (Flag)subject;
                Console.WriteLine($"The flag of the team: {f.TeamOwner} was captured by the team {f.Team}");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
