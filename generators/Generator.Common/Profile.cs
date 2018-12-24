using System.Collections.Generic;
using Newtonsoft.Json;

namespace Generator.Common
{
    /// <summary>
    /// Represents a subsystem as defined in GitHub issue #823.
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// Gets or sets a dictionary where the category names (or "Core", if the project isn't an extension)
        /// are the keys and <see cref="Project"/>s are the values.
        /// </summary>
        public Dictionary<string, Project> Projects { get; set; } = new Dictionary<string, Project>();

        /// <summary>
        /// Gets or sets the root namespace of this profile.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or sets the root namespace of extensions contained within this profile.
        /// </summary>
        public string ExtensionsNamespace { get; set; }

        /// <summary>
        /// Gets or sets the output folder in which the projects are wrote.
        /// </summary>
        [JsonIgnore]
        public string OutputFolder { get; set; }

        /// <summary>
        /// Gets or sets the name of this profile, as defined by the Khronos spec. File names should be used for
        /// colloquial names.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the version of this profile.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets a list of type maps to be applied to the projects in the order in which they're applied.
        /// </summary>
        [JsonIgnore]
        public List<Dictionary<string, string>> TypeMaps { get; set; } = new List<Dictionary<string, string>>();
    }
}
