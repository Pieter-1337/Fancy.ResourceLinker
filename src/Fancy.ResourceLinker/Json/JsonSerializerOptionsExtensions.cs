﻿using System.Text.Json;

namespace Fancy.ResourceLinker.Json
{
    /// <summary>
    /// Extensions for JsonSerializerOptions
    /// </summary>
    public static class JsonSerializerOptionsExtensions
    {
        /// <summary>
        /// Adds the resource converter an instance of JsonSerializerOptions.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <param name="ignoreEmptyMetadata">if set to <c>true</c> ignores empty metadata fields.</param>
        /// <param name="writePrivates">Specifies is fields which stats with '_' shall be read an written.</param>
        public static void AddResourceConverter(this JsonSerializerOptions options, bool ignoreEmptyMetadata = false, bool writePrivates = true)
        {
            options.Converters.Add(new ResourceJsonConverterFactory(writePrivates, ignoreEmptyMetadata));
        }
    }
}
