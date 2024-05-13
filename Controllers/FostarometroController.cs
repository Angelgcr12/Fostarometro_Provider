using FostarometroAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FostarometroAPI.Controllers
{
    public class FostarometroController : ControllerBase
    {
        private readonly IFostarometroServices _fostarometroServices;
        public FostarometroController(IFostarometroServices fostarometroServices)
        {
            _fostarometroServices = fostarometroServices;            
        }
    }
}