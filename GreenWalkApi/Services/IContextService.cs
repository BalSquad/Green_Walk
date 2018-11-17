using GreenWalkApi.Models;

namespace GreenWalkApi.Services
{

    public interface IContextService
    {
        GreenWalkContext Context { get; }
    }

}
