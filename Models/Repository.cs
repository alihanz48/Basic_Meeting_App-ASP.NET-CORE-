namespace MeetingApp.Models{
    public static class Repository{
        
        private static List<UserInfo> _users=new();

        static Repository(){
            _users.Add(new UserInfo(){id=1,name="Ahmet Dursun",phone="012365478985",email="asdasdasd@gmail",willattend=true});
            _users.Add(new UserInfo(){id=2,name="Ali Dursun",phone="014785236985",email="fff@gmail",willattend=false});
            _users.Add(new UserInfo(){id=3,name="Mustafa Dursun",phone="014788996332254",email="dfdfd@gmail",willattend=true});
        }

        public static List<UserInfo> Users{
           get{
              return _users;
           }
        }
        
        public static void CreateUser(UserInfo user){
            user.id=_users.Max(userid=>userid.id)+1;
            _users.Add(user);
        }

        public static UserInfo? userDetails(int id){
            return _users.FirstOrDefault(user=>user.id==id);
        }
    }
}