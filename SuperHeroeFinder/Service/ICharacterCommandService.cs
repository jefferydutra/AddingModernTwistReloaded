using System;
using System.Threading.Tasks;
using SuperHeroeFinder.Service.Messages;

namespace SuperHeroeFinder.Service
{
    public interface ICharacterCommandService
    {
        Task<UpdateCharacterResponse> Update(UpdateCharacterRequest request);
        Task<AddCharacterResponse> Add(AddCharacterRequest request);
        Task Remove(RemoveCharacterRequest request);
    }
}