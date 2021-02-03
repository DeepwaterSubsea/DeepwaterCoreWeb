using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        //  Contractors
        private const string ContractorChevron = "CHEVRON", ContractorDiamond = "DIAMOND", ContractorPacific = "PACIFIC", ContractorSeadril = "SEADRIL", 
            ContractorTransocean = "TRANSOCEAN", ContractorValaris = "VALARIS", ContractorNabors = "NABORS", ContractorNoble = "NOBLE";

        //  OEMs
        private const string OEMHydril = "HYDRIL", OEMCameron = "CAMERON", OEMNOV = "NOV";

        //  Operators
        private const string OperatorAnadarko = "ANADARKO", OperatorBeachEnergy = "BEACH ENERGY", OperatorBeacon = "BEACON", OperatorBHP = "BHP", OperatorBP = "BP", 
            OperatorChevron = "CHEVRON", OperatorEnven = "ENVEN", OperatorEquinor = "EQUINOR", OperatorExxon = "EXXON", OperatorHess = "HESS", 
            OperatorKosmos = "KOSMOS", OperatorLLog = "LLOG", OperatorMurphy = "MURPHY", OperatorOxy = "OXY", OperatorPetroBras = "PETROBRAS", 
            OperatorWoodside = "WOODSIDE", OperatorTotal = "TOTAL", OperatorTalos = "TALOS", OperatorShell = "SHELL";

        //  Rigs
        private const string Rig8503 = "8503", RigBigFoot = "Bigfoot", RigBlackHawk = "BlackHawk", RigBlackHornet = "BlackHornet", RigBlackLion = "BlackLion", RigBlackRhino = "BlackRhino", 
            RigDeepwaterAsgard = "Deepwater Asgard", RigDeepwaterConqueror = "Deepwater Conqueror", RigDeepwaterInvictus = "Deepwater Invictus", RigDiscoverInspiration = "Discover Inspiration",
            RigOceanApex = "Ocean Apex", RigOceanCourage = "Ocean Courage", RigOceanOnyx = "Ocean Onyx", RigOceanValiant = "Ocean Valiant", RigOceanValor = "Ocean Valor",
            RigPacificKhamsin = "Pacic Khamsin", RigPacificSharav = "Pacific Sharav", RigDS15 = "Valaris DS-15 (Renaissance)", RigDS18 = "Valaris DS-18 (Relentless)",
            RigWestCapricorn = "West Capricorn", RigWestNeptune = "West Neptune", RigMODs201 = "MODS 201", RigDonTaylor = "Don Taylor", RigTomMadden = "Tom Madden", RigSamCroft = "Sam Croft";

        //  Status Information
        private const string StatusPlanned = "Planned", StatusActive = "Active", StatusFinished = "Finished";

        public static async Task SeedData(DataContext context)
        {
            if (!context.RigOEMs.Any())
            {
                var rigOEMs = new List<RigOriginalEquipmentManufacturer>()
                {
                    new RigOriginalEquipmentManufacturer
                    {
                        Name = OEMHydril
                    },
                    new RigOriginalEquipmentManufacturer
                    {
                        Name = OEMCameron
                    },
                    new RigOriginalEquipmentManufacturer
                    {
                        Name = OEMNOV
                    }
                };

                await context.RigOEMs.AddRangeAsync(rigOEMs);
                await context.SaveChangesAsync();

            }

            if (!context.RigContractors.Any())
            {
                var rigContractors = new List<RigContractor>()
                {
                    new RigContractor
                    {
                        Name = ContractorChevron
                    },
                    new RigContractor
                    {
                        Name = ContractorDiamond
                    },
                    new RigContractor
                    {
                        Name = ContractorPacific
                    },
                    new RigContractor
                    {
                        Name = ContractorSeadril
                    },
                    new RigContractor
                    {
                        Name = ContractorTransocean
                    },
                    new RigContractor
                    {
                        Name = ContractorValaris
                    },
                    new RigContractor
                    {
                        Name = ContractorNabors
                    },
                    new RigContractor
                    {
                        Name = ContractorNoble
                    }
                };

                await context.RigContractors.AddRangeAsync(rigContractors);
                await context.SaveChangesAsync();
            }

            if (!context.RigOperators.Any())
            {
                var rigOperators = new List<RigOperator>()
                {
                    new RigOperator
                    {
                        Name = OperatorAnadarko
                    },
                    new RigOperator
                    {
                        Name = OperatorBeachEnergy
                    },
                    new RigOperator
                    {
                        Name = OperatorBeacon
                    },
                    new RigOperator
                    {
                        Name = OperatorAnadarko
                    },
                    new RigOperator
                    {
                        Name = OperatorBHP
                    },
                    new RigOperator
                    {
                        Name = OperatorBP
                    },
                    new RigOperator
                    {
                        Name = OperatorChevron
                    },

                    new RigOperator
                    {
                        Name = OperatorEnven
                    },
                    new RigOperator
                    {
                        Name = OperatorEquinor
                    },
                    new RigOperator
                    {
                        Name = OperatorExxon
                    },
                    new RigOperator
                    {
                        Name = OperatorHess
                    },
                    new RigOperator
                    {
                        Name = OperatorKosmos
                    },
                    new RigOperator
                    {
                        Name = OperatorLLog
                    },
                    new RigOperator
                    {
                        Name = OperatorMurphy
                    },
                    new RigOperator
                    {
                        Name = OperatorOxy
                    },
                    new RigOperator
                    {
                        Name = OperatorPetroBras
                    },
                    new RigOperator
                    {
                        Name = OperatorWoodside
                    },
                    new RigOperator
                    {
                        Name = OperatorTotal
                    },
                    new RigOperator
                    {
                        Name = OperatorTalos
                    },
                    new RigOperator
                    {
                        Name = OperatorShell
                    },

                };

                await context.RigOperators.AddRangeAsync(rigOperators);
                await context.SaveChangesAsync();
            }

            if (!context.Rigs.Any())
            {
                var rigs = new List<Rig>()
                {
                    new Rig
                    {
                        Name = Rig8503,
                        RigPrefix = "8503",
                        shipBSEEId = "50541",
                        shipId = "754431",
                        shipMMSI = "636014004",
                        shipIMO = "8770027",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorValaris)).Id
                    },
                    new Rig
                    {
                        Name = RigBigFoot,
                        RigPrefix = "BGFT",
                        shipBSEEId = "100056",
                        shipId = "1189288",
                        shipMMSI = "367550980",
                        shipIMO = "0",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorChevron)).Id
                    },
                    new Rig
                    {
                        Name = RigBlackHawk,
                        RigPrefix = "HAWK",
                        shipBSEEId = "51501",
                        shipId = "714182",
                        shipMMSI = "538005061",
                        shipIMO = "9618898",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorDiamond)).Id
                    },
                    new Rig
                    {
                        Name = RigBlackHornet,
                        RigPrefix = "HORN",
                        shipBSEEId = "51500",
                        shipId = "714407",
                        shipMMSI = "538005314",
                        shipIMO = "9618903",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorDiamond)).Id
                    },
                    new Rig
                    {
                        Name = RigBlackLion,
                        RigPrefix = "LION",
                        shipBSEEId = "51525",
                        shipId = "991567",
                        shipMMSI = "538005361",
                        shipIMO = "9662631",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorDiamond)).Id
                    },
                    new Rig
                    {
                        Name = RigBlackRhino,
                        RigPrefix = "RHNO",
                        shipBSEEId = "28805",
                        shipId = "1270003",
                        shipMMSI = "538005360",
                        shipIMO = "9629641",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorDiamond)).Id
                    },
                    new Rig
                    {
                        Name = RigDeepwaterAsgard,
                        RigPrefix = "DGD",
                        shipBSEEId = "51292",
                        shipId = "713786",
                        shipMMSI = "538004609",
                        shipIMO = "9620580",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorTransocean)).Id
                    },
                    new Rig
                    {
                        Name = RigDeepwaterConqueror,
                        RigPrefix = "DCQ",
                        shipBSEEId = "100053",
                        shipId = "4028173",
                        shipMMSI = "538005579",
                        shipIMO = "9730804",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorTransocean)).Id
                    },
                    new Rig
                    {
                        Name = RigDeepwaterInvictus,
                        RigPrefix = "DVS",
                        shipBSEEId = "51290",
                        shipId = "713787",
                        shipMMSI = "538004610",
                        shipIMO = "9620592",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorTransocean)).Id
                    },
                    new Rig
                    {
                        Name = RigDiscoverInspiration,
                        RigPrefix = "DIN",
                        shipBSEEId = "50279",
                        shipId = "712241",
                        shipMMSI = "538002878",
                        shipIMO = "9409936",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorTransocean)).Id
                    },
                    new Rig
                    {
                        Name = RigOceanApex,
                        RigPrefix = "APEX",
                        shipBSEEId = "",
                        shipId = "1534406",
                        shipMMSI = "538001747",
                        shipIMO = "8753005",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorDiamond)).Id
                    },
                    new Rig
                    {
                        Name = RigOceanCourage,
                        RigPrefix = "CRG",
                        shipBSEEId = "",
                        shipId = "712882",
                        shipMMSI = "538003627",
                        shipIMO = "8768531",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorDiamond)).Id
                    },
                    new Rig
                    {
                        Name = RigOceanOnyx,
                        RigPrefix = "ONYX",
                        shipBSEEId = "28550",
                        shipId = "711516",
                        shipMMSI = "538001765",
                        shipIMO = "8753366",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorDiamond)).Id
                    },
                    new Rig
                    {
                        Name = RigOceanValiant,
                        RigPrefix = "VLNT",
                        shipBSEEId = "28547",
                        shipId = "711515",
                        shipMMSI = "538001763",
                        shipIMO = "8753330",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorDiamond)).Id
                    },
                    new Rig
                    {
                        Name = RigOceanValor,
                        RigPrefix = "VLR",
                        shipBSEEId = "",
                        shipId = "712982",
                        shipMMSI = "538003741",
                        shipIMO = "8769470",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorDiamond)).Id
                    },
                    new Rig
                    {
                        Name = RigPacificKhamsin,
                        RigPrefix = "PKN",
                        shipBSEEId = "51095",
                        shipId = "755841",
                        shipMMSI = "636015856",
                        shipIMO = "9623324",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorPacific)).Id
                    },
                    new Rig
                    {
                        Name = RigPacificSharav,
                        RigPrefix = "PSV",
                        shipBSEEId = "51090",
                        shipId = "755971",
                        shipMMSI = "636016002",
                        shipIMO = "9623336",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorPacific)).Id
                    },
                    new Rig
                    {
                        Name = RigDS15,
                        RigPrefix = "RNS",
                        shipBSEEId = "100052",
                        shipId = "713819",
                        shipMMSI = "538004643",
                        shipIMO = "9630066",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorValaris)).Id
                    },
                    new Rig
                    {
                        Name = RigDS18,
                        RigPrefix = "RLT",
                        shipBSEEId = "100036",
                        shipId = "992095",
                        shipMMSI = "538005035",
                        shipIMO = "9672961",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorValaris)).Id
                    },
                    new Rig
                    {
                        Name = RigWestCapricorn,
                        RigPrefix = "CAP",
                        shipBSEEId = "51181",
                        shipId = "410249",
                        shipMMSI = "352683000",
                        shipIMO = "8770821",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorSeadril)).Id
                    },
                    new Rig
                    {
                        Name = RigWestNeptune,
                        RigPrefix = "NEP",
                        shipBSEEId = "100035",
                        shipId = "5989871",
                        shipMMSI = "371765000",
                        shipIMO = "9655028",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorSeadril)).Id
                    },
                    new Rig
                    {
                        Name = RigMODs201,
                        RigPrefix = "M201",
                        shipBSEEId = "47916",
                        shipId = "0",
                        shipMMSI = "0",
                        shipIMO = "0",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorNabors)).Id
                    },
                    new Rig
                    {
                        Name = RigDonTaylor,
                        RigPrefix = "NDT",
                        shipBSEEId = "92600",
                        shipId = "0",
                        shipMMSI = "0",
                        shipIMO = "0",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorNoble)).Id
                    },
                    new Rig
                    {
                        Name = RigTomMadden,
                        RigPrefix = "NTM",
                        shipBSEEId = "100034",
                        shipId = "0",
                        shipMMSI = "0",
                        shipIMO = "0",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorNoble)).Id
                    },
                    new Rig
                    {
                        Name = RigSamCroft,
                        RigPrefix = "NSC",
                        shipBSEEId = "92610",
                        shipId = "0",
                        shipMMSI = "0",
                        shipIMO = "0",
                        ContractorId = context.RigContractors.SingleOrDefault(r => r.Name.Equals(ContractorNoble)).Id
                    }

                };

                await context.Rigs.AddRangeAsync(rigs);
                await context.SaveChangesAsync();
            }

            if (!context.RigAssets.Any())
            {
                var rigAssets = new List<RigAsset>()
                {
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(Rig8503)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(Rig8503)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "112487025-01",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBigFoot)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "112487026-01",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBigFoot)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBlackHawk)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBlackHawk)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBlackHawk)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBlackHawk)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBlackHornet)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBlackHornet)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBlackHornet)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBlackHornet)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBlackLion)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBlackLion)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBlackLion)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBlackLion)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBlackRhino)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBlackRhino)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBlackRhino)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigBlackRhino)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "11706055-1",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDeepwaterAsgard)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDeepwaterAsgard)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "112717427-01",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDeepwaterAsgard)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDeepwaterAsgard)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "120605417-01",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDeepwaterConqueror)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "120605422-01",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDeepwaterConqueror)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "120605467-01",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDeepwaterConqueror)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "120605469-01",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDeepwaterConqueror)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDeepwaterInvictus)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDeepwaterInvictus)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDeepwaterInvictus)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDeepwaterInvictus)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "153956",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDiscoverInspiration)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "153854",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDiscoverInspiration)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "153955",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDiscoverInspiration)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "154529",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDiscoverInspiration)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanApex)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanApex)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanApex)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanApex)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanCourage)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanCourage)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanCourage)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanCourage)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanOnyx)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanOnyx)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanOnyx)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanOnyx)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanValiant)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanValiant)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanValiant)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMHydril)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanValiant)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanValor)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanValor)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanValor)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigOceanValor)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigPacificKhamsin)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigPacificKhamsin)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigPacificKhamsin)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigPacificKhamsin)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "20095027-1",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigPacificSharav)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "10745517-1",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigPacificSharav)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "20095026-1",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigPacificSharav)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "10755900-1",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigPacificSharav)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "112807669-01",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDS15)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDS15)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "112786873-01",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDS15)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDS15)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDS18)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDS18)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDS18)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDS18)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigWestCapricorn)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigWestCapricorn)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigWestCapricorn)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMCameron)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigWestCapricorn)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigWestNeptune)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigWestNeptune)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigWestNeptune)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigWestNeptune)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDonTaylor)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDonTaylor)).Id
                    },
                                        new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDonTaylor)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigDonTaylor)).Id
                    },
                                     new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigTomMadden)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigTomMadden)).Id
                    },
                                        new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigTomMadden)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigTomMadden)).Id
                    },
                                     new RigAsset
                    {
                        Name = "LMRP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigSamCroft)).Id
                    },
                    new RigAsset
                    {
                        Name = "LMRP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigSamCroft)).Id
                    },
                                        new RigAsset
                    {
                        Name = "BOP 1",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigSamCroft)).Id
                    },
                    new RigAsset
                    {
                        Name = "BOP 2",
                        SerialNumber = "",
                        OEMId = context.RigOEMs.SingleOrDefault(r => r.Name.Equals(OEMNOV)).Id,
                        RigId = context.Rigs.SingleOrDefault(r => r.Name.Equals(RigSamCroft)).Id
                    }
                };

                await context.RigAssets.AddRangeAsync(rigAssets);
                await context.SaveChangesAsync();
            }

            if (!context.StatusInformation.Any())
            {
                var statusInformation = new List<StatusInformation>()
                {
                    new StatusInformation
                    {
                        Name = StatusPlanned,
                        Type = "W"
                    },
                    new StatusInformation
                    {
                        Name = StatusActive,
                        Type = "W"
                    },
                    new StatusInformation
                    {
                        Name = StatusFinished,
                        Type = "W"
                    }
                };

                await context.StatusInformation.AddRangeAsync(statusInformation);
                await context.SaveChangesAsync();
            }

            if (!context.Wells.Any())
            {
                var wells = new List<Well>()
                {
                    new Well
                    {
                        Name = "Shipyard",
                        Location = "Shipyard",
                        Depth = 0,
                        Latitude = 30.34444444,
                        Longitude = -88.51916667,
                        Status = context.StatusInformation.SingleOrDefault(s=>s.Name.Equals(StatusFinished) && s.Type.Equals("W"))
                    }
                };

                await context.AddRangeAsync(wells);
                await context.SaveChangesAsync();
            }

            if (!context.RigWellOperatorRecords.Any())
            {
                var rigWellOperatorRecords = new List<RigWellOperatorRecord>()
                {
                    new RigWellOperatorRecord
                    {
                        BOP = "BOP 1",
                        LMRP = "LMRP 1",
                        LatchDate = new DateTime(2018,08,07),
                        UnlatchDate = new DateTime(2018,12,01),
                        RigId = context.Rigs.SingleOrDefault(r=>r.Name.Equals(RigBlackHornet)).Id,
                        WellId = context.Wells.SingleOrDefault(w=>w.Latitude.Equals(30.34444444) && w.Longitude.Equals(-88.51916667)).Id,
                        OperatorId = context.RigOperators.SingleOrDefault((o=>o.Name.Equals(OperatorBP))).Id
                    }
                };

                await context.RigWellOperatorRecords.AddRangeAsync(rigWellOperatorRecords);
                await context.SaveChangesAsync();
            }
        }
    }
}