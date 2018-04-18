using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
    public class ReportRepository: BaseRepository
    {
        public const string sp_Name = "SP_Report";
        public ReportRepository() : base(new DatabaseCommunication(), sp_Name) { }
    }
}
