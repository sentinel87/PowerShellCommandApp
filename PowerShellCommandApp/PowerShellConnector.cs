using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellCommandApp
{
    public class PowerShellConnector
    {
        public string RunScript(string script)
        {
            string result = "";
            try
            {
                using (Runspace runspace = RunspaceFactory.CreateRunspace())
                {
                    runspace.Open();
                    Pipeline pipeline = runspace.CreatePipeline();
                    pipeline.Commands.AddScript(script);
                    pipeline.Commands.Add("Out-String");
                    Collection<PSObject> results = pipeline.Invoke();
                    runspace.Close();
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (PSObject pSObject in results)
                        stringBuilder.AppendLine(pSObject.ToString());
                    result = stringBuilder.ToString();
                }
            }
            catch(Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
    }
}
