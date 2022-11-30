using System;
using System.Threading.Tasks;
using R5T.F0000;
using R5T.T0132;


namespace R5T.S0054
{
	[FunctionalityMarker]
	public partial interface ISolutionFileScripts : IFunctionalityMarker
	{
		public async Task CreateNewWithProjectReference()
		{
            /// Inputs.
            var solutionFilePath =
                Z0019.SolutionFilePaths.Instance.Temp
                ;

            /// Run.
            await F0085.SolutionFileOperations.Instance.CreateNew_VS2022(
                solutionFilePath,
                solutionFile =>
                {
                    F0085.SolutionFileObjectOperator.Instance.AddProject(
                        solutionFile,
                        solutionFilePath,
                        Z0019.ProjectFilePaths.Instance.Example);

                    return Task.CompletedTask;
                });

            F0033.NotepadPlusPlusOperator.Instance.Open(
                solutionFilePath);
        }

        public async Task CreateNew_VS2022()
        {
            /// Inputs.
            var solutionFilePath =
                Z0019.SolutionFilePaths.Instance.Temp
                ;

            /// Run.
            await F0085.SolutionFileOperations.Instance.CreateNew_VS2022(
                solutionFilePath);

            F0033.NotepadPlusPlusOperator.Instance.Open(
                solutionFilePath);
        }

        public async Task CreateNew_Initial()
		{
            /// Inputs.
            var solutionFilePath =
                Z0019.SolutionFilePaths.Instance.Temp
                ;

            /// Run.
            await F0085.SolutionFileOperations.Instance.CreateNew_Initial(
                solutionFilePath);

            F0033.NotepadPlusPlusOperator.Instance.Open(
                solutionFilePath);
        }

		/// <summary>
		/// Generates a new VS2022 solution file without any projects.
		/// </summary>
		public void GenerateNewEmpty()
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