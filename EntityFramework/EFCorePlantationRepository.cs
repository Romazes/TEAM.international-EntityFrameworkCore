using EntityFramework.Abstract;
using EntityFramework.Context;
using Model;

namespace EntityFramework
{
    public class EFCorePlantationRepository : Repository<Plantation, FlowerDeliveryContext>
    {
        public EFCorePlantationRepository(FlowerDeliveryContext context) : base(context)
        {}
    }
}
