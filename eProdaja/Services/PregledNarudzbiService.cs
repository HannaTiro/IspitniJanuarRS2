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
    public class PregledNarudzbiService:IPregledNarudzbiService
    {
        public eProdajaContext  _context { get; set; }
        protected readonly IMapper _mapper;
        public PregledNarudzbiService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IList<Model.PregledNarudzbi> GetAll(PregledNarudzbiSearchRequest search)
        {
            var request = _context.PregledNarudzbi.AsQueryable();
            if(search?.KupacId!=null)
            {
                request = request.Where(x => x.KupacId == search.KupacId);
            }
            var lista = request.Include(x => x.Kupac).ToList();
            var podaci = _mapper.Map<IList<Model.PregledNarudzbi>>(lista);
            foreach (var item in podaci)
            {
                item.ProsjecniPromet = _context.PregledNarudzbi.Where(x => x.KupacId == search.KupacId).Average(y => (decimal?)y.IznosNarudzbe) ?? 0;
            }

            return podaci;
        }

        public Model.PregledNarudzbi Insert(PregledNarudzbiInsertRequest request)
        {
            var query = _mapper.Map<List<Database.PregledNarudzbi>>(request);
            _context.Add(query);
            _context.SaveChanges();
            return _mapper.Map<Model.PregledNarudzbi>(query);
        }
    }
}
