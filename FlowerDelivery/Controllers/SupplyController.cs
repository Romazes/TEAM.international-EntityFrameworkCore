using EntityFramework;
using FlowerDelivery.Controllers.EFCoreBaseController;
using Model;

namespace FlowerDelivery.Controllers
{
    public class SupplyController : EFCoreBaseController<Supply, EFCoreSupplyRepository>
    {
        public SupplyController(EFCoreSupplyRepository repository) : base(repository)
        {}
    }
}