using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using MarvelCharacterService.Service;
using SuperHeroeFinder.Controllers;

namespace SuperHeroeFinder.DependencyInjection
{
    public class PoorMansCompositionRoot: IHttpControllerActivator
    {
        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {

            if (controllerType == typeof(CharacterController))
                return new CharacterController(new CharacterQueryService());



            if (controllerType == typeof(CharacterCommandController))
                return new CharacterCommandController(new CharacterCommandService());

            //if (controllerType == typeof(CharacterTypesController))
            //    return new CharacterController(new CharacterQueryService());

            return null;
        }
    }
}