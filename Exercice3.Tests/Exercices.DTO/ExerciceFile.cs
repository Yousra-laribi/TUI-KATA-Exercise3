using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.DTO
{
    public class ExerciceFile
    {
        public string Path { get; set; }

        public bool IsTxt
        {
            get
            {
                return System.IO.Path.GetExtension(Path).Equals(".txt");
            }
        }
    }

    
}
