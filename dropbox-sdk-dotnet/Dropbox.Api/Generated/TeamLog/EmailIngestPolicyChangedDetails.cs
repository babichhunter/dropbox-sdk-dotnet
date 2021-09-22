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
    /// <para>Changed email to my Dropbox policy for team.</para>
    /// </summary>
    public class EmailIngestPolicyChangedDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<EmailIngestPolicyChangedDetails> Encoder = new EmailIngestPolicyChangedDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<EmailIngestPolicyChangedDetails> Decoder = new EmailIngestPolicyChangedDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="EmailIngestPolicyChangedDetails"
        /// /> class.</para>
        /// </summary>
        /// <param name="newValue">To.</param>
        /// <param name="previousValue">From.</param>
        public EmailIngestPolicyChangedDetails(EmailIngestPolicy newValue,
                                               EmailIngestPolicy previousValue)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            if (previousValue == null)
            {
                throw new sys.ArgumentNullException("previousValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="EmailIngestPolicyChangedDetails"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public EmailIngestPolicyChangedDetails()
        {
        }

        /// <summary>
        /// <para>To.</para>
        /// </summary>
        public EmailIngestPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>From.</para>
        /// </summary>
        public EmailIngestPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="EmailIngestPolicyChangedDetails" />.</para>
        /// </summary>
        private class EmailIngestPolicyChangedDetailsEncoder : enc.StructEncoder<EmailIngestPolicyChangedDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(EmailIngestPolicyChangedDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.EmailIngestPolicy.Encoder);
                WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.EmailIngestPolicy.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="EmailIngestPolicyChangedDetails" />.</para>
        /// </summary>
        private class EmailIngestPolicyChangedDetailsDecoder : enc.StructDecoder<EmailIngestPolicyChangedDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="EmailIngestPolicyChangedDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override EmailIngestPolicyChangedDetails Create()
            {
                return new EmailIngestPolicyChangedDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(EmailIngestPolicyChangedDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.EmailIngestPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.EmailIngestPolicy.Decoder.Decode(reader);
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
