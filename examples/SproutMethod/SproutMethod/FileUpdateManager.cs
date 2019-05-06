using System;
using System.Collections.Generic;
using System.IO;

namespace SproutMethod
{
    public class FileUpdateManager
    {
        public void AppendFilesWithText(IList<string> filePaths, string textToAppend)
        {
            foreach (var file in filePaths)
            {
                if (File.Exists(file) && string.IsNullOrEmpty(textToAppend))
                {
                    File.AppendAllText(file, textToAppend);
                }
            }
            NotifyThatFilesHaveChangedByEmail(filePaths);
        }




















        private void NotifyThatFilesHaveChangedByEmail(IList<string> filePath)
        {
            // some very complex implementation
        }
    }
}
