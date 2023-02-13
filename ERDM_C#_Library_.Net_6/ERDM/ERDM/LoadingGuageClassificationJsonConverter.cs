using Newtonsoft.Json;
using ERDM.Tier_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ERDM
{
    public class LoadingGaugeClassificationJsonConverter : System.Text.Json.Serialization.JsonConverter<LoadingGaugeClassification?>
    {
        public override LoadingGaugeClassification? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "GA":
                    return LoadingGaugeClassification.GA;
                case "GB":
                    return LoadingGaugeClassification.GB;
                case "GC":
                    return LoadingGaugeClassification.GC;
                case "G1":
                    return LoadingGaugeClassification.G1;
                case "DE3":
                    return LoadingGaugeClassification.DE3;
                case "G2":
                    return LoadingGaugeClassification.G2;
                case "GB1":
                    return LoadingGaugeClassification.GB1;
                case "GB2":
                    return LoadingGaugeClassification.GB2;
                case "BE1":
                    return LoadingGaugeClassification.BE1;
                case "BE2":
                    return LoadingGaugeClassification.BE2;
                case "BE3":
                    return LoadingGaugeClassification.BE3;
                case "FR-3.3":
                    return LoadingGaugeClassification.FR_3_3;
                case "PTb":
                    return LoadingGaugeClassification.PTb;
                case "PTb+":
                    return LoadingGaugeClassification.PTb_plus;
                case "PTc":
                    return LoadingGaugeClassification.PTc;
                case "FIN1":
                    return LoadingGaugeClassification.FIN1;
                case "SEa":
                    return LoadingGaugeClassification.SEa;
                case "SEc":
                    return LoadingGaugeClassification.SEc;
                case "DE1":
                    return LoadingGaugeClassification.DE1;
                case "DE2":
                    return LoadingGaugeClassification.DE2;
                case "Z-GCD":
                    return LoadingGaugeClassification.Z_GCD;
                case "UK1":
                    return LoadingGaugeClassification.UK1;
                case "UK1[D]":
                    return LoadingGaugeClassification.UK1_D;
                case "W6":
                    return LoadingGaugeClassification.W6;
                case "FS":
                    return LoadingGaugeClassification.FS;
                case "S":
                    return LoadingGaugeClassification.S;
                case "GHE16":
                    return LoadingGaugeClassification.GHE16;
                case "GEA16":
                    return LoadingGaugeClassification.GEA16;
                case "GEB16":
                    return LoadingGaugeClassification.GEB16;
                case "GEC16":
                    return LoadingGaugeClassification.GEC16;
                case "IRL1":
                    return LoadingGaugeClassification.IRL1;
                case "IRL2":
                    return LoadingGaugeClassification.IRL2;
                case "IRL3":
                    return LoadingGaugeClassification.IRL3;
                case "GI1":
                    return LoadingGaugeClassification.GI1;
                case "GI2":
                    return LoadingGaugeClassification.GI2;
                case "GI3":
                    return LoadingGaugeClassification.GI3;
                case "GEE10":
                    return LoadingGaugeClassification.GEE10;
                case "GED10":
                    return LoadingGaugeClassification.GED10;
                case "AFM_423":
                    return LoadingGaugeClassification.AFM_423;
                case "NL1":
                    return LoadingGaugeClassification.NL1;
                case "NL2":
                    return LoadingGaugeClassification.NL2;
                case "FR-3.4.1":
                    return LoadingGaugeClassification.FR_3_4_1;
                case "FR-3.4.2":
                    return LoadingGaugeClassification.FR_3_4_2;
                case "AFG":
                    return LoadingGaugeClassification.AFG;
                case "AFM425":
                    return LoadingGaugeClassification.AFM425;
                case "AFM427":
                    return LoadingGaugeClassification.AFM427;
                case "M30":
                    return LoadingGaugeClassification.M30;
                case "M80":
                    return LoadingGaugeClassification.M80;
                case "Tram-train 2.40":
                    return LoadingGaugeClassification.Tram_train_2_40;
                case "Tram-train 2.65":
                    return LoadingGaugeClassification.Tram_train_2_65;
                case "Métrique BA":
                    return LoadingGaugeClassification.Métrique_BA;
                case "Métrique SGV":
                    return LoadingGaugeClassification.Métrique_SGV;
                case "Métrique Cerd.":
                    return LoadingGaugeClassification.Métrique_Cerd;
                case "GB:GČD":
                    return LoadingGaugeClassification.GB_GČD;
                case "GCZ3":
                    return LoadingGaugeClassification.GCZ3;
                case "GČD":
                    return LoadingGaugeClassification.GČD;
                case "GEI1":
                    return LoadingGaugeClassification.GEI1;
                case "GEI2":
                    return LoadingGaugeClassification.GEI2;
                case "GEI3":
                    return LoadingGaugeClassification.GEI3;
                case "GEC14":
                    return LoadingGaugeClassification.GEC14;
                case "other":
                    return LoadingGaugeClassification.other;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, LoadingGaugeClassification? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case LoadingGaugeClassification.GA:
                    writer.WriteStringValue("GA");
                    break;
                case LoadingGaugeClassification.GB:
                    writer.WriteStringValue("GB");
                    break;
                case LoadingGaugeClassification.GC:
                    writer.WriteStringValue("GC");
                    break;
                case LoadingGaugeClassification.G1:
                    writer.WriteStringValue("G1");
                    break;
                case LoadingGaugeClassification.DE3:
                    writer.WriteStringValue("DE3");
                    break;
                case LoadingGaugeClassification.G2:
                    writer.WriteStringValue("G2");
                    break;
                case LoadingGaugeClassification.GB1:
                    writer.WriteStringValue("GB1");
                    break;
                case LoadingGaugeClassification.GB2:
                    writer.WriteStringValue("GB2");
                    break;
                case LoadingGaugeClassification.BE1:
                    writer.WriteStringValue("BE1");
                    break;
                case LoadingGaugeClassification.BE2:
                    writer.WriteStringValue("BE2");
                    break;
                case LoadingGaugeClassification.BE3:
                    writer.WriteStringValue("BE3");
                    break;
                case LoadingGaugeClassification.FR_3_3:
                    writer.WriteStringValue("FR-3.3");
                    break;
                case LoadingGaugeClassification.PTb:
                    writer.WriteStringValue("PTb");
                    break;
                case LoadingGaugeClassification.PTb_plus:
                    writer.WriteStringValue("PTb+");
                    break;
                case LoadingGaugeClassification.PTc:
                    writer.WriteStringValue("PTc");
                    break;
                case LoadingGaugeClassification.FIN1:
                    writer.WriteStringValue("FIN1");
                    break;
                case LoadingGaugeClassification.SEa:
                    writer.WriteStringValue("SEa");
                    break;
                case LoadingGaugeClassification.SEc:
                    writer.WriteStringValue("SEc");
                    break;
                case LoadingGaugeClassification.DE1:
                    writer.WriteStringValue("DE1");
                    break;
                case LoadingGaugeClassification.DE2:
                    writer.WriteStringValue("DE2");
                    break;
                case LoadingGaugeClassification.Z_GCD:
                    writer.WriteStringValue("Z-GCD");
                    break;
                case LoadingGaugeClassification.UK1:
                    writer.WriteStringValue("UK1");
                    break;
                case LoadingGaugeClassification.UK1_D:
                    writer.WriteStringValue("UK1[D]");
                    break;
                case LoadingGaugeClassification.W6:
                    writer.WriteStringValue("W6");
                    break;
                case LoadingGaugeClassification.FS:
                    writer.WriteStringValue("FS");
                    break;
                case LoadingGaugeClassification.S:
                    writer.WriteStringValue("S");
                    break;
                case LoadingGaugeClassification.GHE16:
                    writer.WriteStringValue("GHE16");
                    break;
                case LoadingGaugeClassification.GEA16:
                    writer.WriteStringValue("GEA16");
                    break;
                case LoadingGaugeClassification.GEB16:
                    writer.WriteStringValue("GEB16");
                    break;
                case LoadingGaugeClassification.GEC16:
                    writer.WriteStringValue("GEC16");
                    break;
                case LoadingGaugeClassification.IRL1:
                    writer.WriteStringValue("IRL1");
                    break;
                case LoadingGaugeClassification.IRL2:
                    writer.WriteStringValue("IRL2");
                    break;
                case LoadingGaugeClassification.IRL3:
                    writer.WriteStringValue("IRL3");
                    break;
                case LoadingGaugeClassification.GI1:
                    writer.WriteStringValue("GI1");
                    break;
                case LoadingGaugeClassification.GI2:
                    writer.WriteStringValue("GI2");
                    break;
                case LoadingGaugeClassification.GI3:
                    writer.WriteStringValue("GI3");
                    break;
                case LoadingGaugeClassification.GEE10:
                    writer.WriteStringValue("GEE10");
                    break;
                case LoadingGaugeClassification.GED10:
                    writer.WriteStringValue("GED10");
                    break;
                case LoadingGaugeClassification.AFM_423:
                    writer.WriteStringValue("AFM_423");
                    break;
                case LoadingGaugeClassification.NL1:
                    writer.WriteStringValue("NL1");
                    break;
                case LoadingGaugeClassification.NL2:
                    writer.WriteStringValue("NL2");
                    break;
                case LoadingGaugeClassification.FR_3_4_1:
                    writer.WriteStringValue("FR-3.4.1");
                    break;
                case LoadingGaugeClassification.FR_3_4_2:
                    writer.WriteStringValue("FR-3.4.2");
                    break;
                case LoadingGaugeClassification.AFG:
                    writer.WriteStringValue("AFG");
                    break;
                case LoadingGaugeClassification.AFM425:
                    writer.WriteStringValue("AFM425");
                    break;
                case LoadingGaugeClassification.AFM427:
                    writer.WriteStringValue("AFM427");
                    break;
                case LoadingGaugeClassification.M30:
                    writer.WriteStringValue("M30");
                    break;
                case LoadingGaugeClassification.M80:
                    writer.WriteStringValue("M80");
                    break;
                case LoadingGaugeClassification.Tram_train_2_40:
                    writer.WriteStringValue("Tram-train 2.40");
                    break;
                case LoadingGaugeClassification.Tram_train_2_65:
                    writer.WriteStringValue("Tram-train 2.65");
                    break;
                case LoadingGaugeClassification.Métrique_BA:
                    writer.WriteStringValue("Métrique BA");
                    break;
                case LoadingGaugeClassification.Métrique_SGV:
                    writer.WriteStringValue("Métrique SGV");
                    break;
                case LoadingGaugeClassification.Métrique_Cerd:
                    writer.WriteStringValue("Métrique Cerd.");
                    break;
                case LoadingGaugeClassification.GB_GČD:
                    writer.WriteStringValue("GB:GČD");
                    break;
                case LoadingGaugeClassification.GCZ3:
                    writer.WriteStringValue("GCZ3");
                    break;
                case LoadingGaugeClassification.GČD:
                    writer.WriteStringValue("GČD");
                    break;
                case LoadingGaugeClassification.GEI1:
                    writer.WriteStringValue("GEI1");
                    break;
                case LoadingGaugeClassification.GEI2:
                    writer.WriteStringValue("GEI2");
                    break;
                case LoadingGaugeClassification.GEI3:
                    writer.WriteStringValue("GEI3");
                    break;
                case LoadingGaugeClassification.GEC14:
                    writer.WriteStringValue("GEC14");
                    break;
                case LoadingGaugeClassification.other:
                    writer.WriteStringValue("other");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
