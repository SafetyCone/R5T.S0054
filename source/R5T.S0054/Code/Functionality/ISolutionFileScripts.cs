using System;
using System.Threading.Tasks;
using R5T.F0085;
using R5T.T0132;


namespace R5T.S0054
{
	[FunctionalityMarker]
	public partial interface ISolutionFileScripts : IFunctionalityMarker
	{
        public async Task UpgradeSolutionFile_ToVS2022()
        {
            /// Inputs.
            var solutionFilePath =
                //Z0019.SolutionFilePaths.Instance.Temp
                @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0031\source\R5T.S0031.sln"
                ;

            /// Run.
            await SolutionFileOperations.Instance.UpgradeSolutionFile_ToVS2022(
                solutionFilePath);
        }

		public async Task New_WithProjectReference()
		{
            /// Inputs.
            var solutionFilePath =
                Z0019.SolutionFilePaths.Instance.Temp
                ;

            /// Run.
            await SolutionFileOperations.Instance.NewSolutionFile_VS2022(
                solutionFilePath,
                solutionFile =>
                {
                    SolutionFileObjectOperator.Instance.AddProject(
                        solutionFile,
                        solutionFilePath,
                        Z0019.ProjectFilePaths.Instance.Example);
                });

            F0033.NotepadPlusPlusOperator.Instance.Open(
                solutionFilePath);
        }

        public async Task New_VS2022()
        {
            /// Inputs.
            var solutionFilePath =
                Z0019.SolutionFilePaths.Instance.Temp
                ;

            /// Run.
            await SolutionFileOperations.Instance.NewSolutionFile_VS2022(
                solutionFilePath);

            F0033.NotepadPlusPlusOperator.Instance.Open(
                solutionFilePath);
        }

        public async Task New_Initial()
		{
            /// Inputs.
            var solutionFilePath =
                Z0019.SolutionFilePaths.Instance.Temp
                ;


            /// Run.
            await SolutionFileOperations.Instance.NewSolutionFile_Initial(solutionFilePath);

            F0033.NotepadPlusPlusOperator.Instance.Open(solutionFilePath);
        }

		/// <summary>
		/// Generates a new VS2022 solution file without any projects.
		/// </summary>
		public async Task New_Empty()
		{
			/// Inputs.
			var solutionFilePath =
				Z0019.SolutionFilePaths.Instance.Temp
				;


            /// Run.
            await SolutionFileOperations.Instance.NewSolutionFile_Empty(solutionFilePath);

			F0033.NotepadPlusPlusOperator.Instance.Open(solutionFilePath);
		}
	}
}