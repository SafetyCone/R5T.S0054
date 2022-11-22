using System;


namespace R5T.S0054
{
	public class SolutionFileScripts : ISolutionFileScripts
	{
		#region Infrastructure

	    public static ISolutionFileScripts Instance { get; } = new SolutionFileScripts();

	    private SolutionFileScripts()
	    {
        }

	    #endregion
	}
}