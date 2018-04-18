using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSystem_Model;

namespace WaterSystem_Manager.Receiver
{
    interface IReciever
    {
        void Add(IModel model);
        void Update(IModel model);
        void Delete(IModel model);
        void DatabaseOperation(IModel model);
    }
}
