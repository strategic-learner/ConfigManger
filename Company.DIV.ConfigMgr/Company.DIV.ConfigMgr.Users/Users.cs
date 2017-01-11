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

        public String defaultUser { get; } = "defaultUser";

        public string Mock1()
            {
            return "Mock User1";
            }
        }
    }
