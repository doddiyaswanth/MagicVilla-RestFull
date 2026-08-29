using MagicVilla_VillaAPI.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static  class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto{Id=1,Name="pool view" ,Sqft=500,Occupancy=4},
            new VillaDto{Id=2,Name="beach view",Sqft=600,Occupancy=6},
            new VillaDto{Id=3,Name="mountain view",Sqft=700,Occupancy=8 },
        };


    }
}
