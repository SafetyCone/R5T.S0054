using System;
using System.Threading.Tasks;


namespace R5T.S0054
{
    class Program
    {
        static async Task Main()
        {
            //SolutionFileScripts.Instance.GenerateNewEmpty();
            //await SolutionFileScripts.Instance.CreateNew_Initial();
            //await SolutionFileScripts.Instance.CreateNew_VS2022();
            await SolutionFileScripts.Instance.CreateNewWithProjectReference();
        }
    }
}