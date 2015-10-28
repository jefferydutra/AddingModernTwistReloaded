using System;
using System.Threading.Tasks;
using MarvelCharacterService.Service.Messages;

namespace MarvelCharacterService.Service
{
    public interface ICharacterCommandService
    {
        Task<UpdateCharacterResponse> Update(UpdateCharacterRequest request);
        Task<AddCharacterResponse> Add(AddCharacterRequest request);
        Task Remove(RemoveCharacterRequest request);
    }
}