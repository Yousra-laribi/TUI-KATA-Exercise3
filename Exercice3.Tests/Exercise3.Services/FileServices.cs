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
                if (file.IsTxt)
                {
                    return File.ReadAllText(file.Path);
                }
                else
                {
                    return "ERROR EXTENSION";
                }
            }
            catch(Exception ex)
            {
                return "ERROR EXCEPTION";
            }
        }
    }
}
