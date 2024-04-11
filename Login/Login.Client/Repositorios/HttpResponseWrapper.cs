﻿using System.Net;

namespace Login.Client.Repositorios
{
    public class HttpResponseWrapper<T>
    {       
        public bool Error { get; set; }
        public T? Response { get; set; }
        public HttpResponseMessage? HttpResponseMessage { get; set; }

        public HttpResponseWrapper(bool error, T? response, HttpResponseMessage? httpResponseMessage)
        {
            Error = error;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }

        public async Task<string?> ObtenerMensajeError()
        {
            if (!Error)
            {
                return null;
            }

            var statusCode = HttpResponseMessage.StatusCode;

            switch (statusCode)
            {
                case HttpStatusCode.NotFound:
                    return "Recurso no encontrado";
                    break;
                case HttpStatusCode.BadRequest:
                    return await HttpResponseMessage.Content.ReadAsStringAsync();
                    break;
                case HttpStatusCode.Unauthorized:
                    return "Debe estar autenticado";
                    break;
                case HttpStatusCode.Forbidden:
                    return "Debe estar autorizado";
                    break;
                case HttpStatusCode.Conflict:
                    return "El código de registro ya se encuentra almacenado.";
                    break;
                default:
                    return await HttpResponseMessage.Content.ReadAsStringAsync();
                    break;
            }
        }
    }
}
