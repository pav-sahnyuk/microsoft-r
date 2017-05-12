// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ValidateSetup.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ExecuteResponse
    {
        /// <summary>
        /// Initializes a new instance of the ExecuteResponse class.
        /// </summary>
        public ExecuteResponse()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExecuteResponse class.
        /// </summary>
        /// <param name="success">The operation was successful.</param>
        /// <param name="errorMessage">Errors returned by the
        /// execution.</param>
        /// <param name="outputParameters">Output parameters for the
        /// execution.</param>
        /// <param name="consoleOutput">The console output of the
        /// execution.</param>
        /// <param name="changedFiles">The filenames of the files modified
        /// during execution.</param>
        public ExecuteResponse(bool? success = default(bool?), string errorMessage = default(string), IList<WorkspaceObject> outputParameters = default(IList<WorkspaceObject>), string consoleOutput = default(string), IList<string> changedFiles = default(IList<string>))
        {
            Success = success;
            ErrorMessage = errorMessage;
            OutputParameters = outputParameters;
            ConsoleOutput = consoleOutput;
            ChangedFiles = changedFiles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the operation was successful.
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Gets or sets errors returned by the execution.
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets output parameters for the execution.
        /// </summary>
        [JsonProperty(PropertyName = "outputParameters")]
        public IList<WorkspaceObject> OutputParameters { get; set; }

        /// <summary>
        /// Gets or sets the console output of the execution.
        /// </summary>
        [JsonProperty(PropertyName = "consoleOutput")]
        public string ConsoleOutput { get; set; }

        /// <summary>
        /// Gets or sets the filenames of the files modified during execution.
        /// </summary>
        [JsonProperty(PropertyName = "changedFiles")]
        public IList<string> ChangedFiles { get; set; }

    }
}