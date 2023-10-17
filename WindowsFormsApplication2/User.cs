using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class User
    {
        private string name;
        private string family;
        private string username;
        private string password;
        private string email;
        private int id;

        //constructor
        public User(string name, string family,string username, string password , string email/*, int id*/)
        {
            setName(name);
            setFamily(family);
            setUsername(username);
            setPassword(password);
            setEmail(email);
            //setID(id);       
        }

        //default constructor
        public User()
        {
            setUsername("test");
            setPassword("test");
            setFamily("test");
            setName("test");
            setEmail("test");
            //setID(1);
        }
        public void setName(string name)
        {
            this.name=name;
        }
        public void setFamily(string family)
        {
            this.family = family;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        /*public void setID(int id)
        {
            this.id = id;
        }*/

        public string getName()
        {
            return this.name;
        }
        public string getFamily()
        {
            return this.family;
        }
        public string getUsername()
        {
            return this.username;
        }
        public string getPassword()
        {
            return this.password;
        }
        public string getEmail()
        {
            return this.email;
        }
        /*public int getID()
        {
            return this.id;
        }*/

        //toString
        public string ToString()
        {
            return getName() + " " + getUsername() + " " + getPassword() + " " + getEmail()/*+" "+getID()*/;
        }
    }

}
