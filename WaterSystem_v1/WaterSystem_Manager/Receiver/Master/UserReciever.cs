using System;
using System.Collections.Generic;
using WaterSystem_Model;
using WaterSystem_Repository;


namespace WaterSystem_Manager.Receiver
{
    public class UserReciever
    {
        public UserRepository _userRepo = null;
        public UserReciever()
        {
            this._userRepo = new UserRepository();
        }

        public IEnumerable<UserModel> GetList()
        {
            return ModelConverter.CreateListFromTable<UserModel>(_userRepo.Retrieve().Tables[0]);
        }

        public IEnumerable<GroupModel> GetGroupDetails()
        {
            return ModelConverter.CreateListFromTable<GroupModel>(_userRepo.Retrieve().Tables[1]);
        }

        public void Add(UserModel model)
        {
            model.Flag = Constants.DbConstants.Add;
            DatabaseOperation(model);
        }

        public void Update(UserModel model)
        {
            model.Flag = Constants.DbConstants.Update;
            DatabaseOperation(model);
        }

        public void Delete(UserModel model)
        {
            model.Flag = Constants.DbConstants.Delete;
            DatabaseOperation(model);
        }

        public void DatabaseOperation(UserModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@UserID", model.UserId.ToString());
            parameters.Add("@UserName", model.UserName.ToString());
            parameters.Add("@Password", model.Password.ToString());
            parameters.Add("@GroupID", model.GroupId.ToString());
            parameters.Add("@OrgnisationId", "1");
            parameters.Add("@flag", model.Flag.ToString());
            _userRepo.Save(parameters);
        }
    }
}
