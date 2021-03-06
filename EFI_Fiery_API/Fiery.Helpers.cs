using EFI;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFI_Fiery_API
{
    class FieryHelpers
    {
        public class UnixDateTimeConverter : JsonConverter
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="objectType"></param>
            /// <returns></returns>
            public override bool CanConvert(Type objectType) => objectType == typeof(string) ? true : false;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="objectType"></param>
            /// <param name="existingValue"></param>
            /// <param name="serializer"></param>
            /// <returns></returns>
            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                if (reader.Value == null || string.IsNullOrEmpty(Convert.ToString(reader.Value)))
                {
                    return DateTime.MinValue;
                }
                else
                {
                    try
                    {
                        double unixTimestamp = Convert.ToDouble(Convert.ToString(reader.Value).Split(':')[0]);
                        return unixTimestamp.UnixToDateTime().Date;
                    }
                    catch
                    {
                        // Return Unix Time.
                        if (Convert.ToDateTime(reader.Value) == DateTime.MinValue)
                        {
                            return new DateTime(1970, 01, 01, 00, 00, 00, System.DateTimeKind.Local);
                        }
                        else
                        {
                            double unixDateTime =  Convert.ToDateTime(reader.Value).DateTimeToUnix();
                            return unixDateTime.UnixToDateTime().Date;
                        }
                    }
                }
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="value"></param>
            /// <param name="serializer"></param>
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => writer.WriteValue((DateTime)value);
        }

        public class KbToGbConverter : JsonConverter
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="objectType"></param>
            /// <returns></returns>
            public override bool CanConvert(Type objectType) => objectType == typeof(long) ? true : false;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="objectType"></param>
            /// <param name="existingValue"></param>
            /// <param name="serializer"></param>
            /// <returns></returns>
            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                string value = Convert.ToString(reader.Value).Replace("-", "");
                return Math.Round(Convert.ToInt64(value) / 1e+6) + " GB";
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="value"></param>
            /// <param name="serializer"></param>
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => writer.WriteValue((string)value);
        }

        public class KbToMbConverter : JsonConverter
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="objectType"></param>
            /// <returns></returns>
            public override bool CanConvert(Type objectType) => objectType == typeof(long) ? true : false;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="objectType"></param>
            /// <param name="existingValue"></param>
            /// <param name="serializer"></param>
            /// <returns></returns>
            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                string value = Convert.ToString(reader.Value).Replace("-", "");
                return Math.Round(Convert.ToDecimal(Convert.ToInt64(value) / 1000)) + " MB";
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="value"></param>
            /// <param name="serializer"></param>
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                writer.WriteValue((string)value);
            }
        }

        public class BooleanConverter : JsonConverter
        {
            /// <summary>
            /// Can The Given Type Be Converted?
            /// </summary>
            /// <param name="objectType"></param>
            /// <returns></returns>
            public override bool CanConvert(Type objectType) => objectType == typeof(int) || objectType == typeof(string)? true : false;

            /// <summary>
            /// Read The Value.
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="objectType"></param>
            /// <param name="existingValue"></param>
            /// <param name="serializer"></param>
            /// <returns></returns>
            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                switch (Convert.ToString(reader.Value).ToLower() ?? string.Empty)
                {
                    case "true":
                        return true;
                    case "false":
                        return false;
                    case "yes":
                        return true;
                    case "no":
                        return false;
                    case "":
                        return false;
                    case "1":
                        return true;
                    case "0":
                        return false;
                    default:
                        throw new Exception($"Unable To Convert To Boolean : {reader.Path} :: {objectType.ToString()} ::: {reader.Value.ToString()}");
                }
            }

            /// <summary>
            /// Write The Value.
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="value"></param>
            /// <param name="serializer"></param>
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                writer.WriteValue(value);
            }
        }

        public class MinuteToDayConverter : JsonConverter
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="objectType"></param>
            /// <returns></returns>
            public override bool CanConvert(Type objectType) => objectType == typeof(long) ? true : false;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="objectType"></param>
            /// <param name="existingValue"></param>
            /// <param name="serializer"></param>
            /// <returns></returns>
            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                long time = Convert.ToInt64(reader.Value);
                return time / 86400 + " Day(s)";
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="value"></param>
            /// <param name="serializer"></param>
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => writer.WriteValue((string)value);
        }
    }
}
