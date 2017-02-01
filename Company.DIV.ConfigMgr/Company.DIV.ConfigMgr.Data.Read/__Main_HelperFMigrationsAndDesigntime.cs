using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Threading.Tasks;
using Company.DIV.ConfigMgr.Domain.Read;

namespace Company.DIV.ConfigMgr.Data.Read
    {
    public static class Program
        {
        public static void Main()
            {
            
            try
                {
                MainReal();
                }
            catch ( Exception ex )
                {
                Debug.Print("________________entireException");
                Debug.Print(ex.ToString());
                Debug.Print("________________StackTrace");
                Debug.Print(ex.StackTrace.ToString());
                Debug.Print("________________InnerException");
                Debug.Print(ex.InnerException.ToString());
                Debug.Print("________________Data");
                Debug.Print(ex.Data.ToString());
                }
            finally
                {

                }

            }

        /// <summary>
        /// Signature must be "static async Task<bool>" else it will compile, but the .Wait() operator below won't block... 
        ///   seems to operate same as not Awaiting a Task 
        ///      HResult=-2146233067 Message=A second operation started on this context before a previous asynchronous operation completed. Use 'await' to ensure that any asynchronous operations have completed before calling another method on this context. Any instance members are not guaranteed to be thread safe.
        /// </summary>
        private static async Task<bool> MainReal()
            {
            #if DEBUG
            ///designtime helper for Migrations - use whichever is needed, and set this project as the startup project 
            Database.SetInitializer<ConfigMgrReadContext>(new ConfigMgrCreateDatabaseIfNotExistsInitializer());
            //Database.SetInitializer<ConfigMgrContext>(new ConfigMgrDropCreateAlwaysInitializer());
            //Database.SetInitializer<ConfigMgrContext>(new ConfigMgrDropCreateIfModelChangesInitializer());
#endif

            List<int> List = new List<int>
            //{5,6,7,8 };
            {5,6,7 };

            List<int> List2 = new List<int>
            //{5,6,7,8 };
            {7,8 };


            Domain.Business.UseCase.JobIDList jobIDList = new Domain.Business.UseCase.JobIDList(List);
            Domain.Business.UseCase.JobIDList jobIDList2 = new Domain.Business.UseCase.JobIDList(List2);

            
            DAO.DROConfigFull DROConfigFull1;
            DAO.DROConfigFull DROConfigFull2;
            DAO.DROConfigFull DROConfigFull3;
            Debug.Print("__________MainDeclarationsEnd");

            using ( ConfigMgrReadContext dbcontext = new ConfigMgrReadContext() )
                {
                Debug.Print("__________DROConfigFull1_Start");
                int debug0 = 1;
                DROConfigFull1 = new Company.DIV.ConfigMgr.Data.Read.DAO.DROConfigFull(dbcontext , jobIDList);
                //var load1 = DROConfigFull1.LoadAllAsync();
                //await load1;
                
                try
                    {
                    DROConfigFull1.LoadAllAsync().Wait();
                    //var x1 = DROConfigFull1.LoadAllAsync().Result;
                    //await DROConfigFull1.LoadAllAsync();  // even with non-parallel Async (), this just skips to Main +Finally without running anything inside DROConfigFull1.LoadAllAsync()
                    //var x1 = DROConfigFull1.LoadAllAsync();
                    //await x1;  // this just skips to Main +Finally without running anything inside DROConfigFull1.LoadAllAsync()
                    }
                catch ( Exception ex )
                    {
                    Debug.Print("________________entireException");
                    Debug.Print(ex.ToString());
                    Debug.Print("________________StackTrace");
                    Debug.Print(ex.StackTrace.ToString());
                    Debug.Print("________________InnerException");
                    Debug.Print(ex.InnerException.ToString());
                    Debug.Print("________________Data");
                    Debug.Print(ex.Data.ToString());
                    }
                finally
                    {
                    // # 1
                    }

                int debug1 = 1;
                Debug.Print("__________DROConfigFull1_End");
                }

            using ( ConfigMgrReadContext dbcontext = new ConfigMgrReadContext() )
                {
                Debug.Print("__________DROConfigFull2_Start");
                int debug1 = 1;
                DROConfigFull2 = new Company.DIV.ConfigMgr.Data.Read.DAO.DROConfigFull(dbcontext , jobIDList , DROConfigFull1);
                //var load2 = DROConfigFull2.LoadAllAsync();
                //await load2;
                
                try
                    {
                    DROConfigFull2.LoadAllAsync().Wait();
                    //var x2 = DROConfigFull2.LoadAllAsync().Result;    
                    //await DROConfigFull2.LoadAllAsync();    //even with non-parallel Async (), this just skips to Main +Finally without running anything inside DROConfigFull1.LoadAllAsync()
                    //var x2 = DROConfigFull2.LoadAllAsync();
                    //await x2;  // this just skips to Main +Finally without running anything inside DROConfigFull1.LoadAllAsync()
                    }
                catch ( Exception ex )
                    {
                    Debug.Print("________________entireException");
                    Debug.Print(ex.ToString());
                    Debug.Print("________________StackTrace");
                    Debug.Print(ex.StackTrace.ToString());
                    Debug.Print("________________InnerException");
                    Debug.Print(ex.InnerException.ToString());
                    Debug.Print("________________Data");
                    Debug.Print(ex.Data.ToString());
                    }
                finally
                    {
                    // # 2
                    }
                int debug2 = 1;
                Debug.Print("__________DROConfigFull2_End");
                }

            using ( ConfigMgrReadContext dbcontext = new ConfigMgrReadContext() )
                {
                Debug.Print("__________DROConfigFull3_Start");
                int debug2 = 1;
                DROConfigFull3 = new Company.DIV.ConfigMgr.Data.Read.DAO.DROConfigFull(dbcontext , jobIDList2 , DROConfigFull1);
                //var load3 = DROConfigFull3.LoadAllAsync();
                //await load3;

                try
                    {
                    DROConfigFull3.LoadAllAsync().Wait();
                    //var x3 = DROConfigFull3.LoadAllAsync().Result;
                    //await DROConfigFull3.LoadAllAsync();  //even with non-parallel Async (), this just skips to Main +Finally without running anything inside DROConfigFull1.LoadAllAsync()
                    //var x3 = DROConfigFull3.LoadAllAsync();
                    //await x3;  // this just skips to Main +Finally without running anything inside DROConfigFull1.LoadAllAsync()
                    }
                catch (Exception ex)
                    {
                    Debug.Print("________________entireException");
                    Debug.Print(ex.ToString());
                    Debug.Print("________________StackTrace");
                    Debug.Print(ex.StackTrace.ToString());
                    Debug.Print("________________InnerException");
                    Debug.Print(ex.InnerException.ToString());
                    Debug.Print("________________Data");
                    Debug.Print(ex.Data.ToString());
                    }
                finally
                    {
                    // # 3 
                    }

                int debug3 = 1;
                Debug.Print("__________DROConfigFull3_End");
                }

            return true;
            }

        }
    }
