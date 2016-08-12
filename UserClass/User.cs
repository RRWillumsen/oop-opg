using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySystem
{
    /// <summary>
    /// Summary description for User
    /// </summary>
    public class User
    {

        #region Fields - klassens indkapslede egenskaber
        private string username;
        private string firstname;
        private string lastname;
        private int role;
        #endregion

        #region Constructors - klassens konstruktør (er)
        public User()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion

        #region Properties - klassens offentlige adgang til de indkapslede fields
      
        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }
        
        #endregion

        #region Methods - klassens offentlige metoder
        public static bool IsUser()
        {
            bool result = false;

            if (HttpContext.Current.Session["user"] != null)
            {
                result = true;
            }

            return result;
        }


        public static void CreateSession()
        {
            if
            (HttpContext.Current.Session["user"] == null)
            {
                HttpContext.Current.Session.Add("user", "noname");
            }
        }

        public static void RemoveSession()
        {
            if (HttpContext.Current.Session["user"] != null)
            {
                HttpContext.Current.Session.Remove("user");
            }
        }
        #endregion
    }
}