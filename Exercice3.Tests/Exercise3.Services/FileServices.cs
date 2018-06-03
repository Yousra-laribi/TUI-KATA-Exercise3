using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise3.DTO;
using System.IO;

namespace Exercise3.Services
{
    public class FileServices : IFileServices
    {
        private readonly ExerciceFile file;

        public FileServices(ExerciceFile f)
        {
            file = f;
        }
        public string ReadFile()
        {
            try
            {
                if (!file.IsEncrypted)
                {
                    if (file.IsTxt || file.IsXml)
                    {
                        return File.ReadAllText(file.Path);
                    }
                    else
                    {
                        return "ERROR EXTENSION";
                    }
                }
                else
                {
                    if (file.IsTxt)
                    {
                        return new string(File.ReadAllText(file.Path).Reverse().ToArray());
                    }
                    else
                    {
                        return "ERROR FILE ENCRYPTED";
                    }
                }
            }
            catch (Exception ex)
            {
                return "ERROR EXCEPTION";
            }
        }
    }
}
