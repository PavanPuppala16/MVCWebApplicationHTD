using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{

    public interface IProgrammer
    {
        void WorkOnTask();
    }
    public interface ILead
    {
        void AssignTask();
        void CreateSubTask();
    }
    public class Programmer : IProgrammer
    {
        public void WorkOnTask()
        {
            Console.WriteLine("programmer work"); //code to implement to work on the Task.  
        }
    }
    public class Manager : ILead
    {
        public void AssignTask()
        {
            Console.WriteLine("maneger work");  //Code to assign a Task  
        }
        public void CreateSubTask()
        {
            Console.WriteLine("menager work"); //Code to create a sub taks from a task.  
        }
    }
    public class TeamLead : IProgrammer, ILead
    {
        public void AssignTask()
        {
            Console.WriteLine("teamlead work"); //Code to assign a Task  
        }
        public void CreateSubTask()
        {
            Console.WriteLine("team lead work");  //Code to create a sub task from a task.  
        }
        public void WorkOnTask()
        {
            Console.WriteLine("teamlead work"); //code to implement to work on the Task.  
        }
    }
}
