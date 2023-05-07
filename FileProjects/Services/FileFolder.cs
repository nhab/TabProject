using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProjects.Services
{
    public class FileFolder
    {
        public static DataTable Get(string path)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("caption");
            dataTable.Columns.Add("size",typeof(string)).Caption= "size in bytes";
            dataTable.Columns.Add("Filecount", typeof(string)).Caption= "File count";
            
            string[] entries = Directory.GetFileSystemEntries(path);
            foreach (string entry in entries)
            {
                DataRow row = dataTable.NewRow();
                string name = Path.GetFileName(entry);
                bool isFile = (File.GetAttributes(entry) & FileAttributes.Directory) == 0;
                if (isFile)
                {
                    FileInfo fileInfo = new FileInfo(entry);
                    row["caption"] = name;
                    row["size"] = fileInfo.Length.ToString() + " b";
                    //ListFileDirs.Items.Add(name + " - " + fileInfo.Length.ToString() + " b");
                }
                else
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(entry);
                    int fileCount = dirInfo.GetFiles().Length;
                    row["caption"] = name;
                    row["Filecount"] = fileCount.ToString();
                    //ListFileDirs.Items.Add("<" + name + "> " + fileCount.ToString());
                }
                dataTable.Rows.Add(row);
            }
            return dataTable;
            // ListFileDirs.Items.SortDescriptions.Add(new SortDescription("name", ListSortDirection.Ascending));
        }

    }
}
