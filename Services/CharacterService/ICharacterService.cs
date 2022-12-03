using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_udemy.Dtos.Character;

namespace dotnet_udemy.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(AddCharacterDto newCharacter);
    }
}