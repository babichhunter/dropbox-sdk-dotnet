// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Exported passwords.</para>
    /// </summary>
    public class DropboxPasswordsExportedDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DropboxPasswordsExportedDetails> Encoder = new DropboxPasswordsExportedDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DropboxPasswordsExportedDetails> Decoder = new DropboxPasswordsExportedDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DropboxPasswordsExportedDetails"
        /// /> class.</para>
        /// </summary>
        /// <param name="platform">The platform the device runs export.</param>
        public DropboxPasswordsExportedDetails(string platform)
        {
            if (platform == null)
            {
                throw new sys.ArgumentNullException("platform");
            }

            this.Platform = platform;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DropboxPasswordsExportedDetails"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public DropboxPasswordsExportedDetails()
        {
        }

        /// <summary>
        /// <para>The platform the device runs export.</para>
        /// </summary>
        public string Platform { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DropboxPasswordsExportedDetails" />.</para>
        /// </summary>
        private class DropboxPasswordsExportedDetailsEncoder : enc.StructEncoder<DropboxPasswordsExportedDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DropboxPasswordsExportedDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("platform", value.Platform, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DropboxPasswordsExportedDetails" />.</para>
        /// </summary>
        private class DropboxPasswordsExportedDetailsDecoder : enc.StructDecoder<DropboxPasswordsExportedDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DropboxPasswordsExportedDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DropboxPasswordsExportedDetails Create()
            {
                return new DropboxPasswordsExportedDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DropboxPasswordsExportedDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "platform":
                        value.Platform = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
