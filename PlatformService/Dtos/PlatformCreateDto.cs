using System.ComponentModel.DataAnnotations;

namespace PlatformService.Dtos
{
    public record PlatformCreateDto(
        [param: Required] string Name, 
        [param: Required] string Publisher, 
        [param: Required] string Cost);
}