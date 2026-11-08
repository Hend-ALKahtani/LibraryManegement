using LibraryMangegment_BusnissLogic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManegement
{
    internal class Global
    {
        public static  clsUser CurrentUser;
        // public void RememberMe(string UserName,)
       static string valuPassword = "Password";
       static string valueUserName = "UserName";
       static string Keyname = @"SOFTWARE\LibraryManegment";

        public static bool RememberMe(string UserName, string Password)
        {
            string KeyName = @"HKEY_CURRENT_USER\SOFTWARE\LibraryManegment";
            
            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(Keyname))
                {
                    if (key != null)
                    {
                        key.SetValue(valueUserName, UserName);
                        key.SetValue(valuPassword, Password);
                        return true;
                    }

                }
            }
            catch (Exception E)
            {
                throw new Exception(E.Message);
               // MessageBox.Show(E.Message);
            }
            return false;
        }
        
        public static bool CleareCredential()
        {
            
            try
            {
                using (RegistryKey basekey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = basekey.OpenSubKey(Keyname, writable: true))
                    {
                        if (key != null)
                        {
                            //here we user named arguments throwOnMissingValue:false write parameter name then write value
                            //this argment if the value not found will not throw exception
                            key.DeleteValue(valueUserName, throwOnMissingValue: false);
                            key.DeleteValue(valuPassword, throwOnMissingValue: false);
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
               // MessageBox.Show(ex.Message);
            }
            return false;
        }
        public static bool  LoadData(ref string  UserName,ref string PassWord)
        {
            

           try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    if (baseKey != null)
                    {
                        using (RegistryKey key = baseKey.OpenSubKey(Keyname))
                        {
                            if (key != null)
                            {
                               //here if the namevalue not exist will return null
                                string username = key.GetValue(valueUserName,defaultValue:null) as string;
                                string password = key.GetValue(valuPassword, null) as string;
                                if (username != null && password != null)
                                {
                                    UserName = username;
                                    PassWord = password;
                                    return true;
                                }

                            }
                        }
                    }
                }
            }
             catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }  
            return false;
            /*

              using (RegistryKey key=Registry.CurrentUser.OpenSubKey(KeyName))
            {
                if(key!=null)
                {
                    string username = key.GetValue(valueUserName, null) as string;
                    string password = key.GetValue(valuPassword, null) as string;
                    if (username != null && password != null)
                    {
                        txtUserName.Text = username;
                        txtPassword.Text = password;
                    }
                    else
                    {
                        txtPassword.Text = "";
                        txtUserName.Text = "";
                    }
                }
            }
             */

        }
    }
}
