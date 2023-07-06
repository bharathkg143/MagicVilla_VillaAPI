using Microsoft.AspNetCore.JsonPatch;
using Project_MagicVilla_API.Models;

namespace Project_MagicVilla_API.Repository
{
    public interface IVillaRepository
    {
        IEnumerable<Villa> GetVillas();
        Villa GetVilla(int id);
        void CreateVilla(Villa villa);
        Villa UpdateVilla(Villa villa);
        int DeleteVilla(int id, Villa villa);
        Villa PatchUpdateVilla(JsonPatchDocument<Villa> patchVilla, Villa villa);
    }
}
