﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFluids
{

    //List of FLuids:
    //http://www.coolprop.org/fluid_properties/PurePseudoPure.html




    public enum FluidList
    {
        [MediaType("HEOS", "AMMONIA")                       ] Ammonia,
        [MediaType("HEOS", "AMMONIA")                       ] R717,
        [MediaType("HEOS", "N-BUTANE")                      ] R600,


        [MediaType("HEOS", "AIR")                           ] Air,
        [MediaType("HEOS", "CARBONDIOXIDE")                 ] CO2,
        [MediaType("HEOS", "1BUTENE")                       ] Butene1,
        [MediaType("HEOS", "ACETONE")                       ] Acetone,
        [MediaType("HEOS", "ARGON")                         ] Argon,
        [MediaType("HEOS", "BENZENE")                       ] Benzene,
        [MediaType("HEOS", "CARBONMONOXIDE")                ] CO,
        [MediaType("HEOS", "CARBONYLSULFIDE")               ] CarbonylSulfide,
        [MediaType("HEOS", "CYCLOHEXANE")                   ] CycloHexane,
        [MediaType("HEOS", "CYCLOPROPANE")                  ] CycloPropane,
        [MediaType("HEOS", "CYCLOPENTANE")                  ] Cyclopentane,
        [MediaType("HEOS", "OCTAMETHYLCYCLOTETRASILOXANE")  ] D4,
        [MediaType("HEOS", "DECAMETHYLCYCLOPENTASILOXANE")  ] D5,
        [MediaType("HEOS", "DODECAMETHYLCYCLOHEXASILOXANE") ] D6,
        [MediaType("HEOS", "DEUTERIUM")                     ] Deuterium,
        [MediaType("HEOS", "DICHLOROETHANE")                ] Dichloroethane,
        [MediaType("HEOS", "DEE")                           ] DiethylEther,
        [MediaType("HEOS", "DIMETHYLCARBONATE")             ] DimethylCarbonate,
        [MediaType("HEOS", "DIMETHYLETHER")                 ] DimethylEther,
        [MediaType("HEOS", "ETHANE")                        ] Ethane,
        [MediaType("HEOS", "ETHANOL")                       ] Ethanol,
        [MediaType("HEOS", "ETHYLBENZENE")                  ] EthylBenzene,
        [MediaType("HEOS", "ETHYLENE")                      ] Ethylene,
        [MediaType("HEOS", "ETHYLENEOXIDE")                 ] EthyleneOxide,
        [MediaType("HEOS", "FLUORINE")                      ] Fluorine,
        [MediaType("HEOS", "RE143A")                        ] HFE143m,
        [MediaType("HEOS", "HEAVYWATER")                    ] HeavyWater,
        [MediaType("HEOS", "HELIUM")                        ] Helium,
        [MediaType("HEOS", "HYDROGEN")                      ] Hydrogen,
        [MediaType("HEOS", "HYDROGENCHLORIDE")              ] HydrogenChloride,
        [MediaType("HEOS", "HYDROGENSULFIDE")               ] HydrogenSulfide,
        [MediaType("HEOS", "ISOBUTANE")                     ] IsoButane,
        [MediaType("HEOS", "ISOBUTENE")                     ] IsoButene,
        [MediaType("HEOS", "ISOHEXANE")                     ] Isohexane,
        [MediaType("HEOS", "ISOPENTANE")                    ] Isopentane,
        [MediaType("HEOS", "KRYPTON")                       ] Krypton,
        [MediaType("HEOS", "DECAMETHYLTETRASILOXANE")       ] MD2M,
        [MediaType("HEOS", "DODECAMETHYLPENTASILOXANE")     ] MD3M,
        [MediaType("HEOS", "TETRADECAMETHYLHEXASILOXANE")   ] MD4M,
        [MediaType("HEOS", "OCTAMETHYLTRISILOXANE")         ] MDM,
        [MediaType("HEOS", "HEXAMETHYLDISILOXANE")          ] MM,
        [MediaType("HEOS", "METHANE")                       ] Methane,
        [MediaType("HEOS", "METHANOL")                      ] Methanol,
        [MediaType("HEOS", "METHYLLINOLEATE")               ] MethylLinoleate,
        [MediaType("HEOS", "METHYLLINOLENATE")              ] MethylLinolenate,
        [MediaType("HEOS", "METHYLOLEATE")                  ] MethylOleate,
        [MediaType("HEOS", "METHYLPALMITATE")               ] MethylPalmitate,
        [MediaType("HEOS", "METHYLSTEARATE")                ] MethylStearate,
        [MediaType("HEOS", "NEON")                          ] Neon,
        [MediaType("HEOS", "NEOPENTANE")                    ] Neopentane,
        [MediaType("HEOS", "NITROGEN")                      ] Nitrogen,
        [MediaType("HEOS", "NITROUSOXIDE")                  ] NitrousOxide,
        [MediaType("HEOS", "NOVEC649")                      ] Novec649,
        [MediaType("HEOS", "ORTHODEUTERIUM")                ] OrthoDeuterium,
        [MediaType("HEOS", "ORTHOHYDROGEN")                 ] OrthoHydrogen,
        [MediaType("HEOS", "OXYGEN")                        ] Oxygen,
        [MediaType("HEOS", "PARADEUTERIUM")                 ] ParaDeuterium,
        [MediaType("HEOS", "PARAHYDROGEN")                  ] ParaHydrogen,
        [MediaType("HEOS", "PROPYLENE")                     ] Propylene,
        [MediaType("HEOS", "PROPYNE")                       ] Propyne,
        [MediaType("HEOS", "R11")                           ] R11,
        [MediaType("HEOS", "R113")                          ] R113,
        [MediaType("HEOS", "R114")                          ] R114,
        [MediaType("HEOS", "R115")                          ] R115,
        [MediaType("HEOS", "R116")                          ] R116,
        [MediaType("HEOS", "R12")                           ] R12,
        [MediaType("HEOS", "R123")                          ] R123,
        [MediaType("HEOS", "R1233ZDE")                      ] R1233zdE,
        [MediaType("HEOS", "R1234YF")                       ] R1234yf,
        [MediaType("HEOS", "R1234ZE")                       ] R1234zeE,
        [MediaType("HEOS", "R1234ZE(Z)")                    ] R1234zeZ,
        [MediaType("HEOS", "R124")                          ] R124,
        [MediaType("HEOS", "R1234ZF")                       ] R1243zf,
        [MediaType("HEOS", "R125")                          ] R125,
        [MediaType("HEOS", "R13")                           ] R13,
        [MediaType("HEOS", "R134A")                         ] R134a,
        [MediaType("HEOS", "R13I1")                         ] R13I1,
        [MediaType("HEOS", "R14")                           ] R14,
        [MediaType("HEOS", "R141B")                         ] R141b,
        [MediaType("HEOS", "R142B")                         ] R142b,
        [MediaType("HEOS", "R143A")                         ] R143a,
        [MediaType("HEOS", "R152A")                         ] R152A,
        [MediaType("HEOS", "R161")                          ] R161,
        [MediaType("HEOS", "R21")                           ] R21,
        [MediaType("HEOS", "R218")                          ] R218,
        [MediaType("HEOS", "R22")                           ] R22,
        [MediaType("HEOS", "R227EA")                        ] R227EA,
        [MediaType("HEOS", "R23")                           ] R23,
        [MediaType("HEOS", "R236EA")                        ] R236EA,
        [MediaType("HEOS", "R236FA")                        ] R236FA,
        [MediaType("HEOS", "R245ca")                        ] R245ca,
        [MediaType("HEOS", "R245fa")                        ] R245fa,
        [MediaType("HEOS", "R32")                           ] R32,
        [MediaType("HEOS", "R365MFC")                       ] R365MFC,
        [MediaType("HEOS", "MethylChloride")                ] R40,
        [MediaType("HEOS", "R404A")                         ] R404A,
        [MediaType("HEOS", "R407C")                         ] R407C,
        [MediaType("HEOS", "R41")                           ] R41,
        [MediaType("HEOS", "R410A")                         ] R410A,
        [MediaType("HEOS", "R507A")                         ] R507A,

        

        [MediaType("HEOS", "RC318")                         ] RC318,
        [MediaType("HEOS", "SES36")                         ] SES36,
        [MediaType("HEOS", "SULFURDIOXIDE")                 ] SulfurDioxide,
        [MediaType("HEOS", "SULFURHEXAFLUORIDE")            ] SulfurHexafluoride,
        [MediaType("HEOS", "TOLUENE")                       ] Toluene,
        [MediaType("HEOS", "WATER")                         ] Water,
        [MediaType("HEOS", "XENON")                         ] Xenon,
        [MediaType("HEOS", "C2BUTENE")                      ] C2Butene,
        [MediaType("HEOS", "M-XYLENE")                      ] mXylene,
        [MediaType("HEOS", "N-BUTANE")                      ] nButane,
        [MediaType("HEOS", "N-DECANE")                      ] nDecane,
        [MediaType("HEOS", "N-DODECANE")                    ] nDodecane,
        [MediaType("HEOS", "N-HEPTANE")                     ] nHeptane,
        [MediaType("HEOS", "N-HEXANE")                      ] nHexane,
        [MediaType("HEOS", "N-NONANE")                      ] nNonane,
        [MediaType("HEOS", "N-OCTANE")                      ] nOctane,
        [MediaType("HEOS", "N-PENTANE")                     ] nPentane,
        [MediaType("HEOS", "N-PROPANE")                     ] nPropane,
        [MediaType("HEOS", "N-UNDECANE")                    ] nUndecane,
        [MediaType("HEOS", "O-XYLENE")                      ] oXylene,
        [MediaType("HEOS", "P-XYLENE")                      ] pXylene,
        [MediaType("HEOS", "TRANS-2-BUTENE")                ] T2Butene,


        //PreMix
        [MediaType("HEOS", "Air.mix", "", MixType.Mass)                       ] Air_mix,
        [MediaType("HEOS", "Amarillo.mix", "", MixType.Mass)                  ] Amarillo_mix,
        [MediaType("HEOS", "Ekofisk.mix", "", MixType.Mass)                   ] Ekofisk_mix,
        [MediaType("HEOS", "GulfCoast.mix", "", MixType.Mass)                 ] GulfCoast_mix,
        [MediaType("HEOS", "GulfCoastGas(NIST1).mix", "", MixType.Mass)       ] GulfCoastGas_NIST_mix,
        [MediaType("HEOS", "HighCO2.mix", "", MixType.Mass)                   ] HighCO2_mix,
        [MediaType("HEOS", "HighN2.mix", "", MixType.Mass)                    ] HighN2_mix,
        [MediaType("HEOS", "NaturalGasSample.mix", "", MixType.Mass)          ] NaturalGasSample_mix,
        [MediaType("HEOS", "R401A.mix","", MixType.Mass)                     ] R401A_mix,
        [MediaType("HEOS", "R401B.mix","", MixType.Mass)                     ] R401B_mix,
        [MediaType("HEOS", "R401C.mix","", MixType.Mass)                     ] R401C_mix,
        [MediaType("HEOS", "R402A.mix","", MixType.Mass)                     ] R402A_mix,
        [MediaType("HEOS", "R402B.mix","", MixType.Mass)                     ] R402B_mix,
        [MediaType("HEOS", "R403A.mix","", MixType.Mass)                     ] R403A_mix,
        [MediaType("HEOS", "R403B.mix","", MixType.Mass)                     ] R403B_mix,
        [MediaType("HEOS", "R404A.mix","", MixType.Mass)                     ] R404A_mix,
        [MediaType("HEOS", "R405A.mix","", MixType.Mass)                     ] R405A_mix,
        [MediaType("HEOS", "R406A.mix","", MixType.Mass)                     ] R406A_mix,
        [MediaType("HEOS", "R407A.mix","", MixType.Mass)                     ] R407A_mix,
        [MediaType("HEOS", "R407B.mix","", MixType.Mass)                     ] R407B_mix,
        [MediaType("HEOS", "R407C.mix","", MixType.Mass)                     ] R407C_mix,
        [MediaType("HEOS", "R407D.mix","", MixType.Mass)                     ] R407D_mix,
        [MediaType("HEOS", "R407E.mix","", MixType.Mass)                     ] R407E_mix,
        [MediaType("HEOS", "R408A.mix","", MixType.Mass)                     ] R408A_mix,
        [MediaType("HEOS", "R409A.mix","", MixType.Mass)                     ] R409A_mix,
        [MediaType("HEOS", "R409B.mix","", MixType.Mass)                     ] R409B_mix,
        [MediaType("HEOS", "R410A.mix","", MixType.Mass)                     ] R410A_mix,
        [MediaType("HEOS", "R410B.mix","", MixType.Mass)                     ] R410B_mix,
        [MediaType("HEOS", "R411A.mix","", MixType.Mass)                     ] R411A_mix,
        [MediaType("HEOS", "R411B.mix","", MixType.Mass)                     ] R411B_mix,
        [MediaType("HEOS", "R412A.mix","", MixType.Mass)                     ] R412A_mix,
        [MediaType("HEOS", "R413A.mix","", MixType.Mass)                     ] R413A_mix,
        [MediaType("HEOS", "R414A.mix","", MixType.Mass)                     ] R414A_mix,
        [MediaType("HEOS", "R414B.mix","", MixType.Mass)                     ] R414B_mix,
        [MediaType("HEOS", "R415A.mix","", MixType.Mass)                     ] R415A_mix,
        [MediaType("HEOS", "R415B.mix","", MixType.Mass)                     ] R415B_mix,
        [MediaType("HEOS", "R416A.mix","", MixType.Mass)                     ] R416A_mix,
        [MediaType("HEOS", "R417A.mix","", MixType.Mass)                     ] R417A_mix,
        [MediaType("HEOS", "R417B.mix","", MixType.Mass)                     ] R417B_mix,
        [MediaType("HEOS", "R417C.mix","", MixType.Mass)                     ] R417C_mix,
        [MediaType("HEOS", "R418A.mix","", MixType.Mass)                     ] R418A_mix,
        [MediaType("HEOS", "R419A.mix","", MixType.Mass)                     ] R419A_mix,
        [MediaType("HEOS", "R419B.mix","", MixType.Mass)                     ] R419B_mix,
        [MediaType("HEOS", "R420A.mix", "", MixType.Mass)                     ] R420A_mix,
        [MediaType("HEOS", "R421A.mix","", MixType.Mass)                     ] R421A_mix,
        [MediaType("HEOS", "R421B.mix","", MixType.Mass)                     ] R421B_mix,
        [MediaType("HEOS", "R422A.mix","", MixType.Mass)                     ] R422A_mix,
        [MediaType("HEOS", "R422B.mix","", MixType.Mass)                     ] R422B_mix,
        [MediaType("HEOS", "R422C.mix","", MixType.Mass)                     ] R422C_mix,
        [MediaType("HEOS", "R422D.mix","", MixType.Mass)                     ] R422D_mix,
        [MediaType("HEOS", "R422E.mix","", MixType.Mass)                     ] R422E_mix,
        [MediaType("HEOS", "R423A.mix","", MixType.Mass)                     ] R423A_mix,
        [MediaType("HEOS", "R424A.mix","", MixType.Mass)                     ] R424A_mix,
        [MediaType("HEOS", "R425A.mix","", MixType.Mass)                     ] R425A_mix,
        [MediaType("HEOS", "R426A.mix","", MixType.Mass)                     ] R426A_mix,
        [MediaType("HEOS", "R427A.mix","", MixType.Mass)                     ] R427A_mix,
        [MediaType("HEOS", "R428A.mix","", MixType.Mass)                     ] R428A_mix,
        [MediaType("HEOS", "R429A.mix","", MixType.Mass)                     ] R429A_mix,
        [MediaType("HEOS", "R430A.mix","", MixType.Mass)                     ] R430A_mix,
        [MediaType("HEOS", "R431A.mix","", MixType.Mass)                     ] R431A_mix,
        [MediaType("HEOS", "R432A.mix","", MixType.Mass)                     ] R432A_mix,
        [MediaType("HEOS", "R433A.mix","", MixType.Mass)                     ] R433A_mix,
        [MediaType("HEOS", "R433B.mix","", MixType.Mass)                     ] R433B_mix,
        [MediaType("HEOS", "R433C.mix","", MixType.Mass)                     ] R433C_mix,
        [MediaType("HEOS", "R434A.mix","", MixType.Mass)                     ] R434A_mix,
        [MediaType("HEOS", "R435A.mix","", MixType.Mass)                     ] R435A_mix,
        [MediaType("HEOS", "R436A.mix","", MixType.Mass)                     ] R436A_mix,
        [MediaType("HEOS", "R436B.mix","", MixType.Mass)                     ] R436B_mix,
        [MediaType("HEOS", "R437A.mix","", MixType.Mass)                     ] R437A_mix,
        [MediaType("HEOS", "R438A.mix","", MixType.Mass)                     ] R438A_mix,
        [MediaType("HEOS", "R439A.mix","", MixType.Mass)                     ] R439A_mix,
        [MediaType("HEOS", "R440A.mix","", MixType.Mass)                     ] R440A_mix,
        [MediaType("HEOS", "R441A.mix","", MixType.Mass)                     ] R441A_mix,
        [MediaType("HEOS", "R442A.mix","", MixType.Mass)                     ] R442A_mix,
        [MediaType("HEOS", "R443A.mix","", MixType.Mass)                     ] R443A_mix,
        [MediaType("HEOS", "R444A.mix","", MixType.Mass)                     ] R444A_mix,
        [MediaType("HEOS", "R444B.mix","", MixType.Mass)                     ] R444B_mix,
        [MediaType("HEOS", "R445A.mix","", MixType.Mass)                     ] R445A_mix,
        [MediaType("HEOS", "R446A.mix","", MixType.Mass)                     ] R446A_mix,
        [MediaType("HEOS", "R447A.mix", "", MixType.Mass)                     ] R447A_mix,
        [MediaType("HEOS", "R448A.mix","", MixType.Mass)                     ] R448A_mix,
        [MediaType("HEOS", "R449A.mix","", MixType.Mass)                     ] R449A_mix,
        [MediaType("HEOS", "R449B.mix","", MixType.Mass)                     ] R449B_mix,
        [MediaType("HEOS", "R450A.mix","", MixType.Mass)                     ] R450A_mix,
        [MediaType("HEOS", "R451A.mix","", MixType.Mass)                     ] R451A_mix,
        [MediaType("HEOS", "R451B.mix","", MixType.Mass)                     ] R451B_mix,
        [MediaType("HEOS", "R452A.mix","", MixType.Mass)                     ] R452A_mix,
        [MediaType("HEOS", "R453A.mix","", MixType.Mass)                     ] R453A_mix,
        [MediaType("HEOS", "R454A.mix","", MixType.Mass)                     ] R454A_mix,
        [MediaType("HEOS", "R454B.mix", "", MixType.Mass)                     ] R454B_mix,
        [MediaType("HEOS", "R500.mix","", MixType.Mass)                      ] R500_mix,
        [MediaType("HEOS", "R501.mix","", MixType.Mass)                      ] R501_mix,
        [MediaType("HEOS", "R502.mix","", MixType.Mass)                      ] R502_mix,
        [MediaType("HEOS", "R503.mix","", MixType.Mass)                      ] R503_mix,
        [MediaType("HEOS", "R504.mix", "", MixType.Mass)                      ] R504_mix,
        [MediaType("HEOS", "R507A.mix","", MixType.Mass)                     ] R507A_mix,
        [MediaType("HEOS", "R508A.mix","", MixType.Mass)                     ] R508A_mix,
        [MediaType("HEOS", "R508B.mix","", MixType.Mass)                     ] R508B_mix,
        [MediaType("HEOS", "R509A.mix","", MixType.Mass)                     ] R509A_mix,
        [MediaType("HEOS", "R510A.mix","", MixType.Mass)                     ] R510A_mix,
        [MediaType("HEOS", "R511A.mix","", MixType.Mass)                     ] R511A_mix,
        [MediaType("HEOS", "R512A.mix","", MixType.Mass)                     ] R512A_mix,
        [MediaType("HEOS", "R513A.mix", "", MixType.Mass)                     ] R513A_mix,
        [MediaType("HEOS", "TypicalNaturalGas.mix", "", MixType.Mass)] TypicalNaturalGas_mix,



        //Incompressible
        [MediaType("INCOMP","Water")                        ] InCompWater,
        [MediaType("INCOMP", "AS10")                        ] InCompAspenTemperMinus10,
        [MediaType("INCOMP", "AS20")                        ] InCompAspenTemperMinus20,
        [MediaType("INCOMP", "AS30")                        ] InCompAspenTemperMinus30,
        [MediaType("INCOMP", "AS40")                        ] InCompAspenTemperMinus40,
        [MediaType("INCOMP", "AS55")                        ] InCompAspenTemperMinus55,
        [MediaType("INCOMP", "DEB")                         ] InCompDiethylbenzeneMixture,
        [MediaType("INCOMP", "DowJ")                        ] InCompDowthermJ,
        [MediaType("INCOMP", "DowJ2")                       ] InCompDowthermJMix,
        [MediaType("INCOMP", "DowQ")                        ] InCompDowthermQ,
        [MediaType("INCOMP", "DowQ2")                       ] InCompDowthermQMix,
        [MediaType("INCOMP", "HC10")                        ] InCompDynaleneHC10,
        [MediaType("INCOMP", "HC20")                        ] InCompDynaleneHC20,
        [MediaType("INCOMP", "HC30")                        ] InCompDynaleneHC30,
        [MediaType("INCOMP", "HC40")                        ] InCompDynaleneHC40,
        [MediaType("INCOMP", "HC50")                        ] InCompDynaleneHC50,
        [MediaType("INCOMP", "HCB")                         ] InCompHydrocarbonBlend,
        [MediaType("INCOMP", "HCM")                         ] InCompHydrocarbonMixture,
        [MediaType("INCOMP", "HFE")                         ] InCompHFE71003M,
        [MediaType("INCOMP", "HFE2")                        ] InCompHFE7100,
        [MediaType("INCOMP", "HY20")                        ] InCompHYCOOL20,
        [MediaType("INCOMP", "HY30")                        ] InCompHyCool30,
        [MediaType("INCOMP", "HY40")                        ] InCompHyCool40,
        [MediaType("INCOMP", "HY45")                        ] InCompHyCool45,
        [MediaType("INCOMP", "HY50")                        ] InCompHyCool50,
        [MediaType("INCOMP", "NBS")                         ] InCompNBSWater,
        [MediaType("INCOMP", "NaK")                         ] InCompNitrateSalt,
        [MediaType("INCOMP", "PBB")                         ] InCompPiroblocHTF,
        [MediaType("INCOMP", "PCL")                         ] InCompParacryol,
        [MediaType("INCOMP", "PCR")                         ] InCompParathermCR,
        [MediaType("INCOMP", "PGLT")                        ] InCompParathermGLT,
        [MediaType("INCOMP", "PHE")                         ] InCompParathermHE,
        [MediaType("INCOMP", "PHR")                         ] InCompParathermHR,
        [MediaType("INCOMP", "PLR")                         ] InCompParathermLR,
        [MediaType("INCOMP", "PMR")                         ] InCompParathermMR,
        [MediaType("INCOMP", "PMS1")                        ] InCompPolydimethylsiloxan1,
        [MediaType("INCOMP", "PMS2")                        ] InCompPolydimethylsiloxan2,
        [MediaType("INCOMP", "PNF")                         ] InCompParathermNF,
        [MediaType("INCOMP", "PNF2")                        ] InCompParathermNF2,
        [MediaType("INCOMP", "S800")                        ] InCompSyltherm800,
        [MediaType("INCOMP", "SAB")                         ] InCompMarlothermX,
        [MediaType("INCOMP", "T66")                         ] InCompTherminol66,
        [MediaType("INCOMP", "T72")                         ] InCompTherminol72,
        [MediaType("INCOMP", "TCO")                         ] InCompCitrusOilTerpene,
        [MediaType("INCOMP", "TD12")                        ] InCompTherminolD12,
        [MediaType("INCOMP", "TVP1")                        ] InCompTherminolVP1,
        [MediaType("INCOMP", "TVP1869")                     ] InCompThermogenVP,
        [MediaType("INCOMP", "TX22")                        ] InCompTexatherm22,
        [MediaType("INCOMP", "TY10")                        ] InCompTyfoxit10,
        [MediaType("INCOMP", "TY15")                        ] InCompTyfoxit15,
        [MediaType("INCOMP", "TY20")                        ] InCompTyfoxit20,
        [MediaType("INCOMP", "TY24")                        ] InCompTyfoxit24,
        [MediaType("INCOMP", "XLT")                         ] InCompSylthermXLT,
        [MediaType("INCOMP", "XLT2")                        ] InCompSylthermXLT2,
        [MediaType("INCOMP", "ZS10")                        ] InCompZitrecS10,
        [MediaType("INCOMP", "ZS25")                        ] InCompZitrecS25,
        [MediaType("INCOMP", "ZS40")                        ] InCompZitrecS40,
        [MediaType("INCOMP", "ZS45")                        ] InCompZitrecS45,
        [MediaType("INCOMP", "ZS55")                        ] InCompZitrecS55,


        //Mass Mis
        [MediaType("INCOMP", "FRE", "", MixType.Mass)] MixFreezium,
        [MediaType("INCOMP", "IceEA", "", MixType.Mass)] MixIceslurrywithEthanol,
        [MediaType("INCOMP", "IceNA", "", MixType.Mass)] MixIceslurrywithNaCl,
        [MediaType("INCOMP", "IcePG", "", MixType.Mass)] MixIceslurrywithPropyleneGlycol,
        [MediaType("INCOMP", "LiBr", "", MixType.Mass)] MixLithiumbromideSolution,
        [MediaType("INCOMP", "MAM",     "",       MixType.Mass)] MixAmmoniaAQ,
        [MediaType("INCOMP", "MAM2",    "",       MixType.Mass)] MixMelinderAmmonia,
        [MediaType("INCOMP", "MCA",     "",       MixType.Mass)] MixCalciumChlorideAQ,
        [MediaType("INCOMP", "MCA2",    "",       MixType.Mass)] MixMelinderCalciumChloride,
        [MediaType("INCOMP", "MEA",     "",       MixType.Mass)] MixEthanolAQ,
        [MediaType("INCOMP", "MEA2",    "",       MixType.Mass)] MixMelinderEthanol,
        [MediaType("INCOMP", "MEG", "Ethylene Glycol",       MixType.Mass)] MixEthyleneGlycolAQ,
        [MediaType("INCOMP", "MEG2",    "",       MixType.Mass)] MixMelinderEthyleneGlycol,
        [MediaType("INCOMP", "MGL",     "",       MixType.Mass)] MixGlycerolAQ,
        [MediaType("INCOMP", "MGL2",    "",       MixType.Mass)] MixMelinderGlycerol,
        [MediaType("INCOMP", "MITSW",   "",       MixType.Mass)] MixMITSeawater,
        [MediaType("INCOMP", "MKA",     "",       MixType.Mass)] MixPotassiumAcetateAQ,
        [MediaType("INCOMP", "MKA2",    "",       MixType.Mass)] MixMelinderPotassiumAcetate,
        [MediaType("INCOMP", "MKC",     "",       MixType.Mass)] MixPotassiumCarbonateAQ,
        [MediaType("INCOMP", "MKC2",    "",       MixType.Mass)] MixMelinderPotassiumCarbonate,
        [MediaType("INCOMP", "MKF",     "",       MixType.Mass)] MixPotassiumFormateAQ,
        [MediaType("INCOMP", "MLI",     "",       MixType.Mass)] MixLithiumChlorideAQ,
        [MediaType("INCOMP", "MMA",     "",       MixType.Mass)] MixMethanolAQ,
        [MediaType("INCOMP", "MMA2",    "",       MixType.Mass)] MixMelinderMethanol,
        [MediaType("INCOMP", "MMG",     "",       MixType.Mass)] MixMgCl2AQ,
        [MediaType("INCOMP", "MMG2",    "",       MixType.Mass)] MixMelinderMagnesiumChloride,
        [MediaType("INCOMP", "MNA",     "",       MixType.Mass)] MixSodiumChlorideAQ,
        [MediaType("INCOMP", "MNA2",    "",       MixType.Mass)] MixMelinderSodiumChloride,
        [MediaType("INCOMP", "MPG", "Propylen Glycol",       MixType.Mass)] MixPropyleneGlycolAQ,
        [MediaType("INCOMP", "MPG2",    "",       MixType.Mass)] MixMelinderPropyleneGlycol,
        [MediaType("INCOMP", "VCA",     "",       MixType.Mass)] MixVDICalciumCloride,
        [MediaType("INCOMP", "VKC",     "",       MixType.Mass)] MixVDIPotassiumCarbonate,
        [MediaType("INCOMP", "VMA",     "",       MixType.Mass)] MixVDIMethanol,
        [MediaType("INCOMP", "VMG",     "",       MixType.Mass)] MixVDIMagnesiumChloride,
        [MediaType("INCOMP", "VNA",     "",       MixType.Mass)] MixVDISodiumChloride,

        //Vol Mix
        [MediaType("INCOMP", "AEG", "", MixType.Vol)] VolMixASHRAEEthyleneGlycol,
        [MediaType("INCOMP", "AKF", "",           MixType.Vol)] VolMixPotassiumFormate,
        [MediaType("INCOMP", "AL",  "",           MixType.Vol)] VolMixAntifrogenPropyleneGlycol,
        [MediaType("INCOMP", "AN",  "",           MixType.Vol)] VolMixAntifrogenEthyleneGlycol,
        [MediaType("INCOMP", "APG", "",           MixType.Vol)] VolMixASHRAEPropyleneGlycol,
        [MediaType("INCOMP", "GKN", "",           MixType.Vol)] VolMixGlykosolEthyleneGlycol,
        [MediaType("INCOMP", "PK2", "",           MixType.Vol)] VolMixPekasol2000,
        [MediaType("INCOMP", "PKL", "",           MixType.Vol)] VolMixPropyleneGlycol,
        [MediaType("INCOMP", "ZAC", "",           MixType.Vol)] VolMixCorrosionInhibitor,
        [MediaType("INCOMP", "ZFC", "",           MixType.Vol)] VolMixFCPropyleneGlycol,
        [MediaType("INCOMP", "ZLC", "",           MixType.Vol)] VolMixLCPropyleneGlycol,
        [MediaType("INCOMP", "ZM",  "",           MixType.Vol)] VolMixMEthyleneGlycol,
        [MediaType("INCOMP", "ZMC", "",           MixType.Vol)] VolMixMCEthyleneGlycol,

        [MediaType("CustomFluid", "SHC226E", "", MixType.Mass)] Custom_SHC226E,
        [MediaType("CustomFluid", "SHC228",  "",  MixType.Mass)] Custom_SHC228,
        [MediaType("CustomFluid", "SHC230",  "",  MixType.Mass)] Custom_SHC230,
        [MediaType("CustomFluid", "Number13","",  MixType.Mass)] Custom_Number13,
        [MediaType("CustomFluid", "AmmoniaWater", "", MixType.Mass)] AWMix,

    }





}
