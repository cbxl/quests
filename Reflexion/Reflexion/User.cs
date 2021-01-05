using System;
using System.Collections.Generic;
using System.Text;

namespace Reflexion
{
    public class User
    {        
            private String _lastName { get; set; }
            private String _phoneNumber { get; set; }
            public String pseudo { get; set; }

            public User()
            {
                _lastName = String.Empty;
                _phoneNumber = String.Empty;
                pseudo = "pseudo001";
            }
        
    }
}
