using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework;
using FlowerDelivery.Controllers.EFCoreBaseController;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace FlowerDelivery.Controllers
{
    public class FlowerController : EFCoreBaseController<Flower, EFCoreFlowerRepository>
    {
        public FlowerController(EFCoreFlowerRepository repository) : base(repository)
        {}
    }
}