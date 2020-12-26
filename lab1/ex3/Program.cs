using System;
/// <summary>
/// The program demonstrates the use of XML comments.
/// 
/// Emplyee class user constructors to inialize the IDand
/// name of the employee and displays them
/// </summary>
/// <remarks>
/// this program user both parameterized and 
/// non-parametrized constructors
/// </remarks>
    class Program
    {
        /// <summary>
        /// Integer field to store employee ID
        /// </summary>
        private int _id;
        /// <summary>
        /// String field to store employee name
        /// </summary>
        private string _name;
    /// <summary>
    /// this constructor initializes the idand name to-1 and null
    /// </summary>
    /// <remarks>
    /// <seealso cref="Employee (int,string)">Employee(int,string)</seealso>
    /// </remarks>
    public Program()
        {
            _id = -1;
            _name = null;
        }
        ///<summary>
        ///this constructor initializes the id and name
        ///(<paramref name="id"/>,<paramerf name="name"/>
        /// </summary>
        /// <pram name="id">Employee ID</pram>
        /// <param name="name">Employee Name</param>
        public Program(int id,string name)
        {
            this._id = id;
            this._name = name;
        }
        ///<summary>
        ///The entry point for the application
        /// <paramref name="args"/>Alist of command line arguments</param>
        /// </summary>
        /// 


       
   
     
        static void Main(string[] args)
        {
            //Creating an object of Emloyee class and displaying the
            //id and name of the employee
            Program objEmp = new Program(101, "David Smith");
        Console.WriteLine("Employee ID : {0}\nEmployee Name: {1} ", objEmp._id, objEmp._name);
        }
    }

