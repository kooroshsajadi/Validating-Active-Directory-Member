using System;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Net.Sockets;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form : System.Windows.Forms.Form
    {
        public DirectorySearcher DirSearch = null;
        public Form()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //GetInfo(textBoxUsername.Text, textBoxPassword.Text, textBoxAddress.Text);
            //PrincipalContext pc = new PrincipalContext(ContextType.Domain, "WinNT://192.168.0.17");
            //PrincipalContext pc = new PrincipalContext(ContextType.Domain, "WinNT://192.168.0.17", "ksajadi", "Abc1234@$");
            //bool Valid = pc.ValidateCredentials("ksajadi", "Abc1234@$");
            PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, TxtBoxAddress.Text);
            bool userValid = principalContext.ValidateCredentials(TxtBoxUsername.Text, TxtBoxPassword.Text);
            MessageBox.Show(userValid.ToString());

            //bool result = false;
            //using (DirectoryEntry _entry = new DirectoryEntry())
            //{
            //    _entry.Username = "ksajadi";
            //    _entry.Password = "Abc1234@$";
            //    DirectorySearcher _searcher = new DirectorySearcher(_entry)
            //    {
            //        Filter = "(objectclass=user)"
            //    };
            //    SearchResult sr = _searcher.FindOne();
            //    string name = sr.Properties["displayname"][0].ToString();
            //    string accName = sr.Properties["samaccountname"][0].ToString();
            //    string sn = sr.Properties["sn"][0].ToString();
            //    MessageBox.Show(name);
            //    MessageBox.Show(accName);
            //    MessageBox.Show(sn);
            //    result = true;
            //    MessageBox.Show(result.ToString());
            //}
        }

        private void GetInfo(string username, string password, string domain)
        {
            SearchResult rs = null;
            if (textBoxSearch.Text.IndexOf("@") > 0)
                rs = SearchByEmail(GetDirectorySearcher(username, password, domain), textBoxSearch.Text);
            else
                rs = SearchByUserName(GetDirectorySearcher(username, password, domain), textBoxSearch.Text);
            if (rs != null)
                ShowUserInformation(rs);
        }

        private SearchResult SearchByEmail(DirectorySearcher ds, string email)
        {
            ds.Filter = "(&((&(objectCategory=Person)(objectClass=User)))(mail=" + email + "))";
            ds.SearchScope = SearchScope.Subtree;
            ds.ServerTimeLimit = TimeSpan.FromSeconds(40);

            SearchResult userObject = ds.FindOne();
            if (userObject != null)
                return userObject;
            else
                return null;
        }

        private DirectorySearcher GetDirectorySearcher(string username, string password, string domain)
        {
            DirSearch = new DirectorySearcher(
                new DirectoryEntry("WinNT://" + domain, username, password, AuthenticationTypes.SecureSocketsLayer));
            return DirSearch;
        }

        private void ShowUserInformation(SearchResult rs)
        {
            if (rs.GetDirectoryEntry().Properties["samaccountname"].Value != null)
            {
                textBoxInformation.Text = "Username :" + rs.GetDirectoryEntry().Properties["samaccountname"].Value.ToString();
            }

            if(rs.GetDirectoryEntry().Properties["givenName"].Value != null)
            {
                textBoxInformation.AppendText("First Name :" + rs.GetDirectoryEntry().Properties["givenName"].Value.ToString());
            }

            if (rs.GetDirectoryEntry().Properties["initials"].Value != null)
            {
                textBoxInformation.AppendText("Middle Name :" + rs.GetDirectoryEntry().Properties["initials"].Value.ToString());
            }

            if (rs.GetDirectoryEntry().Properties["sn"].Value != null)
            {
                textBoxInformation.AppendText("Last Name :" + rs.GetDirectoryEntry().Properties["sn"].Value.ToString());
            }

            if (rs.GetDirectoryEntry().Properties["sn"].Value != null)
            {
                textBoxInformation.AppendText("Last Name :" + rs.GetDirectoryEntry().Properties["sn"].Value.ToString());
            }

            if (rs.GetDirectoryEntry().Properties["mail"].Value != null)
            {
                textBoxInformation.AppendText("Email :" + rs.GetDirectoryEntry().Properties["mail"].Value.ToString());
            }
        }
        private SearchResult SearchByUserName(DirectorySearcher ds, string username)
        {
            ds.Filter = "(&((objectCategory=Person)(objectClass=User)))(samaccountname=" + username + "))";
            ds.SearchScope = SearchScope.Subtree;
            ds.ServerPageTimeLimit = TimeSpan.FromSeconds(40);
            SearchResult userObject = ds.FindOne();
            if (userObject != null)
                return userObject;
            else
                return null;
        }
        
        public void PrincipalContext()
        {

        }
    }
}
