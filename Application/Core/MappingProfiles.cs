using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<RigAsset, RigAsset>();
            CreateMap<RigContractor, RigContractor>();
            CreateMap<RigOriginalEquipmentManufacturer, RigOriginalEquipmentManufacturer>();
            CreateMap<RigOperator, RigOperator>();
            CreateMap<Rig, Rig>();
            CreateMap<RigWellOperatorRecord, RigWellOperatorRecord>();
            CreateMap<StatusInformation, StatusInformation>();
            CreateMap<Well, Well>();
        }
    }
}