

using System.Xml.Serialization;

namespace ERDM.Tier_3
{
	public enum LoadingGaugeClassification
	{
		GA,
		GB,
		GC,
		G1,
		DE3,
		G2,
		GB1,
		GB2,
		BE1,
		BE2,
		BE3,
		[XmlEnum("FR-3.3")]
		FR_3_3,
		PTb,
        [XmlEnum("PTb+")]
        PTb_plus,
		PTc,
		FIN1,
		SEa,
		SEc,
		DE1,
		DE2,
        [XmlEnum("Z-GCD")]
        Z_GCD,
		UK1,
        [XmlEnum("UK1[D]")]
        UK1_D,
		W6,
		FS,
		S,
		GHE16,
		GEA16,
		GEB16,
		GEC16,
		IRL1,
		IRL2,
		IRL3,
		GI1,
		GI2,
		GI3,
		GEE10,
		GED10,
        [XmlEnum("AFM-423")]
        AFM_423,
		NL1,
		NL2,
        [XmlEnum("FR-3.4.1")]
        FR_3_4_1,
        [XmlEnum("FR-3.4.2")]
        FR_3_4_2,
		AFG,
		AFM425,
		AFM427,
		M30,
		M80,
        [XmlEnum("Tram-train 2.40")]
        Tram_train_2_40,
        [XmlEnum("Tram-train 2.65")]
        Tram_train_2_65,
        [XmlEnum("Métrique BA")]
        Métrique_BA,
        [XmlEnum("Métrique SGV")]
        Métrique_SGV,
        [XmlEnum("Métrique Cerd.")]
        Métrique_Cerd,
        [XmlEnum("GB:GČD")]
        GB_GČD,
		GCZ3,
        [XmlEnum("GČD")]
        GČD,
		GEI1,
		GEI2,
		GEI3,
		GEC14,
		other,
	}
}