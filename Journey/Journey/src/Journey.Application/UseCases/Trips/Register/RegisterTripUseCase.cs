using Journey.Communication.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey.Application.UseCases.Trips.Register
{
    public class RegisterTripUseCase
    {
        public void Execute (RequestRegisterTripJson request)
        {
        }

        //Função auxiliar
        private void Validate(RequestRegisterTripJson request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
               throw new ArgumentException("Nome não pode ser vazio.");

            if (request.StartDate < DateTime.UtcNow.Date)
               throw new ArgumentException("A viagem não pode ser registrada para uma data passada.");           

            if (request.EndDate < request.StartDate.Date)
               throw new ArgumentException("A viagem deve terminar após a data de início.");            
        }
        //43:41
    }
}
