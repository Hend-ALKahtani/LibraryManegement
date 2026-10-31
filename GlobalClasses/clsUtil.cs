using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManegement
{
    internal class clsUtil
    {
        public static string GenrateGUID()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
        public static string ReplaceFileNameWithGUID(string Resource)
        {
            FileInfo info= new FileInfo(Resource);
            return GenrateGUID() + info.Extension; 
        }
        public static bool CreatFolderIfNotExist(string FolderName)
        {
            if(!Directory.Exists(FolderName))
            {
                try
                {
                    Directory.CreateDirectory(FolderName);
                    return true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Failed to create file"+ex.Message);
                    return false;
                }
            }
            return true;
        }
        public static bool CopyImageToProjectFolder(ref string resourceFile)
        {
            string destinationFolder = "D:\\Project\\LibraryManegement\\Image";
            if (!CreatFolderIfNotExist(destinationFolder))
            {
                return false;

            }
           
              
            string FileName = destinationFolder + ReplaceFileNameWithGUID(resourceFile);
            try
            {
                File.Copy(resourceFile, FileName,true);

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                EventLogToEventViwer(E.Message);
                return false;
            }
            resourceFile = FileName;
            return true;
        }
        public static void EventLogToEventViwer(string WritEntry)
        {
            string resource = "LibraryManegement";
           if(!EventLog.SourceExists(resource))
            {
                EventLog.CreateEventSource(resource, "Application");
            }
           EventLog.WriteEntry(resource, WritEntry,EventLogEntryType.Error);
        }
    }
}
