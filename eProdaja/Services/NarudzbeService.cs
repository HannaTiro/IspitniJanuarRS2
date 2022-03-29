using AutoMapper;
using eProdaja.Database;
using eProdaja.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class NarudzbeService:INarudzbeService
    {
        public eProdajaContext  _context  { get; set; }
        protected readonly IMapper _mapper;
        public NarudzbeService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IList<Model.Narudzbe> GetAll(NarudzbeSearchRequest search)
        {
            var request = _context.Narudzbes.Include(x=>x.Kupac).Include(x=>x.Izlazis).Include(x=>x.NarudzbaStavkes).AsQueryable();
            if(search?.ProizvodId!=null)
            {
                request = request.Where(x => x.NarudzbaStavkes.Count(x => x.ProizvodId == search.ProizvodId) > 0);
            }
            if(search?.DatumOD!=null)
            {
                request = request.Where(x => x.Datum >= search.DatumOD);
            }
            if (search?.DatumDO != null)
            {
                request = request.Where(x => x.Datum <= search.DatumDO);
            }
            if(search?.MinimalniIznosNarudzbe!=null)
            {
                request = request.Where(x => x.Izlazis.Sum(y => y.IznosSaPdv) >= search.MinimalniIznosNarudzbe);
            }
            var podaci = request.ToList();
            return _mapper.Map<IList<Model.Narudzbe>>(podaci);
        }
    }
}
