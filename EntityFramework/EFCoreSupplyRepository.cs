using EntityFramework.Abstract;
using EntityFramework.Context;
using Model;

namespace EntityFramework
{
    public class EFCoreSupplyRepository : Repository<Supply, FlowerDeliveryContext>
    {
        public EFCoreSupplyRepository(FlowerDeliveryContext context) : base(context)
        {}
    }
}
