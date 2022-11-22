using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.S0054
{
	[FunctionalityMarker]
	public partial interface ISolutionFileScripts : IFunctionalityMarker
	{
		public void CreateNewEmpty()
		{
			/// Inputs.
			var solutionFilePath =
				Z0019.SolutionFilePaths.Instance.Temp
				;

			/// Run.
			F0024.SolutionFileGenerator.Instance.CreateNew(
				solutionFilePath);

			F0033.NotepadPlusPlusOperator.Instance.Open(
				solutionFilePath);
		}
	}
}