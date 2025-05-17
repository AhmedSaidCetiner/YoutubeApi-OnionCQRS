using MediatR;
using System.ComponentModel;

namespace YoutubeApi.Application.Features.Auth.Command.Login
{
    public class LoginCommandRequest : IRequest<LoginCommandResponse>
    {
        [DefaultValue("acetiner@gmail.com")]
        public string Email { get; set; }
        [DefaultValue("03421192")]
        public string Password { get; set; }
    }
}
