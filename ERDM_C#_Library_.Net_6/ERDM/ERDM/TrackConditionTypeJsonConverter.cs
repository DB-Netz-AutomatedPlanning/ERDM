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
    public class TrackConditionTypeJsonConverter : System.Text.Json.Serialization.JsonConverter<TrackConditionType?>
    {
        public override TrackConditionType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            else if (reader.TokenType != JsonTokenType.String)
                throw new JsonSerializationException(string.Format("Unexpected token {0}", reader.TokenType));
            var s = reader.GetString();
            switch (s)
            {
                case "Powerless Section, lower pantograph":
                    return TrackConditionType.PowerlessSection_LowerPantograph;
                case "Powerless Section, switch off Main power switch":
                    return TrackConditionType.PowerlessSection_SwitchOffMainPowerSwitch;
                case "Air tightness":
                    return TrackConditionType.AirTightness;
                case "Switch off eddy current brake for service brake":
                    return TrackConditionType.SoundHorn;
                case "Switch off eddy current brake for emergency brake":
                    return TrackConditionType.NonStoppingArea;
                case "Switch off magnetic shoe brake":
                    return TrackConditionType.TunnelStoppingArea;
                case "Sound horn":
                    return TrackConditionType.BigMetalMasses__;
                case "Non stopping area":
                    return TrackConditionType.RadioHole__;
                case "Tunnel stopping area":
                    return TrackConditionType.SwitchOffRegenerativeBrake;
                case "Big metal masses, ignore onboard integrity check alarms of balise transmission":
                    return TrackConditionType.SwitchOffEddyCurrentBrake_serviceBrake;
                case "Radio hole, Stop supervision of the loss of safe Radio connection":
                    return TrackConditionType.SwitchOffEddyCurrentBrake_emergencyBrake;
                case "Switch off regenerative brake":
                    return TrackConditionType.SwitchOffEddyMagneticShoeBrake;
                default:
                    return null;
            }
        }
        public override void Write(Utf8JsonWriter writer, TrackConditionType? value, JsonSerializerOptions options)
        {

            switch (value)
            {
                case TrackConditionType.PowerlessSection_LowerPantograph:
                    writer.WriteStringValue("Powerless Section, lower pantograph");
                    break;
                case TrackConditionType.PowerlessSection_SwitchOffMainPowerSwitch:
                    writer.WriteStringValue("Powerless Section, switch off Main power switch");
                    break;
                case TrackConditionType.AirTightness:
                    writer.WriteStringValue("Air tightness");
                    break;
                case TrackConditionType.SoundHorn:
                    writer.WriteStringValue("Switch off eddy current brake for service brake");
                    break;
                case TrackConditionType.NonStoppingArea:
                    writer.WriteStringValue("Switch off eddy current brake for emergency brake");
                    break;
                case TrackConditionType.TunnelStoppingArea:
                    writer.WriteStringValue("Switch off magnetic shoe brake");
                    break;
                case TrackConditionType.BigMetalMasses__:
                    writer.WriteStringValue("Sound horn");
                    break;
                case TrackConditionType.RadioHole__:
                    writer.WriteStringValue("Non stopping area");
                    break;
                case TrackConditionType.SwitchOffRegenerativeBrake:
                    writer.WriteStringValue("Tunnel stopping area");
                    break;
                case TrackConditionType.SwitchOffEddyCurrentBrake_serviceBrake:
                    writer.WriteStringValue("Big metal masses, ignore onboard integrity check alarms of balise transmission");
                    break;
                case TrackConditionType.SwitchOffEddyCurrentBrake_emergencyBrake:
                    writer.WriteStringValue("Radio hole, Stop supervision of the loss of safe Radio connection");
                    break;
                case TrackConditionType.SwitchOffEddyMagneticShoeBrake:
                    writer.WriteStringValue("Switch off regenerative brake");
                    break;
                default:
                    writer.WriteNullValue();
                    break;
            }
        }
    }
}
