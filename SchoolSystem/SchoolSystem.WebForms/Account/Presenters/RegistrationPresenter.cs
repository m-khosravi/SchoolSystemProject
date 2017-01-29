﻿using SchoolSystem.WebForms.Account.Views;
using WebFormsMvp;
using SchoolSystem.WebForms.Account.Views.EventArguments;
using SchoolSystem.WebForms.Identity;
using Microsoft.AspNet.Identity.Owin;
using SchoolSystem.Data.Models;
using Microsoft.AspNet.Identity;
using SchoolSystem.Web.Services.Contracts;
using System;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace SchoolSystem.WebForms.Account.Presenters
{
    public class RegistrationPresenter : Presenter<IRegisterView>
    {
        private readonly IUserRolesDataService service;

        public RegistrationPresenter(IRegisterView view, IUserRolesDataService service)
            : base(view)
        {
            if (service == null)
            {
                throw new ArgumentNullException("service");
            }

            this.service = service;

            this.View.EventRegisterUser += RegisterUser;
            this.View.EventBindUserRoles += BindUserRoles;
        }

        private void BindUserRoles(object sender, EventArgs e)
        {
            this.View.Model.UserRoles = this.service.GetAllUserRoles();
        }

        private void RegisterUser(object sender, RegistrationPageEventArgs e)
        {
            var manager = e.OwinCtx.GetUserManager<ApplicationUserManager>();

            var user = new User()
            {
                Email = e.Email,
                UserName = e.Email,
                FirstName = e.FirstName,
                LastName = e.LastName
            };

            IdentityResult result = manager.Create(user, e.Password);
            manager.AddToRole(user.Id, e.UserType);
            ////////////////////
            this.View.Model.Result = result;
        }

    }
}