using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;

namespace BUS
{
    public class TableBUS
    {
        TableDAO tb = new TableDAO();
        public DataTable Get()
        {
            return tb.Get();
        }
    }
}
