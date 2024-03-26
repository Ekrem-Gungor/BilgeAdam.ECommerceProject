using Project.BLL.Managers.Abstracts;
using Project.DAL.Repository.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Managers.Concretes
{
    public class ShipperManager : BaseManager<Shipper>, IShipperManager
    {
        readonly IShipperRepository _shipRep;
        public ShipperManager(IShipperRepository shipRep) : base(shipRep)
        {
            _shipRep = shipRep;
        }
    }
}
