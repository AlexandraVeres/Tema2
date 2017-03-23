using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandy_style
{
   public interface IDManager
    {
        void AddSt(Student student);
        void UpdateSt(Student student);
        void DeleteSt(Student student);
    }
}
