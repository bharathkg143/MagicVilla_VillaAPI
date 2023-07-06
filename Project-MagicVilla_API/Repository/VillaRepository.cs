using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using Project_MagicVilla_API.Context;
using Project_MagicVilla_API.Models;

namespace Project_MagicVilla_API.Repository
{
    public class VillaRepository : IVillaRepository
    {
        private readonly ApplicationDbContext _context;
        public VillaRepository(ApplicationDbContext context)
        {
            _context=context;
        }
        public void CreateVilla(Villa villa)
        {
            _context.Villas.Add(villa);
            _context.SaveChanges();
        }

        public int DeleteVilla(int id,Villa villa)
        {
            
             _context.Villas.Remove(villa);
             _context.SaveChanges();
            
            return 1;
        }

        public Villa GetVilla(int id)
        {
            Villa? villa = _context.Villas.FirstOrDefault(x => x.Id == id);
            return villa;
        }

        public IEnumerable<Villa> GetVillas()
        {
            return _context.Villas;
        }

        public Villa PatchUpdateVilla(JsonPatchDocument<Villa> patchVilla,Villa villa)
        {
            patchVilla.ApplyTo(villa);

            return villa;
        }

        public Villa UpdateVilla(Villa villa)
        {
            _context.Villas.Update(villa);
            _context.SaveChanges();

            return villa;
        }
    }
}
