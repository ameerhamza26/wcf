using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService5
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        bool insertuser(users userInsert);

        [OperationContract]
        List<users> getUsers();

        [OperationContract]

        List<testsinfo> gettestinfo();

        [OperationContract]

        List<testsinfo> getspecifictestinfo(int k);

        [OperationContract]

        List<tests> getspecifictest(int k);

        [OperationContract]

        List<tests> gettest();

        [OperationContract]
        bool inserttestDetails(testsinfo testInsert);

        [OperationContract]

        bool insertTest(tests testInsert);

        [OperationContract]
        bool insertuserandmarks(marks_users insertMarks);

        [OperationContract]
        bool insertuserformobile(int id,string f, string l, string e, string p, string a);

        [OperationContract]
        List<marks_users> getallusermarks(int k);
       
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   [DataContract]
    public class marks_users
    {
       private int id;
       private int test_id;
       private string name;
       private string email;
       private string sch_colg;
       private int obt_marks;

       [DataMember]
       public int ID { get { return id; } set { id = value; } }

       [DataMember]
       public int Test_ID { get { return test_id; } set { test_id = value; } }

       [DataMember]

       public string Name { get { return name; } set { name = value; } }

       [DataMember]

       public string Email { get { return email; } set { email = value; } }

       [DataMember]

       public string School_Colg { get { return sch_colg; } set { sch_colg = value; } }

       [DataMember]

       public int Obtained_Marks { get { return obt_marks; } set { obt_marks = value; } }


    }
    
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    [DataContract]
    public class users
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string about;

        [DataMember]
        public int userId { get { return id; } set { id = value; } }
         [DataMember]
        public string first_name
        { get { return firstName; } set { firstName = value; } }
        
        [DataMember]
         public string last_name { get { return lastName; } set { lastName = value; } }

        [DataMember]

        public string Email { get { return email; } set { email = value; } }

        [DataMember]

        public string Password { get { return password; } set { password = value; } }

        [DataMember]

        public string About { get { return about; } set { about = value; } }
    }

    [DataContract]
    public class testsinfo
    {
        private int userId;
        private int testsId;
        private string testName;
        private string testSub;
        private string testTime;
        private string testMax;
        private string testDetails;
       
        [DataMember]
        public int user_ID { get { return userId; } set { userId = value; } }

        [DataMember]
        public int test_ID { get { return testsId; } set { testsId = value; } }
        [DataMember]
        public string test_name { get { return testName; } set { testName = value; } }
        [DataMember]
        public string test_Sub { get { return testSub; } set { testSub = value; } }

        [DataMember]
        public string test_time { get { return testTime; } set { testTime = value; } }

        [DataMember]
        public string test_max { get { return testMax; } set { testMax = value; } }
        [DataMember]

        public string test_details { get { return testDetails; } set { testDetails = value; } }
    
    }

    [DataContract]
    public class tests 
    {
        private int id;
        private int testid;
        private string question;
        private string opt1;
        private string opt2;
        private string opt3;
        private string opt4;
        private string rightans;

        [DataMember]
        public int Id { get { return id; } set { id = value; } }

        [DataMember]
        public int test_id {get{ return testid;} set{ testid =value;}}

        [DataMember]
        public string Ques {get { return question;} set{ question =value;}}
        [DataMember]
        public string option1 {get {return opt1;} set {opt1 = value;}}
        [DataMember]

        public string option2 {get { return opt2;} set{opt2 = value;}}

        [DataMember]
    public string option3 {get{return opt3;} set { opt3 = value;}}
        [DataMember]
        public string option4 { get{return opt4;} set{opt4 =value;}}
        [DataMember]
        public string Right_ans { get { return rightans; } set { rightans = value; } }
    
    }

}
