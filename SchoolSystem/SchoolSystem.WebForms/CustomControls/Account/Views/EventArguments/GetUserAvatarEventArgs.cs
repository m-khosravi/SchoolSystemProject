﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolSystem.WebForms.CustomControls.Account.Views.EventArguments
{
    public class GetUserAvatarEventArgs : EventArgs
    {
        public string LoggedUseUserName { get; set; }
    }
}