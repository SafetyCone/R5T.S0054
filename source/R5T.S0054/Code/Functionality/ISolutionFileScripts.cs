using System;
using System.Threading.Tasks;

using R5T.F0085;
using R5T.L0091.T000;
using R5T.L0092.T001;
using R5T.T0132;


namespace R5T.S0054
{
	[FunctionalityMarker]
	public partial interface ISolutionFileScripts : IFunctionalityMarker
	{
        public async Task Create_SolutionFile_Empty_WithContextOperations()
        {
            /// Inputs.
            var solutionName =
                "P0002"
                ;
            var solutionDirectoryPath =
                @"C:\Code\DEV\Git\GitHub\davidcoats\D8S.E0013\source"
                ;

            /// Run.
            await Instances.ContextOperator.In_Context<Context001>(
                Instances.ContextOperations.Construct_Context_A_A<Context001>(
                    Instances.SolutionFileContextOperations.Set_SolutionName<Context001>(solutionName,
                        out var solutionNameSet),
                    Instances.SolutionFileContextOperations.Set_SolutionDirectoryPath<Context001>(solutionDirectoryPath,
                        out var solutionDirectoryPathSet),
                    Instances.SolutionFileContextOperations.Set_SolutionFilePath<Context001>((solutionNameSet, solutionDirectoryPathSet),
                        out var solutionFilePathSet)
                ),
                Instances.SolutionFileContextOperations.Verify_SolutionFile_DoesNotExist<Context001>(
                    solutionFilePathSet,
                    out var checkedSolutionFileDoesNotExist),
                Instances.SolutionFileContextOperations.Create_SolutionFile<Context001>(
                    checkedSolutionFileDoesNotExist,
                    out var checkedSolutionFileExists)
            );

            Ensure_SolutionFileChecks(
                checkedSolutionFileDoesNotExist,
                checkedSolutionFileExists);

#pragma warning disable IDE0060 // Remove unused parameter

            static void Ensure_SolutionFileChecks(
                IChecked<IFileDoesNotExist> checkedSolutionFileDoesNotExist,
                IChecked<IFileExists> checkedSolutionFileExists)
            {
                // Do nothing.
            }

#pragma warning restore IDE0060 // Remove unused parameter
        }

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