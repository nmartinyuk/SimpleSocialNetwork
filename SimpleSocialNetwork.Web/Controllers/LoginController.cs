﻿using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ninject;
using SimpleSocialNetwork.App_Code;
using SimpleSocialNetwork.Dto;
using SimpleSocialNetwork.Service.ModelProfileService;

namespace SimpleSocialNetwork.Controllers
{
    public class LoginController : ApiController
    {
        private readonly IModelProfileService modelProfileService;

        public LoginController()
        {
            var kernel = new StandardKernel(new NinjectRegistrations());
            this.modelProfileService = kernel.Get<IModelProfileService>();
        }

        [HttpPost]
        public DtoProfile Login(DtoProfile profile)
        {
            try
            {
                profile.token = this.modelProfileService.Login(profile.name, profile.password).ToString();
                return profile;
            }
            catch (Exception e)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent(e.Message) });
            }
        }

        [HttpPost]
        public bool IsRegistered(DtoProfile profile)
        {
            return new ModelProfileService().IsRegistered(profile.name, profile.password);
        }

        [HttpPost]
        public bool IsAuthenticated(DtoProfile profile)
        {
            return new ModelProfileService().IsAuthenticated(profile.name, profile.token);
        }
    }
}
