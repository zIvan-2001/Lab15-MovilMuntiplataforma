﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace TodoREST
{
    public interface IHttpClientHandlerService
    {
        HttpClientHandler GetInsecureHandler();
    }
}
