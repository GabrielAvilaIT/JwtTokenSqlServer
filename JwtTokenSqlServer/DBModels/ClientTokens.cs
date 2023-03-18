using System;
using System.Collections.Generic;

namespace JwtTokenSqlServer.DBModels;

public class ClientTokens
{
    public string? ClientId { get; set; }

    public string Secret{ get; set; } = null!;

}