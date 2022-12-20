using System;
using System.Threading.Tasks;


namespace R5T.S0054
{
    class Program
    {
        static async Task Main()
        {
            //await SolutionFileScripts.Instance.New_Empty();
            //await SolutionFileScripts.Instance.New_Initial();
            //await SolutionFileScripts.Instance.New_VS2022();
            await SolutionFileScripts.Instance.New_WithProjectReference();
            //await SolutionFileScripts.Instance.UpgradeSolutionFile_ToVS2022();
        }
    }
}