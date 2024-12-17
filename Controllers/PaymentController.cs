using ChainOfResponsibilityPattern.Abstracts;
using ChainOfResponsibilityPattern.Handlers;
using ChainOfResponsibilityPattern.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChainOfResponsibilityPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IHandler _bankAdapterConrolHandler;
        private readonly IHandler  _commissionControlHandler;
        private readonly IHandler _dealerControlHandler;
        private readonly IHandler _paymentControlHandler;

        public PaymentController([FromKeyedServices("bankAdapterConrolHandler")]IHandler bankAdapterConrolHandler,
            [FromKeyedServices("commissionControlHandler")]IHandler commissionControlHandler, 
            [FromKeyedServices("dealerControlHandler")]IHandler dealerControlHandler, 
            [FromKeyedServices("paymentControlHandler")]IHandler paymentControlHandler)
        {
            _bankAdapterConrolHandler = bankAdapterConrolHandler;
            _commissionControlHandler = commissionControlHandler;
            _dealerControlHandler = dealerControlHandler;
            _paymentControlHandler = paymentControlHandler;
        }

        [HttpPost]
        public IActionResult Payment([FromBody] TransactionModel model)
        {
            //Sırasıyla business flowu belirledik.
            _dealerControlHandler
                .SetNext(_commissionControlHandler)
                .SetNext(_bankAdapterConrolHandler)
                .SetNext(_paymentControlHandler);
            //Flowu tetikledik.
            var returnValue = _dealerControlHandler.Handle(model);
            return Ok(returnValue);
        }
    }
}
