using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LiqMetalDMS_Bll_Data.Security
{

    public class Security
    {
        //        private string _path;
        //        private string _filterAttribute;
        //        private string _defaultDomain;
        //private lms_usuarios _user;

        //public lms_usuarios User
        //{
        //    get { return _user; }
        //    set { _user = value; }
        //}
        //        private Object_RoleList m_objectList = new Object_RoleList();
        private int m_UserId = 0;
        private string m_Machine = "";

        /// <summary>
        /// Name of machine in the network
        /// </summary>
        public string Machine
        {
            get { return m_Machine; }
            set { m_Machine = value; }
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Security()
        {
            //_path = Latinode.Core.Properties.Settings.Default["LDAP"].ToString();
            //_DefaultDomain = Latinode.Core.Properties.Settings.Default["DOMAIN"].ToString();
            //_defaultDomain = "LATINODE";
            //_path = @"ldap://srv01a:389/dc=com";
        }

        /// <summary>
        /// Constructo with ldap path
        /// </summary>
        /// <param name="path"></param>
        //public Security(string path)
        //{
        //   _path = path;
        //}

        private string m_LoginName;

        public string LoginName
        {
            get { return m_LoginName; }
            set { m_LoginName = value; }
        }

        public int UserId
        {
            get { return m_UserId; }
            //            set { m_UserId = value; }
        }

        public bool CanCreate(string Obj)
        {
            return true;
        }

        public bool CanDelete(string Obj)
        {
            return true;
        }

        public bool CanUse(string Obj)
        {
            return true;
        }

        public bool CanUpdate(string Obj)
        {
            return true;
        }

        //public string UserName
        //{
        //    get { return _user.nombre + " " + _user.apellidos; }
        //}

        //public int ValidateUser(string Name, string Pass)
        //{
        //    int validated=0;
        //    _user = Medicenek.lms_usuariosController.Instance().Get(Name);
        //    if (_user != null)
        //    {
        //        m_UserId = _user.id;
        //        validated = verifySha1Hash(Pass, _user.clave)?1:-1;
        //    }
        //    return validated;

        //}

        /// <summary>
        /// Get the hash for a string
        /// </summary>
        /// <param name="input">input string</param>
        /// <returns>32 character hexadecimal string</returns>
        public string getSHA1(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            SHA1 sha1Hasher = SHA1.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = sha1Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        /// <summary>
        /// Validate a hash 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        private bool verifySha1Hash(string input, string hash)
        {
            // Hash the input.
            string hashOfInput = getSHA1(input);

            // Create a StringComparer an comare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        public string FilterString(string p)
        {
            return "";
        }

        public string FilterCanUseSecurityField(object Obj)
        {
            return "";
        }

        public bool CanModify(string p)
        {
            return true;
        }

    }


    /// <summary>
    /// Summary description for sec
    /// </summary>
    public static class Validate
    {
        public const string ITEM_DESCRIPTION = "SecurtyKey";

        private static bool m_isWeb = true;
        private static Security m_Security;

        /// <summary>
        /// Type indicate if the class is used in a web environment
        /// </summary>
        public static bool IsWeb
        {
            get
            {
                return m_isWeb;
            }
            set
            {
                m_isWeb = value;
            }
        }
        /// <summary>
        /// This is the item's description
        /// </summary>
        public static Security security
        {

            get
            {
                Security sec;
                //if (IsWeb)
                //{
                //    sec = (Security)HttpContext.Current.Session[ITEM_DESCRIPTION];
                //    if (sec == null)
                //    {
                //        sec = new Security();
                //        HttpContext.Current.Session[ITEM_DESCRIPTION] = sec;
                //    }
                //}
                //else
                //{
                sec = m_Security;
                if (sec == null)
                {
                    sec = new Security();
                    m_Security = sec;
                }
                //}
                return sec;
            }
        }

        /// <summary>
        /// To write log
        /// </summary>
        /// <param name="nciUser_Id"></param>
        /// <param name="cnaMachine"></param>
        /// <param name="dtTransaction"></param>
        /// <param name="cnaModule"></param>
        /// <param name="cnaTable"></param>
        /// <param name="nctTransactionType"></param>
        /// <param name="ctxValues"></param>
        /// <param name="ctxResult"></param>
        /// <param name="nctResultType"></param>
        /// <param name="nctTransactionSchema"></param>
        public static void WriteLog(int nciUser_Id, string cnaMachine, DateTime dtTransaction, string cnaModule, string cnaTable, int nctTransactionType, string ctxValues, string ctxResult, int nctResultType, int nctTransactionSchema)
        {
            // Transaction_LogController.Instance().WriteLog(logType, values);            
        }
        /// <summary>
        /// To write log, use the user logon, machine and current time
        /// </summary>
        /// <param name="cnaModule"></param>
        /// <param name="cnaTable"></param>
        /// <param name="nctTransactionType"></param>
        /// <param name="ctxValues"></param>
        /// <param name="ctxResult"></param>
        /// <param name="nctResultType"></param>
        /// <param name="nctTransactionSchema"></param>
        public static void WriteLog(string cnaModule, string cnaTable, int nctTransactionType, string ctxValues, string ctxResult, int nctResultType, int nctTransactionSchema)
        {
            WriteLog(m_Security.UserId, m_Security.Machine, DateTime.Now, cnaModule, cnaTable, nctTransactionType, ctxValues, ctxResult, nctResultType, nctTransactionSchema);
        }

        private static NumberFormatInfo m_NumberInfo;

        /// <summary>
        /// For using an unique format number in the aplication
        /// </summary>
        public static NumberFormatInfo NumberInfo
        {
            get
            {
                if (m_NumberInfo == null)
                {
                    m_NumberInfo = new NumberFormatInfo();
                    m_NumberInfo.CurrencyDecimalSeparator = ".";
                    //m_NumberInfo.CurrencyDecimalDigits = 2;
                    m_NumberInfo.NumberDecimalSeparator = ".";
                    //m_NumberInfo.NumberDecimalDigits = 2;
                }

                return m_NumberInfo;
            }
        }


    }
}
