using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.DIV.ConfigMgr.Users
    {

    /// <summary>
    /// replace with your desired UserManagement implementation
    /// </summary>
    public class MockUsers
        {

        public static String defaultUser { get; } = "defaultUser";

        public static string Mock1()
            {
            return "Mock User1";
            }
        }
    }
