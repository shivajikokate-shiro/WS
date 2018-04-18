using System.Collections.Generic;
using WaterSystem_Model;
using WaterSystem_Repository;


namespace WaterSystem_Manager.Receiver
{
    public class EmployeeReciever
    {
        EmployeeRepository _empRepo = null;
        public EmployeeReciever()
        {
            _empRepo = new EmployeeRepository();
        }

        public IEnumerable<EmployeeModel> GetList()
        {
            return ModelConverter.CreateListFromTable<EmployeeModel>(_empRepo.Retrieve().Tables[0]);
        }

        public void Add(EmployeeModel model)
        {
            model.Flag = Constants.DbConstants.Add;
            DatabaseOperation(model);
        }

        public void Update(EmployeeModel model)
        {
            model.Flag = Constants.DbConstants.Update;
            DatabaseOperation(model);
        }

        public void Delete(EmployeeModel model)
        {
            model.Flag = Constants.DbConstants.Delete;
            DatabaseOperation(model);
        }

        public void DatabaseOperation(EmployeeModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@Emp_Id", model.Emp_Id.ToString());
            parameters.Add("@Emp_Name", model.Emp_Name.ToString());
            parameters.Add("@Emp_Add", model.Emp_Add.ToString());
            parameters.Add("@Emp_Mob", model.Emp_Mob.ToString());
            parameters.Add("@Emp_BirthDate", model.Emp_BirthDate.ToString());
            parameters.Add("@Emp_JoinDate", model.Emp_JoinDate.ToString());
            parameters.Add("@Emp_Sal", model.Emp_Sal.ToString());
            parameters.Add("@IsCheck", model.IsCheck.ToString());
            parameters.Add("@flag", model.Flag.ToString());
            _empRepo.Save(parameters);
        }
    }
}
