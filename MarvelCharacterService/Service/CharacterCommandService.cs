using System;
using System.Data.Entity;
using System.Threading.Tasks;
using MarvelCharacterService.Models;
using MarvelCharacterService.Service.Messages;

namespace MarvelCharacterService.Service
{
    public class CharacterCommandService : ICharacterCommandService, IDisposable
    {
        private readonly SuperHeroContext _db = new SuperHeroContext();

        public async Task<UpdateCharacterResponse> Update(UpdateCharacterRequest request)
        {
            var character = await _db.Characters.FindAsync(request.Id);
            var characterType = await _db.CharacterTypes.FindAsync(request.CharacterTypeId);
            character.Name = request.Name;
            character.NumberOfComics = request.NumberOfComics;
            character.NumberOfSeries = request.NumberOfSeries;
            character.ProfilePage = request.ProfilePage;
            character.CharacterType = characterType;

            _db.Entry(character).State = EntityState.Modified;

            await _db.SaveChangesAsync();

            return new UpdateCharacterResponse {Success = true};
        }

        public async Task<AddCharacterResponse> Add(AddCharacterRequest request)
        {
            var characterType = await _db.CharacterTypes.FindAsync(request.CharacterTypeId);
            var character = new Character
            {
                Name = request.Name,
                NumberOfComics = request.NumberOfComics,
                NumberOfSeries = request.NumberOfSeries,
                ProfilePage = request.ProfilePage,
                CharacterType = characterType
            };
            _db.Characters.Add(character);
            await _db.SaveChangesAsync();

            return new AddCharacterResponse
            {
                Success = true,
                Character = new CharacterDto {Id = character.Id}
            };
        }

        public async Task Remove(RemoveCharacterRequest request)
        {
            var character = await _db.Characters.FindAsync(request.Id);
            _db.Characters.Remove(character);
            await _db.SaveChangesAsync();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}