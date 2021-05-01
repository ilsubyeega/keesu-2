// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace osu.Game.Online
{
    public class DevelopmentEndpointConfiguration : EndpointConfiguration
    {
        public DevelopmentEndpointConfiguration()
        {
            WebsiteRootUrl = APIEndpointUrl = @"https://dev.keesu.512.kr";
            APIClientSecret = @"3LP2mhUrV89xxzD1YKNndXHEhWWCRLPNKioZ9ymT";
            APIClientID = "3";
            SpectatorEndpointUrl = "https://dev.keesu.512.kr/api/realtime/spectator";
            MultiplayerEndpointUrl = "https://dev.keesu.512.kr/api/realtime/multiplayer";
        }
    }
}
