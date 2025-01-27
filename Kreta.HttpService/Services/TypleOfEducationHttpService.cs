using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.HttpService.Services
{
    public class TypleOfEducationHttpService : BaseService<TypeOfEducation, TypeOfEducationDto>, ITypeOfEducationHttpService
    {
        public TypleOfEducationHttpService(IHttpClientFactory? httpClientFactory, TypeOfEducationAssambler assambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
