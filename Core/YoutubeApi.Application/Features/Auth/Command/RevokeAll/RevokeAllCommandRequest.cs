using MediatR;

namespace YoutubeApi.Api.Controllers
{
    public class RevokeAllCommandRequest : IRequest<Unit>
    {
    }
}