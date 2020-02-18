using System;
using System.Collections.Generic;
using System.Text;

namespace GraphSave
{
    /// <summary>
    /// DO NOT USE OUTSIDE!  Implement data file path for other formater class.
    /// </summary>
    public class DiscGraphSave
    {
        /// <summary>
        /// Path to file.
        /// </summary>
        protected string filePath;

        /// <summary>
        /// Inicjalize disc save and load to file.
        /// </summary>
        /// <param name="filePath">Set file path.</param>
        public DiscGraphSave(string filePath) =>
            this.filePath = filePath;

        /// <summary>
        /// Change file directory to save/load.
        /// </summary>
        /// <param name="filePath">File path.</param>
        public void ChangeDirectory(string filePath) =>
            this.filePath = filePath;

    }
}
