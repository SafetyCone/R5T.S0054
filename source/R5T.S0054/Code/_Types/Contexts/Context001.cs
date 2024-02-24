using System;

using R5T.F0024.T001;
using R5T.L0095.T000;
using R5T.L0095.T001;
using R5T.T0137;


namespace R5T.S0054
{
    /// <summary>
    /// A good <see cref="F0024.T001.SolutionFile"/> context.
    /// </summary>
    [ContextImplementationMarker]
    public class Context001 : IContextImplementationMarker,
        IWithSolutionName,
        IWithSolutionDirectoryPath,
        IWithSolutionFilePath,
        IWithSolutionFile
    {
        public string SolutionName { get; set; }
        public string SolutionDirectoryPath { get; set; }
        public string SolutionFilePath { get; set; }
        public SolutionFile SolutionFile { get; set; }
    }
}
