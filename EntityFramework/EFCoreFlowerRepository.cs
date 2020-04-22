using EntityFramework.Abstract;
using EntityFramework.Context;
using Model;

namespace EntityFramework
{
    public class EFCoreFlowerRepository : Repository<Flower, FlowerDeliveryContext>
    {
        public EFCoreFlowerRepository(FlowerDeliveryContext context) : base(context)
        {}
    }
}
