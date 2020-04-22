using EntityFramework.Abstract;
using EntityFramework.Context;
using Model;

namespace EntityFramework
{
    public class EFCoreWarehouseRepository : Repository<Warehouse, FlowerDeliveryContext>
    {
        public EFCoreWarehouseRepository(FlowerDeliveryContext context) : base(context)
        {}
    }
}
