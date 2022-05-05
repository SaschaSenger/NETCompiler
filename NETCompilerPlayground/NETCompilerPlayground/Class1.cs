using Microsoft.Build.Evaluation;
//using Microsoft.CodeAnalysis;
using Microsoft.Build.Construction;
using System.Linq;

namespace NETCompilerPlayground
{
    public class Compiler
    {
        public Compiler()
        {
            Project testProj = new Project();
            testProj.Xml.AddTarget("BuildProjects");

            foreach (ProjectTargetElement pti in testProj.Xml.Targets.Where(pti => pti.Name == "BuildProjects"))
            {
                pti.AddTask("MSBuild");
            }

            testProj.Save(@"D:\testProj.csproj");

            //var projectCollection = new ProjectCollection();
            //var proj = projectCollection.LoadProject("Test");

            //var tmp = new Microsoft.Build.Evaluation.Project();
        }

    }
}